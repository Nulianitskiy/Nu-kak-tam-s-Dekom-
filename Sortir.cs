using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                arr[i] = rnd.Next();
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

        public void Comb_sort(int[] arr)
        {
            if (arr.Length <= 1) return;
            double k = 1.247;
            int step = arr.Length - 1;
            while (step > 1)
            {
                for (int i = 0; i + step < arr.Length - 1; i++)
                    if (arr[i] > arr[i + step])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + step];
                        arr[i + step] = t;
                    }
                //step /= k;
            }
            bool b = true;
            while (b)
            {
                b = false;
                for (int i = 1; i + 1 < arr.Length; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;
                        b = true;
                    }
            }
        }

        public void Insertion_sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i;
                while (j > 1 && arr[i - 1] > arr[i])
                {
                    int t = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = t;
                    j--;
                }
            }
        }

        public void Selection_sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = arr[i], ind = i;
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        ind = j;
                    }
                    int t = arr[i];
                    arr[i] = arr[ind];
                    arr[ind] = t;
                }
            }
        }

        public class TreeNode
        {
            public TreeNode(int data)
            {
                Data = data;
            }

            private int Data { get; set; }//данные
            private TreeNode Left { get; set; }//левая ветка дерева
            private TreeNode Right { get; set; }//правая ветка дерева

            private void Insert(TreeNode node)//рекурсивное добавление узла в дерево
            {
                if (node.Data < Data)

                    if (Left == null)
                        Left = node;
                    else
                        Left.Insert(node);

                else

                    if (Right == null)
                    Right = node;
                else
                    Right.Insert(node);
            }

            private int[] Transform(List<int> elements = null)//преобразование дерева в отсортированный массив
            {
                if (elements == null)
                    elements = new List<int>();

                if (Left != null)
                    Left.Transform(elements);
                elements.Add(Data);

                if (Right != null)
                    Right.Transform(elements);
                return elements.ToArray();
            }

            public int[] TreeSort(int[] array)//метод для сортировки с помощью двоичного дерева
            {
                var treeNode = new TreeNode(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    treeNode.Insert(new TreeNode(array[i]));
                }

                return treeNode.Transform();
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
