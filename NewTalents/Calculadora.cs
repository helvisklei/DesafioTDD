using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        /* O importante no TDD é que antes de codificar, deve ser codificado nos teste */
        public int somar(int val1, int val2) 
        {
            int resultadoSoma = val1 + val2;

            listaHistorico.Insert(0,"Resultado +: " + resultadoSoma);

            return resultadoSoma; // podendo fazer direto val1 + val 2;
        }

        public int subtrair(int val1, int val2)
        {
            int resultadoSubtracao = val1 - val2;

            listaHistorico.Insert(0, "Resultado -: " + resultadoSubtracao);

            return resultadoSubtracao;
        }

        public int multiplicar(int val1, int val2)
        {
            int resultadoMultiplicacao = val1 * val2;

            listaHistorico.Insert(0, "Resultado *: " + resultadoMultiplicacao);

            return resultadoMultiplicacao;
        }

        public int dividir(int val1, int val2)
        {
            int resultadoDivisao = val1 / val2;

            listaHistorico.Insert(0, "Resultado /: " + resultadoDivisao);

            return resultadoDivisao;
        }

        public List<string> historico() 
        {
            listaHistorico.RemoveRange(3,listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
