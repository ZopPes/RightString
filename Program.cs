using System;

namespace OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ToRigtString(-1261));
        }

        public static string ToRigtString(int arg)
        {
            if (arg == 0) return "ноль";

            var rez = arg < 0 ? "минус " : "";

            arg = Math.Abs(arg);

            // rez += desattis(arg % 100000 / 1000);
            rez += thousand(arg % 10000 / 1000);
            rez += hundred(arg % 1000 / 100);

            if (arg % 100 / 10 == 1) rez += ten(arg % 10);
            else
            {
                rez += dozens(arg % 100 / 10);
                rez += unit(arg % 10);
            }
            return rez;
        }

        private static string desattis(int arg)
        {
            if (arg % 100 / 10 == 1)
            {
                switch (arg % 10)
                {
                    case 0:
                        return "десять ";

                    case 1:
                        return "одинадцать ";

                    case 2:
                        return "двенадцать ";

                    case 3:
                        return "тренадцать ";

                    case 4:
                        return "четурнадцать ";

                    case 5:
                        return "пятнадцать ";

                    case 6:
                        return "шеснадцать ";

                    case 7:
                        return "семнадцать ";

                    case 8:
                        return "восемнадцать ";

                    case 9:
                        return "девятнадцать ";
                }
            }
            else
            {
                var rez = "";

                switch (arg % 100 / 10)
                {
                    case 2:
                        rez += "двадцть ";
                        break;

                    case 3:
                        rez += "тридцать ";
                        break;

                    case 4:
                        rez += "сорок ";
                        break;

                    case 5:
                        rez += "пядесят ";
                        break;

                    case 6:
                        rez += "шездясят ";
                        break;

                    case 7:
                        rez += "семдясят ";
                        break;

                    case 8:
                        rez += "восемдясят ";
                        break;

                    case 9:
                        rez += "девяносто ";
                        break;
                }

                return rez;
            }
            return "";
        }

        private static string ten(int arg) => arg switch
        {
            0 => "десять ",
            1 => "одинадцать ",
            2 => "двенадцать ",
            3 => "тренадцать ",
            4 => "четырнадцать ",
            5 => "пятнадцать ",
            6 => "шеснадцать ",
            7 => "семнадцать ",
            8 => "восемандцать ",
            9 => "девятнадцать ",
            _ => "",
        };

        private static string hundred(int arg) => arg switch
        {
            1 => "сто ",
            2 => "двести ",
            3 => "триста ",
            4 => "четыресто ",
            5 => "пятьсот ",
            6 => "шесот ",
            7 => "семсот ",
            8 => "восемсот ",
            9 => "девятсот ",
            _ => "",
        };

        private static string dozens(int arg) => arg switch
        {
            2 => "двадцать ",
            3 => "тридцать ",
            4 => "сорок ",
            5 => "педясят ",
            6 => "шестьдясят ",
            7 => "семьдесят ",
            8 => "восемдесят ",
            9 => "девяносто ",
            _ => "",
        };

        private static string unit(int arg) => arg switch
        {
            1 => "один",
            2 => "два",
            3 => "три",
            4 => "четыре",
            5 => "пять",
            6 => "шесть",
            7 => "семь",
            8 => "восем",
            9 => "девять",
            _ => "",
        };

        private static string thousand(int arg) => arg switch
        {
            1 => "одна тысяча ",
            2 => "две тысячи ",
            3 => "три тысячи ",
            4 => "четыре тысячи ",
            5 => "пять тысяч ",
            6 => "шесть тысяч ",
            7 => "сем тысяч ",
            8 => "восем тысяч ",
            9 => "девять тысяч ",
            _ => "",
        };
    }
}