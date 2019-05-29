using System;
using System.Collections.Generic;
using System.Linq;
using Testes.Entities;
using Testes.Entities.Comparadores;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            ordenacao();
        }

        // Manuseio e uso do Icomparable - ordenação - List<> -> método sort()
        public static void ordenacao()
        {
            var clientes = new List<Cliente>();

            var cliente1 = new Cliente("Gabriel", 23, 2222);
            clientes.Add(cliente1);
            var cliente2 = new Cliente("João", 22, 5555);
            clientes.Add(cliente2);
            var cliente3 = new Cliente("Lucas", 21, 4444);
            clientes.Add(cliente3);
            var cliente4 = new Cliente("Pedro", 20, 1111);
            clientes.Add(cliente4);

            // código para ordenar -- Criei uma classe específica para isso.
            clientes.Sort(new ComparadorClientePorCpf());

            IOrderedEnumerable<Cliente> listaOrdenada =
                clientes.OrderBy(cliente => cliente.Nome);


            foreach (var item in listaOrdenada)
            {
                Console.WriteLine(item);
            }

            // foreach para a lista do tipo List<>
            /*
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
