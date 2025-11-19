using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos.SPR
{
    public interface ICalculadoraDePedido
    {
        public decimal CalcularTotal(Pedido pedido);
    }
}
