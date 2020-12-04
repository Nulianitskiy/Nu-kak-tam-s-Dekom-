﻿using System;
using System.Collections.Generic;

namespace Ну_как_там_с_деком
{
    class Stack
    {
        protected List<int> items;
        protected int top;

        public Stack(int Lenght)
        {
            items = new List<int>();
            
            for (int i = 0; i < Lenght; i++)
                items.Add(0);
            top = 0;
        }

        protected bool CheckFull()
        {
            return top == items.Count - 1;
        }
        protected bool CheckEmpty()
        {
            return top == 0;
        }

        protected void push(int TextIn) /*Добавление в топ*/
        {
            if (CheckFull())
                throw new IndexOutOfRangeException();
            else
            {
                items[top++] = TextIn;
            }
        }

        protected void pop() /*Удаление из топа*/
        {
            if (CheckEmpty())
                throw new IndexOutOfRangeException();
            else
            {
                items[--top] = 0;
            }
        }

        public int get() /*Элемент на топе*/
        {
            if (CheckEmpty())
                throw new IndexOutOfRangeException();
            else
                return items[top - 1];
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

        protected void stackReverse() /*Инверсия*/
        {
            items.Reverse();
        }
    }
}
