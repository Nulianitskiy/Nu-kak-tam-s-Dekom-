using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using ZedGraph;

namespace Ну_как_там_с_деком
{
    public partial class Sortir_Form : Form
    {
        GraphPane paneMain;

        PointPairList Bubble_list = new PointPairList();
        PointPairList Shaker_list = new PointPairList();
        PointPairList Comb_list = new PointPairList();
        PointPairList Insertion_list = new PointPairList();
        PointPairList Selection_list = new PointPairList();
        PointPairList Tree_list = new PointPairList();
        PointPairList Heap_list = new PointPairList();
        PointPairList Smooth_list = new PointPairList();
        public Sortir_Form()
        {
            InitializeComponent();
            paneMain = zMain.GraphPane;
            paneMain.XAxis.Title.Text = "Количество эллементов";
            paneMain.YAxis.Title.Text = "Время в секундах";
            paneMain.Title.Text = "Рассчет эффективности";
        }
        Sortir Zuma = new Sortir();

        int[] MainArray;
        int[] WorkArray;

        string writePath = @"Out.txt";


        private void Bubble_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Zuma.Bubble_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Bubble_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Shaker_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Zuma.Shaker_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Shaker_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Comb_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Zuma.Comb_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Comb_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Insertion_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Zuma.Insertion_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Insertion_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Selection_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Zuma.Selection_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Selection_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            Sortir.TreeSort Tree = new Sortir.TreeSort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            WorkArray = Tree.sort(ref WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Tree_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Heap_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            Sortir.HeapSort heap = new Sortir.HeapSort();
            stopWatch.Start();

            heap.sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Heap_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Smooth_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            Sortir.SmoothSort smooth = new Sortir.SmoothSort();
            stopWatch.Start();

            smooth.sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Smooth_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            MainArray = Zuma.Zapolnitel(TextBoxZuma.Text);
            WorkArray = new int[MainArray.Length];
            MainArray.CopyTo(WorkArray, 0);
            RichTextBoxZuma.Text = "Длина массива = " + MainArray.Length;
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
            MainArray.CopyTo(WorkArray, 0);
            RichTextBoxZuma.Text = "Массив перезаписан!";
        }

        private void graphCreate_Click(object sender, EventArgs e)
        {
            zMain.GraphPane.CurveList.Clear();

            LineItem Bubble_Curve = paneMain.AddCurve("Bubble", Bubble_list, Color.Blue, SymbolType.None);
            LineItem Shaker_Curve = paneMain.AddCurve("Shaker", Shaker_list, Color.Brown, SymbolType.None);
            LineItem Comb_Curve = paneMain.AddCurve("Comb", Comb_list, Color.Red, SymbolType.None);
            LineItem Insertion_Curve = paneMain.AddCurve("Insertion", Insertion_list, Color.Green, SymbolType.None);
            LineItem Selection_Curve = paneMain.AddCurve("Selection", Selection_list, Color.Gray, SymbolType.None);
            LineItem Tree_Curve = paneMain.AddCurve("Tree", Tree_list, Color.Black, SymbolType.None);
            LineItem Heap_Curve = paneMain.AddCurve("Heap", Heap_list, Color.Yellow, SymbolType.None);
            LineItem Smooth_Curve = paneMain.AddCurve("Smooth", Smooth_list, Color.Magenta, SymbolType.None);

            zMain.AxisChange();
            zMain.Invalidate();
        }
    }
}
