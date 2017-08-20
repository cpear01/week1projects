using System;
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
            //float money = 2.50f; (most common to use doubles over floats)
            //double rocketCal = 7.8934;
            //decimal number = 3.847258324786m;
            //bool itWorked = true;
            //Console.WriteLine(5 + 15);
            //Console.WriteLine(itWorked);
            //Console.WriteLine(5 < 10);

            //Console.WriteLine("enter your first name");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName +" " + "Welcome"); //string concatenating between string and integer



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

            //331 students went on a field trip. Six buses were filled and 7 students traveled in cars. How many students were in each bus?
            //totalStudents=331, numBuses=6, studentsInCars = 7
            //54
            //int totalStudents = 331;
            //int numBuses = 6;
            //int studentsInCars = 7;
            //Console.WriteLine((totalStudents - studentsInCars) / numBuses);

            //Aliyah had $24 to spend on seven pencils. After buying them she had $10. How much did each pencil cost?
            //2
            //int totalMoney = 24;
            //int moneyLeft = 10;
            //int numPencils = 7;
            //Console.WriteLine((totalMoney - moneyLeft) / numPencils);

            //The sum of three consecutive numbers is 72. What are the smallest of these numbers?
            //need 3 consecutive numbers that = 72 (23, 24, 25)
            //23 
            //int sumTotal = 72;
            //int numbersNeeded = 3;
            //Console.WriteLine(sumTotal / numbersNeeded -1);

            //tutoring: Lilys code: not sure why we brought back all the #'s when it was only asking for the smallest
            //int middleNum = (72 / 3);
            //int smallNum = (middleNum - 1);
            //int largeNum = (middleNum + 1);
            //Console.WriteLine(smallNum);
            //Console.WriteLine(middleNum);
            //Console.WriteLine(largeNum);


            //The sum of three consecutive even numbers is 48. What are the smallest of these numbers?
            //need 3 consecutive EVEN number that = 48 (14, 16, 18)
            //14
            //int totalEvenNumbers = 48;
            //int numNeeded = 3;
            //Console.WriteLine(totalEvenNumbers / numNeeded - 2);



            //Maria bought seven boxes. A week later half of all her boxes were destroyed in a fire. 
            //There are now only 22 boxes left. With how many did she start?
            //boughtLaterBoxes=7, boxesNow=22, halfDestroyed=22

            //if question is how many boxes before the fire, answer is 44
            //int boxesNow = 22;
            //int halfdestroyed = 22;
            //int newBoxes = 7;
            //Console.WriteLine(boxesNow + halfdestroyed);

            ////if question is how many boxes before the fire, answer is 37
            //Console.WriteLine((boxesNow + halfdestroyed) - newBoxes);

            //comparing variables using < > will result in a boolean value
            //int jessicaAge = 23;
            //int samAge = 47;

            //Console.WriteLine(jessicaAge > samAge); //this is False
            //Console.WriteLine(jessicaAge < samAge); //this is True

            //using Console.ReadLine & Console.WriteLine
            //Console.WriteLine("What's your favorite color?");
            //string color = Console.ReadLine();
            //Console.WriteLine("I like" + " " + color + " " + "too!");
            //outputs: What is your favorite color? purple  I like purple

            //int.Parse ReadLine method
            //since Console.ReadLine() takes user input as a string(text), need to convert it to text if input is a number

            //Console.WriteLine("How old are you?");
            //int userAge = Console.ReadLine(); //THIS IS WRONG & GAVE ERROR:'can't convert string type to int'. when you try 
            //to run it gives a build error and shows the same error in the error box below

            //instead need to use int.Parse(Console.ReadLine()) to convert the age to a string; need to keep parentheses in 
            //Console.ReadLine() method, and put parentheses around entire method

            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());   USER INPUT: 24
            //Console.WriteLine(age);                    CONSOLE PRINTED: 24

            //practice using Arithmetic Operators
            int A = 10;
            //int B = 20;
            //Console.WriteLine(A + B); //30
            //Console.WriteLine(A - B); //-10
            //Console.WriteLine(A * B); //200
            //Console.WriteLine(B / A); //2
            //Console.WriteLine(B % A); //0  (Modulus Operator -this give the remainder of after an integer division)
            Console.WriteLine(A++);   //10 THIS IS WRONG, s/b 11 - ASK
            Console.WriteLine(A--);   //11 THIS IS WRONG, s/b 9 - ASK

            //My Donation Tracker
            //Your client needs to print receipts when donations are received. Donations are received in ones, fives, tens, twenties, 
            //fifties, hundreds, and quarters. Ask the user how many of each denomination are being donated, and print a receipt. 
            //Your client wants the following information printed on the receipts:
            //Donor Name, Donor Address, Donor Email, Fiscal Year, Donation Amount

            //MY PLAN:
            //need to plan in 3 sections: 1) ask user for information & donation amounts for all denominations (1's, 5's, 10's etc)
            //2) calculations - total amounts for each denominations
            //3) Print receipt with: Name, Address, email, year, total donation amount

            //Intro & User input
            Console.WriteLine("Welcome to Donation Nation!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            string email = Console.ReadLine();
            Console.WriteLine("Please indicate how many of each denomination you would like to donate:");
            Console.WriteLine("Quarters?");
            double quarters = int.Parse(Console.ReadLine());
            Console.WriteLine("$1 bills?");
            double dollar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("$5 bills?");
            double dollar5 = int.Parse(Console.ReadLine());
            Console.WriteLine("$10 bills?");
            double dollar10 = int.Parse(Console.ReadLine());
            Console.WriteLine("$20 bills?");
            double dollar20 = int.Parse(Console.ReadLine());
            Console.WriteLine("$50 bills?");
            double dollar50 = int.Parse(Console.ReadLine());
            Console.WriteLine("$100 bills?");
            double dollar100 = int.Parse(Console.ReadLine());
            
            //Receipt:
            Console.WriteLine("We thank you for your generous donation!");
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(email);
            int year = 2017;
            Console.WriteLine("Donation Year:" + " " + year);
            
            //Calculation:
            Console.WriteLine("Total Donation:" + quarters * ); 








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

        }
    }
}
