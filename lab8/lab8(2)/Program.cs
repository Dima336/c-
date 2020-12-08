using lab_8_inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            chornotelephone telephone1 = new chornotelephone();
            telephone1.call();
            telephone1.getCall();

            Console.WriteLine("----------");
            Knoptelephone Knoptelephone1 = new Knoptelephone();
            Knoptelephone1.getCall();

            Console.WriteLine("-----------");
            chornotelephone chornotelephone1 = new chornotelephone();
            chornotelephone1.sendsms();
            chornotelephone1.getsms();

            Console.WriteLine("----------");
            kolortelephone kolortelephone1 = new kolortelephone();
            kolortelephone1.sendmms();
            kolortelephone1.getmms();
            kolortelephone1.call(false);

            Console.WriteLine("---------");
            smartphone smartphone1 = new smartphone();
            smartphone1.Photo(1);
            smartphone1.Video(2);

            Console.ReadKey();

        }
    }
}
