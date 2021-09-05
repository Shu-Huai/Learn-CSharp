namespace Test_Delegate
{
    class Program
    {
        public delegate string Del(string str);
        public static void DoStr(string[] list, Del del)
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = del(list[i]);
            }
        }
        public static string DoUpper(string str)
        {
            return str.ToUpper();
        }
        public static string DoLower(string str)
        {
            return str.ToLower();
        }
        public static string AddSimbol(string str)
        {
            return "\"" + str + "\"";
        }
        private static void Main()
        {
            string[] test = new string[] { "aaaa", "AAAAAAAA", "asD", "dd", "D" };
            DoStr(test, new Del(DoUpper));
            DoStr(test, delegate (string str)
            {
                return str.ToLower();
            });
            DoStr(test, (string str) => { return str.ToUpper(); });
            return;
        }
    }
}
