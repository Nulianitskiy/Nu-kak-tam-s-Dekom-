using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Ну_как_там_с_деком
{
    public partial class Sortir_Form : Form
    {
        public Sortir_Form()
        {
            InitializeComponent();
        }
        Sortir Zuma = new Sortir();

        int[] MainArray;
        int[] WorkArray;

        string writePath = @"Out.txt";
        Stopwatch stopWatch = new Stopwatch();// Секундомер

        private void Timer(Stopwatch stopwatch)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }
        private void Bubble_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Bubble_sort(WorkArray);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Shaker_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Shaker_sort(WorkArray);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Comb_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Comb_sort(WorkArray);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Insertion_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Insertion_sort(WorkArray);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Selection_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Selection_sort(WorkArray);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            Sortir.TreeSort tree = new Sortir.TreeSort();
            stopWatch.Start();

            tree.InsertToTree(WorkArray);
            tree.inorderRec(tree.Root);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Heap_Click(object sender, EventArgs e)
        {
            Sortir.HeapSort heap = new Sortir.HeapSort();
            stopWatch.Start();

            heap.sort(WorkArray);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Smooth_Click(object sender, EventArgs e)
        {
            Sortir.SmoothSort smooth = new Sortir.SmoothSort();
            stopWatch.Start();

            smooth.sort(WorkArray);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            MainArray = Zuma.Zapolnitel(TextBoxZuma.Text);
            WorkArray = MainArray;
            RichTextBoxZuma.Text = "Длина массива = " + WorkArray.Length;
        }

        private void PrintIn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            foreach (int item in WorkArray)//Печатаем в файл
            {
                sw.Write(item);
                sw.Write("\t");
            }
            sw.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WorkArray = MainArray;
            RichTextBoxZuma.Text = "Массив перезаписан!";
        }
    }
}
