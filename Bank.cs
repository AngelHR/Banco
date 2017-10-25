using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos
{
    class Bank:Client
    {
        public string Name { get; set; }
        public void banco(string p)
        {
            Name = p;
        }

        List<Client> clientes = new List<Client>();

        public void agrecli(Client n)
        {
            clientes.Add(n);
        }
        public void consulta(string i)
        {

            int o=0;
            foreach (Client item in clientes)
            {
                if (i == clientes[o].Nombre)
                {
                    Console.WriteLine($"Nombre: {item.Nombre} {item.Apellido}\nNumero de cuenta:{item.Ncuenta}\nSaldo:{item.saldo}\n");
                }
            }
        }
        public void Abonar(int index,int money)
        {
            int i = 0;
            foreach (Client item in clientes)
            {
                if (index==i)
                {
                    item.saldo += money;
                    Console.WriteLine($"Operacion Exitosa");
                }
                i++;
            }
        }
        public void Retirar(int index,int p)
        {
            int i = 0;
                foreach (Client item in clientes)
            {
                if (index == i)
                {
                    item.saldo -= p;
                    Console.WriteLine($"Operacion Exitosa");
                }
            }
        }



    }
}
