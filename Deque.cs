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
            if (items.Count < lenght)
            {
                items.Add(TextIn);
                return true;
            }
            else return false;
        }
        
        public bool delete_end() /*Удаление из конца дека*/
        {
            if (items.Count != 0)
            {
                items.RemoveAt(items.Count - 1);
                return true;
            }
            else return false;
        }
      
        public int end() /*Конечный элемент*/
        {
            return items[items.Count - 1];
        }
        
    }
}
