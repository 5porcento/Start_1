string msgInicial = "Bem vindo(a) a essa aplicação";

void ExibirLogo()
{
    Console.WriteLine(@" 
███╗░░░███╗░█████╗░██╗░░░██╗██╗███████╗░██████╗  ░█████╗░██████╗░██████╗░
████╗░████║██╔══██╗██║░░░██║██║██╔════╝██╔════╝  ██╔══██╗██╔══██╗██╔══██╗
██╔████╔██║██║░░██║╚██╗░██╔╝██║█████╗░░╚█████╗░  ███████║██████╔╝██████╔╝
██║╚██╔╝██║██║░░██║░╚████╔╝░██║██╔══╝░░░╚═══██╗  ██╔══██║██╔═══╝░██╔═══╝░
██║░╚═╝░██║╚█████╔╝░░╚██╔╝░░██║███████╗██████╔╝  ██║░░██║██║░░░░░██║░░░░░
╚═╝░░░░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝╚══════╝╚═════╝░  ╚═╝░░╚═╝╚═╝░░░░░╚═╝░░░░░");
    Console.WriteLine(msgInicial);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um filme");
    Console.WriteLine("Digite 2 para mostrar todos os filmes");
    Console.WriteLine("Digite 3 para avaliar um filme");
    Console.WriteLine("Digite 4 para exibir a media de um filme");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção:");
   string opcaoEscolhida= Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    switch(opcaoEscolhidaNum)
    {
    case 1: RegistrarFilme();
            break;
     case 2: MostrarFilmes();
                break;
            case 3: Console.WriteLine("voce escolheu " + opcaoEscolhidaNum);
            break;
            case 4: Console.WriteLine("voce escolheu " + opcaoEscolhidaNum); 
            break;
            case -1: Console.WriteLine("Tchau Tchau");
            break;
            default: Console.WriteLine("opçao invalida ");
            break;
    }

}
void RegistrarFilme()
{
    Console.Clear();
    Console.WriteLine("Registro de filmes");
    Console.Write("Digite o nome do filme: ");
    string nomeFilme = Console.ReadLine()!;
    Console.WriteLine("o filme {0} foi registrado com sucesso!!", nomeFilme);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}
ExibirMenu();