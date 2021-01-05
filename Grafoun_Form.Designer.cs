namespace Ну_как_там_с_деком
{
    partial class Grafoun_Form
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
            this.zMain = new ZedGraph.ZedGraphControl();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OXY = new System.Windows.Forms.Button();
            this.OYZ = new System.Windows.Forms.Button();
            this.OXZ = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zMain
            // 
            this.zMain.Location = new System.Drawing.Point(-4, -2);
            this.zMain.Name = "zMain";
            this.zMain.ScrollGrace = 0D;
            this.zMain.ScrollMaxX = 0D;
            this.zMain.ScrollMaxY = 0D;
            this.zMain.ScrollMaxY2 = 0D;
            this.zMain.ScrollMinX = 0D;
            this.zMain.ScrollMinY = 0D;
            this.zMain.ScrollMinY2 = 0D;
            this.zMain.Size = new System.Drawing.Size(659, 453);
            this.zMain.TabIndex = 0;
            this.zMain.UseExtendedPrintDialog = true;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(664, 77);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(35, 20);
            this.tbA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // OXY
            // 
            this.OXY.Location = new System.Drawing.Point(661, 163);
            this.OXY.Name = "OXY";
            this.OXY.Size = new System.Drawing.Size(75, 23);
            this.OXY.TabIndex = 4;
            this.OXY.Text = "OXY";
            this.OXY.UseVisualStyleBackColor = true;
            this.OXY.Click += new System.EventHandler(this.OXY_Click);
            // 
            // OYZ
            // 
            this.OYZ.Location = new System.Drawing.Point(661, 193);
            this.OYZ.Name = "OYZ";
            this.OYZ.Size = new System.Drawing.Size(75, 23);
            this.OYZ.TabIndex = 5;
            this.OYZ.Text = "OYZ";
            this.OYZ.UseVisualStyleBackColor = true;
            // 
            // OXZ
            // 
            this.OXZ.Location = new System.Drawing.Point(664, 223);
            this.OXZ.Name = "OXZ";
            this.OXZ.Size = new System.Drawing.Size(75, 23);
            this.OXZ.TabIndex = 6;
            this.OXZ.Text = "OXZ";
            this.OXZ.UseVisualStyleBackColor = true;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(723, 77);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(35, 20);
            this.tbB.TabIndex = 7;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(784, 77);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(32, 20);
            this.tbC.TabIndex = 8;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(836, 48);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(32, 20);
            this.tbAnswer.TabIndex = 9;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(673, 131);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 20);
            this.tbFrom.TabIndex = 10;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(784, 131);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(100, 20);
            this.tbTo.TabIndex = 11;
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(784, 163);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(100, 20);
            this.tbStep.TabIndex = 12;
            // 
            // Grafoun_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.OXZ);
            this.Controls.Add(this.OYZ);
            this.Controls.Add(this.OXY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.zMain);
            this.Name = "Grafoun_Form";
            this.Text = "Grafoun_Form";
            this.Load += new System.EventHandler(this.Grafoun_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zMain;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OXY;
        private System.Windows.Forms.Button OYZ;
        private System.Windows.Forms.Button OXZ;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbStep;
    }
}