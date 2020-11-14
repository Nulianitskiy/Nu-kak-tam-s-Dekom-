using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        int[] MainArrai;

        string writePath = @"D:\FastSpace\Out.txt";
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

            Zuma.Bubble_sort(MainArrai);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Shaker_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Shaker_sort(MainArrai);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Comb_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            //Zuma.Comb_sort(MainArrai);
            RichTextBoxZuma.Text = "Временные неполадки. Ждите правок в говнокоде!";
            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Insertion_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Insertion_sort(MainArrai);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Selection_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            Zuma.Selection_sort(MainArrai);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            Sortir.TreeNode tree = new Sortir.TreeNode(0);
            stopWatch.Start();

            tree.TreeSort(MainArrai);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Heap_Click(object sender, EventArgs e)
        {
            Sortir.HeapSort heap = new Sortir.HeapSort();
            stopWatch.Start();

            heap.sort(MainArrai);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Smooth_Click(object sender, EventArgs e)
        {
            Sortir.SmoothSort smooth = new Sortir.SmoothSort();
            stopWatch.Start();

            smooth.sort(MainArrai);

            stopWatch.Stop();
            Timer(stopWatch);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            MainArrai = Zuma.Zapolnitel(TextBoxZuma.Text);
            RichTextBoxZuma.Text = "Длина массива = " + MainArrai.Length;
        }

        private void PrintIn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            foreach (int item in MainArrai)//Печатаем в файл
            {
                sw.Write(item);
                sw.Write("\t");
            }
            sw.Close();
        }
    }
}
