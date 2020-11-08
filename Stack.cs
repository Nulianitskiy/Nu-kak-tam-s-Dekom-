using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ну_как_там_с_деком
{
    class Stack
    {
        protected List<int> items;
        protected int lenght;

        public Stack(int Lenght)
        {
            items = new List<int>();
            lenght = Lenght;
        }

        protected bool CheckFull()
        {
            return items.Count == lenght;
        }
        protected bool CheckEmpty()
        {
            return items.Count == 0;
        }

        protected void add_top(int TextIn) /*Добавление в топ*/
        {
            if (CheckFull())
                throw new IndexOutOfRangeException();
            items.Add(TextIn);
        }

        protected void delete_top() /*Удаление из топа*/
        {
            if (CheckEmpty())
                throw new IndexOutOfRangeException();
            items.RemoveAt(items.Count - 1);
        }

        public int top /*Элемент на топе*/
        {
            get => items[items.Count - 1];
        }

        public int operations(string chose)
        {
            if (!CheckEmpty())
            {
                int x = 0;
                switch (chose)
                {
                    case "min":
                    case "max":
                        x = items[0];
                        break;
                    case "sum":
                        x = 0;
                        break;
                    case "mult":
                        x = 1;
                        break;
                }
                foreach (int Item in items)
                    switch (chose)
                    {
                        case "min":
                            if (Item < x) x = Item;
                            break;
                        case "max":
                            if (Item > x) x = Item;
                            break;
                        case "sum":
                            x += Item;
                            break;
                        case "mult":
                            x *= Item;
                            break;
                    }
                return x;
            }
            else return 0;
        }

        protected int[] all() /*Все элементы*/
        {
            int[] output = items.ToArray();
            return output;   
        }
        public int[] All
        {
            get => all();
        }

        protected void stack_reverse() /*Инверсия*/
        {
            items.Reverse();
        }
    }
}
