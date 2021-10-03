using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFEMAT
{
    class Zaplat
    {
        public string Volba { get; set; } = "";
        public Zaplat()
        {                       
            string volba = Console.ReadLine();
            Volba = volba;
        }
    }
}
