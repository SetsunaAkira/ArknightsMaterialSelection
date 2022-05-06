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
    internal class Materials
    {
        private List<MaterialObject> TierOneMaterials = new List<MaterialObject>();
        private List<MaterialObject> TierTwoMaterials = new List<MaterialObject>();
        private List<MaterialObject> TierThreeMaterials = new List<MaterialObject>();
        private List<MaterialObject> TierFourMaterials = new List<MaterialObject>();
        private List<MaterialObject> TierFiveMaterials = new List<MaterialObject>();

        public void DistributeMaterials ()
        {
            //Dictionary<int, string>tierToMaterials = new Dictionary<int, string>();
            PullMaterialsList();


        }

        public void PullMaterialsList()
        {
            CsvConfiguration config = CreateConfig();
            ParseCSVFile(Environment.CurrentDirectory + "\\Files\\Material List.csv", config);
            TestMats(TierOneMaterials);
            TestMats(TierTwoMaterials);
            TestMats(TierThreeMaterials);
            TestMats(TierFourMaterials);
            TestMats(TierFiveMaterials);
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
                switch (Material.MaterialTier)
                {
                    case 1:
                        TierOneMaterials.Add(Material);
                        break;
                    case 2:
                        TierTwoMaterials.Add(Material);
                        break;
                    case 3:
                        TierThreeMaterials.Add(Material);
                        break;
                    case 4:
                        TierFourMaterials.Add(Material);
                        break;
                    case 5:
                        TierFiveMaterials.Add(Material);
                        break;
                }
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
