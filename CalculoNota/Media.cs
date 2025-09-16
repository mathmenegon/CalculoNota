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
            int qtd = int.Parse(Console.ReadLine()!);
            
            var alunos = new List<(string Nome, float Media, bool Situacao)>();

            for (int i = 0; i < qtd; i++)
            { 
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine()!;
                Console.WriteLine("Digite a primeira nota: ");
                float nota1 = float.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite a segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite a terceira nota: ");
                float nota3 = float.Parse(Console.ReadLine()!);
                Console.WriteLine("Calculando...");
                Thread.Sleep(2500);
                Console.Clear();

                float media = (nota1 + nota2 + nota3) / 3;
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
