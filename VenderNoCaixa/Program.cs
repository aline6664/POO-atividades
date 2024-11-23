// Método Main()
using VenderNoCaixa;

//instância dos produtos (com código, nome, preço, estoque)
Produto p1 = new Produto(100004958, "Biscoito", 3.85, 30);
// p1.MostrarDadosProduto();
Produto p2 = new Produto(100057375, "Macarrão", 9.99, 45);
Produto p3 = new Produto(100007886, "Leite", 6.50, 10);

p1.MostrarDados();
p2.MostrarDados();
p3.MostrarDados();

// instância da venda
Venda vd = new Venda();
System.Console.WriteLine(" \n=================================== NOVA VENDA ===================================\n ");
// instância do vetor dos itens
// instância dos itens (com quantidade)
ItemVenda it1 = new ItemVenda(50, p1);
vd.VetItens.Add(it1);
it1.CalcularSubtotal();

ItemVenda it2 = new ItemVenda(1,p2);
vd.VetItens.Add(it2);
it2.CalcularSubtotal();

ItemVenda it3 = new ItemVenda(2,p3);
vd.VetItens.Add(it3);
it3.CalcularSubtotal();

vd.CalcularTotal();
vd.MostrarDados();

int qtdTotalItens = vd.CalcularQuantidadeTotal();
if (qtdTotalItens >= 50) {
    DescontoAtacado desconto = new DescontoAtacado(vd);
    desconto.CalcularDesconto();
    System.Console.WriteLine("\nDesconto Atacado aplicado!\n");
    desconto.MostrarDados();
    vd.MostrarDados();
}

// pagamento
// instância do pagamento
Pagamento pgto = new Pagamento(vd.Total);
// seleção do tipo de pagamento
System.Console.WriteLine("\nSelecione o tipo de pagamento: \n1 - Em espécie \n2 - Cartão de crédito \n3 - Cheque \nAperte qualquer tecla para sair.\n");
System.Console.Write("Tipo de pagamento: ");

int opcaoPagamento = Convert.ToInt32(Console.ReadLine());

switch (opcaoPagamento) {
    case 1:
        System.Console.WriteLine("\nEspécie selecionado.\n");
            Especie esp = new Especie(pgto.Total);
            System.Console.Write("Informe a quantia a pagar: ");
            esp.Quantia = Convert.ToDouble(Console.ReadLine());
            double troco = esp.CalcularTroco(esp.Quantia);
            if (troco != -1)
                esp.MostrarDados();
            else {
                System.Console.WriteLine("Quantia insuficiente.");
            }
        break;
    case 2:
        System.Console.WriteLine("\nCartão de crédito selecionado.\n");
            Cartao car = new Cartao(pgto.Total, "Número: 2736 3646 4374 3747 \tCVC: 321 \tPagamento: Débito");
            car.ProcessarDadosTransacao(500); // quantia fornecida pelo cartão
            car.MostrarDados();
        break;
    case 3:
        System.Console.WriteLine("\nCheque selecionado.");
            Cheque che = new Cheque(pgto.Total, 1247483837292194, 1);
            che.ProcessarDadosCheque();
            che.MostrarDados();
        break;
    default:
        System.Console.WriteLine("\nProcesso cancelado.\n");
        break;
}





