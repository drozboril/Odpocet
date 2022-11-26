using System;
using System.Media;
using System.Threading;

namespace Odpočet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo");
            int vstup = int.Parse(Console.ReadLine());
            if (vstup < 1 || vstup > 9)
            {
                Console.WriteLine("Neplatný vstup");
            }
            else
            {
                Console.SetWindowSize(10, 10);
                Odpočet_Třída o = new Odpočet_Třída();
                SoundPlayer beep = new SoundPlayer(@"F:\Users\User\Desktop\Dave\SŠ\MOA\Prog\MOA4\Odpočet\beep.wav"); //uživatel musí po stažení opravit umístění aby se přehrávaly zvuky
                SoundPlayer boom = new SoundPlayer(@"F:\Users\User\Desktop\Dave\SŠ\MOA\Prog\MOA4\Odpočet\explode.wav");
                for (int i = vstup; i > 0; i--)
                {
                    char horizontal = '-';
                    char vertical = '|';
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    switch (vstup)
                    {
                        case 1:
                            o.Jedna(vertical);
                            break;
                        case 2:
                            o.Dvě(horizontal, vertical);
                            break;
                        case 3:
                            o.Tři(horizontal, vertical);
                            break;
                        case 4:
                            o.Čtyři(horizontal, vertical);
                            break;
                        case 5:
                            o.Pět(horizontal, vertical);
                            break;
                        case 6:
                            o.Šest(horizontal, vertical);
                            break;
                        case 7:
                            o.Sedm(horizontal, vertical);
                            break;
                        case 8:
                            o.Osm(horizontal, vertical);
                            break;
                        case 9:
                            o.Devět(horizontal, vertical);
                            break;
                    }
                    beep.Play();
                    Thread.Sleep(1000);
                    vstup--;
                }
                Console.Clear();
                Console.SetCursorPosition(2, 5);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("BOOM!!!");
                boom.Play();
            }
            Console.ReadLine();
        }
    }
    class Odpočet_Třída
    {
        public char horizontal = '-';
        public char vertical = '|';
        public void HorizontalObject(char horizontal)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}", horizontal);
            }
            Console.WriteLine();
            return;
        }
        public void VerticalObject(char vertical)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", vertical);
            }
            return;
        }
        public void EmptyCenter(char vertical)
        {
            Console.WriteLine("{0} {1}", vertical, vertical);
            return;
        }
        public void Jedna(char vertical)
        {
            VerticalObject(vertical);
            return;
        }
        public void Dvě(char horizontal, char vertical)
        {
            HorizontalObject(horizontal);
            Console.WriteLine("  {0}", vertical);
            HorizontalObject(horizontal);
            Console.WriteLine("{0}  ", vertical);
            HorizontalObject(horizontal);
            return;
        }
        public void Tři(char horizontal, char vertical)
        {
            for (int i = 0; i < 2; i++)
            {
                HorizontalObject(horizontal);
                Console.WriteLine("  {0}", vertical);
            }
            HorizontalObject(horizontal);
            return;
        }
        public void Čtyři(char horizontal, char vertical)
        {
            Console.WriteLine();
            EmptyCenter(vertical);
            HorizontalObject(horizontal);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}  ", vertical);
            }
            return;
        }
        public void Pět(char horizontal, char vertical)
        {
            HorizontalObject(horizontal);
            Console.WriteLine("{0}  ", vertical);
            HorizontalObject(horizontal);
            Console.WriteLine("  {0}", vertical);
            HorizontalObject(horizontal);
            return;
        }
        public void Šest(char horizontal, char vertical)
        {
            HorizontalObject(horizontal);
            Console.WriteLine("{0}  ", vertical);
            HorizontalObject(horizontal);
            EmptyCenter(vertical);
            HorizontalObject(horizontal);
            return;
        }
        public void Sedm(char horizontal, char vertical)
        {
            HorizontalObject(horizontal);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  {0}", vertical);
            }
            return;
        }
        public void Osm(char horizontal, char vertical)
        {
            for (int i = 0; i < 2; i++)
            {
                HorizontalObject(horizontal);
                EmptyCenter(vertical);
            }
            HorizontalObject(horizontal);
            return;
        }
        public void Devět(char horizontal, char vertical)
        {
            HorizontalObject(horizontal);
            EmptyCenter(vertical);
            HorizontalObject(horizontal);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("  {0}", vertical);
            }
            return;
        }
    }
}