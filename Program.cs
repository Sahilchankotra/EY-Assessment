using ShoppingSite_GUI;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Shopping
{
    public static List<Products> lproduct = new List<Products>();
    static int price = 3000;
    static void Main()
    {
        
            bool b=false;
            Console.WriteLine("Please Enter your Name");
            string name = Console.ReadLine();
        while (true)
        {
            Console.WriteLine($"********* Welcome to EY Product site : {name}");
            Console.WriteLine("To Get better services, Kindly select below options");
            Console.WriteLine("1.) Already acccount select 1 ");
            Console.WriteLine("2.) New User select 2 ");

            int userselection = int.Parse(Console.ReadLine());

            switch (userselection)
            {
                case 1:
                    {

                        Console.WriteLine("Enter your Username: ");
                        string _username = Console.ReadLine();
                        Console.WriteLine("Enter your Password: ");
                        string _password = Console.ReadLine();


                        LoginClass loginobj = new LoginClass();
                        b = loginobj.LoginMethod(_username, _password);
                        if (!b) { Console.WriteLine("Incorrect credentials");
                     
                        }
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Our Development team is working on this selection.. Sorry for the incovineinace");
                        break;
                    }

                default:
                    break;
            }
            if (b)
            {

                DeclareProduct();

                Console.WriteLine("1.) Check Out: ");
                Console.WriteLine("2.) Select More: ");
                Console.WriteLine("3.) Clear Cart: ");

                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                      int total=  checkout();
                        Console.WriteLine("Your total is: " + total);
                        break;
                }


               
            }
            else { Console.WriteLine("Close the applicatino and run again"); }
            Console.WriteLine("Do you want to continue y/n");
            string userdecision = Console.ReadLine();

            if (userdecision == "n" || userdecision == "No" || userdecision == "N")
            {
                Console.WriteLine("**********  Thanks for using our app **********");

                break;
            }
        }
    }
        public static void DeclareProduct() {

            Console.WriteLine("Below are the products, kindly select the option to add in the cart:");
            Console.WriteLine("1: Protein");
            Console.WriteLine("2: Shaker");
            Console.WriteLine("3: Sandwich");
            Console.WriteLine("4: Bread");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Quantity");
            int quant = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {

                        AddtoCart("Protein", quant);
                        break;
                    }
                case 2:
                    {
                        AddtoCart("Shaker", quant);
                        break;
                    }
                case 3:
                    {

                        AddtoCart("Sandwich", quant);
                        break;
                    }
                case 4:
                    {
                        AddtoCart("Bread", quant);
                        break;
                    }
           


        } }
    public static void AddtoCart(string product, int quantity)
    {


        lproduct.Add(new Products { Name = product, quantity = quantity });
        
    }

    public static int checkout()
    {
        int quant = 0;
        foreach(var i in lproduct)
        {
            quant = quant+i.quantity*price;

            Console.WriteLine(i.Name + " " + i.quantity+" "+quant);
        }


        return quant;   
    }
  



}