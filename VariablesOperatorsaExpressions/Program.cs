﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //char letter = 'A';
            //string name = "Colleen";
            //int age = 20;
            //float money = 2.50f;
            //double rocketCal = 7.8934;
            //decimal number = 3.847258324786m;
            //bool itWorked = true;
            //Console.WriteLine(5 + 15);
            //Console.WriteLine(itWorked);
            //Console.WriteLine(5 < 10);

            //Console.WriteLine("enter your first name");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName +" " + "Welcome"); //string concatenating between string and integer



            ////initizling a variable - making a memory 

            ////At a restaurant, Mike and his three friends decided to divide the bill evenly.If each person paid $13 then what was the total bill?
            ////52
            //int numberPeople = 4;
            //int perPerson = 13;
            //Console.WriteLine(numberPeople * perPerson);

            ////Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has 
            ////already put in 2 cups. How many more cups does she need to put in?
            ////5
            //int totalCups = 7;
            //int alreadyIn = 2;
            //Console.WriteLine(totalCups - alreadyIn);

            ////How many packages of diapers can you buy with $40 if one package costs $8?
            ////5
            //int costForOne = 8;
            //int totalPackageAmt = 40;
            //Console.WriteLine(totalPackageAmt / costForOne);

            ////Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic.
            ////He now has $41. How much money did he receive?
            ////12
            //int lastFriday = 29;
            //int totalNow = 41;
            //Console.WriteLine(totalNow - lastFriday);

            ////Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?
            ////17
            //int juliaTotalMiles = 47;
            //int moreMilesThanPranav = 30;
            //Console.WriteLine(juliaTotalMiles - moreMilesThanPranav);

            ////How many boxes of envelopes can you buy with $12 if one box costs $3?
            ////4
            //int oneBox = 3;
            //int maxAmount = 12;
            //Console.WriteLine(maxAmount / oneBox);

            ////After paying $5.12 for a salad, Norachai has $27.10. How much money did he have before buying the salad?
            ////32.22
            //float totalBill = 27.10f;
            //float salad = 5.12f;
            //Console.WriteLine(totalBill + salad);

            //Donation Tracker #1

            ////First is the questions needed to ask them for the info
            //Console.WriteLine("Welcome to Movie Non Profit");
            //Console.WriteLine("What is your name?");
            //string donorName = Console.ReadLine();
            //Console.WriteLine("What is your address?");
            //string donorAddress = string.Concat(Console.ReadLine());
            //Console.WriteLine("What is your email address?");
            //string donorEmail = Console.ReadLine();
            //Console.WriteLine("What is the year ?");
            //String donorYear = Console.ReadLine();

            ////asking for the donation amounts
            //Console.WriteLine("How many quarters are you donating?");
            //int quarterAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many One Dollar Bills are you donating?");
            //int oneDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many Five Dollar Bills are you donating?");
            //int fiveDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many Ten Dollar bills are you donating?");
            //int tenDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many twenty dollar bills are you donating?");
            //int twentyDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many fifty dollar bills are you donating?");
            //int fiftyDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many hundred dollar bills are you donating?");
            //int hundredDollarAmount = int.Parse(Console.ReadLine());


            ////doing the math
            //double donationAmount = (oneDollarAmount + fiveDollarAmount * 5 + tenDollarAmount * 10 + twentyDollarAmount * 20 + fiftyDollarAmount * 50 + hundredDollarAmount * 100 + quarterAmount * 0.25);

            ////printing out the receipt
            //Console.WriteLine("Thank you for your donation! The amount donated is $" + donationAmount);
            //Console.WriteLine("donorName:" + donorName);
            //Console.WriteLine("donorAddress:" + donorAddress);
            //Console.WriteLine("donorEmail:" + donorEmail);
            //Console.WriteLine("yearofdonation:" + donorYear);

            /*Console.WriteLine("Welcome to Movie Non Profit");
            Console.WriteLine("What is your name?");
            string donorName = Console.ReadLine();
            Console.WriteLine("What is your address?");
            string donorAddress = string.Concat(Console.ReadLine());
            Console.WriteLine("What is your email address?");
            string donorEmail = Console.ReadLine();
            Console.WriteLine("What is the year ?");
            String donorYear = Console.ReadLine();

            //asking for the donation amounts
            Console.WriteLine("How many quarters are you donating?");
            int quarterAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many One Dollar Bills are you donating ?");
            int oneDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Five Dollar Bills are you donating ?");
            int fiveDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Ten Dollar bills are you donating ?");
            int tenDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many twenty dollar bills are you donating ?");
            int twentyDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fifty dollar bills are you donating ?");
            int fiftyDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hundred dollar bills are you donating ?");
            int hundredDollarAmount = int.Parse(Console.ReadLine());


            //doing the math
            double donationAmount = (oneDollarAmount + fiveDollarAmount * 5 + tenDollarAmount * 10 + twentyDollarAmount * 20 + fiftyDollarAmount * 50 + hundredDollarAmount * 100 + quarterAmount * 0.25);

            //printing out the receipt
            Console.WriteLine("Thank you for your donation! The amount donated is $" + donationAmount);
            Console.WriteLine("Donor name:" + donorName);
            Console.WriteLine("Donor address:" + donorAddress);
            Console.WriteLine("Donor email:" + donorEmail);
            Console.WriteLine("Year of donation:" + donorYear);*/

            //Donation Tracker #2

            ////First is the questions needed to ask them for the info
            //Console.WriteLine("Welcome to Movie Non Profit");
            //Console.WriteLine("What is your name?");
            //string donorName = Console.ReadLine();
            //Console.WriteLine("What is your address?");
            //string donorAddress = Console.ReadLine();
            //Console.WriteLine("What is your email address?");
            //string donorEmail = Console.ReadLine();
            //Console.WriteLine("What is the year ?");
            //String donorYear = Console.ReadLine();

            ////asking for the donation amounts
            //Console.WriteLine("How many quarters are you donating?");
            //int quarterAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many One Dollar Bills are you donating ?");
            //int oneDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many Five Dollar Bills are you donating ?");
            //int fiveDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many Ten Dollar bills are you donating ?");
            //int tenDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many twenty dollar bills are you donating ?");
            //int twentyDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many fifty dollar bills are you donating ?");
            //int fiftyDollarAmount = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many hundred dollar bills are you donating ?");
            //int hundredDollarAmount = int.Parse(Console.ReadLine());


            ////doing the math - might be better to write out each amount as its own variable, then add together
            //double donationAmount = (oneDollarAmount + fiveDollarAmount * 5 + tenDollarAmount * 10 + twentyDollarAmount * 20 + fiftyDollarAmount * 50 + hundredDollarAmount * 100 + quarterAmount * 0.25);

            ////printing out the receipt
            //Console.WriteLine("Thank you for your donation! The amount donated is $" + donationAmount);
            //Console.WriteLine("Donor name: " + donorName);
            //Console.WriteLine("Donor address: " + donorAddress);
            //Console.WriteLine("Donor email: " + donorEmail);
            //Console.WriteLine("Year of donation: " + donorYear);

            //Donation Tracker - Karen's

            //First is the questions needed to ask them for the info
            Console.WriteLine("Welcome to Movie Non Profit");
            Console.WriteLine("What is your name?");
            string donorName = Console.ReadLine();
            Console.WriteLine("What is your address?");
            string donorAddress = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            string donorEmail = Console.ReadLine();
            Console.WriteLine("What is the year ?");
            String donorYear = Console.ReadLine();

            //asking for the donation amounts
            Console.WriteLine("How many quarters are you donating?");
            int quarterAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many One Dollar Bills are you donating ?");
            int oneDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Five Dollar Bills are you donating ?");
            int fiveDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Ten Dollar bills are you donating ?");
            int tenDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many twenty dollar bills are you donating ?");
            int twentyDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fifty dollar bills are you donating ?");
            int fiftyDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hundred dollar bills are you donating ?");
            int hundredDollarAmount = int.Parse(Console.ReadLine());

         
            //doing the math - might be better to write out each amount as its own variable, then add together
            double donationAmount = (oneDollarAmount + fiveDollarAmount * 5 + tenDollarAmount * 10 + twentyDollarAmount * 20 + fiftyDollarAmount * 50 + hundredDollarAmount * 100 + quarterAmount * 0.25);

            //printing out the receipt
            Console.WriteLine("Thank you for your donation! The amount donated is $" + donationAmount);
            Console.WriteLine("Donor name: " + donorName);
            Console.WriteLine("Donor address: " + donorAddress);
            Console.WriteLine("Donor email: " + donorEmail);
            Console.WriteLine("Year of donation: " + donorYear);

        }
    }
}
