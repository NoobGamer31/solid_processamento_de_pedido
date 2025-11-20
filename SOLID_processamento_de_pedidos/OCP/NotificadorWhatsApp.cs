using SOLID_processamento_de_pedidos.SPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos.OCP
{
    public class NotificadorWhatsApp : INotificadorDeCliente
    {
        public void Notificar(Pedido pedido)
        {
            Console.WriteLine($"[REPOSITÓRIO] O pedido de ID {pedido.ID} foi salvo no repositório (Notificação via WhatsApp) - Total de {pedido.ValorTotal}");
        }
    }
}
