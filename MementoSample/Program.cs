using System;

namespace MementoSample
{
    class Program
    {
        private static int index = -1;  //定义一个索引记录当前状态所在位置
        private static MementoCaretaker mc = new MementoCaretaker();
        //public static void Display(Chessman chess)
        //{
        //    Console.WriteLine("棋子{0}的当前位置为：第{1}行第{2}列", chess.Label, chess.X, chess.Y);
        //}

        static void Main(string[] args)
        {
            Chessman chess = new Chessman("车", 1, 1);
            
            Play(chess);
            chess.Y = 4;
            Play(chess);
            chess.X = 5;
            Play(chess);
            Undo(chess, index);
            chess.X = 6;
            Play(chess);
            Undo(chess, index);
            Undo(chess, index);
            Redo(chess, index);
            Redo(chess, index);

            Console.Read();
        }

        //下棋
        public static void Play(Chessman chess)
        {
            mc.SetMemento(chess.Save());
            index++;
            Console.WriteLine("棋子{0}的当前位置为：第{1}行第{2}列", chess.Label, chess.X, chess.Y);
        }

        //悔棋
        public static void Undo(Chessman chess, int i)
        {
            Console.WriteLine("******悔棋******");
            index--;
            chess.Restore(mc.GetMenmento(i - 1));   //撤销到上一个备忘录
            Console.WriteLine("棋子{0}的当前位置为：第{1}行第{2}列", chess.Label, chess.X, chess.Y);
        }

        //撤销悔棋
        public static void Redo(Chessman chess, int i)
        {
            Console.WriteLine("******撤销悔棋******");
            index++;
            chess.Restore(mc.GetMenmento(i + 1));   //撤销到上一个备忘录
            Console.WriteLine("棋子{0}的当前位置为：第{1}行第{2}列", chess.Label, chess.X, chess.Y);
        }
    }
}
