using SOLID_processamento_de_pedidos.SPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_processamento_de_pedidos
{
    public class PedidoService : IPedidoService
    {
        // Dependências
        private readonly ICalculadoraDePedido _calculadora;
        private readonly List<INotificadorDeCliente> _notificadores;
        private readonly IRepositorio _repo;

        // Injeção de dependências, DIP
        public PedidoService(ICalculadoraDePedido calculadora, List<INotificadorDeCliente> notificador, IRepositorio repo)
        {
            this._calculadora = calculadora;
            this._notificadores = notificador;
            this._repo = repo;
        }

        public void Processar(Pedido pedido)
        {
            if (!ValidarPedido(pedido))
            {
                Console.WriteLine($"Pedido de id {pedido.ID} não passou na verificação.");
                return;
            }

            // VIOLA SPR
            //decimal total = 0;
            //foreach (Item i in pedido.Itens)
            //{
            //    total = total + (i.Preco * (decimal)1.05);
            //}

            //pedido.ValorTotal = total;

            // Apenas chama as dependências, não faz o código
            decimal total = _calculadora.CalcularTotal(pedido);
            pedido.ValorTotal = total;

            _repo.Salvar(pedido);

            // Antes do OCP aplicado
            //_notificador.Notificar(pedido);

            // OCP aplicado
            foreach (INotificadorDeCliente ndc in _notificadores)
            {
                ndc.Notificar(pedido);
            }



            Console.WriteLine($"[SERVICE]: Fluxo de processamento de Pedido {pedido.ID} CONCLUÍDO.");
        }

        // Método de validação pode estar aqui porque não é complexo. Em caso de complexidade, criar uma outra interface e classe.
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
