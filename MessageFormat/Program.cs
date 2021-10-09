using System;

namespace MessageFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string fullname ;
            string PhNum ;
            bool r1,r2,r3;

            
            Format obj = new Format();
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter FullName");
            fullname = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            PhNum = Console.ReadLine();



            r1 = obj.ValidateName(name);
            Console.WriteLine(r1);

            r2= obj.ValidateFname(fullname);
            Console.WriteLine(r2);

            r3= obj.ValidateNum(PhNum); 
            Console.WriteLine(r3);

            if (r1 && r2 && r3 == true)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Hello {0},We have your full name as {1} in our system.\n your contact number is 91 - {2}.\n Please, let us know in case of any clarification Thank you BridgeLabz", name, fullname, PhNum);
            }
            else
                Console.WriteLine("Enter Valid Input");

        }
    }
}
