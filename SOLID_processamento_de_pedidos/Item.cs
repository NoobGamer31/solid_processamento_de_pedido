using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos
{
    public class Item
    {
        public int ID { get; private set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        private static int _nextID = 0;

        public Item(string nome, decimal preco)
        {
            this.ID = SetID();
            this.Nome = nome;
            this.Preco = preco;
        }

        private int SetID()
        {
            return Interlocked.Increment(ref _nextID);
        }
    }
}
