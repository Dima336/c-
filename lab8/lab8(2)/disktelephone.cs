using System;

namespace lab_8_inheritance
{
    class disktelephone
    {
        public string Number { get; set; }
        public string Symbols = "1234567890";

        public virtual void call()
        {
            Console.WriteLine("я звоню");
        }
        public virtual void getCall()
        {
            Console.WriteLine("я приймаю дзвінок");
        }
    }
}