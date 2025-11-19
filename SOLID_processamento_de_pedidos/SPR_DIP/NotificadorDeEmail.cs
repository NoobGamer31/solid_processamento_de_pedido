using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos.SPR
{
    public class NotificadorDeEmail : INotificadorDeCliente
    {
        public void Notificar(Pedido pedido)
        {
            Console.WriteLine($"[REPOSITÓRIO] O pedido de ID {pedido.ID} foi salvo no repositório - Total de {pedido.ValorTotal}");
        }
    }
}
