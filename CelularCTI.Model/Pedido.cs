using CelularCTI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model
{
    public class Pedido
    {
        private Int64 id_pedido;
        private Aparelho aparelho;
        private DateTime data_pedido;
        private string observacao;

        public long Id_pedido { get => id_pedido; set => id_pedido = value; }
        internal Aparelho Aparelho { get => aparelho; set => aparelho = value; }
        public DateTime Data_pedido { get => data_pedido; set => data_pedido = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
