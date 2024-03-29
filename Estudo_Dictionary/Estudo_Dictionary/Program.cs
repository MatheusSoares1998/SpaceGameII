﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoAnalisado = "Uma atividade livre, conscientemente tomada como “não-séria” e exterior à vida" +
                " habitual, mas ao mesmo tempo capaz de absorver o jogador de maneira intensa e total. É uma atividade" +
                " desligada de todo e qualquer interesse material, com a qual não se pode obter qualquer lucro, praticada" +
                " dentro de limites espaciais e temporais próprios, segundo uma certa ordem e certas regras. Promove a " +
                "formação de grupos sociais com tendência a rodearem-se de segredo e a sublinharem sua diferença em " +
                "relação ao resto do mundo por meio de disfarces ou outros meios semelhantes";
            Dictionary<string, int> resultado = VerificarQuantidadePalavras(textoAnalisado);
            foreach (var item in resultado)
            {
                Console.WriteLine($"A palavra [{item.Key}] se repete {item.Value} vez(es)");
            }
            Console.ReadLine();
            Console.WriteLine("Agora com o SortedDictionary:");
            SortedDictionary<string, int> resultadoOrdenado = VerificarQuantidadePalavrasOrdenadas(textoAnalisado);
            foreach (var item in resultadoOrdenado)
            {
                Console.WriteLine($"A palavra [{item.Key}] se repete {item.Value} vez(es)");
            }
            Console.ReadLine();
        }

        static Dictionary<string, int> VerificarQuantidadePalavras(string texto)
        {
            Dictionary<string, int> palavrasColetadas = new Dictionary<string, int>();
            string[] palavras = texto.Split(' ', ',', ';', '.');
            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    int count;
                    if (!palavrasColetadas.TryGetValue(item.ToLower(), out count)){
                        count = 0;
                    } 
                    palavrasColetadas[item.ToLower()] = count + 1;
                }
            }
            return palavrasColetadas;
        }

        static SortedDictionary<string, int> VerificarQuantidadePalavrasOrdenadas(string texto)
        {
            SortedDictionary<string, int> palavrasColetadas = new SortedDictionary<string, int>();
            string[] palavras = texto.Split(' ', ',', ';', '.');
            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    int count;
                    if (!palavrasColetadas.TryGetValue(item.ToLower(), out count))
                    {
                        count = 0;
                    }
                    palavrasColetadas[item.ToLower()] = count + 1;
                }
            }
            return palavrasColetadas;
        }
    }
}
