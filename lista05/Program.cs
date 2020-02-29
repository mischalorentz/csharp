

using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class General
        {
            static void Main()
            {
                Console.WriteLine("Insira 5 números: ");
                Console.WriteLine("Adicione o primeiro número: ");

                #region List
                // Criando uma lista
                List<string> objList = new List<string>();

                // Atribuindo valor
                objList.Add(Console.ReadLine());
                Console.WriteLine("Adicione o segundo número: ");
                objList.Add(Console.ReadLine());
                Console.WriteLine("Adicione o terceiro número: ");
                objList.Add(Console.ReadLine());
                Console.WriteLine("Adicione o quarto número: ");
                objList.Add(Console.ReadLine());
                Console.WriteLine("Adicione o quinto número: ");
                objList.Add(Console.ReadLine());

            Console.WriteLine("Meu objeto lista" + objList);


                // Imprimindo todos
                foreach (var item in objList)
                {
                    Console.WriteLine(item);
                }
            #endregion



            /*
            #region Dictionary

            // Declaracao
            Dictionary<int, string> dic = new Dictionary<int, string>();

            // Insercao
            dic.Add(1, "Item A");
            dic.Add(2, "Item B");
            dic.Add(3, "Item C");

            // A posicao exata do dictionario baseado na key
            var itemDic = dic[1].ToString();
            Console.WriteLine(itemDic);

            // Imprimir todas
            foreach (var item in dic)
            {
                Console.WriteLine("Key: " + item.Key + " Valor: " + item.Value);

                // Checa existencia de um valor 
                if (item.Key == 1)
                    Console.WriteLine("Contem 1");

                if (dic.ContainsKey(1))
                    Console.WriteLine("Contem 1");
            }
            #endregion

            #region Queue
            // Fila. FIFO (First in First out)
            Queue<string> q = new Queue<string>();

            // Adicionar na fila
            q.Enqueue("Fila 1");
            q.Enqueue("Fila 2");

            // Tiro da fila e armazena na variavel
            string itemNaFila = q.Dequeue();

            // Listando item da fila
            foreach (var itemQueue in q)
            {
                Console.WriteLine("Item d fila = " + itemQueue);
            }
            #endregion

            #region Stack 
            // Pilha (LIFO)
            Stack<string> pilha = new Stack<string>();
            // Adiciona na pilha
            pilha.Push("Pilha 1");
            pilha.Push("Pilha 2");

            // Remove da pilha e guarda na variavel
            string itemPop = pilha.Pop();

            // Lendo todos itens da pilha
            foreach (var item in pilha)
            {
                Console.WriteLine("Item da pilha: " + item);
            }
            #endregion

            #region Tupla

            // Declaracao de uma tupla. Ja deve passar valor no construtor
            Tuple<int, string, string, string, string> tup =
                new Tuple<int, string, string, string, string>(1, "Tiago", "Programador", "M", "professor");

            // Imprimindo posicao 2
            Console.WriteLine("Tupla: " + tup.Item2);

            #endregion
            */
        }
    }
}

