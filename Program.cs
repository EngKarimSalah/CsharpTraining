namespace BankingServices
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //execute, increase, check condition, repeat until condition is false
            //int option; // declare once and assign multiple times in loop

            //bool exit = false;  //flag variable to control loop exit
            //while (exit == false)
            //{  
            //    Console.WriteLine("Welcome to bank services");
            //    Console.WriteLine("Please select an option:");
            //    Console.WriteLine("10. ATM Services");
            //    Console.WriteLine("25. Online Banking");
            //    Console.WriteLine("30. Loan Services");
            //    Console.WriteLine("0. Exit");

            //    option = Convert.ToInt32(Console.ReadLine());
            //    switch (option)
            //    {
            //        case 10:
            //            Console.WriteLine("ATM Services selected.");
            //            break;
            //        case 25:
            //            Console.WriteLine("Online Banking selected.");
            //            break;
            //        case 30:
            //            Console.WriteLine("Loan Services selected.");
            //            break;
            //        case 0:
            //            Console.WriteLine("Exiting...");
            //            exit = true;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid option.");
            //            break;
            //    }
            //}











            //execute, increase, check condition, repeat until condition is false
            int option; // declare once and assign multiple times in loop

            bool exit = false;  //flag variable to control loop exit
           do
            {
                Console.WriteLine("Welcome to bank services");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("10. ATM Services");
                Console.WriteLine("25. Online Banking");
                Console.WriteLine("30. Loan Services");
                Console.WriteLine("0. Exit");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 10:
                        Console.WriteLine("ATM Services selected.");
                        break;
                    case 25:
                        Console.WriteLine("Online Banking selected.");
                        break;
                    case 30:
                        Console.WriteLine("Loan Services selected.");
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            } while (exit == false) ;








            //flag = false
            //while(flag == false)  
            /*
                code to repeat until flag is true   

             */



            //int i = 1; 

            //while(i <= 5)
            //{
            //    Console.WriteLine("Karim");
            //    i++; //increment counter to avoid infinite loop
            //}



            //int counter; //reserve place in memory for counter variable  

            //for (counter = 1; counter <= 5; counter++)
            //{
            //    Console.WriteLine("Karim");
            //}





            //system setup ( system storage )
            /*
                declare variables
                add initial vaues
            */




            //system options
            /*
               display main menu ( set of console writelines to display options )
               switch( option )
            {
               case 1 - 7

               inside each case ex: case 1: 

                Case 1:
                             display welcome screen
                             display options for 1.atm services ( view balance )
                             switch( atmOptions )
                             {

                             }

                  break;

            }


            */







            ////////////////////////////////////////////////////
            //double totalDeposits = 0;

            //for (int day = 1; day <= 5; day++)
            //{
            //    Console.Write("Enter deposit for day " + day + ": ");
            //    double deposit = Convert.ToDouble(Console.ReadLine());

            //    totalDeposits += deposit;
            //}

            //Console.WriteLine("Total deposits = " + totalDeposits);

            ///////////////////////////////////////////////////////////////////
            //double balance = 1000;

            //while (balance >= 200)
            //{
            //    Console.Write("Enter withdrawal amount: ");
            //    double amount = Convert.ToDouble(Console.ReadLine());

            //    balance -= amount;

            //    Console.WriteLine("Remaining balance = " + balance);
            //}

            //Console.WriteLine("Minimum safe balance reached.");
            ////////////////////////////////////////////////////////////////

            //int correctPin = 1234;
            //int enteredPin;
            //int attempts = 0;

            //do
            //{
            //    Console.Write("Enter ATM PIN: ");
            //    enteredPin = Convert.ToInt32(Console.ReadLine());

            //    attempts++;

            //    if (enteredPin == correctPin)
            //    {
            //        Console.WriteLine("Login successful.");
            //        attempts = 3; // force loop end
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong PIN.");
            //    }

            //} while (attempts < 3);

            //Console.WriteLine("Session ended.");
            ////////////////////////////////////////////////////////////////////


            //for (int patient = 1; patient <= 4; patient++)
            //{
            //    Console.Write("Enter temperature for patient " + patient + ": ");
            //    double temperature = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Patient " + patient + " recorded.");
            //}
            //////////////////////////////////////////////////////////////////////
            //int heartRate = 80;

            //while (heartRate <= 100)
            //{
            //    Console.Write("Enter current heart rate: ");
            //    heartRate = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Monitoring...");
            //}

            //Console.WriteLine("Alert: High heart rate detected!");
            ////////////////////////////////////////////////////////////////////
            //int checkCount = 0;
            //double temperature;

            //do
            //{
            //    Console.Write("Enter patient temperature: ");
            //    temperature = Convert.ToDouble(Console.ReadLine());

            //    checkCount++;

            //    if (temperature < 37.5)
            //    {
            //        Console.WriteLine("Patient is stable.");
            //        checkCount = 3; // end loop
            //    }
            //    else
            //    {
            //        Console.WriteLine("Continue observation.");
            //    }

            //} while (checkCount < 3);

            //Console.WriteLine("Observation completed.");
        }

    } 

    }
    

    
    

