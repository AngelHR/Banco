using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos
{
    class Client
    {

        public double saldo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Ncuenta { get; set; }



        public Client Crea(int p)
        {
            Client n = new Client();
                 Console.WriteLine("Dame el nombre del Cliente");
                n.Nombre = Console.ReadLine();
                Console.WriteLine("Dame el Apellido del Cliente");
                n.Apellido= Console.ReadLine();
                Console.WriteLine("Dame el saldo del Cliente");
                n.saldo = double.Parse( Console.ReadLine());
                n.Ncuenta = p;
           
            return n;
        }
    }
}
