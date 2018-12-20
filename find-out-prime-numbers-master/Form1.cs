using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPrimeNumbersWithMultiThread
{
    public partial class Form1 : Form
    {
        private static int topLimit, numberOfThread, biggestPrime, number, accrual;
        private static int startPoint = 2, endPoint;
        private static PrimeNumbersEntities context = new PrimeNumbersEntities();
        private static Thread Th, MainThread;
        private static List<int> listTable;

        public Form1()
        {
            InitializeComponent();

            //context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Prime]");

            //insert dummy data, if context is empty
            if (context.Primes.Count() < 5)
            {
                context.Primes.Add(new Prime { prime1 = 2 });
                context.Primes.Add(new Prime { prime1 = 3 });
                context.Primes.Add(new Prime { prime1 = 5 });
                context.Primes.Add(new Prime { prime1 = 7 });
                context.Primes.Add(new Prime { prime1 = 11 });
                context.SaveChanges();
            }

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            lblSearchingFor.Visible = true;
            btnEnd.Enabled = true;
            btnStart.Enabled = false;
            rtbResult.Visible = false;
            rtbThreads.ReadOnly = false;
            rtbResult.ReadOnly = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            rtbResult.Visible = true;
            rtbThreads.ReadOnly = true;
            rtbResult.ReadOnly = true;

            refreshData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primeNumbersDataSet.Prime' table. You can move, or remove it, as needed.
            this.primeTableAdapter.Fill(this.primeNumbersDataSet.Prime);
            refreshData();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblSearchingFor.Text = lblSearchingFor.Text.Replace("Searching", "Searched");
        }

        private void refreshData()
        {
            this.primeTableAdapter.Fill(this.primeNumbersDataSet.Prime);
            this.label1.Text = "Prime Numbers (" + context.Primes.Count().ToString() + ")";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int tempIncrease;

            biggestPrime = (int)context.Primes.OrderByDescending(p => p.prime1).FirstOrDefault().prime1;
            number = biggestPrime + 2;

            for (int i = number; ; i += 2)
            {
                int tempCounter = 0;
                topLimit = (int)Math.Sqrt(number);

                if (context.Primes.Where(a => a.prime1 <= topLimit).Count() < 100)
                {
                    numberOfThread = 2;
                }
                else
                {
                    numberOfThread = (int)(context.Primes.Where(a => a.prime1 <= topLimit).Count() / 100) + 1;
                }

                accrual = context.Primes.Where(a => a.prime1 <= topLimit).Count() / numberOfThread;

                tempIncrease = accrual;

                listTable = context.Primes.Where(a => a.prime1 <= topLimit).Select(a => (int)a.prime1).ToList();

                startPoint = listTable[0];
                endPoint = listTable[accrual - 1];

                string threadText = "";
                string[] infoForPrimeData = new string[2];
                string[] tempInfoForPrimeData = new string[2];
                for (int j = 1; j <= numberOfThread; j++)
                {
                    threadText += "Thread" + j.ToString() + "\t\t" + startPoint.ToString() + "\t\t" + endPoint.ToString() + "\t";
                    Th = new Thread(() => tempInfoForPrimeData = threadFunction(j, number, startPoint, endPoint));
                    Th.Start();
                    while (Th.IsAlive) { }

                    if (tempInfoForPrimeData[0] == "True,")
                        threadText += "\tTrue\n";
                    else
                    {
                        threadText += "\tFalse\n";
                        tempCounter++;
                        if (tempCounter == 1)
                            infoForPrimeData[1] = tempInfoForPrimeData[1];
                    }

                    if (j < numberOfThread - 1)
                    {
                        accrual += tempIncrease;
                        startPoint = endPoint;
                        endPoint = listTable[accrual - 1];
                    }

                    // the start and end points to be sent to the last thread: the starting point and the end point are replaced.
                    // the last thread has not changed since the end point is equal to the end point of the previous thread
                    // is the largest prime number in the table where the starting point is equal to or smaller than the square root of the number investigated.

                    if (j == numberOfThread - 1)
                    {
                        startPoint = (int)context.Primes.Where(a => a.prime1 <= topLimit).OrderByDescending(p => p.prime1).FirstOrDefault().prime1;
                    }

                    infoForPrimeData[0] += tempInfoForPrimeData[0];
                }

                string[] temp = infoForPrimeData[0].Split(',');

                if (!temp.Contains("False"))
                {
                    threadText += "," + tempInfoForPrimeData[1];
                    MainThread = new Thread(() => mainThreadFunction(number));
                    MainThread.Start();
                    while (MainThread.IsAlive) { }
                }
                else
                {
                    threadText += "," + infoForPrimeData[1];
                }

                backgroundWorker1.ReportProgress(i, threadText);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    number += 2;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblSearchingFor.Text = "Searching for:" + e.ProgressPercentage.ToString();
            string[] threadResultText = e.UserState.ToString().Split(',');
            rtbThreads.Text = "Threads\tStart Point\t\tEnd Point\n" + threadResultText[0];
            rtbResult.Text = threadResultText[1];
        }

        //thread function that checks the prime numbers
        private static string[] threadFunction(int orderOfThread, int number, int start, int end)
        {
            int counter = 0;
            string[] result = new string[2];
            result[1] = number.ToString() + " is not a prime number!\nIt can divisible by ";

            if (orderOfThread == numberOfThread)
            {
                foreach (int i in listTable.Where(a => a <= start && a >= end))
                {
                    if (number % i == 0)
                    {
                        counter++;
                        result[1] += i.ToString();
                        break;
                    }
                }
            }
            else
            {
                foreach (int i in listTable.Where(a => a >= start && a <= end))
                {
                    if (number % i == 0)
                    {
                        counter++;
                        result[1] += i.ToString();
                        break;
                    }
                }
            }

            if (counter == 0)
            {
                result[0] = "True,";
                result[1] = number.ToString() + " is a prime number!";
            }

            else
            {
                result[0] = "False,";
                result[1] += " that included in Thread" + numberOfThread.ToString();
            }
            return result;
        }

        //thread function that inserts the prime numbers to the table
        private static void mainThreadFunction(int number)
        {

            context.Primes.Add(new Prime { prime1 = number });
            context.SaveChanges();
        }
    }
}
