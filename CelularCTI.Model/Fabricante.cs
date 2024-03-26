using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model
{
    public class Fabricante
    {
        //Atributos internos
        private Int64 id_Fabricante;
        private string nome;

        //Propriedades
        public Int64 Id_Fabricante 
        { 
            get { return id_Fabricante; } 
            set { id_Fabricante = value; }
        }

        public string Nome
        { 
            get { return nome; } 
            set {  nome = value; } 
        }

        //Construtor
        public Fabricante(Int64 id_Fabricante, string nome)
        {
            this.id_Fabricante = id_Fabricante;
            this.nome = nome;
        }
        public Fabricante()
        {

        }
    }
}
