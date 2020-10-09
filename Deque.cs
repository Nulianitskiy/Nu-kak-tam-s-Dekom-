using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ну_как_там_с_деком
{
    class Deque : Stack
    {   
        public bool add_end(int TextIn) /*Добавление в конец дека*/
        {
            if (!Full())
            {
                items.Add(TextIn);
                return true;
            }
            else return false;
        }
        
        public bool delete_end() /*Удаление из конца дека*/
        {
            if (!Empty())
            {
                items.RemoveAt(items.Count - 1);
                return true;
            }
            else return false;
        }
      
        public int end() /*Конечный элемент*/
        {
            if (!Empty())
            {
                return items[items.Count - 1];
            }
            else return 0;
        }
        
    }
}
