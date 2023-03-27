using System.Collections;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize Table
        Hashtable customerTable = new Hashtable();

        //Create Customer Objects
        Customer customer1 = new Customer("Jeremy", 38, 1);
        Customer customer2 = new Customer("CarLecia", 39, 2);
        Customer customer3 = new Customer("Carl", 37, 3);
        Customer customer4 = new Customer("Dustin", 36, 4);
        //add customers to the table, assign object key value as the Customers user id,
        //and the object value as the customer object)
        customerTable.Add(customer1.UserId, customer1);
        customerTable.Add(customer2.UserId, customer2);
        customerTable.Add(customer3.UserId, customer3);
        customerTable.Add(customer4.UserId, customer4);


        #region Dictionary
        Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
        // Adding customers to the Dictionary<int, Customer>
        // TODO: un-comment this out to see the error
        // customerDictionary.Add(customer1.UserId, "Jeremy");

        customerDictionary.Add(customer2.UserId, customer2);
        customerDictionary.Add(customer3.UserId, customer3);
        customerDictionary.Add(customer4.UserId, customer4);
        #endregion

        // retrieve info from database if you know the key needed to access the value.

        //create a variable of type Customer to store the value. eg storedcustomer1.

        //Query the customer table and access via the userid the userId.


        //the customerTable needs to casted as a customer object in order to work
        //this way what is returned is of type customer

        Customer storedCustomer1 = (Customer)customerTable[customer1.UserId];

        //Console the query to test
        Console.WriteLine("======================");
        Console.WriteLine(storedCustomer1.UserName);
        Console.WriteLine(storedCustomer1.UserAge);
        Console.WriteLine(storedCustomer1.UserId);

    }
}