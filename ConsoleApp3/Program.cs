using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalachisFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
            //User Input

        
        
        {
           
            Console.WriteLine("I am The GREATEST of ALL Mystics... Call Me MAGNIFICENT MALACHI");
            Console.WriteLine("            !!! I can predict your future !!!");
            Console.WriteLine();

            Console.WriteLine("Tell me your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now tell me your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            var remainder = age % 2;
            var isEven = remainder == 0;
            var isOdd = remainder == 1;
            string retirment;
            

            if ((remainder %2) == 0)
            {
                retirment = "25 years";
            }
            else
            {
                retirment = "2 years";
            }
            Console.WriteLine(); 
            Console.WriteLine("In what month were you born?");
            int birthMonth = int.Parse(Console.ReadLine());
            double resultBirth_month= 0 ;
            double moneyOne = 0.00;
            double moneyTwo = 1000000.00;
            double moneyThree = 25.00;
            double moneyFour = 500000.00;
            if ((birthMonth <1) || (birthMonth >12))
            { resultBirth_month = moneyOne;   }
            if ((birthMonth == 1) || (birthMonth == 2) || (birthMonth == 3) || (birthMonth == 4))
            { resultBirth_month = moneyTwo;   }
            if ((birthMonth == 5) || (birthMonth == 6) || (birthMonth == 7) || (birthMonth == 8))
            { resultBirth_month = moneyThree; }
            if ((birthMonth == 9) || (birthMonth == 10) || (birthMonth == 11) || (birthMonth == 12))
            { resultBirth_month = moneyFour;  }
            Console.WriteLine();

            string resultColor= "";

            Console.WriteLine("Choose your favorite color from the following... ROYGBIV. Type Help for ROYGBIV color list");
            string color = Console.ReadLine().ToUpper();

            switch (color)
            {
                case "R":
                    resultColor = "1989 Honda Civic";
                    break;
                case "O":
                    resultColor = "legless Horse";
                    break;
                case "Y":
                    resultColor = "Segway";
                    break;
                case "G":
                    resultColor = "Nissan  GT-R";
                    break;
                case "B":
                    resultColor = "1968 Pontiac GTO";
                    break;
                case "I":
                    resultColor = "good pair of shoes, because your walking";
                    break;
                case "V":
                    resultColor = "Bugatti Veyron";
                    break;
                case "HELP":
                    Console.WriteLine("Type R for red - Type O for orange - Type Y for yellow - Type G for green - Type B for blue - Type I for indigo - Type V for violet");
                    break;
                    
             }


            Console.WriteLine();
            string resultVac_home= "";
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            if (siblings.Equals(0))
            { resultVac_home = "Cancun,Mexico";     }
            else if (siblings < 0)
            { resultVac_home = "Detroit,Michigan";  }
            else if (siblings.Equals(1))
            { resultVac_home = "Honolulu,Hawaii";   }
            else if (siblings.Equals(2))
            { resultVac_home = "Anchorage,Alaska";  }
            else if (siblings.Equals(3))
            { resultVac_home = "Cairo,Egypt";       }
            else if (siblings > 3)
            { resultVac_home = "Tokyo,Japan";       }


            Console.WriteLine();

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retirment + " with $" + resultBirth_month + " in the bank, a vacation home in " + resultVac_home + " ,and a " + resultColor + " for transportation."  );

        


       






        }
    }
}
