using System;
using System.Collections.Generic;
using CadastroNotas.Controllers;
using CadastroNotas.Views;

namespace CadastroNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new AlunoController();

            while (true)
            {
                View.ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do aluno: ");
                        string nome = Console.ReadLine();
                        controller.CadastrarAluno(nome);
                        break;
                    case "2":
                        Console.Write("Nome do aluno: ");
                        nome = Console.ReadLine();
                        Console.Write("Nome da disciplina: ");
                        string disciplina = Console.ReadLine();
                        controller.AdicionarDisciplina(nome, disciplina);
                        break;
                    case "3":
                        Console.Write("Nome do aluno: ");
                        nome = Console.ReadLine();
                        Console.Write("Nome da disciplina: ");
                        disciplina = Console.ReadLine();
                        var notas = new List<double>();
                        for (int i = 1; i <= 3; i++)
                        {
                            Console.Write($"Nota {i}: ");
                            notas.Add(double.Parse(Console.ReadLine()));
                        }
                        controller.AlterarNotas(nome, disciplina, notas);
                        break;
                    case "4":
                        Console.Write("Nome do aluno a ser excluído: ");
                        nome = Console.ReadLine();
                        controller.ExcluirAluno(nome);
                        break;
                    case "5":
                        View.LimparTela();
                        View.ExibirBoletim(controller);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                View.LimparTela();
            }
        }
    }
}
