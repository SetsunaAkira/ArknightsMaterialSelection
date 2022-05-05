using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsMaterialSelection
{
    internal class BeginOperation
    {
        public bool CloseOperation = false;
        public Dictionary<int, string> UserOptions = new Dictionary<int, string>();
        public string? UserInput = "";
        public void Start()
        {
            addUserOptions(UserOptions);
            while(CloseOperation == false)
            {
                Console.WriteLine("Please select what you would like to do");

                foreach(KeyValuePair<int, string> pair in UserOptions)
                {
                    Console.WriteLine("[" + pair.Key + "]" + pair.Value);
                }

                UserInput = Console.ReadLine();

                switch(UserInput)
                {
                    case "1":
                        Console.WriteLine("View Material");
                        break;

                     case "2":
                        Console.WriteLine("View Operator");
                        break;

                     case"3":
                        Console.WriteLine("Bulk Material Search");
                        break;



                }
            }
        }

        public void addUserOptions(Dictionary<int, string> UserOptions)
        {
            UserOptions.Add(0, "Exit");
            UserOptions.Add(1, "View Material");
            UserOptions.Add(2, "View Operator");
            UserOptions.Add(3, "Bulk Material Search");
            UserOptions.Add(4, "Operators that use the same Materials");
        }
    }
}
