using System;
using System.Linq;
namespace Flight_Game
{
    class Program
    {
        public static int[] map_ = new int[100];
        public static Player[] players_ = new Player[2];
        public static int tempLength_ = 0;
        public struct Player
        {
            public string name_;
            public int position_;
            public bool needPause_;
        }
        public static void DisplayTitle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************飞行棋***************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("************************************************************");
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
        public static int GetMax(params int[] elems)
        {
            return elems.Max();
        }
        public static void DisplayGame(bool needClear = true)
        {
            (int xCoordinate, int yCoordinate) = Console.GetCursorPosition();
            if (needClear)
            {
                Console.SetCursorPosition(0, 0);
                DisplayTitle();
                Console.WriteLine("{0}的棋子用Ａ表示，{1}的棋子用Ｂ表示。\n图例：◎：幸运轮盘，☆：地雷，▲：暂停，卐：时空隧道。", players_[0].name_, players_[1].name_);
            }
            Console.SetCursorPosition(0, 8);
            DisplayMap();
            if (needClear)
            {
                for (int i = 0; i < yCoordinate - 21; i++)
                {
                    int playerOneLength = players_[0].name_.Length;
                    int playerTwoLength = players_[1].name_.Length;
                    int firstLength = 17 + playerOneLength + playerTwoLength + GetMax(playerOneLength, playerTwoLength);
                    int secondLength = 27 + GetMax(playerOneLength, playerTwoLength) + (int)Math.Ceiling((double)tempLength_ / 2);
                    for (int j = 0; j < GetMax(firstLength, secondLength); j++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
                (xCoordinate, yCoordinate) = (0, 21);
            }
            Console.SetCursorPosition(xCoordinate, yCoordinate);
            tempLength_ = 0;
        }
        public static void PlayerMove(int playerNumber, int step, ref int times)
        {
            times++;
            if (times > 2)
            {
                return;
            }
            players_[playerNumber].position_ += step;
            if (players_[playerNumber].position_ < 0)
            {
                players_[playerNumber].position_ = 0;
            }
            else if (players_[playerNumber].position_ > 99)
            {
                players_[playerNumber].position_ = 99;
            }
            DisplayGame(false);
            if (players_[playerNumber].position_ == players_[1 - playerNumber].position_)
            {
                Console.WriteLine("{0}踩到了{1}，{1}退六格，按任意键开始行动。", players_[playerNumber].name_, players_[1 - playerNumber].name_);
                Console.ReadKey(true);
                PlayerMove(1 - playerNumber, -6, ref times);
                Console.WriteLine("{0}行动完了。", players_[playerNumber].name_);
                Console.ReadKey(true);
                return;
            }
            switch (map_[players_[playerNumber].position_])
            {
                case 0:
                    Console.WriteLine("{0}踩到了方块，安全。", players_[playerNumber].name_);
                    Console.ReadKey(true);
                    break;
                case 1:
                    string selection;
                    do
                    {
                        Console.Write("{0}踩到了幸运轮盘，输入１交换玩家位置，输入２对方退六格：", players_[playerNumber].name_);
                        selection = Console.ReadLine();
                        tempLength_ = GetMax(tempLength_, selection.Length);
                        if (selection != "1" && selection != "2")
                        {
                            Console.WriteLine("输入有误，请重新输入。");
                        }
                    } while (selection != "1" && selection != "2");
                    if (selection == "1")
                    {
                        Console.WriteLine("{0}选择交换玩家位置，按任意键开始行动。", players_[playerNumber].name_);
                        Console.ReadKey(true);
                        int temp = players_[0].position_;
                        players_[0].position_ = players_[1].position_;
                        players_[1].position_ = temp;
                    }
                    else
                    {
                        Console.WriteLine("{0}选择对方退六格，按任意键开始行动。", players_[playerNumber].name_);
                        Console.ReadKey(true);
                        PlayerMove(1 - playerNumber, -6, ref times);
                    }
                    break;
                case 2:
                    Console.WriteLine("{0}踩到了地雷，退六格。", players_[playerNumber].name_);
                    Console.ReadKey(true);
                    PlayerMove(playerNumber, -6, ref times);
                    break;
                case 3:
                    Console.WriteLine("{0}踩到了暂停，暂停一回合。", players_[playerNumber].name_);
                    Console.ReadKey(true);
                    players_[playerNumber].needPause_ = true;
                    break;
                case 4:
                    Console.WriteLine("{0}踩到了时空隧道，前进十格。", players_[playerNumber].name_);
                    Console.ReadKey(true);
                    PlayerMove(playerNumber, 10, ref times);
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0}行动完了。", players_[playerNumber].name_);
            Console.ReadKey(true);
        }
        public static void Main()
        {
            InitializeMap();
            DisplayTitle();
            for (int i = 0; i < 2; i++)
            {
                do
                {
                    Console.Write("请输入{0}玩家的姓名：", i == 0 ? "Ａ" : "Ｂ");
                    players_[i].name_ = Console.ReadLine();
                    if (players_[i].name_.Length > 20)
                    {
                        Console.WriteLine("长度过长。");
                        players_[i].name_ = "";
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(players_[i].name_) || players_[0].name_ == players_[1].name_)
                    {
                        Console.WriteLine("输入有误，请重新输入。");
                    }

                } while (string.IsNullOrWhiteSpace(players_[i].name_) || players_[0].name_ == players_[1].name_);
            }
            DisplayGame();
            int roundCount = 0;
            while (players_[0].position_ < 99 && players_[1].position_ < 99)
            {
                if (!players_[roundCount % 2].needPause_)
                {
                    Console.WriteLine("{0}按任意键开始掷骰子。", players_[roundCount % 2].name_);
                    Console.ReadKey(true);
                    Random dice = new();
                    int diceNumber = dice.Next(1, 7);
                    Console.WriteLine("{0}投出了{1}，按任意键开始行动。", players_[roundCount % 2].name_, diceNumber);
                    Console.ReadKey(true);
                    int times = 0;
                    PlayerMove(roundCount % 2, diceNumber, ref times);
                    DisplayGame();
                }
                else
                {
                    Console.WriteLine("{0}暂停。", players_[roundCount % 2].name_);
                    Console.ReadKey(true);
                    players_[roundCount % 2].needPause_ = false;
                    Console.WriteLine("{0}行动完了。", players_[roundCount % 2].name_);
                    Console.ReadKey(true);
                }
                roundCount++;
            }
            if (players_[0].position_ == 99)
            {
                Console.WriteLine("{0}获胜。", players_[0].name_);
            }
            else if (players_[1].position_ == 99)
            {
                Console.WriteLine("{0}获胜。", players_[1].name_);
            }
            Console.ReadKey(true);
        }
    }
}