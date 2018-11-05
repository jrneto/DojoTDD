using System;
using System.Collections.Generic;

namespace NumerosRomanos.Domain
{
    public class ConversorDeNumeroRomano
    {
        private static Dictionary<string, int> tabela = new Dictionary<string, int>()
        {
            {"I",1},{"V",5},{"X",10},{"L",50},{"C",100},{"D",500},{"M",1000}
        };

        public int Converte(string numeroRomano)
        {
            int acumulador = 0;
            int ultimoVizinhoDaDireita = 0;

            for (int i = numeroRomano.Length - 1; i >= 0; i--)
            {
                //pega o inteiro referente ao simbolo atual
                int atual = tabela[numeroRomano[i].ToString()];
                //se o da direita for menor multiplicaremos por -1 para torná-lo negativo
                int multiplicador = 1;

                if (atual < ultimoVizinhoDaDireita)
                {
                    multiplicador = -1;
                }

                acumulador += atual * multiplicador;

                //Atualiza o vizinho da direita
                ultimoVizinhoDaDireita = atual;
            }

            return acumulador;
        }
    }
}