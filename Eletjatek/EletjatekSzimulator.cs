using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Eletjatek
{
    internal class EletjatekSzimulator
    {
        private int[,] Matrix { get; set; }
        private int OszlopokSzama { get; set; }
        private int SorokSzama { get; set; }

        public EletjatekSzimulator(int sorokSzama, int oszlopokSzama)
        {
            Matrix = new int[sorokSzama + 2, oszlopokSzama + 2];
            SorokSzama = sorokSzama;
            OszlopokSzama = oszlopokSzama;

            /* default 0 értékük van, így a szélekkel nem kell foglalkozni */
            Random rnd = new();
            for (int i = 1; i < Matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < Matrix.GetLength(1) - 1; j++)
                {
                    Matrix[i, j] = rnd.Next(2);
                }
            }
        }

        private void KovetkezoAllapot()
        {
            int[,] ujAllapot = new int[SorokSzama + 2, OszlopokSzama + 2];
            for (int i = 1; i < Matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < Matrix.GetLength(1) - 1; j++)
                {
                    int szomszedokSzama = KornyezoSejtekSzama(i, j);
                    if (Matrix[i, j] == 1 && (szomszedokSzama == 2 || szomszedokSzama == 3))
                    {
                        ujAllapot[i, j] = 1;
                    }
                    else if (Matrix[i, j] == 0 && szomszedokSzama == 3)
                    {
                        ujAllapot[i, j] = 1;
                    }
                }
            }

            Matrix = ujAllapot;
        }

        private int KornyezoSejtekSzama(int x, int y)
        {
            int n = 0;
            for (int i = x-1; i < x+2; i++)
            {
                for (int j = y-1; j < y+2; j++)
                {
                    if (i == x && j == y) continue;
                    if (Matrix[i, j] == 1) n++;
                }
            }
            return n;
        }

        private void Megjelenit()
        {
            Console.Clear();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == Matrix.GetLength(0) - 1 || j == Matrix.GetLength(1) - 1)
                    {
                        Console.Write('X');
                    }
                    else if (Matrix[i, j] == 0)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('S');
                    }
                }
                Console.WriteLine();
            }
        }

        public void Run()
        {
            while (!Console.KeyAvailable)
            {
                Megjelenit();
                KovetkezoAllapot();
                Thread.Sleep(500);
            }
        }
    }
}
