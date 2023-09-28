using System;
using System.Diagnostics;

namespace The_Yard_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---WELCOME TO THE YARD MANAGEMNET SYSTEM--->"); // Title of the program, this is diplayed to users screen 
            Console.WriteLine();




            const int mAX_LOGIN_ATTEMPTS = 3; // Variable storing the number of times user is able to attempt logging this doesn't change  
            int loginAttempts = 0;

            while (true) // loop that will run as long as the if conditions are true will not run if false 
            {
                Console.WriteLine("Username:");
                String Username = Console.ReadLine(); // prompt user to enter Username in text 
                Console.WriteLine("Password:");
                string Password = Console.ReadLine(); // prompt user to enter Password in text 

                if (Username == "admin" && Password == "pw") // the user trying to access the system needs to enter the username equal to admin and the password equal to pw 
                {
                    Console.WriteLine("You have successfully logged  in ");
                    Console.WriteLine();

                    Console.WriteLine("Please press any key to proceed to the  main menu");
                    Console.ReadKey(); // This will allow the successfull log in message to display until the user goes on the next stage.

                    while (true)
                    {
                        Console.Clear();// This clears the previous information that was displayed. 

                        Console.WriteLine("---Hello, Welcome to the main menu.---");
                        Console.WriteLine();

                        Console.WriteLine("---Please choose from one of the options below by inputing the number you number of your option and clicking enter---");
                        Console.WriteLine();

                        Console.WriteLine("1: Entry cost calculator;");
                        Console.WriteLine("2: Atendance monitoring;");
                        Console.WriteLine("3: Open the following  commonly used URL's;");
                        Console.WriteLine("4: Attendee registration;");
                        Console.WriteLine("5: Report and incident ;");
                        Console.WriteLine("6: Exit the system;");
                        Console.WriteLine();



                        int option = int.Parse(Console.ReadLine()); // This allows the input from the user to be a number and not text. 
                        switch (option)
                        {     // Case 1 is a calculator that calculates the total of adult and childreen ticket, with a consideration of 2for1 on adult tickets
                            case 1:
                                Console.Clear(); // Clears the information previously diplayed before running the case

                                Console.WriteLine("Entry cost calculator");
                                Console.WriteLine();

                                Console.WriteLine("Standard entry cost");
                                Console.WriteLine();
                                Console.WriteLine("Adults Tickets - £12.00"); // Pirce tickets for adult tickets 
                                Console.WriteLine("Children Ticket - £7.50"); // Price tickets for children tickets 
                                Console.WriteLine("Please note that adults get a 2 for 1 offer.");
                                Console.WriteLine();
                                int numberofAdults = 0; // set variable to allow imput of the number of adults or children gettting tiekcts
                                int numberofchildren = 0;
                                double AdultPrice = 12.00; // use of double to allow two decimal place .Setting a variable for the prices of the tickets
                                double ChildrenPrice = 7.50;
                                double totalPrice = 0; // variable to hold the price of the ticket with 2for1 promation or with out 



                                Console.WriteLine("Please enter the number of adults entering:");
                                numberofAdults = int.Parse(Console.ReadLine()); // this enable the input to be accepted as a number 
                                Console.WriteLine();

                                Console.WriteLine("Please enter the number of children entering");
                                numberofchildren = int.Parse(Console.ReadLine()); // enables the use  to enter the number of children 
                                Console.WriteLine();

                                if (numberofAdults % 2 == 0) // This will check if the number imputed is even or odd using the modolu  to see what remainders are left when divided by 2
                                {
                                    totalPrice = (numberofAdults * AdultPrice) / 2; // If the number imputed is even and has no remainder  then it will just be divided by 2 
                                }
                                else
                                {
                                    int count = 0; // a count so that the 2 for 1 deal can be applied

                                    for (int i = 0; i < numberofAdults; i++) // The loop runs for the number of Adults that are imputed 
                                    {
                                        if (count == 1) // As it is 2 for 1 if the count is one 1 this means they are on the 'second' person and there won't be a charged 
                                        {
                                            count = 0; // instead of increasing  the total price it resets the count the price for that person is not added on. 
                                        }
                                        else
                                        {
                                            totalPrice += AdultPrice; // if the count is not on the "second" person then they will be charged for a ticket
                                            count++; //Increase the count by 1
                                        }
                                    }
                                }

                                double TotalCost = ((numberofchildren * ChildrenPrice) + totalPrice); // this equation adds  the ticket prices for the children proved and the adults tickets as well as the 2-4-1 offer 

                                Console.WriteLine($"The total cost for {numberofAdults} adults  and {numberofchildren} children  is £{TotalCost}. Thank you!"); // here the number of adults and children inputed as shown and thee total cost as well 
                                Console.WriteLine();

                                break;
                            // Case 2 is a system then allow sthe user to attend attendees a=or remove attendes that go in a out of the yard venue 
                            case 2:



                                Console.Clear();
                                Console.WriteLine(" ---Attendance  Monitoring---");
                                Console.WriteLine();
                                Console.WriteLine("The Yard event  venue has a max capacity for 300  ");
                                Console.WriteLine();
                                Console.WriteLine("A: Adding new attendees");
                                Console.WriteLine("R: Remove attendees ");
                                Console.WriteLine();
                                string Update = Console.ReadLine(); // this String allows thie input of the choice the user chooses. It in put into the swtich statement 
                                int CurrentCapacity = 0; // Displays the capacity of the venue after ther new attendees are added.
                                const int MaxCapacity = 300; // Sets a constant number for the Max number of people the venue is able to take which is 300 
                                int NewAttendees = 0; // stores the value that the user input of the attendees being added
                                double percent = (double)CurrentCapacity / MaxCapacity * 100; // equsation to work out the percent of how full the venue is

                                switch (Update)
                                {
                                    case "A":
                                        Console.WriteLine("Please enter the number of attenedees being added");
                                        NewAttendees = int.Parse(Console.ReadLine()); // enables the user to input the number of attendees they want to add
                                        if (NewAttendees > 0) // checks if the inputed numbe s greater than 0 and is vaild to be added 
                                        {
                                            if (NewAttendees + CurrentCapacity <= MaxCapacity) // adds the new attendees to the current attendees and workds out if the total is less than or equal to the nax capacity of 300
                                            {
                                                NewAttendees += CurrentCapacity; // equation for adding the new attendees to the current capacity 
                                                Console.WriteLine($"You have added {NewAttendees} / {MaxCapacity} to the attendees list"); // diplays the new attendees added and how much capacity there is
                                                Console.WriteLine($"This is {percent}% full"); // displays the percentage of  how full the venue is 


                                            }
                                            else
                                            {
                                                Console.WriteLine("Capcity is at MAX can not add more.");
                                            }

                                        }
                                        else

                                        {
                                            Console.WriteLine(" The number you have entered is invaild please try again.");
                                        }

                                        break;

                                    case "R":
                                        Console.WriteLine("Please enter the number of attenenees being removed");
                                        NewAttendees = int.Parse(Console.ReadLine()); // enables user to enter the number of attendees they would like to remove 
                                        if (NewAttendees > 0) // checks if the inputed numbe s greater than 0 and is vaild to be removed 
                                        {
                                            if (CurrentCapacity >= NewAttendees) // equation for if current capacity is greater than or equal to the attendees wishing to be removed then tha statment will be carried out 
                                            {
                                                CurrentCapacity -= NewAttendees; // removing attendeesd from the current attendees 
                                                Console.WriteLine($"There is now  {CurrentCapacity} / {MaxCapacity}  attendees listed "); // display how mney attendess are left
                                                Console.WriteLine($"This is {percent}% full");


                                            }
                                            else
                                            {
                                                Console.WriteLine("Can't remove anymore people");
                                            }

                                        }
                                        else

                                        {
                                            Console.WriteLine("Number not vaild, Please try again");
                                        }
                                        break;

                                }




                                break;

                            // Case 3  is to open The yard website and the option for the user to search a keyword 
                            case 3:
                                Console.Clear();

                                Console.WriteLine("Opening the following URL's");
                                Console.WriteLine();

                                Console.WriteLine("1: Vist the Yard venue website.");
                                Console.WriteLine("2: Search  keyword.");

                                int Search = int.Parse(Console.ReadLine()); // enable user to input the number option they would like to pick from in the swtich statement 

                                switch (Search)
                                {
                                    case 1:
                                        Console.WriteLine(" Click the link below to go to the Yard venue website.");
                                        Process.Start("https://theyardmcr.com/");// The link that will take the user to the The yard webiste 
                                        Console.WriteLine();
                                        break;

                                    case 2:
                                        Console.WriteLine("Enter the keyword you would like to search in your default browser.");
                                        String keywordsearch = Console.ReadLine(); // enables user to input the key word they would like to search 
                                        String URLsearch = $"https://www.google.com/search?q={keywordsearch}"; // link the takes user to the search of the work in a broswer
                                        Process.Start(URLsearch); // allows the link with teh keyword to be excuted. 
                                        break;

                                }
                                break;

                            case 4:
                                break;
                            // Allows the user to reprot and incidetn that has happned. Thye ae rquired to provide the date and time as well as if the incident is minor or major
                            case 5:

                                Console.Clear();
                                Console.WriteLine("---Report an incident---");
                                Console.WriteLine();

                                Console.WriteLine("Please give the date  for the incident in form dd/mm/yy");
                                Console.WriteLine("Day"); var day = Console.ReadLine(); // prompts user to enter a day .  variable that stores the day the user inputs a
                                Console.WriteLine("Month"); var month = Console.ReadLine();//  prompts user to enter a month .  variable that stores the month the user inputs a
                                Console.WriteLine("Year"); var year = Console.ReadLine(); // prompts user to enter a year .  variable that stores the year the user inputs a
                                Console.WriteLine($"{day}/{month}/{year}"); // displeays the day , month and years as one date. 


                                Console.WriteLine("Please give the time of the incident in the form HH:00");
                                var time = Console.ReadLine(); // prompts users to input the time. And stored it as a vatiable time 

                                Console.WriteLine("Please provide more details of the incident"); //Asks the user  to provide a detail of the incident they wnat to report
                                Console.ReadLine();

                                Console.WriteLine("Please proved if the incident was minor or major");
                                Console.WriteLine();
                                Console.WriteLine("1: Minor");
                                Console.WriteLine("2: Major");
                                int incidenttype = int.Parse(Console.ReadLine()); // allows the input of the option they wish to choose 

                                switch (incidenttype)
                                {
                                    case 1:
                                        Console.WriteLine($"The incident you had was minor");
                                        break;

                                    case 2:
                                        Console.WriteLine("$The  incident you had was major");
                                        break;


                                }

                                Console.WriteLine(" Thank you for your incident report. We have saved it and we will be getting back to you in due time");


                                break;
                            // Case  6 allows the user to exist the whole system 
                            case 6:
                                Console.Clear();
                                Console.WriteLine("You are exiting");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to exist");
                                Console.ReadKey();
                                return; // enables user to exist the sysem.


                        }
                        Console.WriteLine();
                        Console.WriteLine("To return  to the main menu please press any key");
                        Console.ReadKey();

                    }


                }
                else // If the Usernamd and password are incorrect message below is displayed. 
                {

                    Console.WriteLine("Sorry the Details you have  entered are incorrect! Please try again ");
                    loginAttempts++; // Increases that the set variable of 0 by 1 .

                    if (loginAttempts == mAX_LOGIN_ATTEMPTS) //If the number of times the user trys to login in is equal the max login attempts(3) then system kicks them out 
                    {
                        Console.WriteLine("Sorry have reached the max number of attempts");
                        return; // exists the program 
                    }

                }



            }


        }
    }


}



