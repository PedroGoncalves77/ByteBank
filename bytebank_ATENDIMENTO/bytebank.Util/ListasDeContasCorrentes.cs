using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListasDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;
        public ListasDeContasCorrentes(int tamanhoInicial = 5) => _itens = new ContaCorrente[tamanhoInicial];
        public int Tamanho { get { return _proximaPosicao; } }
       

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificandoCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }
        public void VerificandoCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
             return; 

            Console.WriteLine("Aumentando tamanho da lisat");
            ContaCorrente[] criandoArray = new ContaCorrente[tamanhoNecessario];
            for (int i = 0; i < _itens.Length; i++)
            {
                criandoArray[i] = _itens[i];
            }
            _itens = criandoArray;

        }
      
        public void Remover(ContaCorrente conta) 
        {
            int indiceitem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaatual = _itens[i];
                if (contaatual == conta)
                {
                    indiceitem = i;
                    break;
                }
            }       
                for (int i = indiceitem; i < _proximaPosicao - 1; i++)
                {
                    _itens[i] = _itens[i + 1];
                }
                _proximaPosicao--;
                _itens[_proximaPosicao] = null!;
            }
        
       



        public void ListarArray() 
        {
            foreach(var item in _itens ) 
            {
                Console.WriteLine(item.Conta);
                Console.WriteLine(item.Numero_agencia);
            }
        }

        public ContaCorrente RetornaMaiorValor() => _itens.MaxBy(i => i.Saldo);
        
        public ContaCorrente AcessarIndiceItem(int indice) 
        {
            if (indice < 0 || indice >= _proximaPosicao) 
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        public ContaCorrente this[int indice] 
        { 
            get 
            { return AcessarIndiceItem(indice); } 
        }







}
}
