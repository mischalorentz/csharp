using System;
using System.Collections.Generic;
using System.Text;

namespace projeto01
{
    class Program
    {

        static void Main()
        {

            MenuPrincipal();

        }

        static void MenuPrincipal()
        {
            int opt = 0;
            do
            {
                Console.WriteLine("\n## Escolhe uma opçao ##");
                StringBuilder menu = new StringBuilder();
                menu.Append("\n## 1 - Votar \n");
                menu.Append("## 2 - Conferir Contagem \n");
                menu.Append("## 3 - Sair \n");
                Console.WriteLine(menu);
                opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    Votar();
                }
                else if (opt == 2)
                {
                    try
                    {
                        Contagem.Conferir();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Não foi possível efetuar a contagem.");
                        Console.WriteLine(e.Message);
                    }
                }
                else if (opt == 3)
                    break;
            } while (opt != 3);
        }
        private static void Votar()
        {
            int vot = 0;
            do
            {
                Console.WriteLine("\n## 1 - Candidato 1");
                Console.WriteLine("## 2 - Candidato 2");
                Console.WriteLine("## 3 - Nulo");
                Console.WriteLine("## 4 - Branco");
                vot = int.Parse(Console.ReadLine());

                if (vot == 1 || vot == 2 || vot == 3 || vot == 4)
                {
                    Contagem.Incluir();
                    Console.WriteLine("## Voto computado com sucesso");
                    break;
                }

                else
                {
                    Console.WriteLine("## Opção inválida. Tente novamente.");
                    Votar();
                }

            } while (vot != 4);
        }

    }
}

public class Contagem
{
    public int totalDeVotos;
    public double PorcentagemDeNulos;
    public double PorcentagemDeBrancos;
    public int PontosCandidato1;
    public int PontosCandidato2;
    public string CandidatoVencedor;

    Contagem.Incluir();
   
    public static void Incluir()
    {
        List<int> list = new List<int>();
        {

            list.Add(Convert.ToInt32(Console.ReadLine()));
            totalDeVotos = list.Count;
        }

    }
    public static void Conferir()
    {
        Console.WriteLine("## Contagem de Votos");
        Console.WriteLine("## Total de votos: " + totalDeVotos);
        Console.WriteLine("## Porcentagem de Nulos: " + PorcentagemDeNulos);
    }

}




//public & static method
//public & static class
//construtor
//NUMERO read only (get)
//global variable
//try, catch
//class tipo enum
//string builder menu
