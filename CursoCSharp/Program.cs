using System;
using System.Collections.Generic;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando numero - Fundamentos", FormatandoNumero.Executar},
                {"Convercoes - Fundamentos", Convercoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadoror Ternario - Fundamentos", OperadorTernario.Executar},

                //ESTRUTURA DE CONTROLE
                {"Estrutura If - Estrutura de controle", EstruturaIf.Executar},
                {"Estrutura If/Else/If - Estrutura de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de controle", EstruturaWhile.Executar},
                {"Estrutura Do/While - Estrutura de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de controle", EstruturaFor.Executar},
                {"Estrutura Break - Estrutura de controle", EstruturaBreak.Executar},

                //Classes e Métodos
                {"Menbros - Classes e Métodos", Membros.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}