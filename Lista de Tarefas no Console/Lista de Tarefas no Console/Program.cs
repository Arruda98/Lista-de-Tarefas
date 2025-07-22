using System;

namespace Projeto
{
    class ListaDeTarefa
    {
        public static List<string> Tarefas = new List<string>();

        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();

            Console.WriteLine("====== Central de Tarefas ======\n");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Adicionar Tarefa\n2 - Listar Tarefas\n3 - Marcar tarefas como Concluídas\n4 - Remover Tarefas\n5 - Sair\n");

            Console.Write("Escolha uma opção: ");
            double opcaoMenu = double.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcaoMenu)
            {
                case 1: AdicionarTarefa(); break;
                case 2: ListarTarefa(); break;
                case 3: MarcarTarefa(); break;
                case 4: RemoverTarefa(); break;
                case 5: Sair(); break;
                default: break;
            }
            
        }

        public static void AdicionarTarefa()
        {
            Console.Clear();
            Thread.Sleep(500);
            
            Console.WriteLine("Qual tarefa deseja adicionar?");
            var atividade = Console.ReadLine();

            Tarefas.Add(atividade);

            Console.WriteLine("Tarefa adicionada com sucesso!");

            Thread.Sleep(1000);

            Menu();
        }
        
        public static void ListarTarefa()
        {
            if (Tarefas.Count == 0)
            {
                Console.Clear();

                Thread.Sleep(500);
                Console.WriteLine("Nenhuma atividade adicionada.");
                Thread.Sleep(3000);

                return;
            }

            Console.WriteLine("Lista de atividades: ");

            for (int i = 0; i < Tarefas.Count; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine($"{i+1}. [ ] {Tarefas[i]}");
            }

            Thread.Sleep(4000);
        }

        public static void MarcarTarefa()
        {
            Console.Clear();

            Thread.Sleep(500);
            Console.WriteLine("Qual tarefa você deseja marcar?");
            ListarTarefa();
            int marcar = int.Parse(Console.ReadLine());

            Console.WriteLine($"");
        }

        public static void RemoverTarefa()
        {

        }

        public static void Sair()
        {

        }
    }
}