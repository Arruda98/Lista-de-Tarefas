using System;

namespace Projeto
{
    class ListaDeTarefa
    {
        List<string> Tarefas = new List<string>();

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

        }

        public static void ListarTarefa()
        {

        }

        public static void MarcarTarefa()
        {

        }

        public static void RemoverTarefa()
        {

        }

        public static void Sair()
        {

        }

}