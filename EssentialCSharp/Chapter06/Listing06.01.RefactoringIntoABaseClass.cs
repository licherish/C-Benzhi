namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_01
{
    using System;

    public class PdaItem
    {
        public string Name { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    // Define the Contact class as inheriting the PdaItem class
    public class Contact : PdaItem
    {
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
