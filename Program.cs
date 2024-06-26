﻿using System;  // Importando uma biblioteca, já não se faz mais necessário importar o System, pois o .NET já faz isso por padrão.
namespace MeuApp  // Declarando o "package" - Divisão lógica
{
    /// <summary>
    /// Valor explicativo da minha classe
    /// </summary>
    class Program  // Declarando a classe
    {
        static void Main(string[] args)  // Método principal, onde é executado o programa por padrão
        {
            // Variáveis
            int idade;  // Correto, inicia com zero
            int anos = 22;  // Correto, inicia com 22
            var numero = 22;  // Correto, inicia com 22
            // var numero2;  // Errado
            // Console.WriteLine(idade);
            Console.WriteLine(anos);
            Console.WriteLine(numero);



            // Constantes
            // const int IDADE_MINIMA;  // Errado
            const int IDADE_MINIMA = 22;  // Correto, inicia com 22
            Console.WriteLine(IDADE_MINIMA);
            // const var IDADE_MAXIMA = 30; // Errado
            // const var IDADE_MAXIMA; // Errado



            // Palavras reservadas ou Keywords
            // var, char, int, float, double, const
            // Não pode declarar variáveis e constantes com os nomes reservados pelo sistema
            // int float = 23;  / Errado



            // Comentários
            // Comentário em uma linha
            /*
                Comentário em várias
                linhas
            */
            /// Notação XML (Metadata)



            // Tipos primitivos - built-in types
            /*
            - Simple Types (Tipos Simples)
            - Enums (Enumeradores)
            - Structs (Estruturas)
            - Nullable Types (Tipos Nulos)
            */


            /* Tipo byte e sbyte
            - byte (8bits)
            - 0 até 255
            */
            byte byteMaximo = 255;

            /*
            - sbyte (8bits)
            - -128 até 127
            */
            sbyte byteMinimo = -128;



            /*
            Números Inteiros
            - short/ushort
            - int/uint
            - long/ulong
            - Assim como temos o signed nos bytes, nos números por padrão são permitidos valores negativos
            - Então usamos o unsigned para definir que o mesmo não pode receber valores negativos
            - O tipo int é o mais comum a ser encontrado

            Definições:
            - short (16bits)
            - -32.768 até 32.767

            - ushort (16bits)
            - 0 até 65.535

            - int (32bits)
            - -2.147.483.648 até 2.147.483.647

            - uint (32bits)
            - 0 até 4.294.967.295

            - long (64bits)
            - -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807

            - ulong (64bits)
            - 0 até 18.446.744.073.709.551.615
            */



            /*
            Números Reais
            - float (Notação F)
            - double
            - decimal (Notação M)

            Definições:
            - float (32bits)
            - -3.402823e38 até 3.402823e38

            - double (64bits)
            - -1.79769313486232e308 até 1.79769313486232e308

            - decimal (128bits)
            - (+ ou -)1.0 x 10e-28 até 7.9 x 10e28

            - Números que exigem uma maior precisão, ou seja, com pontuação
            - Possuem assimilação negativa e positiva por padrão, dispensando uso do signed/unsigned em seus tipos
            */

            var salario = 2.500;  // O "var" vai dinamicamente atribuir um tipo double para a variável
            double salarioDesejado = 4.500;  // Para o tipo double, não se faz necessário especificar um sufixo
            float novoSalario = 3.000f;  // Para implicitamente declarar como float, deve-se atribuir o "f" ao final do número
            decimal salarioAnual = 36.000m;  // Para implicitamente declarar como decimal, deve-se atribuir o "m" ao final do número



            /*
            Boolean
            - true (verdadeiro)
            - false (falso)

            Definições:
            - Definido pela palavra reservada bool
            - bool (8bits)
            - true ou false
            */

            bool usuarioJaCadastrado = true;
            bool pagamentoRecebido = false;
            var usuarioExpirado = false;



            /*
            Char
            - char (16bits)
            Definições:
            - Utilizado para armazenar apenas um caractere no formato Unicode
            - Definido pela palavra reservada char
            - A atribuição de um valor char é dada por aspas simples
            - Qualquer caractere
            */

            char primeiraLetra = 'a';
            var segundaLetra = 'b';



            /*
            String
            string (n bits)
            Definições:
            - Armazena uma cadeia de caracteres
            - Podemos pensar nele como uma lista de char
            - Definido pela palavra reservada string
            - A atribuição de um valor string é dada por aspas duplas
            */

            string meuNome = "David";
            var documento = "Documento.PDF";



            /*
            Var
            var idade = 22;  Será do tipo int
            var nome = "David";  Será do tipo string
            Definições:
            - Substitui o nome de um tipo
            - Será do tipo do primeiro valor atribuído
            - Recomendado o uso
            - Deixe para usar o var quando já dominar os tipos
            */

            // IEnumerable<MeuTipoComplexo> aluno = new IEnumerable<MeuTipoComplexo>();
            // var aluno = new IEnumerable<MeuTipoComplexo>();



            /*
            Object
            object idade = 22;  / Será do tipo object
            object nome = "David";  / Será do tipo object
            Definições:
            - Tipo genérico que recebe qualquer valor ou objeto
            - Caso não saiba o tipo da informação ou ela seja de vários tipos diferentes
            - Não possui intelisense (AJuda dos editores) por ser um tipo desconhecido
            - Evite usar
            */
            object quantidade;
            quantidade = 1;
            quantidade = 2.5;
            quantidade = "David";
            System.Console.WriteLine(quantidade.GetType());



            /*
            Null
            Definições:
            - Significa vazio, nada
            - Diferente de zero ou uma string vazia
            - Todo tipo, primitivo ou complexo pode receber o valor null
            - O tipo deve ser marcado como Nullable Type

            - Podemos atribuir null a um objeto
            - Desde que o mesmo seja marcado como nullable
             - Usando a interrogação na frente do tipo
            - Se uma chamada a um valor nulo for feita, um erro será apresentado
            */

            int? novaIdade = null;  // A variável recebe um valor null
            System.Console.WriteLine(novaIdade);
            novaIdade = 0;  // Depois é atribuído o valor 0
            System.Console.WriteLine(novaIdade);
            novaIdade = 22;  // E então passa a ser 22
            System.Console.WriteLine(novaIdade);

            /*
            Alias
            Definições:
            - Alias é um apelido que todo tipo no .NET tem
            - Por exemplo
             - System.String tem o alias string
             - Vimos anteriormente os alias
             - C# é Case Sensitive
             - É recomendado sempre usar o alias
             - No caso abaixo o resultado é o mesmo
              - Com o alias escrevemos menos

             string minhaString = "David" // Alias
             System.String minhaString = "David" //Tipo
            */

            String minhaString = "Sou derivado de ";
            Console.WriteLine(minhaString + minhaString.GetType());

            System.Int16 inteiroShort = 5;  // Mesma coisa que: short inteiroShort = 5;
            System.Console.WriteLine(inteiroShort.GetType());



            /*
            Valores Padrões
            Definições:
            - Todo tipo built-in, já possui um valor padrão
            - Se nenhum valor for informado, seu valor padrão será utilizado
            - int => 0
            - float => 0.0f
            - decimal => 0.0m
            - bool => false
            - char => '\0'
            - string => ""
            */
        }
    }
}