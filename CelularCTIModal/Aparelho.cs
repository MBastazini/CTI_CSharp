using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model
{
    internal class Aparelho
    {
        private Int64 id_aparelho;
        private string nome;
        private Fabricante fabricante;
        private double expressura;
        private double largura;
        private double peso;
        private int quantidade;
        private decimal preco;
        private decimal desconto;
        private string modelo;
        private double altura;


        public Int64 Id_Aparelho { get; set; }
        public string Nome { get; set; }
        public Fabricante Fabricante { get; set; }
        public double Espessura { get; set; }
        public double Largura { get; set; }
        public double Peso { get; set; }
        public int Quantidade { get; set; }

        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
                else
                {
                    throw new Exception("Preço deve ser maior que zero");
                }
            }
        }
        public decimal Desconto { get; set; }
        public string Modelo { get; set; }
        public double Altura { get; set; }

    }
}
