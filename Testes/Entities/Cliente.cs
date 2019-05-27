using System;
using System.Collections.Generic;
using System.Text;

namespace Testes.Entities
{
    class Cliente : IComparable
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        public int Cpf { get; set; }

        public Cliente(string nome, int idade, int cpf)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
        }

        public Cliente()
        {
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                    + ", Idade: " + Idade
                    + ", Cpf: " + Cpf;
        }


        public int CompareTo(object obj)
        {
            // retornar -1 quando for menor
            // retornar 0 quando nossa instancia e obj forem iguais
            // retornar 1 quando for maior

            Cliente c = obj as Cliente;

            if (Idade < c.Idade)
            {
                return -1;
            }
            else if (Idade == c.Idade)
            {
                return 0;
            }

            return 1;
        }
    }

}
