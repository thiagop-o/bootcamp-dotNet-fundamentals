using System;

namespace Revisao
{
    class Program
    {

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToLower() != "s")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        AdicionarAluno(alunos, indiceAluno);
                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var contador = 0;
                        for(int i = 0; i < (indiceAluno+1); i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal = notaTotal + alunos[i].Nota;
                                contador++;
                            }

                        }
                        decimal media = notaTotal / contador;
                        Console.WriteLine("A média geral é :" + media);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
                indiceAluno++;
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("S - Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static void AdicionarAluno(Aluno[] alunos, int indiceAluno)
        {
            Console.WriteLine("Informe o nome do aluno: ");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                throw new ArgumentException("O valor da nota deve ser decimal");
            }
            alunos[indiceAluno] = aluno;
        }

    }
}
