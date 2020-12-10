using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("string 1 " + "string 2 " + "string 3");
            string line = "this is a string";
            Console.WriteLine(line.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("Lorem ipsum dolor sit amet, libris populo sea ne, sit illum discere cu, cum no menandri sapientem. ");
            sb.Append("Ex veritus tibique has, te eum adhuc vulputate. ");
            sb.Append("Eam an facer persius appareat, id idque dolor fastidii nec. ");
            sb.Append("Suas consul tamquam usu in, quo id offendit suscipiantur. ");
            sb.Append("Magna constituto an his, mel sint omnium te. ");
            sb.Append("Qui quod paulo in, mel ex elit everti definitionem, et quis adhuc numquam vis.");
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
