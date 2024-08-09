using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen(30, 10);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScreen(int numColunas, int numLinhas) {

            Extremidades(numColunas);

            for (int lines = 0; lines <= numLinhas; lines++) {
                Console.Write("|");
                for (int i = 0; i <= numColunas; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Extremidades(numColunas);

        }
        public static void WriteOptions() {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Seleciona uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");


        }
        public static void HandleMenuOption(short option) {

            switch (option) {
                case 1:
                    Editor.Show(); break;
                case 2:
                    Console.WriteLine("View"); break;
                case 0: {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }

        }

        public static void Extremidades(int numColum) {
            Console.Write("+");
            for (int i = 0; i <= numColum; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");

        }


    }
}

