using System.Collections.Generic;
using System.Linq;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;


namespace AMA_Backprop
{
    class CsvHelper
    {
        public List<LungCancerData> getRecords()
        {
            using (var reader = new StreamReader(@"C:\Users\adavi\Downloads\lung-cancer.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<LungCancerDataClassMap>();
                    var records = csv.GetRecords<LungCancerData>().ToList();
                    return records;
                }
            }
           
        }


        public class LungCancerDataClassMap : ClassMap<LungCancerData>
        {
            public LungCancerDataClassMap()
            {
                Map(m => m.Gender).Name("GENDER");
                Map(m => m.Age).Name("AGE");
                Map(m => m.Smoking).Name("SMOKING");
                Map(m => m.Yellow_Fingers).Name("YELLOW_FINGERS");
                Map(m => m.Anxiety).Name("ANXIETY");
                Map(m => m.Peer_Pressure).Name("PEER_PRESSURE");
                Map(m => m.Chronic_Disease).Name("CHRONIC DISEASE");
                Map(m => m.Fatigue).Name("FATIGUE ");
                Map(m => m.Allergy).Name("ALLERGY ");
                Map(m => m.Wheezing).Name("WHEEZING");
                Map(m => m.Alcohol_Consuming).Name("ALCOHOL CONSUMING");
                Map(m => m.Coughing).Name("COUGHING");
                Map(m => m.Shortness_Of_Breath).Name("SHORTNESS OF BREATH");
                Map(m => m.Swallowing_Difficulty).Name("SWALLOWING DIFFICULTY");
                Map(m => m.Chest_Pain).Name("CHEST PAIN");
                Map(m => m.Lung_Cancer).Name("LUNG_CANCER");
            }
        }

        public class LungCancerData
        {
            [Name("GENDER")]
            public int Gender { get; set; }

            [Name("AGE")]
            public int Age { get; set; }

            [Name("SMOKING")]
            public int Smoking { get; set; }

            [Name("YELLOW_FINGERS")]
            public int Yellow_Fingers { get; set; }

            [Name("ANXIETY")]
            public int Anxiety { get; set; }

            [Name("PEER_PRESSURE")]
            public int Peer_Pressure { get; set; }

            [Name("CHRONIC DISEASE")]
            public int Chronic_Disease { get; set; }


            [Name("FATIGUE ")]
            public int Fatigue { get; set; }


            [Name("ALLERGY ")]
            public int Allergy { get; set; }


            [Name("WHEEZING")]
            public int Wheezing { get; set; }


            [Name("ALCOHOL CONSUMING")]
            public int Alcohol_Consuming { get; set; }


            [Name("COUGHING")]
            public int Coughing { get; set; }


            [Name("SHORTNESS OF BREATH")]
            public int Shortness_Of_Breath { get; set; }


            [Name("SWALLOWING DIFFICULTY")]
            public int Swallowing_Difficulty { get; set; }


            [Name("CHEST PAIN")]
            public int Chest_Pain { get; set; }

            [Name("LUNG_CANCER")]
            public int Lung_Cancer { get; set; }

        }

    }
}
