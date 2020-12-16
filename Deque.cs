using System;

namespace Ну_как_там_с_деком
{
    class Deque : Stack
    {
        private int front;

        public Deque(int Lenght) : base(Lenght)
        {
            front = Lenght;
            top = -1;
        }
        private bool CheckConflict()
        {
            return top == front || (top == -1 && front == 0) || (top == items.Count && front == items.Count + 1);
        }
        private bool CheckDEmpty()
        {
            return front >= items.Count;
        }
        private bool CheckDFull()
        {
            return front <= 0;
        }


        public void pushBack(int TextIn) /*Добавление в начало дека*/
        {
            if (CheckConflict())
                throw new IndexOutOfRangeException();
            else
            {
                if (top == -1)
                    top++;
                push(TextIn);
            }
        }

        public void popBack() /*Удаление из начала дека*/
        {
            if (CheckConflict())
                throw new IndexOutOfRangeException();
            else
            {
                pop();
            }
        }

        public int getBack() /*Начальный элемент*/
        {
            return get();
        }

        public void pushFront(int TextIn)
        {
            if (CheckConflict() || CheckDFull())
                throw new IndexOutOfRangeException();
            else
            {
                if (front == items.Count + 1)
                    front--;
                items[--front] = TextIn;
            }
        }
        public void popFront()
        {
            if (CheckDEmpty()|| CheckConflict())
                throw new IndexOutOfRangeException();
            else
            {
                items[front++] = 0;
            }
        }
        public int getFront()
        {
            if (CheckDEmpty())
                throw new IndexOutOfRangeException();
            else
                return items[front];
        }

        public int operations(string chose)
        {
            return stackOperations(chose);
        }

        public int[] getAll()
        {
            return all();
        }
        public void dequeReverse()
        {
            int t = front;
            front = top;
            top = t;
            stackReverse();
        }
    }
}
