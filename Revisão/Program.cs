using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Digite seu ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine()); //o ReadLine sempre retorna em string. Logo é necessário a conversão para int
        int idade = 2024 - ano;
        System.Console.WriteLine("Sua idade é " + idade + " ano(s)."); // cw + tecla "Tab" -> escreve automaticamente o comando
        if (idade >= 18)
            System.Console.WriteLine("Maior de Idade.");
        else if (idade == 1)
            System.Console.WriteLine("É um bebê.");
        else
            System.Console.WriteLine("Menor de Idade.");
        

        // Estrutura de condicional de múltipla escolha
        // Nesse caso, pode escolhar número 1, 2, 3... e pode ou não haver um case que atenda essa opção.
        
        int opcao = 2;
        switch (opcao) // Focado em int, nunca usado em float
        {
            case 1: System.Console.WriteLine("1 - Somar");
                // qualquer lógica
                break; // Interrope. É necessário para não executar tudo ao mesmo tempo.
            case 2: System.Console.WriteLine("2 - Subtrair");
                break;
            default: System.Console.WriteLine("Opção inválida."); // similar ao "else"
                break;
        }


        // Estrutura de Repetição
        int num = 1;
        while (num <= 10)
        {
            System.Console.WriteLine("5 x " + num + " = " + num * 5); // Concatenação realizada já no WriteLine
            num ++; // Incremento (num + 1) para evitar um loop infinito
        }

        for (int tabuada = 1; tabuada <= 10; tabuada++) // valor que inicia, qtd de repetições, incremento
            for (int nume = 1; nume <= 10; nume++) 
                System.Console.WriteLine(tabuada + " x " + nume + " = " + nume * tabuada);
        
        do // Usada quando não precisa validar o primeiro valor. Nesse caso, esse laço de repetição não valida o 1
        {
            System.Console.WriteLine("7 x " + num + " = " + num * 7); // realiza a lógica primeiro
            num ++;
        }while(num <= 10); // depois valida a condição e realiza a 
        
        // Estrutura de repetição usada em vetor
        int[] vetor = new int[3]; 
        vetor[0] = 99;
        vetor[1] = 88;
        vetor[2] = 77;
        foreach (int vet in vetor) // percorre dentro do vetor
            System.Console.WriteLine(vet);

        System.Console.WriteLine("Exemplo com for"); // funciona similar, porém pode especificar índices
        for (int i = 0; i < vetor.Length; i++)
        {
            System.Console.WriteLine(vetor[i]);
        }
    }
}