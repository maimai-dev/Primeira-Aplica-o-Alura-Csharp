// Soul Beats!!!!
string mensagemDeBoasVindas = "Boas vindas ao Soul Beats";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Yung Buda", new List<int> { 10, 8, 6});
bandasRegistradas.Add("BTS", new List<int> { 5, 9, 6});

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██╗░░░██╗██╗░░░░░  ██████╗░███████╗░█████╗░████████╗░██████╗
██╔════╝██╔══██╗██║░░░██║██║░░░░░  ██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝
╚█████╗░██║░░██║██║░░░██║██║░░░░░  ██████╦╝█████╗░░███████║░░░██║░░░╚█████╗░
░╚═══██╗██║░░██║██║░░░██║██║░░░░░  ██╔══██╗██╔══╝░░██╔══██║░░░██║░░░░╚═══██╗
██████╔╝╚█████╔╝╚██████╔╝███████╗  ██████╦╝███████╗██║░░██║░░░██║░░░██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚══════╝  ╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: TodasBandas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: MediaDeUmaBanda();
            break;
        case -1: VoltarMenu();
            break;
        default: Console.WriteLine("Tchau Tchau :)");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(1000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void TodasBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    Thread.Sleep(1000);
    ExibirLogo();
    ExibirOpcoesDoMenu();

}

// poder avaliar a mesma banda mais de uma vez
void AvaliarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucessso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey(); 
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
}

void MediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média das bandas");
    Console.Write("Digite o nome da banda que deseja ver a média de notas: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda)){
        double mediaDasMusicas = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {mediaDasMusicas}");
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void VoltarMenu()
{
    
}

void ExibirTituloDaOpcao (string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
    
}


ExibirLogo();
ExibirOpcoesDoMenu();

