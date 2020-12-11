namespace Ну_как_там_с_деком
{
    partial class Sortir_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sortir_Form));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.TextBoxZuma = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.RichTextBoxZuma = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxTime = new System.Windows.Forms.RichTextBox();
            this.PrintIn = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.zMain = new ZedGraph.ZedGraphControl();
            this.graphCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Пузырьком";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bubble_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Шейкер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Shaker_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Расческой";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Comb_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(370, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Вставкой";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Insertion_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Выбором";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Selection_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(415, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Деревом";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Tree_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(568, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Пирамидальная";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Heap_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(496, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Плавная";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Smooth_Click);
            // 
            // TextBoxZuma
            // 
            this.TextBoxZuma.Location = new System.Drawing.Point(230, 407);
            this.TextBoxZuma.Name = "TextBoxZuma";
            this.TextBoxZuma.Size = new System.Drawing.Size(194, 20);
            this.TextBoxZuma.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(208, 300);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 67);
            this.button9.TabIndex = 9;
            this.button9.Text = "Создать массив";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Create_Click);
            // 
            // RichTextBoxZuma
            // 
            this.RichTextBoxZuma.Enabled = false;
            this.RichTextBoxZuma.Location = new System.Drawing.Point(158, 433);
            this.RichTextBoxZuma.Name = "RichTextBoxZuma";
            this.RichTextBoxZuma.Size = new System.Drawing.Size(353, 35);
            this.RichTextBoxZuma.TabIndex = 10;
            this.RichTextBoxZuma.Text = "";
            // 
            // RichTextBoxTime
            // 
            this.RichTextBoxTime.Location = new System.Drawing.Point(1, 433);
            this.RichTextBoxTime.Name = "RichTextBoxTime";
            this.RichTextBoxTime.Size = new System.Drawing.Size(122, 48);
            this.RichTextBoxTime.TabIndex = 11;
            this.RichTextBoxTime.Text = "";
            // 
            // PrintIn
            // 
            this.PrintIn.Location = new System.Drawing.Point(536, 433);
            this.PrintIn.Name = "PrintIn";
            this.PrintIn.Size = new System.Drawing.Size(107, 48);
            this.PrintIn.TabIndex = 12;
            this.PrintIn.Text = "Запись в файл";
            this.PrintIn.UseVisualStyleBackColor = true;
            this.PrintIn.Click += new System.EventHandler(this.PrintIn_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(347, 300);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 65);
            this.button10.TabIndex = 13;
            this.button10.Text = "Перезапись массива";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // zMain
            // 
            this.zMain.Location = new System.Drawing.Point(640, -3);
            this.zMain.Name = "zMain";
            this.zMain.ScrollGrace = 0D;
            this.zMain.ScrollMaxX = 0D;
            this.zMain.ScrollMaxY = 0D;
            this.zMain.ScrollMaxY2 = 0D;
            this.zMain.ScrollMinX = 0D;
            this.zMain.ScrollMinY = 0D;
            this.zMain.ScrollMinY2 = 0D;
            this.zMain.Size = new System.Drawing.Size(602, 484);
            this.zMain.TabIndex = 14;
            this.zMain.UseExtendedPrintDialog = true;
            // 
            // graphCreate
            // 
            this.graphCreate.Location = new System.Drawing.Point(1015, 12);
            this.graphCreate.Name = "graphCreate";
            this.graphCreate.Size = new System.Drawing.Size(102, 23);
            this.graphCreate.TabIndex = 15;
            this.graphCreate.Text = "Построить";
            this.graphCreate.UseVisualStyleBackColor = true;
            this.graphCreate.Click += new System.EventHandler(this.graphCreate_Click);
            // 
            // Sortir_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1240, 480);
            this.Controls.Add(this.graphCreate);
            this.Controls.Add(this.zMain);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.PrintIn);
            this.Controls.Add(this.RichTextBoxTime);
            this.Controls.Add(this.RichTextBoxZuma);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.TextBoxZuma);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Sortir_Form";
            this.Text = "Sortir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox TextBoxZuma;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RichTextBox RichTextBoxZuma;
        private System.Windows.Forms.RichTextBox RichTextBoxTime;
        private System.Windows.Forms.Button PrintIn;
        private System.Windows.Forms.Button button10;
        private ZedGraph.ZedGraphControl zMain;
        private System.Windows.Forms.Button graphCreate;
    }
}