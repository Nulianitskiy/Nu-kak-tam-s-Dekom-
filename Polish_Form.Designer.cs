namespace Ну_как_там_с_деком
{
    partial class Polish_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polish_Form));
            this.Calculation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPol = new System.Windows.Forms.TextBox();
            this.RichTextBoxPol = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculation
            // 
            this.Calculation.BackColor = System.Drawing.Color.Transparent;
            this.Calculation.Location = new System.Drawing.Point(12, 53);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(200, 50);
            this.Calculation.TabIndex = 0;
            this.Calculation.Text = "Вычислить";
            this.Calculation.UseVisualStyleBackColor = false;
            this.Calculation.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поле ввода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поле вывода";
            // 
            // TextBoxPol
            // 
            this.TextBoxPol.Location = new System.Drawing.Point(12, 27);
            this.TextBoxPol.Name = "TextBoxPol";
            this.TextBoxPol.Size = new System.Drawing.Size(200, 20);
            this.TextBoxPol.TabIndex = 3;
            // 
            // RichTextBoxPol
            // 
            this.RichTextBoxPol.Location = new System.Drawing.Point(12, 182);
            this.RichTextBoxPol.Name = "RichTextBoxPol";
            this.RichTextBoxPol.Size = new System.Drawing.Size(250, 44);
            this.RichTextBoxPol.TabIndex = 4;
            this.RichTextBoxPol.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Polish_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(274, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RichTextBoxPol);
            this.Controls.Add(this.TextBoxPol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculation);
            this.Name = "Polish_Form";
            this.Text = "Polish_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPol;
        private System.Windows.Forms.RichTextBox RichTextBoxPol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}