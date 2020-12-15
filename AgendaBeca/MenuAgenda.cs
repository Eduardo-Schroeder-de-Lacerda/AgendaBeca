using System;

namespace AgendaBeca
{
    public class MenuAgenda
    {
        public void MenuPrincipal()
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            CrudAgenda agenda = new CrudAgenda();
            agenda.HandleDiretorio();
            bool menuAgenda = true;
            while (menuAgenda)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("     AGENDA DO EDUARDO LACERDA   ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Cadastrar Pessoa              [1]");
                Console.WriteLine("Buscar Pessoa por nome        [2]");
                Console.WriteLine("Listar Agenda                 [3]");
                Console.WriteLine("Excluir Pessoa por nome       [4]");
                Console.WriteLine("Sair                          [0]");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        agenda.AdicionarPessoa();
                        break;

                    case 2:
                        agenda.BuscarPorNome();
                        break;

                    case 3:
                        agenda.BuscarTodos();
                        break;

                    case 4:
                        agenda.RemoverPorNome();
                        break;

                    case 0:
                        menuAgenda = false;
                        Console.WriteLine("Fechando Agenda...");
                        break;

                    default:
                        Console.WriteLine("Selecione uma opção valida");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void HandleDiretorio()
        {
            throw new NotImplementedException();
        }
    }
}