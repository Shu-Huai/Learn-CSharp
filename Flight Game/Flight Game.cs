using System;
namespace Flight_Game
{
    class FlightGame
    {
        public static int[] map_ = new int[100];
        public static Player[] players_ = new Player[2];
        public struct Player
        {
            public string name_;
            public int position_;
        }
        public static void DisplayTitle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********飞行棋********");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void InitializeMap()
        {
            int[] luckyTurn = { 6, 23, 40, 55, 69, 83 };
            foreach (int index in luckyTurn)
            {
                map_[index] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            foreach (int index in landMine)
            {
                map_[index] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            foreach (int index in pause)
            {
                map_[index] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            foreach (int index in timeTunnel)
            {
                map_[index] = 4;
            }
        }
        public static string JudgeElem(int index, out int color)
        {
            if (index == players_[0].position_ || index == players_[1].position_)
            {
                color = 15;
                if (index == players_[0].position_ && index != players_[1].position_)
                {
                    return "Ａ";
                }
                else if (index == players_[1].position_ && index != players_[0].position_)
                {
                    return "Ｂ";
                }
                else
                {
                    return "<>";
                }
            }
            else
            {
                switch (map_[index])
                {
                    case 0:
                        color = 14;
                        return "□";
                    case 1:
                        color = 10;
                        return "◎";
                    case 2:
                        color = 12;
                        return "☆";
                    case 3:
                        color = 9;
                        return "▲";
                    case 4:
                        color = 3;
                        return "卐";
                    default:
                        color = 0;
                        return "";
                }
            }
        }
        public static void DisplayMap()
        {
            for (int i = 0; i < 30; i++)
            {
                string elem = JudgeElem(i, out int color);
                Console.ForegroundColor = (ConsoleColor)color;
                Console.Write(elem);
            }
            Console.WriteLine();
            for (int i = 30; i < 35; i++)
            {
                Console.Write("                                                          ");
                string elem = JudgeElem(i, out int color);
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine(elem);
            }
            for (int i = 64; i > 34; i--)
            {
                string elem = JudgeElem(i, out int color);
                Console.ForegroundColor = (ConsoleColor)color;
                Console.Write(elem);
            }
            Console.WriteLine();
            for (int i = 65; i < 70; i++)
            {
                string elem = JudgeElem(i, out int color);
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine(elem);
            }
            for (int i = 70; i < 100; i++)
            {
                string elem = JudgeElem(i, out int color);
                Console.ForegroundColor = (ConsoleColor)color;
                Console.Write(elem);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main()
        {
            InitializeMap();
            DisplayTitle();
            for (int i = 0; i < 2; i++)
            {
                do
                {
                    Console.Write("请输入{0}玩家的姓名：", i == 0 ? "Ａ" : "Ｂ");
                    players_[i].name_ = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(players_[i].name_) || players_[0].name_ == players_[1].name_)
                    {
                        Console.WriteLine("输入有误，请重新输入。");
                    }

                } while (string.IsNullOrWhiteSpace(players_[i].name_) || players_[0].name_ == players_[1].name_);
            }
            DisplayMap();
        }
    }
}