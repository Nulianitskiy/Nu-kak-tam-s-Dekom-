using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ну_как_там_с_деком
{
    class Deque : Stack
    {   
        public bool add_start(int TextIn) /*Добавление в начало дека*/
        {
            if (lenght != items.Count)
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
            if (items.Count != 0)
            {
                return items[0];
            }
            else return 0;
        }
    }
}
