namespace Ну_как_там_с_деком
{
    partial class AutoLogic_Form
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
            this.TermCheck = new System.Windows.Forms.Button();
            this.WordCheck = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TermCheck
            // 
            this.TermCheck.Location = new System.Drawing.Point(181, 12);
            this.TermCheck.Name = "TermCheck";
            this.TermCheck.Size = new System.Drawing.Size(149, 29);
            this.TermCheck.TabIndex = 0;
            this.TermCheck.Text = "Проверка выражения";
            this.TermCheck.UseVisualStyleBackColor = true;
            this.TermCheck.Click += new System.EventHandler(this.TermCheck_Click);
            // 
            // WordCheck
            // 
            this.WordCheck.Location = new System.Drawing.Point(181, 72);
            this.WordCheck.Name = "WordCheck";
            this.WordCheck.Size = new System.Drawing.Size(149, 31);
            this.WordCheck.TabIndex = 1;
            this.WordCheck.Text = "Проверка слова";
            this.WordCheck.UseVisualStyleBackColor = true;
            this.WordCheck.Click += new System.EventHandler(this.WordCheck_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(181, 109);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(149, 20);
            this.textBox.TabIndex = 3;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(120, 139);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTerm.Location = new System.Drawing.Point(148, 16);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(27, 25);
            this.labelTerm.TabIndex = 5;
            this.labelTerm.Text = "X";
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(148, 109);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(27, 25);
            this.labelWord.TabIndex = 6;
            this.labelWord.Text = "X";
            // 
            // AutoLogic_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 163);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.WordCheck);
            this.Controls.Add(this.TermCheck);
            this.Name = "AutoLogic_Form";
            this.Text = "AutoLogic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TermCheck;
        private System.Windows.Forms.Button WordCheck;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelWord;
    }
}