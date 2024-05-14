using System;
using CadastroNotas.Controllers;

namespace CadastroNotas.Views
{
    public class View
    {
        public static void ExibirMenu()
        {
            Console.WriteLine("===== Cadastro de Alunos =====");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Adicionar Disciplina");
            Console.WriteLine("3. Alterar Notas");
            Console.WriteLine("4. Excluir Aluno");
            Console.WriteLine("5. Mostrar Boletim");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
        }

        public static void ExibirBoletim(AlunoController controller)
        {
            Console.WriteLine("===== Boletim =====");
            controller.MostrarBoletim();
            Console.WriteLine("====================");
        }

        public static void LimparTela()
        {
            Console.Clear();
        }
    }
}
