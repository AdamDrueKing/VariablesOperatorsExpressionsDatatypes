using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableOperatorsExpressionsDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Mike";
            //Console.WriteLine(name);

            //name = "Daniel";
            //Console.WriteLine(name);

            //string birthMonth = "May";
            //Console.WriteLine(birthMonth);
            ////initalizing new firstname variable

            //int age = 65;
            //string why = "because I said so";
            //char firstInitial = 'L';

            ////floating point types
            //float floatNumber = 2.164403304897294849383961032f;
            //Console.WriteLine(floatNumber);

            //double doubleNumber = 2.164403304897294849383961032d;
            //Console.WriteLine(doubleNumber);

            //decimal decimalNumber = 2.164403304897294849383961032m;
            //Console.WriteLine(decimalNumber);

            //int jessicaAge = 23;
            //int samAge = 47;
            //Console.WriteLine(jessicaAge < samAge);

            //Console.WriteLine("What is the name on the reservation?");
            //string reservationName = Console.ReadLine();

            //Console.WriteLine("How many people are in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());


            //double amountEachPaid = 13.53;
            //double totalBill = numberOfPeople * amountEachPaid;
            //Console.WriteLine();

            //Console.WriteLine("Reservation: " + reservationName);
            //Console.WriteLine("Total Due: $" + totalBill);



            //double amountOfSugar = 7;
            //Console.WriteLine("How Many Cups Did You Put In?");
            //double amountPutIn = double.Parse(Console.ReadLine());
            //double amountLeftToPutIn = (amountOfSugar - amountPutIn);
            //Console.WriteLine("Amount Left to Put in" + amountLeftToPutIn);


            double amountPerPackage = 8;
            double amountOfMoney = 40;
            double amountOfPackagesCanBuy = amountOfMoney / amountPerPackage;
            Console.WriteLine(amountOfPackagesCanBuy);

        }
    }
}
