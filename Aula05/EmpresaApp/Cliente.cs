using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaApp
{
    class Cliente
    {
        private string nome;
        private double limite = 100;
        public Cliente(string nome, double limite)
        {
            this.nome = nome;
            if (limite > 0) this.limite = limite;
        }
        public override string ToString()
        {
            return $"Cliente = {nome} - Limite = {limite}";
        }
    }
}
