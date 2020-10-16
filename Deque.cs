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

        public Deque(int Lenght) : base(Lenght)
        {
            back = 0;
        }



        public bool add_start(int TextIn) /*Добавление в начало дека*/
        {
            if (!CheckFull())
            {
                items.Insert(0, TextIn);
                return true;
            }
            else return false;
        }

        public bool delete_start() /*Удаление из начала дека*/
        {
            if (!CheckEmpty())
            {
                items.RemoveAt(0);
                return true;
            }
            else return false;
        }

        public int start() /*Начальный элемент*/
        {
            if (!CheckEmpty())
            {
                return items[0];
            }
            else return 0;
        }
    }
}
