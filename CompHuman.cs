using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLScs
{
    class CompHuman: Player
    {
        private string gesture;
        public CompHuman() : base()
        {
        }
        public string getGesture()
        {
            Console.WriteLine("Computer chose...");
            return Console.ReadLine();
        }
    }
}
