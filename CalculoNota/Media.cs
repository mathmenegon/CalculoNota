using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNota
{
    internal class Media
    {
        public void Show()
        {
            Aluno();
        }

        static void Aluno()
        {
            Console.Clear();
            Console.WriteLine("Gostaria de calcular a media de quantos alunos?");
            int qtdAlunos = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Gostaria de calcular a media de quantas provas?");
            int qtdNotas= int.Parse(Console.ReadLine()!);

            var alunos = new List<(string Nome, float Media, bool Situacao)>();
            var notas = new List<float>();

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine()!;
                for (int y = 0; y < qtdNotas; y++)
                {
                    var x = y + 1;
                    Console.WriteLine($"Digite a {x}º nota do aluno: ");
                    float nota = float.Parse(Console.ReadLine()!);
                    notas.Add(nota);
                }

                Console.WriteLine("Calculando...");
                Thread.Sleep(2500);
                Console.Clear();

                float media = notas.Sum() / notas.Count();
                bool situacao = media >= 7.0;
                alunos.Add((nome, media, situacao));
            }

            Console.WriteLine("Resultados dos alunos:");
            Console.WriteLine("----------------------");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome} | Média: {aluno.Media:F2} | {(aluno.Situacao ? "Aprovado" : "Reprovado")}");
            }
        }
    }
}
