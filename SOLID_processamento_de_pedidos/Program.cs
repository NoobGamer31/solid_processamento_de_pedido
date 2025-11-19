namespace SOLID_processamento_de_pedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRIAR ITENS
            Item i1 = new Item("Serviiço A", (decimal)200.0);
            Item i2 = new Item("Alimentação ao Dominício", (decimal)100.0);
            Item i3 = new Item("Serviço de Decoração", (decimal)500.0);
            Item i4 = new Item("Entrega ao Portão", (decimal)20.0);
            
            Pedido p1 = new Pedido(new List<Item> { i1, i2 });
            Pedido p2 = new Pedido(new List<Item> { i3, i1 });
            Pedido p3 = new Pedido(new List<Item> { i2, i4 });
            Pedido p4 = new Pedido(new List<Item> { i1, i2, i3, i4 });

            PedidoService pedidoServide = new PedidoService();
            pedidoServide.Processar(p1);
            pedidoServide.Processar(p2);
            pedidoServide.Processar(p3);
            pedidoServide.Processar(p4);

            Console.ReadKey();
        }
    }
}
