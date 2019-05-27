using System;
using System.Collections.Generic;
using System.Text;

namespace Testes.Entities.Comparadores
{
    class ComparadorClientePorCpf : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            // para se ambos forem null
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            // como o atributo CPF é um int, e por padrão o List<> - método sort(), já ordena os elementos 
            // desse tipo, ao ínves de usarmos todas essas comparações abaixo, podemos substituir por esse código:

            return x.Cpf.CompareTo(y.Cpf);


            /*
          if (x.Cpf < y.Cpf)
            {
                return -1;
            }

            if (x.Cpf == y.Cpf)
            {
                return 0;
            }

            return 1;
        }
        */


        }
    }
}
