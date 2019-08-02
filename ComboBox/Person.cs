using System;

namespace ComboBox
{
    public class Person
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public int Age { get; set; }

        public string fullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        
        
        }
    }
}
