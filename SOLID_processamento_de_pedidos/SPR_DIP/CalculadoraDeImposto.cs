using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos.SPR
{
    public class CalculadoraDeImposto : ICalculadoraDePedido
    {
        public decimal CalcularTotal(Pedido pedido)
        {
            decimal total = 0;
            foreach (Item i in pedido.Itens)
            {
                // Motivo para mudar pode ser o aumento do imposto (1.05)
                total = total + (i.Preco * (decimal)1.05);
            }
            return total;
        }
    }
}
