using System;

namespace AgeVerfierWebApplication.AgeVerifierInput
{
    public class AgeVerifierInputClass
    {
        public string State  { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int Dob { get; set; }
        public string TypeofID { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public int Sex { get; set; }
        public int Hgt { get; set; }
        private DateTime stampdateTime = DateTime.Now;           
        string[] CultureNames = {"en-US", "en-BG,", "fr-FR", "sp-SP"};

    }
}
