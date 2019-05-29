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
            clientes.Add(null);
            var cliente2 = new Cliente("João", 22, 5555);
            clientes.Add(cliente2);
            var cliente3 = new Cliente("Lucas", 21, 4444);
            clientes.Add(cliente3);
            clientes.Add(null);
            var cliente4 = new Cliente("Pedro", 20, 1111);
            clientes.Add(cliente4);

            // código para ordenar -- Criei uma classe específica para isso.
            clientes.Sort(new ComparadorClientePorCpf());

            //Ordenando o elemento selecionado (no caso é um atributo)
            // IOrderedEnumerable<Cliente> clientesOrdenados = clientes.OrderBy(cliente => cliente.Nome);

            //var clientesNaoNulos = clientes.Where(cliente => cliente != null);
            
            //Tratando para não ter execões por causa de elementos null
                var clientesOrdenados =
                clientes.Where(cliente => cliente !=null)
                .OrderBy(cliente => cliente.Idade);


            foreach (var item in clientesOrdenados)
            {
                //condição para validar se uma conta é null ou não
                // Se quiser usar apenas as contão que não são null, é só usar 1 if com 'item != null
                if (item != null)
                {
                    Console.WriteLine(item);
                }
                

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
