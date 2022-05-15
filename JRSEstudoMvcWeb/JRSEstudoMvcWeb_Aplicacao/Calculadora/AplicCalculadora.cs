using JRSEstudoMvcWeb_Aplicacao.Calculadora.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSEstudoMvcWeb_Aplicacao.Calculadora
{
    public enum operacoes
    {
        subtracao = 4,
        soma = 1,
        divisao = 2,
        multiplicacao = 3
    }
    public class AplicCalculadora : IAplicCalculadora
    {
        public decimal Calculador(decimal primeiroNumero, operacoes operacao, decimal segundoNumero)
        {
            var resultado = 0m;

            switch (operacao)
            {
                case operacoes.subtracao:
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case operacoes.soma:
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case operacoes.divisao:
                    resultado = primeiroNumero / segundoNumero;
                    break;
                case operacoes.multiplicacao:
                    resultado = primeiroNumero * segundoNumero;
                    break;
                default:
                    throw new Exception("Não foi identificado nenhuma operação");
            }

            return resultado;
        }
    }
}
