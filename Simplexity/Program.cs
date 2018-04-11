using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DrawMenu();

        }

        static void Choise(byte menuSel) {
            if (menuSel == 1) {

            } else if (menuSel == 2) {
                DrawRules();
                DrawMenu();
            } else {
                DrawMenu();
            }
        }

        static void DrawMenu() {
            byte menuSel;

            // Simple menu
            Console.Clear();
            Console.WriteLine("╔═══════════════════════╗");
            Console.WriteLine("║\tSimplexity\t║");
            Console.WriteLine("╠═══════════════════════╣");
            Console.WriteLine("║\t1 - Play\t║");
            Console.WriteLine("║\t2 - How to win\t║");
            Console.WriteLine("╚═══════════════════════╝");
            menuSel = Convert.ToByte(Console.ReadLine());

            Choise(menuSel);
        }

        static void DrawRules() {
            Console.Clear();

            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║         Win Conditions        ║");
            Console.WriteLine("╚═══════════════════════════════╝\n");
            Console.WriteLine("╔════════╦═══════════╦═══════════╗");
            Console.WriteLine("║ Player ║ Win Color ║ Win Piece ║");
            Console.WriteLine("╠════════╬═══════════╬═══════════╣");
            Console.WriteLine("║ 1      ║ White     ║ Cilinder  ║");
            Console.WriteLine("╠════════╬═══════════╬═══════════╣");
            Console.WriteLine("║ 2      ║ Red       ║ Square    ║");
            Console.WriteLine("╚════════╩═══════════╩═══════════╝\n\n");
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║             Help             ║");
            Console.WriteLine("╚══════════════════════════════╝\n");
            Console.WriteLine("╔════════╦══════════╦══════════╗");
            Console.WriteLine("║        ║ Cilinder ║  Square  ║");
            Console.WriteLine("╠════════╬══════════╬══════════╣");
            Console.WriteLine("║ White  ║  \u25CF       ║  \u25A0       ║");
            Console.WriteLine("╠════════╬══════════╬══════════╣");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red");
            Console.ResetColor();
            Console.Write("    ║  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u25CF");
            Console.ResetColor();
            Console.Write("       ║  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u25A0");
            Console.ResetColor();
            Console.WriteLine("       ║");
            Console.WriteLine("╚════════╩══════════╩══════════╝");
            Console.ReadKey();
        }
    }
}