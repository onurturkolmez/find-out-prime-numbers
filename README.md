### Summary  
The aim of the project is to use the multi thread to find the prime numbers starting from 2 up to N and stored in the database.
This project has developed with C# windows form application,sql server and entity framework. It was a project for 2nd grade computer science students.

### Database Config 
For database table, you could find sql file in the project file.You are gonna find the database connection infos if you search on the project as "ONURPC". You will need to config for your computer server settings. 

### Project Description 

If the prime numbers between 2 and its square root do not divide into prime numbers, these numbers are called prime numbers. For example; The square root of the number 17 is 4,123. It is the prime number because it is not fully divided into numbers 2 and 3. Once the number is verified to be prime, it must save it in the table in the SQL database.

-Steps

1. Finding the square number of the square root of the number
The square root of the number 17.163 is 131,00763. Therefore, the ceiling number is 131.

2. Finding the number of threads to use for prime number control
The number of threads to be used should be calculated as follows. If the number of elements between the base and the number of ceilings in the SQL table is below 100, 2 threads are over 100;
Thread Count = (int) (element number / 100) +1
For example: if the number of elements is 146, (146/100) +1 = 2, (221/100) +1 = 3 thread should be specified.

3. Determining the starting and ending points of threads
The process of determining the starting and ending points of threads is as shown in Figure 1. The square root of the number 17.163 is 131,00763 17. Therefore, the ceiling number is 131.

4. Perform prime number control for each thread
Each thread has to complete the prime number check operation. If the number to be searched is divided exactly into a number within the threads, then it is not a prime number. The number is the ASAL number if it is determined that the numbers within all threads are tested and not fully divisible.

5. If the prime number is recorded in the database
To register prime numbers in the database, a thread must also be defined. Thread will connect with the database and save it to the SQL table. Data extraction from the SQL Table will be performed in the Main Thread.

The number to be searched on the Application screen will start with the first odd number after the last prime number in the SQL table. For example 127 get the last prime number in the SQL table. When the program is switched back on, it will start the check operation starting from the searched number 129. As soon as the Start button is pressed, the searched number will appear on the screen and the number of threads, start and end points used for the number will be specified. The False value indicates that none of the numbers in the thread divide the number investigated. The True value indicates that one of the prime numbers in the thread exactly divides the searched number. When the Stop program button is pressed in the program, it will be checked whether the current researched number is prime and the program will be stopped after displaying the result.
