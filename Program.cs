using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Exceções;
using CursoCSharp.API;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacão - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAritimeticos.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar },
                
                // Estruturas de Controle
                {"Estrutura IF - Estrutura de Controle", EstruturaIF.Executar },
                {"Estrutura IF/Else - Estrutura de Controle", EstruturaIfElse.Executar },
                {"Estrutura IF/Else IF - Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de Controle", Switch.Executar },
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar },
                
                //Classes e Métodos
                {"Membros - Classes E Metodos", Membros.Executar },
                {"Construtores - Classes E Metodos", Construtores.Executar },
                {"Metodos com Retorno - Classes E Metodos", MetodosComRetorno.Executar },
                {"Metodos Estaticos - Classes E Metodos", MetodosEstaticos.Executar },
                {"Atributos Estaticos - Classes E Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes E Metodos", DesafioAtributo.Executar },
                {"Params - Classes E Metodos", Params.Executar },
                {"Parametros Nomeados - Classes E Metodos", ParametrosNomeados.Executar },
                {"Get e Set - Classes E Metodos", GetSet.Executar },
                {"Props -  Classes e Metodos", Props.Executar },
                {"ReadOnly - Classes e Metodos", ReadOnly.Executar },
                {"Enum - Classes e Metodos", ExemploEnum.Executar },
                {"Struct - Classes e Metodos", ExemploStruct.Executar },
                {"Struct vs Classe - Classes e Metodos", StructVsClasse.Executar },
                {"Valor vs Referência - Classes e Metodos", ValorVsReferencia.Executar },
                {"Parametros por Referencia - Classes e Metodos", ParamentrosPorReferencia.Executar },
                {"Parametro Padrão - Classes e Metodos", ParametroPadrao.Executar },
                
                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },

                //Orientação a objeto
                {"Herança - Orientação a Objeto", Heranca.Executar },
                {"Construtor This - Orientação a Objeto", ConstrutorThis.Executar },
                {"Encapsulamento - Orientação a Objeto", OO.Encapsulamento.Executar },
                {"Polimorfismo - Orientação a Objeto", Polimorfismo.Executar },
                {"Abstract - Orientação a Objeto", Abstract.Executar },
                {"Interface - Orientação a Objeto", Interface.Executar },
                {"Sealed - Orientação a Objeto", Sealed.Executar },

                // Metodos e Funções
                {"Lambda - Metodos & Funções", ExemploLambda.Executar },
                {"Lambdas com Delegates - Metodos & Funções", LambdasDelegate.Executar },
                {"Usando Delegates - Metodos & Funções", UsandoDelegates.Executar },
                {"Delegates com Funções Anonimas - Metodos & Funções", DelegateFuncAnonima.Executar },
                {"Delegates com Parametros - Metodos & Funções", DelegatesComParametros.Executar },
                {"Métodos e Funções - Metodos & Funções", MetodosDeExtensao.Executar },


                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceção Personalizada - Exceções", ExcecoesPersonalizadas.Executar },


                //API
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}