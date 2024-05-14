using System;
using System.Collections.Generic;

namespace CadastroNotas.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public Dictionary<string, List<double>> Disciplinas { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Disciplinas = new Dictionary<string, List<double>>();
        }

        public void AdicionarDisciplina(string disciplina)
        {
            if (!Disciplinas.ContainsKey(disciplina))
            {
                Disciplinas[disciplina] = new List<double> { 0, 0, 0 };
            }
        }

        public void AlterarNotas(string disciplina, List<double> notas)
        {
            if (Disciplinas.ContainsKey(disciplina))
            {
                Disciplinas[disciplina] = notas;
            }
        }

        public double CalcularMedia(string disciplina)
        {
            if (Disciplinas.ContainsKey(disciplina))
            {
                double media = 0;
                foreach (var nota in Disciplinas[disciplina])
                {
                    media += nota;
                }
                return media / 3;
            }
            return 0;
        }

        public double CalcularNotaRecuperacao(string disciplina)
        {
            double media = CalcularMedia(disciplina);
            if (media < 6)
            {
                return (6 * 4 - Disciplinas[disciplina][0] - Disciplinas[disciplina][1] - Disciplinas[disciplina][2]) / 1;
            }
            return 0;
        }
    }
}
