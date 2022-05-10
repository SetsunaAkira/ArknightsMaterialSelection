using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace ArknightsMaterialSelection
{ 
    internal class MaterialDataPull
    {
        public List<MaterialObject> AllMaterials = new List<MaterialObject>();

        public List<MaterialObject> InitializeMaterials ()
        {
            PullMaterialsList();
            return AllMaterials;
        }

        public void PullMaterialsList()
        {
            CsvConfiguration config = CreateConfig();
            ParseCSVFile(Environment.CurrentDirectory + "\\Files\\Material List.csv", config);
        }

        private CsvConfiguration CreateConfig()
        {
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            return config;
        }
        
        private void ParseCSVFile(string file, CsvConfiguration config)
        {
            using StreamReader reader = new StreamReader(file) ;
            using CsvReader csv = new CsvReader(reader, config);

            var records = csv.GetRecords<MaterialObject>().ToList();

            foreach (MaterialObject Material in records)
            {
                AllMaterials.Add(Material);
            }
        }

        private void TestMats(List<MaterialObject> Tier)
        {
            foreach(MaterialObject Material in Tier)
            {
                Console.WriteLine("Material: " + Material.MaterialName + " " + "Tier: " + Material.MaterialTier);
            }
        }
    }
}
