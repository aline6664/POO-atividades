// Método Main()
using VenderNoCaixa;

//instância dos produtos (com código, nome, preço, estoque)
Produto p1 = new Produto(100004958, "Biscoito", 3.85, 30);
// p1.MostrarDadosProduto();
Produto p2 = new Produto(100057375, "Macarrão", 12.99, 45);
Produto p3 = new Produto(100007886, "Leite", 6.50, 10);

p1.MostrarDadosProduto();
p2.MostrarDadosProduto();
p3.MostrarDadosProduto();

// instância da venda
Venda vd = new Venda();
// instância do vetor dos itens
vd.VetItens = new List<ItemVenda>();
// instância dos itens (com quantidade)
ItemVenda it1 = new ItemVenda(4);
ItemVenda it2 = new ItemVenda(1);
ItemVenda it3 = new ItemVenda(2);
vd.VetItens.Add(it1);
vd.VetItens.Add(it2);
vd.VetItens.Add(it3);

vd.MostrarDadosVenda();

// pagamento
/*
Pagamento pgto = new Pagamento(500);
pgto.MostrarDadosPagamento();
System.Console.WriteLine("Selecione o tipo de pagamento: \n1 - Em espécie \n2 - Cartão de Crédito \n3 - Cheque \nAperte qualquer tecla para sair.");
string opcaoPagamento = Console.Read();
    if (opcaoPagamento == "1") {
        Especie esp = new Especie();
        esp.CalcularTroco(100); // quantia de R$100,00
    }
    else if (opcaoPagamento == "2") {
        Cartao car = new Cartao("Número: 12736 3646 4374 3747 \tCVC: 321 \tPagamento: Débito", 1);
    }
    else if (opcaoPagamento == "3") {
        Cheque che = new Cheque(124748383729219);
        che.VerificarSituacao(2);
        che.MostrarDadosPagamento();
    }
    else {
        System.Console.WriteLine("Processo cancelado.");
    }

    Especie esp = new Especie();
    System.Console.Write("Informe a quantia a pagar: ");
    esp.Quantia = Convert.ToDouble(Console.ReadLine());
    esp.CalcularTroco(esp.Quantia); // quantia de R$100,00
    esp.MostrarDadosPagamento();

    Cartao car = new Cartao("Número: 2736 3646 4374 3747 \tCVC: 321 \tPagamento: Débito", 1);
    car.MostrarDadosPagamento();

    Cheque che = new Cheque(124748383729219);
    che.VerificarSituacao(2);
    che.MostrarDadosPagamento();
*/