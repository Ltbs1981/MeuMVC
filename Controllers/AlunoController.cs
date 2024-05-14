using System;
using System.Collections.Generic;
using CadastroNotas.Models;

namespace CadastroNotas.Controllers
{
    public class AlunoController
    {
        private List<Aluno> alunos;

        public AlunoController()
        {
            alunos = new List<Aluno>();
        }

        public void CadastrarAluno(string nome)
        {
            alunos.Add(new Aluno(nome));
        }

        public void AdicionarDisciplina(string nomeAluno, string disciplina)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.Nome == nomeAluno)
                {
                    aluno.AdicionarDisciplina(disciplina);
                }
            }
        }

        public void AlterarNotas(string nomeAluno, string disciplina, List<double> notas)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.Nome == nomeAluno)
                {
                    aluno.AlterarNotas(disciplina, notas);
                }
            }
        }

        public void ExcluirAluno(string nome)
        {
            alunos.RemoveAll(aluno => aluno.Nome == nome);
        }

        public void MostrarBoletim()
        {
            Console.WriteLine("===Boletim===");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                foreach (var disciplina in aluno.Disciplinas)
                {
                    Console.WriteLine($"Disciplina: {disciplina.Key}");
                    Console.WriteLine($"Notas: {string.Join(", ", disciplina.Value)}");
                    double media = aluno.CalcularMedia(disciplina.Key);
                    Console.WriteLine($"Média: {media}");
                    if (media < 6)
                    {
                        Console.WriteLine("Status: Recuperação");
                        double notaRecuperacao = aluno.CalcularNotaRecuperacao(disciplina.Key);
                        Console.WriteLine($"Nota necessária para aprovação: {notaRecuperacao}");
                    }
                    else
                    {
                        Console.WriteLine("Status: Aprovado");
                    }
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
