using NodeDef;
using Exam;
namespace Laba2_Alg
{
    class Program
    {
        static void Main()
        {
            NodeWork<int> queue = new NodeWork<int>();
            queue.Add(5);
            queue.Add(2);
            queue.Add(8);
            queue.Add(9);
            queue.Add(6);
            queue.Add(1);

            Init_Menu.Menu(queue);

        }
    }
}