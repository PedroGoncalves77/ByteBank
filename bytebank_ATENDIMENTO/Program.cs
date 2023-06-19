using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

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
listaDeContasCorrentes.Remover(conta5);
listaDeContasCorrentes.ListarArray();



