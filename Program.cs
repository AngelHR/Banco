using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos
{
    class Program:Bank
    {
        static void Main(string[] args)
        {
            Bank n = new Bank();
            n.Name = "Juan";

            for(;; )
            {
                int p;
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("[1]agregar Cliente");
                Console.WriteLine("[2]Abonar a Cliente");
                Console.WriteLine("[3]Retirar a Cliente");
                Console.WriteLine("[4]Consultar");
                p=byte.Parse(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        n.agrecli(n.Crea(1));
                        break;
                    case 2:
                        Console.WriteLine("Cuanto va a abonar");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("A Que Cuenta abonar");
                        n.Abonar(int.Parse(Console.ReadLine())-1,p);
                        break;
                    case 3:
                        Console.WriteLine("Cuanto vas a retirar");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("A Que Cuenta Retirar");
                        n.Retirar(int.Parse(Console.ReadLine())-1,p);
                        break;
                    case 4:
                        Console.WriteLine("A quien desea consultar:");
                        n.consulta(Console.ReadLine()); 
                        break;
                    default:
                        Console.WriteLine("Opcion no Valida");
                        break;

                }
            }
        }
    }
}
