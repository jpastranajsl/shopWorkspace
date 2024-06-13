using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimenaPastranaProject
{
    static public class Register
    {
        static public double Cash { get; set; } = 0;
        static public double Card { get; set; } = 0;
        static public double Total = Cash + Card;

        static Register()
        {
            Total = Cash + Card;
        }
    }
}
