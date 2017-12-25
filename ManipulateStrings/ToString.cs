using System;

namespace ManipulateStrings
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
public string ToString(string format)
        {
            if (String.IsNullOrWhiteSpace(format) || format == "G") format = "FL";
            format = format.Trim().ToUpperInvariant();
            switch (format)
            {
                                case "FL":
                return FirstName + " " +LastName;
                                case "LF":
                return LastName + " " +FirstName;
                                case "FSL":
                return FirstName + ", " +LastName;
                                case "LSF":
                return LastName + ", " +FirstName;
                                default:
                                    throw new FormatException($"The { format} format string is not supported.");
            }
        }
    }
}
