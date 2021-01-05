namespace Ну_как_там_с_деком
{
    partial class Choser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choser));
            this.Open_Polish = new System.Windows.Forms.Button();
            this.Open_Deque = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Zuma = new System.Windows.Forms.Button();
            this.Grafouni = new System.Windows.Forms.Button();
            this.AutoLogic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open_Polish
            // 
            this.Open_Polish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open_Polish.BackgroundImage")));
            this.Open_Polish.Location = new System.Drawing.Point(197, 0);
            this.Open_Polish.Name = "Open_Polish";
            this.Open_Polish.Size = new System.Drawing.Size(200, 200);
            this.Open_Polish.TabIndex = 0;
            this.Open_Polish.UseVisualStyleBackColor = true;
            this.Open_Polish.Click += new System.EventHandler(this.Open_Polish_Click);
            // 
            // Open_Deque
            // 
            this.Open_Deque.Image = ((System.Drawing.Image)(resources.GetObject("Open_Deque.Image")));
            this.Open_Deque.Location = new System.Drawing.Point(-3, 0);
            this.Open_Deque.Name = "Open_Deque";
            this.Open_Deque.Size = new System.Drawing.Size(200, 200);
            this.Open_Deque.TabIndex = 1;
            this.Open_Deque.UseVisualStyleBackColor = true;
            this.Open_Deque.Click += new System.EventHandler(this.Open_Deque_Click);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(-3, 194);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(989, 100);
            this.Close.TabIndex = 2;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Zuma
            // 
            this.Zuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Zuma.BackgroundImage")));
            this.Zuma.Location = new System.Drawing.Point(394, 0);
            this.Zuma.Name = "Zuma";
            this.Zuma.Size = new System.Drawing.Size(200, 200);
            this.Zuma.TabIndex = 3;
            this.Zuma.UseVisualStyleBackColor = true;
            this.Zuma.Click += new System.EventHandler(this.Zuma_Click);
            // 
            // Grafouni
            // 
            this.Grafouni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Grafouni.BackgroundImage")));
            this.Grafouni.Location = new System.Drawing.Point(591, 0);
            this.Grafouni.Name = "Grafouni";
            this.Grafouni.Size = new System.Drawing.Size(200, 200);
            this.Grafouni.TabIndex = 4;
            this.Grafouni.UseVisualStyleBackColor = true;
            this.Grafouni.Click += new System.EventHandler(this.Grafouni_Click);
            // 
            // AutoLogic
            // 
            this.AutoLogic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AutoLogic.BackgroundImage")));
            this.AutoLogic.Location = new System.Drawing.Point(786, 0);
            this.AutoLogic.Name = "AutoLogic";
            this.AutoLogic.Size = new System.Drawing.Size(200, 200);
            this.AutoLogic.TabIndex = 5;
            this.AutoLogic.UseVisualStyleBackColor = true;
            this.AutoLogic.Click += new System.EventHandler(this.AutoLogic_Click);
            // 
            // Choser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 290);
            this.Controls.Add(this.AutoLogic);
            this.Controls.Add(this.Grafouni);
            this.Controls.Add(this.Zuma);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Open_Deque);
            this.Controls.Add(this.Open_Polish);
            this.Name = "Choser";
            this.Text = "Choser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_Polish;
        private System.Windows.Forms.Button Open_Deque;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Zuma;
        private System.Windows.Forms.Button Grafouni;
        private System.Windows.Forms.Button AutoLogic;
    }
}