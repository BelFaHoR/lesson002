using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson002_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const long br_year = 2365;
            short b = (short)br_year ;
            const long nab = 30;// стара константа 32768
            short sh = (short)nab;// не працює оскіль  перевищує 16 біт 
            
           
            Console.WriteLine("Birth year : {0} ",br_year);
            Console.WriteLine("Birth year : {0} ", b);
            Console.WriteLine("Namber: {0} ", nab);
            Console.WriteLine("Short + const: {0}",sh);
            Console.ReadKey();

 
        }
    }
}
