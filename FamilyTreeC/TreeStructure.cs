using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FamilyTreeC
{
    class TreeStructure : Person
    {
        public static void ShowFamily(Person a)
        {
            ShowFamily(a, 0);
        }

        public static void ShowFamily(Person a, int level)
        {
            Console.WriteLine("".PadLeft(level * 4) + (a.Children.Any() ? "*" : "-") + a.Name + " " + a.DateOfBirth);
            foreach (var c in a.Children)
            {
                ShowFamily(c, level + 1);
            }
        }

        public static string personname()
        {
            string name;
            Console.WriteLine("What is  Name");
            name = Console.ReadLine();
            return name;
            
        }
        public static bool anyC()
        {
            bool children;
            string yesno;
            Console.WriteLine("Any Children");
            yesno = Console.ReadLine();
            if (yesno == "yes" || yesno == "Yes")
            {
                children = true;
            }
            else
            {
                children = false;
            }
            return children;
            

        }
        public static string persondob()
        {
            string dob;
            Console.WriteLine("What is the persons date of birth");
            dob = Console.ReadLine();
            Console.Clear();
            return dob;
            

        }
    }
}
