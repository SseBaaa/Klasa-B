using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_B
{
    internal class KlasaB
    {
        public string BezPrvogIZadnjeg(string stringUnos)
        {
            return stringUnos.Substring(1, stringUnos.Length - 2);

        }
    }
}
