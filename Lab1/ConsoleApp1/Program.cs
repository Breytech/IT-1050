

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastname;

            System.Console.Write("First Name : ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Middle Name :");
            middleName = System.Console.ReadLine();

            System.Console.Write("Last Name :");
            lastname = System.Console.ReadLine();

            string fullname = firstName + "" + middleName + "" + lastname;

            System.Console.WriteLine(fullname);

            System.Threading.Thread.Sleep(5000);

            const double multiplier = 2.54;
            const int inchesInFoot = 12;


            System.Console.Write("Height In Feet");
            int heightInFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Extra Inches");
            double heightInInches = double.Parse(System.Console.ReadLine());

            double inches = inchesInFoot * heightInFeet;
            inches += heightInInches;

            double centimeters = inchesInFoot * multiplier;

            System.Console.WriteLine(centimeters);

            System.Threading.Thread.Sleep(5000);

            System.Console.Write("How old are you? :");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen of America?");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote = age > 17 && isCitizen;


            System.Console.WriteLine(canVote);

            System.Threading.Thread.Sleep(5000);
        }
    }
}

