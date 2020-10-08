using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ну_как_там_с_деком
{
    class Stack
    {
        public List<int> items = new List<int>();
        public const int lenght = 5;

        public bool add_start(int TextIn) /*Добавление в начало дека*/
        {
            if (items.Count < lenght)/*Проверка на переполнение*/
            {
                items.Insert(0, TextIn);
                return true;
            }
            else return false;
        }

        public bool delete_start() /*Удаление из начала дека*/
        {
            if (items.Count != 0)
            {
                items.RemoveAt(0);
                return true;
            }
            else return false;
        }

        public int start() /*Начальный элемент*/
        {
                return items[0];
        }

        public int max() /*Максимум*/
        {
            int M = Convert.ToInt32(items[0]);
            int m;

            foreach (int Item in items)
            {
                m = Item;
                if (m > M) M = m;
            }
            return M;
        }

        public int min() /*Минимум*/
        {
            int M = items[0];
            int m;

            foreach (int Item in items)
            {
                m = Item;
                if (m < M) M = m;
            }
            return M;
        }

        public int count() /*Количество*/
        {
            return items.Count;
        }

        public string all() /*Все элементы*/
        {
            string x = "";
            if (items.Count != 0)
            {
                foreach (int Item in items)
                    x += Convert.ToString(Item) + " ";
            }
            return x;
        }

        public int sum() /*Сумма*/
        {
            int x = 0;
            foreach (int Item in items)
                x += Item;

            return x;
        }

        public int mult() /*Произведение*/
        {
            int x = 1;
            foreach (int Item in items)
                x *= Item;

            return x;
        }

        public void reverse() /*Инверсия*/
        {
            items.Reverse();
        }
    }
}
