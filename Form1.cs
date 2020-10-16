using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ну_как_там_с_деком;

namespace Может_через_список_попробовать
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Deque Serega;
        int x = 0;
        private void Init_Click(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(TextBoxIn.Text, out number))
            {
                Serega = new Deque(Convert.ToInt32(TextBoxIn.Text));
                TextBoxIn.Text = "";
                label1.Text = "Ввод дека";
                Add_end.Enabled = true;
                Add_start.Enabled = true;
                Delete_end.Enabled = true;
                Delete_start.Enabled = true;
                End.Enabled = true;
                Start.Enabled = true;
                Min.Enabled = true;
                Max.Enabled = true;
                Sum.Enabled = true;
                Multiplex.Enabled = true;
                All.Enabled = true;
                Count.Enabled = true;
                Reverse.Enabled = true;
                Add_end.Visible = true;
                Add_start.Visible = true;
                Delete_end.Visible = true;
                Delete_start.Visible = true;
                End.Visible = true;
                Start.Visible = true;
                Min.Visible = true;
                Max.Visible = true;
                Sum.Visible = true;
                Multiplex.Visible = true;
                All.Visible = true;
                Count.Visible = true;
                Reverse.Visible = true;
                Init.Enabled = false;
                Init.Visible = false;
            }
            else RichTextBox.Text = "\nОшибка ввода!";
        }

        private void Add_end_Click(object sender, EventArgs e)//Добавление элемента в конец
        {
            int number;
            if (Int32.TryParse(TextBoxIn.Text, out number))
            {
                if (Serega.add_top(Convert.ToInt32(TextBoxIn.Text)))
                {
                    RichTextBox.Text += "\nВ дек добавлен элемент!";
                    TextBoxIn.Text = "";
                }
                else
                {
                    RichTextBox.Text += "\nОшибка переполнения данных!";
                    TextBoxIn.Text = "";
                }
            }
            else
            {
                RichTextBox.Text += "\nОшибка ввода данных!";
                TextBoxIn.Text = "";
            }
        }
        private void Add_start_Click(object sender, EventArgs e)//Добавление элемента в начало
        {
            int number;
            if (Int32.TryParse(TextBoxIn.Text, out number))
            {
                if (Serega.add_start(Convert.ToInt32(TextBoxIn.Text)))
                {
                    RichTextBox.Text += "\nВ дек добавлен элемент!";
                    TextBoxIn.Text = "";
                }
                else
                {
                    RichTextBox.Text += "\nОшибка переполнения данных!";
                    TextBoxIn.Text = "";
                } 
            }
            else
            {
                RichTextBox.Text += "\nОшибка ввода данных!";
                TextBoxIn.Text = "";
            }
        }

        private void Delete_end_Click(object sender, EventArgs e)//Удаление элемента из конца
        {
            if (Serega.delete_top())
            {
                RichTextBox.Text += "\nИз дека удален элемент!";
            }
            else
                RichTextBox.Text += "\nДек пуст!";
        }
        private void Delete_start_Click(object sender, EventArgs e)//Удаление элемента из начала
        {
            if (Serega.delete_start())
            {
                RichTextBox.Text += "\nИз дека удален элемент!";
            }
            else
                RichTextBox.Text += "\nДек пуст!";
        }

        private void End_Click(object sender, EventArgs e)//Конец дека
        {
            if (!Serega.CheckEmpty())
            {
                RichTextBox.Text += "\nНа конце дека: ";
                RichTextBox.Text += Serega.top();
            }
            else RichTextBox.Text += "\nДек пуст!";
        }
        private void Start_Click(object sender, EventArgs e)//Начало дека
        {
            if (!Serega.CheckEmpty())
            {
                RichTextBox.Text += "\nВ начале дека: ";
                RichTextBox.Text += Serega.start();
            }
            else RichTextBox.Text += "\nДек пуст!";
        }

        private void Max_Click(object sender, EventArgs e) //Максимум
        {
            string chose = "max";
            x = 0;
            RichTextBox.Text += "\nМаксимальный элемент дека = ";
            RichTextBox.Text += Serega.Operations(chose, x).ToString();
        }

        private void Min_Click(object sender, EventArgs e) //Минимум
        {
            string chose = "min";
            x = 0;
            RichTextBox.Text += "\nМинимальный элемент дека = ";
            RichTextBox.Text += Serega.Operations(chose, x).ToString();
        }

        private void Sum_Click(object sender, EventArgs e) //Сумма элементов
        {
            string chose = "sum";
            x = 0;
            RichTextBox.Text += "\nСумма элементов дека = ";
            RichTextBox.Text += Serega.Operations(chose, x).ToString();
        }

        private void Multiplex_Click(object sender, EventArgs e) //Произведение элементов
        {
            string chose = "mult";
            x = 0;
            RichTextBox.Text += "\nПроизведение элементов дека = ";
            RichTextBox.Text += Serega.Operations(chose, x).ToString();
        }

        private void Count_Click(object sender, EventArgs e) //Количество элементов
        {
            RichTextBox.Text += "\nКолличество элементов в деке = ";
            RichTextBox.Text += Serega.all().Count().ToString();
        }
        private void All_Click(object sender, EventArgs e) //Все элементы
        {
            int[] output = Serega.all();
            RichTextBox.Text += "\nЭлементы дека: ";
            foreach (int Item in output)
            {
                RichTextBox.Text += Item.ToString() + " ";
            }
        }

        private void Reverse_Click(object sender, EventArgs e) //Инвертирование дека
        {
            Serega.reverse();
            RichTextBox.Text += "\nДек инвертирован!";
        }

        private void Clear_mag_Click(object sender, EventArgs e) //Очистка журнала
        {
            RichTextBox.Text = "";
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox.SelectionStart = RichTextBox.Text.Length;
            RichTextBox.ScrollToCaret();
        }
    }
}
