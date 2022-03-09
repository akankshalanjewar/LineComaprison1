using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public void Length()
        {
            double x1, x2, y1, y2;
            double f1, f2, g1, g2;

            Console.WriteLine("Enter co-ordinate of line1");
            Console.WriteLine("Enter co-ordinate of (x1,y1)");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter co-ordinate of line1");
            Console.WriteLine("Enter co-ordinate of (x2,y2)");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter co-ordinate of line2");
            Console.WriteLine("Enter co-ordinate of (f1,g1)");
            f1 = double.Parse(Console.ReadLine());
            g1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter co-ordinate of line2");
            Console.WriteLine("Enter co-ordinate of (f2,g2)");
            f2 = double.Parse(Console.ReadLine());
            g2 = double.Parse(Console.ReadLine());


            double Length1 = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            double Length2 = Math.Sqrt(((f2 - f1) * (f2 - f1) + (g2 - g1) * (g2 - g1)));


            Console.WriteLine("Length of line1 is" + Length1);
            Console.WriteLine("Length of line2 is" + Length2);


        }
        public void Comparison()
        {
            double x1, x2, y1, y2;
            double g1, g2, h1, h2;

            Console.WriteLine("Enter co-ordinate of line1");
            Console.WriteLine("Enter co-ordinate of (x1,y1):");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter co-ordinate of line1");
            Console.WriteLine("Enter co-ordinate of (x2,y2):");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter co-ordinate of line2");
            Console.WriteLine("Enter co-ordinate of (g1,h1):");
            g1 = double.Parse(Console.ReadLine());
            h1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter co-ordinate of line2");
            Console.WriteLine("Enter co-ordinate of (g2,h2):");
            g2 = double.Parse(Console.ReadLine());
            h2 = double.Parse(Console.ReadLine());

            double Length1 = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            double Length2 = Math.Sqrt(((g2 - g1) * (g2 - g1) + (h2 - h1) * (h2 - h1)));

            Console.WriteLine("Length of line1:" + Length1);
            Console.WriteLine("Lenght of line2:" + Length2);

            if (Length1 == Length2)
            {
                Console.WriteLine("Two line are equal");
            }
            else
            {
                Console.WriteLine("Two line are not equal");
            }

        }
        public void GreaterAndLessor()
        {
            double x1, x2, y1, y2;
            double g1, g2, h1, h2;

            Console.WriteLine("Enter co-ordinate of line1");
            Console.WriteLine("Enter co-ordinate of (x1,y1):");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter co-ordinate of line1");
            Console.WriteLine("Enter co-ordinate of (x2,y2):");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter co-ordinate of line2");
            Console.WriteLine("Enter co-ordiante of (g1,h1):");
            g1 = double.Parse(Console.ReadLine());
            h1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter co-ordinate of line2");
            Console.WriteLine("Enter co-ordinate of(g2,h2)");
            g2 = double.Parse(Console.ReadLine());
            h2 = double.Parse(Console.ReadLine());


            double Length1 = (((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            double Length2 = (((g2 - g1) * (g2 - g1) + (h2 - h1) * (h2 - h1)));

            if (Length1 == Length2)
            {
                Console.WriteLine("Two line are equal");
            }
            else if (Length1 > Length2)
            {
                Console.WriteLine("The Length of line1 is greater than line1");
            }
            else if (Length1 < Length2)
            {
                Console.WriteLine("The length of line1 is less than line1");
                Console.ReadLine();
            }

        }

    }
}

