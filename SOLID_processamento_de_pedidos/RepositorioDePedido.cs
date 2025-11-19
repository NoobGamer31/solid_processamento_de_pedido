using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos
{
    public class RepositorioDePedido : IRepositorio
    {
        public void Salvar(Pedido pedido)
        {
            // código que abriria BD ou uma lista

            // Simulação de salvamento
            Console.WriteLine($"[REPOSITÓRIO] O pedido de ID {pedido.ID} foi salvo no repositório - Total de {pedido.ValorTotal}");
        }
    }
}
