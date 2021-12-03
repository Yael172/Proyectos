using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.tasks;

namespace figurasgeo
{
    class figurasgeo
    {
        static void Main(string[] args)
        {
            int b, a, area, num;
             string si;
             do
             {
            Console.WritLine("elija una figura geometrica");
            Console.WritLinet("1. Circulo");
            Console.WritLine("2. Triangulo");
            Console.WritLine("3. Rectangulo");
            num = Convert.ToInt32(Console.Readline());
            Console.WritLine("ponga la base");
            b = Convert.ToInt32(Console.Readline());
            Console.WritLine("ponga la altura");
            a = Convert.ToInt32(Console.Readline());
            switch (num)
             {
                case 1:
                area = b * a;
                Console.WritLine("el area del circulo es:" + area);
                break;

                case 2:
                area = b * a / 2;
                Console.WritLine("el area del triangulo es:" + area);
                break;

                 case 3:
                area = b * a;
                Console.WritLine("el area del rectangulo es:" + area);
                break;
             }
            Console.WriteLine("desea volver a intentarlo");
            si = Console.ReadLine();
            }
            while(si == "SI" || si == "si");
        }
   
    }
}