using System;

namespace lab_8_inheritance
{
    class Knoptelephone: disktelephone
    {
        public string Number { get; set; }
        public string Symbols = "1234567890#*";

        public virtual void getcall()
        {
            Console.WriteLine("я звоню на +380---------");
        }
       
    }
}