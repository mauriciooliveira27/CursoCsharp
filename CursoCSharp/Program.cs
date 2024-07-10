using System;
using System.Collections.Generic;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.MetodosEFuncoes;

using CursoCSharp.Fundamentos;
using static CursoCSharp.ClassesEMetodos.Moto;
using CursoCSharp.Excecoes;
using CursoCSharp.api;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
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
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get / Set - Classes e Métodos", GetSet.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e Métodos", ExemploStruct.Executar },


                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", Colecoes.List.Executar},

                //Orientação a Objeto
                {"Herança - Orentição a Objeto" , OO.Herenca.Executar},
                {"Construtor This - Orentição a Objeto" , OO.ConstrutorThis.Executar},
                {"Encapsulamento - Orentição a Objeto" , OO.Encapsulamentos.Executar},
                {"Polimorfismo - Orentição a Objeto" , OO.Polimorfismo.Executar},
                {"Abstract - Orentição a Objeto" , OO.Abstract.Executar},
                {"Interface - Orentição a Objeto" , OO.Interface.Executar},
                {"Sealed - Orentição a Objeto" , OO.Sealed.Executar},

                //Funções e Métodos
                {"Exemplo Lambda - Funções e Métodos" , ExemploLambda.Executar},
                {"Lambda Delegate - Funções e Métodos" , LambdaDelegate.Executar},
                {"Usando Delegate  - Funções e Métodos" , UsandoDelegate.Executar},
                {"Delegate com Função anônima  - Funções e Métodos" , DelegateFuncAnonima.Executar},
                {"Delegate com Parametros  - Funções e Métodos" , DelegatesComParametros.Executar},
                {"Metodos De Extensao  - Funções e Métodos" , MetodosDeExtensao.Executar},

                //Exceções
                 {"Primeira Exceção  - Exceção" , PrimeiraExcecao.Executar},
                 {"Exceção Personalizadas - Exceção" , ExcecoesPersonalizadas.Executar},

                // api
                {"Primeiro Arquivo - API" , PrimeiroArquivo.Executar},
                {"Lendo Arquivo - API" , LendoArquivo.Executar},
                {"Exemplo FileInfo - API" , ExemploFileInfo.Executar},
                {"Diretorios - API" , Diretorios.Executar},
                {"Exemplo DateTime - API" , ExemploDateTime.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}