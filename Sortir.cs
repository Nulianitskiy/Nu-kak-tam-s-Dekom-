using System;

namespace Ну_как_там_с_деком
{
    class Sortir
    {

        public int[] Zapolnitel(string Razm)
        {
            Random rnd = new Random();
            int n;
            if (Razm == "")
            {
                n = rnd.Next(0, 100000);
            }
            else
            {
                n = Convert.ToInt32(Razm);
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(0, 1000);
            return arr;
        }

        public void Bubble_sort(int[] arr)
        {
            if (arr.Length <= 1) return;

            bool b = true;
            while (b)
            {
                b = false;
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;
                        b = true;
                    }
                n--;
            }
        }

        public void Shaker_sort(int[] arr)
        {
            if (arr.Length <= 1) return;
            bool b = true;
            int beg = 0, end = arr.Length - 1;
            while (b)
            {
                b = false;
                beg++;
                for (int i = beg; i < end; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;
                        b = true;
                    }
                if (!b) break;
                end--;
                for (int i = end; i > beg; i--)
                    if (arr[i] < arr[i - 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = t;
                        b = true;
                    }
            }
        }

        private static int GetNextGap(int gap)
        {
            //The "shrink factor", empirically shown to be 1.3
            gap = (gap * 10) / 13;
            if (gap < 1)
            {
                return 1;
            }
            return gap;
        }

        public void Comb_sort(int[] array)
        {
            int length = array.Length;

            int gap = length;

            //We initialize this as true to enter the while loop.
            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = GetNextGap(gap);

                //Set swapped as false.  Will go to true when two values are swapped.
                swapped = false;

                //Compare all elements with current gap 
                for (int i = 0; i < length - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        //Swap
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
        }

        public void Insertion_sort(int[] array)
        {
            //1. For each value in the array...
            for (int i = 1; i < array.Length; ++i)
            {
                //2. Store the current value in a variable.
                int currentValue = array[i];
                int pointer = i - 1;

                //3. While we are pointing to a valid value...
                //4. If the current value is less than the value we are pointing at...
                while (pointer >= 0 && array[pointer] > currentValue)
                {
                    //5. Then move the pointed-at value up one space, and store the
                    //   current value at the pointed-at position.
                    array[pointer + 1] = array[pointer];
                    pointer -= 1;
                }
                array[pointer + 1] = currentValue;
            }
        }

        public void Selection_sort(int[] array)
        {
            int temp, smallest;

            //The algorithm builds the sorted list from the left.
            //1. For each item in the array...
            for (int i = 0; i < array.Length - 1; i++)
            {
                //2. ...assume the first item is the smallest value
                smallest = i;
                //3. Cycle through the rest of the array
                for (int j = i + 1; j < array.Length; j++)
                {
                    //4. If any of the remaining values are smaller, find the smallest of these
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                //5. Swap the found-smallest value with the current value
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
        }


        public class Node
        {
            public int Key { get; set; }
            public Node LeftNode, RightNode;

            public Node(int item)
            {
                Key = item;
                LeftNode = RightNode = null;
            }
        }

        public class TreeSort
        {
            // Root of Binary Search Tree
            Node Root = null;


            Node Insert(Node root, int key)
            {

                /* If the tree is empty, 
                return a new node */
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }

                /* Otherwise, recur 
                down the tree */
                if (key < root.Key)
                {
                    root.LeftNode = Insert(root.LeftNode, key);
                }
                else if (key > root.Key)
                {
                    root.RightNode = Insert(root.RightNode, key);
                }

                return root;
            }

            public void InsertToTree(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Root = Insert(Root, arr[i]);
                }
            }
        }

        public class HeapSort
        {
            public void sort(int[] arr)
            {
                int n = arr.Length;

                for (int i = n / 2 - 1; i >= 0; i--)// Построение кучи (перегруппируем массив)
                    heapify(arr, n, i);


                for (int i = n - 1; i >= 0; i--)// Один за другим извлекаем элементы из кучи
                {
                    int temp = arr[0];// Перемещаем текущий корень в конец
                    arr[0] = arr[i];
                    arr[i] = temp;

                    heapify(arr, i, 0);// вызываем процедуру heapify на уменьшенной куче
                }
            }


            // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
            // индексом в arr[]. n - размер кучи

            void heapify(int[] arr, int n, int i)
            {
                int largest = i;// Инициализируем наибольший элемент как корень
                int l = 2 * i + 1; // left = 2*i + 1
                int r = 2 * i + 2; // right = 2*i + 2

                if (l < n && arr[l] > arr[largest])// Если левый дочерний элемент больше корня
                    largest = l;

                if (r < n && arr[r] > arr[largest])
                    largest = r;// Если правый дочерний элемент больше, чем самый большой элемент на данный момент

                if (largest != i)// Если самый большой элемент не корень
                {
                    int swap = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = swap;

                    heapify(arr, n, largest);
                    // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                }
            }
        }

        public class SmoothSort
        {

            public void sort(int[] InputArray)//input array to sort
            {

                int len = InputArray.Length;
                for (int i = len / 2 - 1; i >= 0; i--)
                    LeonardHeap(InputArray, len, i);


                for (int i = len - 1; i >= 0; i--)//create binary Heap
                {
                    int temp = InputArray[0];
                    InputArray[0] = InputArray[i];
                    InputArray[i] = temp;
                    LeonardHeap(InputArray, i, 0);
                }


            }
            //to compare the childs with root to make the max-heap
            void LeonardHeap(int[] arr, int len, int index)
            {
                int lar = index;
                int l = 2 * index + 1;
                int r = 2 * index + 2;

                if (l < len && arr[l] > arr[lar])
                    lar = l;

                if (r < len && arr[r] > arr[lar])
                    lar = r;

                if (lar != index)
                {
                    int swap = arr[index];
                    arr[index] = arr[lar];
                    arr[lar] = swap;

                    LeonardHeap(arr, len, lar);

                }

            }
        }
    }
}
