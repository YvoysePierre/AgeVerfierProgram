namespace AgeVerifierWebApplication.AgeVerifierOutput
{
    // TODO: For your own sanity order the fields as you would expect to see them, "Name", DOB, Sex... Address fields ...
    public class AgeVerifier
    {
        public string State { get; set; }

        //TODO: Number what?
        public string Number { get; set; }
        public string Name { get; set; }

        //TODO: You want to use full names, like "DateOfBirth", and int doesn't make sense for a birth date, should be DateTime
        public int Dob { get; set; }

        //TODO: Make an enum of ID types and be explicit about the types of IDs you know about, such as DL's, passports, ect
        public string TypeofID { get; set; }

        //TODO: StreetNumber isn't a valid street part, what you mean is house number, and even that isn't an int
        // should just be "Street" or "Address1" or something like that
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }

        //TODO: ZipCode is not an int
        public int ZipCode { get; set; }

        //TODO: Sex is not an int, should be a string (bad) or enum (good)
        public int Sex { get; set; }
        
        //TODO: Height, again, full names, also, probably not an int? Or you need units.
        public int Hgt { get; set; } 
        
    }
}

