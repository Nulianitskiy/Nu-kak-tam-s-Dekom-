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
        public List<int> items = new List<int>();
        public const int lenght = 5;

        protected bool Full()/*Проверка на переполнение*/
        {
            if (lenght == items.Count) return true;
            else return false;
        }
        protected bool Empty()
        {
            if (items.Count == 0) return true;
            else return false;
        }

        public bool add_start(int TextIn) /*Добавление в начало дека*/
        {
            if (!Full())
            {
                items.Insert(0, TextIn);
                return true;
            }
            else return false;
        }

        public bool delete_start() /*Удаление из начала дека*/
        {
            if (!Empty())
            {
                items.RemoveAt(0);
                return true;
            }
            else return false;
        }

        public int start() /*Начальный элемент*/
        {
            if (!Empty())
            {
                return items[0];
            }
            else return 0;
        }

        public int Operations(string chose, int x)
        {
            if (!Empty())
            {
                x = 0;
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
            else return x;
        }

        public int[] all() /*Все элементы*/
        {
            int[] output = items.ToArray();
            return output;   
        }

        public void reverse() /*Инверсия*/
        {
            items.Reverse();
        }
    }
}
