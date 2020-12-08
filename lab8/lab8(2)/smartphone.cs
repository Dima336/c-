using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2_
{
    class smartphone: kolortelephone
    {
        public bool sensorkeryvannya { get; set; }
        public byte maksondodotic { get; set; }
        public byte kilikistkamer { get; set; }

        public void Photo(byte Camera)
        {
            Console.WriteLine($"Я делаю снимок с {Camera} камеры");
        }
        public void Video(byte Camera)
        {
            Console.WriteLine($"Я делаю видео с {Camera} камеры");
        }
    }
}

