using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ну_как_там_с_деком
{
    class Deque : Stack
    {
        private int back;
        private int front;

        public Deque(int Lenght) : base(Lenght)
        {
            back = 0;
            front = Lenght;
        }
        private bool CheckConflict()
        {
            return back == front;
        }


        public void add_back(int TextIn) /*Добавление в начало дека*/
        {
            if (CheckFull() || CheckConflict())
                throw new IndexOutOfRangeException();
            items.Insert(0, TextIn);
            back++;
        }

        public void delete_back() /*Удаление из начала дека*/
        {
            if (CheckEmpty())
                throw new IndexOutOfRangeException();
            items.RemoveAt(0);
            back--;
        }

        public int get_back() /*Начальный элемент*/
        {
            return items[0];
        }

        public void add_front(int TextIn)
        {
            if (CheckConflict())
                throw new IndexOutOfRangeException();
            add_top(TextIn);
            front--;
        }
        public void delete_front()
        {
            delete_top();
            front++;
        }
        public int get_front()
        {
            return top;
        }
        public void deque_reverse()
        {
            stack_reverse();
            int t = front;
            front = back;
            back = t;
        }
    }
}
