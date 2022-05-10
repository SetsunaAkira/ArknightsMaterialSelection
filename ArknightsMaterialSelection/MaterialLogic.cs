using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsMaterialSelection
{
    internal class MaterialLogic
    {

        public void ViewMaterialMenu(List<MaterialObject> materials)
        {
            bool activeMenu = true;
            while(activeMenu)
            {
                Console.WriteLine("Select How to Filter:");
                Console.WriteLine("1: True One to One, 2: Case insensitive, 3: Bulk General Filter");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        {
                            ViewMaterial(materials, "OneToOne");
                            break;
                        }
                    case "2":
                        {
                            ViewMaterial(materials, "Insensitive");
                            break;
                        }
                    case "3":
                        {
                            ViewMaterial(materials, "GeneralFilter");
                            break;
                        }
                }

            }
        }
        public void ViewMaterial(List<MaterialObject> materials, string SearchType)
        {
            bool flow = true;
            while (flow == true)
            {
                Console.WriteLine("Enter the Material to approximate the available selection");
                string input = Console.ReadLine();
                Console.Clear();

                switch(SearchType)
                {
                    case "OneToOne":
                        {
                            TrueOneToOne(input, materials);
                            flow = false;
                            break;
                        }
                    case "Insensitive":
                        {
                            CaseInsensitive(input, materials);
                            break;
                        }
                    case "GeneralFilter":
                        {
                            GeneralFilter(input, materials);
                            break;
                        }

                }
             }
         }

        public void TrueOneToOne(string input, List<MaterialObject> materials)
        {
            if (input != null || input != "")
            {
                foreach (MaterialObject mat in materials)
                {
                    if (mat.MaterialName == input)
                    {
                        Console.WriteLine("You are now Viewing:");
                        Console.WriteLine("Material: " + mat.MaterialName);
                        Console.WriteLine("Rarity Tier: " + mat.MaterialTier);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
            }
        }

        public void CaseInsensitive(string input, List<MaterialObject> materials)
        {

        }

        public void GeneralFilter(string input, List<MaterialObject> materials)
        {

        }
    }
 }

