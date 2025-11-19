using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos
{
    public class PedidoService : IPedidoService
    {
        public void Processar(Pedido pedido)
        {
            if (!ValidarPedido(pedido))
            {
                Console.WriteLine($"Pedido de id {pedido.ID} não passou na verificação.");
                return;
            }

            decimal total = 0;
            foreach (Item i in pedido.Itens)
            {
                total = total + (i.Preco * (decimal)1.05);
            }

            pedido.ValorTotal = total;

            RepositorioDePedido rdp = new RepositorioDePedido();
            rdp.Salvar(pedido);
        }

        private bool ValidarPedido(Pedido pedido)
        {
            if (pedido.Itens.Count <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
