using System;
using System.Collections.Generic;


namespace Customerİnfo
{
    internal class Program
    { /// <summary>
    /// 
    /// 
    /// This program intends to get a customers's iformations and save it to database.
    ///
    /// If customer wants to take a userName which is already taken this program will not allow that,and save that customer's userName as empty stirng.
    /// 
    /// Program will not allow save a mail which is alread saved in database.
    /// 
    /// 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        { /*
           * In this ragion program reads customer's informations
           * 
           */
            Customer cust = new Customer();
            cust.Name = "Alex";
            cust.lastname = "Luscon";
            cust.id = 1;
            cust.Mail = "alex.luscon@gmail.com";
            cust.userName = "Aluscon";
            cust.Password = "47";
            /*
             * With this "add" command program saves customer informations to our database   (i use a arraylist as virtual database)
             */
            Customer.AddCustomer(cust);

            Customer cust2 = new Customer()
            {
                Name = "Mark",
                Password = "42",
                lastname = "Luscon",
                id = 1,
                Mail = "mark.luscon@gmail.com",
                userName = "maluscon",
            };
            Customer.AddCustomer(cust2);
            Customer cust3 = new Customer();
            cust3.Name = "Alex";
            cust3.lastname = "Luscon";
            cust3.id = 1;
            cust3.Mail = "alex.luscon@gmail.com";
            cust3.userName = "Aluscon";
            cust3.Password = "47";
            Customer.AddCustomer(cust3);
            Console.ReadKey();




        }
    }
}
