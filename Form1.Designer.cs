namespace Может_через_список_попробовать
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add_end = new System.Windows.Forms.Button();
            this.Delete_end = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.TextBoxIn = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Multiplex = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear_mag = new System.Windows.Forms.Button();
            this.Add_start = new System.Windows.Forms.Button();
            this.Delete_start = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_end
            // 
            this.Add_end.Location = new System.Drawing.Point(393, 35);
            this.Add_end.Name = "Add_end";
            this.Add_end.Size = new System.Drawing.Size(100, 40);
            this.Add_end.TabIndex = 0;
            this.Add_end.Text = "Добавить в конец";
            this.Add_end.UseVisualStyleBackColor = true;
            this.Add_end.Click += new System.EventHandler(this.Add_end_Click);
            // 
            // Delete_end
            // 
            this.Delete_end.Location = new System.Drawing.Point(393, 71);
            this.Delete_end.Name = "Delete_end";
            this.Delete_end.Size = new System.Drawing.Size(100, 40);
            this.Delete_end.TabIndex = 1;
            this.Delete_end.Text = "Удаление из конца";
            this.Delete_end.UseVisualStyleBackColor = true;
            this.Delete_end.Click += new System.EventHandler(this.Delete_end_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(393, 108);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(100, 40);
            this.End.TabIndex = 2;
            this.End.Text = "Конец дека";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // TextBoxIn
            // 
            this.TextBoxIn.Location = new System.Drawing.Point(126, 45);
            this.TextBoxIn.Name = "TextBoxIn";
            this.TextBoxIn.Size = new System.Drawing.Size(240, 20);
            this.TextBoxIn.TabIndex = 3;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(154, 80);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 40);
            this.Max.TabIndex = 4;
            this.Max.Text = "Максимальный элемент";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(248, 80);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(100, 40);
            this.Min.TabIndex = 5;
            this.Min.Text = "Минимальный элемент";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(154, 126);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 40);
            this.Count.TabIndex = 6;
            this.Count.Text = "Количество элементов";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(154, 172);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 40);
            this.Sum.TabIndex = 7;
            this.Sum.Text = "Сумма";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Multiplex
            // 
            this.Multiplex.Location = new System.Drawing.Point(248, 172);
            this.Multiplex.Name = "Multiplex";
            this.Multiplex.Size = new System.Drawing.Size(100, 40);
            this.Multiplex.TabIndex = 8;
            this.Multiplex.Text = "Произведение";
            this.Multiplex.UseVisualStyleBackColor = true;
            this.Multiplex.Click += new System.EventHandler(this.Multiplex_Click);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(203, 218);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(100, 40);
            this.Reverse.TabIndex = 9;
            this.Reverse.Text = "Инверсия";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(0, 295);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(518, 158);
            this.RichTextBox.TabIndex = 10;
            this.RichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(204, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ввод дека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Журнал";
            // 
            // Clear_mag
            // 
            this.Clear_mag.Location = new System.Drawing.Point(368, 275);
            this.Clear_mag.Name = "Clear_mag";
            this.Clear_mag.Size = new System.Drawing.Size(150, 20);
            this.Clear_mag.TabIndex = 13;
            this.Clear_mag.Text = "Очистка журнала";
            this.Clear_mag.UseVisualStyleBackColor = true;
            this.Clear_mag.Click += new System.EventHandler(this.Clear_mag_Click);
            // 
            // Add_start
            // 
            this.Add_start.Location = new System.Drawing.Point(12, 35);
            this.Add_start.Name = "Add_start";
            this.Add_start.Size = new System.Drawing.Size(100, 40);
            this.Add_start.TabIndex = 14;
            this.Add_start.Text = "Добавить в начало";
            this.Add_start.UseVisualStyleBackColor = true;
            this.Add_start.Click += new System.EventHandler(this.Add_start_Click);
            // 
            // Delete_start
            // 
            this.Delete_start.Location = new System.Drawing.Point(12, 71);
            this.Delete_start.Name = "Delete_start";
            this.Delete_start.Size = new System.Drawing.Size(100, 40);
            this.Delete_start.TabIndex = 15;
            this.Delete_start.Text = "Удалить из начала";
            this.Delete_start.UseVisualStyleBackColor = true;
            this.Delete_start.Click += new System.EventHandler(this.Delete_start_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 108);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 40);
            this.Start.TabIndex = 16;
            this.Start.Text = "Начало дека";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(248, 126);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(100, 40);
            this.All.TabIndex = 17;
            this.All.Text = "Элементы дека";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(515, 449);
            this.Controls.Add(this.All);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Delete_start);
            this.Controls.Add(this.Add_start);
            this.Controls.Add(this.Clear_mag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Multiplex);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.TextBoxIn);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Delete_end);
            this.Controls.Add(this.Add_end);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_end;
        private System.Windows.Forms.Button Delete_end;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.TextBox TextBoxIn;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Multiplex;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_mag;
        private System.Windows.Forms.Button Add_start;
        private System.Windows.Forms.Button Delete_start;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button All;
    }
}

