using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.Text;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
#region
 string Retornaname(List<string> lista, string nome)
{
    if (lista.Contains(nome)) 
    {
        return $"nome: {nome} encontrado!";
    }
    return "Nome não encontrado";

}
ListasDeContasCorrentes listaDeContasCorrentes = new();

var conta1 = new ContaCorrente(874, "1234567-A");
conta1.Saldo = 1;
var conta2 = new ContaCorrente(874, "1234567-B");
conta2.Saldo = 2;
var conta3 = new ContaCorrente(874, "1234567-C");
conta3.Saldo = 3;
var conta4 = new ContaCorrente(874, "1234567-D");
conta4.Saldo = 80;
var conta5 = new ContaCorrente(874, "1234567-X");
conta5.Saldo = 80;
//var conta6 = new ContaCorrente(874, "1234567-F");
//var conta7 = new ContaCorrente(874, "1234567-G");
//var conta8 = new ContaCorrente(874, "1234567-x");


listaDeContasCorrentes.Adicionar(conta4);
listaDeContasCorrentes.Adicionar(conta3);
listaDeContasCorrentes.Adicionar(conta5);
listaDeContasCorrentes.Adicionar(conta1);
listaDeContasCorrentes.Adicionar(conta2);
listaDeContasCorrentes.ListarArray();
Console.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! " );
//listaDeContasCorrentes.Remover(conta5);
listaDeContasCorrentes.ListarArray();
for (int i = 0; i < listaDeContasCorrentes.Tamanho; i++) 
{
    ContaCorrente conta = listaDeContasCorrentes[i];
    Console.WriteLine(conta);
}
#endregion
List<ContaCorrente> _listaDeContas = new List<ContaCorrente>();

void AtendimentoAoCliente() 
{
    char opcao = '0';
    while (opcao != 6)
    {
        Console.Clear();
        Console.WriteLine("=========  Atendimento  ========= ");
        Console.WriteLine("=== 1- Cadastrar conta ===");
        Console.WriteLine("=== 2- Listar contas ===");
        Console.WriteLine("=== 3- Remover conta ===");
        Console.WriteLine("=== 4- Ordenar contas ===");
        Console.WriteLine("=== 5- Pesquisar contas ===");
        Console.WriteLine("=== 6- Sair ===");
        Console.WriteLine(" ");
        Console.Write("Digite a opção desejada: ");
        try { 
        opcao = Console.ReadLine()[0];
         }
        catch(Exception excecao) 
        {
            throw new ByteBankException(excecao.Message);
        }
        switch (opcao) 
        {
            case '1': CadastrarConta(); break;
            case '2': ListarConta(); break;
                //case '3': RemoverConta(); break;
                //case '4': OredenarConta(); break;
                //case '5': PesquisarConta(); break;
                //case '6': System.Environment.Exit(0);break;
                //default: AtendimentoAoCliente(); break; 
        }

    }
}

void PesquisarConta()
{
    throw new NotImplementedException();
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine()!;

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine()!);

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine()!);

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine()!;

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine()!;

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine()!;

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}


//void OredenarConta()
//{
//    throw new NotImplementedException();
//}

//void RemoverConta()
//{
//    throw new NotImplementedException();
//}

void ListarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count <= 0) 
    {
        Console.WriteLine("Lista de contas vazia");
        Console.ReadKey();
        return;
    }
    foreach(var item in _listaDeContas) 
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

//void CadastraConta()
//{
//    throw new NotImplementedException();
//}
AtendimentoAoCliente();