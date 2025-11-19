using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos
{
    public interface IPedidoService
    {
        public void Processar(Pedido pedido);
    }
}
