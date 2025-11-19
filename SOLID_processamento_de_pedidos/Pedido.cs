using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos
{
    public class Pedido
    {
        public int ID { get; private set; }
        public List<Item> Itens;
        public decimal ValorTotal;
        private static int _nextID = 0;
        public Pedido(List<Item> itensPedido)
        {
            this.ID = SetID();
            this.Itens = itensPedido;
        }

        private int SetID()
        {
            return Interlocked.Increment(ref _nextID);
        }
    }
}
