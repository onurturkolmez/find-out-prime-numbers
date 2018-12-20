namespace FindPrimeNumbersWithMultiThread
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblSearchingFor = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.rtbThreads = new System.Windows.Forms.RichTextBox();
            this.lblThreads = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.primeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.primeNumbersDataSet = new FindPrimeNumbersWithMultiThread.PrimeNumbersDataSet();
            this.primeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primeTableAdapter = new FindPrimeNumbersWithMultiThread.PrimeNumbersDataSetTableAdapters.PrimeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeNumbersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStart.Location = new System.Drawing.Point(12, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnd.Enabled = false;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnd.Location = new System.Drawing.Point(139, 10);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(82, 46);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Stop";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblSearchingFor
            // 
            this.lblSearchingFor.AutoSize = true;
            this.lblSearchingFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchingFor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSearchingFor.Location = new System.Drawing.Point(12, 69);
            this.lblSearchingFor.Name = "lblSearchingFor";
            this.lblSearchingFor.Size = new System.Drawing.Size(137, 24);
            this.lblSearchingFor.TabIndex = 3;
            this.lblSearchingFor.Text = "Searching for...";
            this.lblSearchingFor.Visible = false;
            // 
            // rtbResult
            // 
            this.rtbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rtbResult.Location = new System.Drawing.Point(12, 128);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(209, 261);
            this.rtbResult.TabIndex = 6;
            this.rtbResult.Text = "";
            this.rtbResult.Visible = false;
            // 
            // rtbThreads
            // 
            this.rtbThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbThreads.Location = new System.Drawing.Point(238, 47);
            this.rtbThreads.Name = "rtbThreads";
            this.rtbThreads.Size = new System.Drawing.Size(610, 342);
            this.rtbThreads.TabIndex = 7;
            this.rtbThreads.Text = "";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblThreads.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblThreads.Location = new System.Drawing.Point(524, 19);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(85, 25);
            this.lblThreads.TabIndex = 8;
            this.lblThreads.Text = "Threads";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(849, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prime Numbers";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.primeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.primeBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(854, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(191, 342);
            this.dataGridView2.TabIndex = 12;
            // 
            // primeDataGridViewTextBoxColumn
            // 
            this.primeDataGridViewTextBoxColumn.DataPropertyName = "prime";
            this.primeDataGridViewTextBoxColumn.HeaderText = "prime";
            this.primeDataGridViewTextBoxColumn.Name = "primeDataGridViewTextBoxColumn";
            this.primeDataGridViewTextBoxColumn.ReadOnly = true;
            this.primeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // primeBindingSource1
            // 
            this.primeBindingSource1.DataMember = "Prime";
            this.primeBindingSource1.DataSource = this.primeNumbersDataSet;
            // 
            // primeNumbersDataSet
            // 
            this.primeNumbersDataSet.DataSetName = "PrimeNumbersDataSet";
            this.primeNumbersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // primeTableAdapter
            // 
            this.primeTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 401);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThreads);
            this.Controls.Add(this.rtbThreads);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblSearchingFor);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Out Prime Numbers with Multi Thread Method";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeNumbersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblSearchingFor;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.RichTextBox rtbThreads;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource primeBindingSource;
        private PrimeNumbersDataSet primeNumbersDataSet;
        private System.Windows.Forms.BindingSource primeBindingSource1;
        private PrimeNumbersDataSetTableAdapters.PrimeTableAdapter primeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn primeDataGridViewTextBoxColumn;
    }
}

