using System;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;

namespace OctoShell
{
    class Program
    {
        static void Main(string[] args)
        {
            FigletFont font = FigletFont.Load("slant.flf");
            Figlet figlet = new Figlet(font);

            Console.SetWindowSize(40, 40);
            Console.WriteLine(figlet.ToAscii("Github"), ColorTranslator.FromHtml("#8AFFEF"));

            var content = @".------------------------------------------------------------------------------.
|                             .mmMMMMMMMMMMMMMmm.                              |
|                         .mMMMMMMMMMMMMMMMMMMMMMMMm.                          |
|                      .mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm.                       |
|                    .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.                     |
|                  .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.                   |
|                 MMMMMMMM'  `""MMMMM""""""""""""""MMMM""""`  'MMMMMMMM                  |
|                MMMMMMMMM                           MMMMMMMMM                 |
|               MMMMMMMMMM:                         :MMMMMMMMMM                |
|              .MMMMMMMMMM                           MMMMMMMMMM.               |
|              MMMMMMMMM""                             ""MMMMMMMMM               |
|              MMMMMMMMM                               MMMMMMMMM               |
|              MMMMMMMMM                               MMMMMMMMM               |
|              MMMMMMMMMM                             MMMMMMMMMM               |
|              `MMMMMMMMMM                           MMMMMMMMMM`               |
|               MMMMMMMMMMMM.                     .MMMMMMMMMMMM                |
|                MMMMMMMMMMMMMMMMMM         MMMMMMMMMMMMMMMMMM                 |
|                 MMMMMMMMMMMMMMMM           MMMMMMMMMMMMMMMM                  |
|                  `MMMMMMMMMMMMMM           MMMMMMMMMMMMMM`                   |
|                    `MMMMMMMMMMMM           MMMMMMMMMMMM`                     |
|                      `""MMMMMMMMM           MMMMMMMMM""`                       |
|                         `""MMMMMM           MMMMMM""`                          |
|                             `""""M           M""""`                              |
'------------------------------------------------------------------------------'";

            var lines = content.Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            int r = 225;
            int g = 255;
            int b = 250;
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i], Color.FromArgb(r, g, b));

                r -= 8;
                b -= 4;
            }

            Console.ReadLine();
        }
    }
}
