﻿using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Ну_как_там_с_деком;

namespace Может_через_список_попробовать
{
    public partial class Deque_Form : Form
    {

        public Deque_Form()
        {
            InitializeComponent();
        }
        Deque Serega;

        private void Init_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                RichTextBox.Text = "\nОшибка ввода!";
            }
        }

        private void Add_end_Click(object sender, EventArgs e)//Добавление элемента в конец
        {
            int number;
            if (Int32.TryParse(TextBoxIn.Text, out number))
                try
                {
                    Serega.pushFront(Convert.ToInt32(TextBoxIn.Text));
                    RichTextBox.Text += "\nВ дек добавлен элемент!";
                    TextBoxIn.Text = "";
                }
                catch (IndexOutOfRangeException)
                {
                    RichTextBox.Text += "\nОшибка переполнения данных!";
                    TextBoxIn.Text = "";
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
                try
                {
                    Serega.pushBack(Convert.ToInt32(TextBoxIn.Text));
                    RichTextBox.Text += "\nВ дек добавлен элемент!";
                    TextBoxIn.Text = "";
                }
                catch (IndexOutOfRangeException)
                {
                    RichTextBox.Text += "\nОшибка переполнения данных!";
                    TextBoxIn.Text = "";
                }
            else
            {
                RichTextBox.Text += "\nОшибка ввода данных!";
                TextBoxIn.Text = "";
            }
        }

        private void Delete_end_Click(object sender, EventArgs e)//Удаление элемента из конца
        {
            try
            {
                Serega.popFront();
                RichTextBox.Text += "\nИз дека удален элемент!";
            }
            catch (IndexOutOfRangeException)
            {
                RichTextBox.Text += "\nКонец дека пуст!";
            }
        }

        private void Delete_start_Click(object sender, EventArgs e)//Удаление элемента из начала
        {
            try
            {
                Serega.popBack();
                RichTextBox.Text += "\nИз дека удален элемент!";
            }
            catch (IndexOutOfRangeException)
            {
                RichTextBox.Text += "\nНачало дека пусто!";
            }
        }

        private void End_Click(object sender, EventArgs e)//Конец дека
        {
            try
            {
                RichTextBox.Text += "\nНа конце дека: ";
                RichTextBox.Text += Serega.getFront();
            }
            catch (Exception)
            {
                RichTextBox.Text += "\nНевозможно!";
            }
        }

        private void Start_Click(object sender, EventArgs e)//Начало дека
        {
            try
            {
                RichTextBox.Text += "\nВ начале дека: ";
                RichTextBox.Text += Serega.getBack();
            }
            catch (Exception)
            {
                RichTextBox.Text += "\nНевозможно!";
            }
        }

        private void Max_Click(object sender, EventArgs e) //Максимум
        {
            RichTextBox.Text += "\nМаксимальный элемент дека = ";
            RichTextBox.Text += Serega.operations("max").ToString();
        }
        private void Min_Click(object sender, EventArgs e) //Минимум
        {
            RichTextBox.Text += "\nМинимальный элемент дека = ";
            RichTextBox.Text += Serega.operations("min").ToString();
        }
        private void Sum_Click(object sender, EventArgs e) //Сумма элементов
        {
            RichTextBox.Text += "\nСумма элементов дека = ";
            RichTextBox.Text += Serega.operations("sum").ToString();
        }
        private void Multiplex_Click(object sender, EventArgs e) //Произведение элементов
        {
            RichTextBox.Text += "\nПроизведение элементов дека = ";
            RichTextBox.Text += Serega.operations("mult").ToString();
        }

        private void Count_Click(object sender, EventArgs e) //Количество элементов
        {
            RichTextBox.Text += "\nКолличество элементов в деке = ";
            RichTextBox.Text += Serega.getAll().Count().ToString();
        }

        private void All_Click(object sender, EventArgs e) //Все элементы
        {
            int[] output = Serega.getAll();
            RichTextBox.Text += "\nЭлементы дека: ";
            foreach (int Item in output)
            {
                RichTextBox.Text += Item.ToString() + " ";
            }
        }

        private void Reverse_Click(object sender, EventArgs e) //Инвертирование дека
        {
            Serega.dequeReverse();
            RichTextBox.Text += "\nДек инвертирован!";
        }

        private void Clear_mag_Click(object sender, EventArgs e) //Очистка журнала
        {
            RichTextBox.Text = "";
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e) //Автоскролл вниз
        {
            RichTextBox.SelectionStart = RichTextBox.Text.Length;
            RichTextBox.ScrollToCaret();
        }
    }
}
