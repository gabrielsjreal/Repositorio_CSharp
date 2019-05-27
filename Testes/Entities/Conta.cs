using System;
using System.Collections.Generic;
using System.Text;

namespace Testes.Entities
{
    class Conta
    {
        public Cliente Cliente { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public Conta(Cliente cliente, int agencia, int numero)
        {
            Cliente = cliente;
            Agencia = agencia;
            Numero = numero;
        }

        public Conta()
        {
        }

        public override string ToString()
        {
            return "Cliente: " + Cliente + "\n"
                    + "Agência: " + Agencia + "\n"
                    + "Conta: " + Numero + "\n";
        }
    }
}
