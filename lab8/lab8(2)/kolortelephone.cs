using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2_
{
    class kolortelephone: chornotelephone
    {
        public int kilkistkolor { get; set; }
        public bool twosim { get; set; }
        public string twonomertelephone { get; set; }
        public virtual void sendmms()
        {
            Console.WriteLine("отправка ммс");
        }
        public virtual void getmms()
        {
            Console.WriteLine("принимаю ммс");
        }
        public void call(bool calls = true)
        {
            if (calls) base.call(); else Console.WriteLine("Я звоню с 2 симки");
        }
    }
}
