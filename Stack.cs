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


        public bool add_top(int TextIn) /*Добавление в топ*/
        {
            if (lenght != items.Count)
            {
                items.Add(TextIn);
                return true;
            }
            else return false;
        }

        public bool delete_top() /*Удаление из топа*/
        {
            if (items.Count != 0)
            {
                items.RemoveAt(items.Count - 1);
                return true;
            }
            else return false;
        }

        public int top() /*Элемент на топе*/
        {
            if (items.Count != 0)
            {
                return items[items.Count - 1];
            }
            else return 0;
        }

        public int Operations(string chose, int x)
        {
            if (items.Count != 0)
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
