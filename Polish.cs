using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ну_как_там_с_деком
{
    class Opz
    {
        private List<object> opz;

        private Opz()
        {
            opz = new List<object>();
        }

        private void addNumber(ref string number)
        {
            if (number == "")
            {
                return;
            }
            number = number.Replace(',', '.');
            double numberAsDouble;
            if (!double.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out numberAsDouble))
            {
                throw new Exception("Один из операндов был не числом");
            }
            if (number.Length > 0)
            {
                opz.Add(numberAsDouble);
                number = "";
            }
        }

        public static Opz fromInfix(string input)
        {
            var res = new Opz();
            Stack<char> stack = new Stack<char>();
            bool checkMinus = true;
            string number = "";
            foreach (var symbol in input)
            {
                if (char.IsWhiteSpace(symbol))
                {
                    continue;
                }
                if (char.IsDigit(symbol) || symbol == '.'
                    || symbol == ',' || (symbol == '-' && checkMinus))
                {
                    number += symbol;
                }
                else
                {
                    res.addNumber(ref number);
                    if (symbol == '(')
                    {
                        stack.Push(symbol);
                    }
                    else if (symbol == ')')
                    {
                        while (stack.Count > 0 && stack.Peek() != '(')
                        {
                            res.opz.Add(stack.Pop());
                        }
                        if (stack.Count <= 0 || stack.Peek() != '(')
                        {
                            throw new Exception("В выражении либо неверно поставлен разделитель, либо не согласованы скобки");
                        }
                        stack.Pop();
                    }
                    else if (isBinaryOp(symbol))
                    {
                        while (stack.Count > 0 && isPriorityHigher(stack.Peek(), symbol))
                        {
                            res.opz.Add(stack.Pop());
                        }
                        stack.Push(symbol);
                    }
                }
                checkMinus = symbol == '(';
            }
            res.addNumber(ref number);
            while (stack.Count > 0 && isOperation(stack.Peek()))
            {
                res.opz.Add(stack.Pop());
            }
            if (stack.Count > 0)
            {
                throw new Exception("В выражении не согласованы скобки");
            }
            return res;
        }

        public string toString()
        {
            return string.Join(" ", opz);
        }

        public double evaluate()
        {
            Stack<double> stack = new Stack<double>();
            foreach (var el in opz)
            {
                if (el is char)
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    char op = (char)el;
                    if (op == '+')
                    {
                        stack.Push(a + b);
                    }
                    else if (op == '-')
                    {
                        stack.Push(a - b);
                    }
                    else if (op == '*')
                    {
                        stack.Push(a * b);
                    }
                    else if (op == '/')
                    {
                        stack.Push(a / b);
                    }
                }
                else
                {
                    stack.Push((double)el);
                }
            }
            if (stack.Count != 1)
            {
                throw new Exception("При вычислении на стеке должен был остаться 1 элемент." +
                    " Осталось " + stack.Count + " элемент. Ошибка");
            }
            return stack.Pop();
        }

        private static bool isOperation(char symbol)
        {
            return isBinaryOp(symbol);
        }

        private static bool isBinaryOp(char symbol)
        {
            return symbol == '+' || symbol == '-'
                || symbol == '*' || symbol == '/';
        }

        private static bool isPriorityHigher(char a, char b)
        {
            if (a == '*' || a == '/')
            {
                return true;
            }
            if (a == '+' || a == '-')
            {
                if (b == '*' || b == '/')
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
