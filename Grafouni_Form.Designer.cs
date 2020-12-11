namespace Ну_как_там_с_деком
{
    partial class Grafouni_Form
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
            this.Creation = new System.Windows.Forms.Button();
            this.OXY = new System.Windows.Forms.Button();
            this.OYZ = new System.Windows.Forms.Button();
            this.OXZ = new System.Windows.Forms.Button();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zMain
            // 
            this.zMain.Location = new System.Drawing.Point(0, 0);
            this.zMain.Name = "zMain";
            this.zMain.ScrollGrace = 0D;
            this.zMain.ScrollMaxX = 0D;
            this.zMain.ScrollMaxY = 0D;
            this.zMain.ScrollMaxY2 = 0D;
            this.zMain.ScrollMinX = 0D;
            this.zMain.ScrollMinY = 0D;
            this.zMain.ScrollMinY2 = 0D;
            this.zMain.Size = new System.Drawing.Size(1000, 600);
            this.zMain.TabIndex = 0;
            this.zMain.UseExtendedPrintDialog = true;
            // 
            // Creation
            // 
            this.Creation.Location = new System.Drawing.Point(1016, 529);
            this.Creation.Name = "Creation";
            this.Creation.Size = new System.Drawing.Size(180, 55);
            this.Creation.TabIndex = 1;
            this.Creation.Text = "Построить";
            this.Creation.UseVisualStyleBackColor = true;
            this.Creation.Click += new System.EventHandler(this.Creation_Click);
            // 
            // OXY
            // 
            this.OXY.Location = new System.Drawing.Point(1016, 168);
            this.OXY.Name = "OXY";
            this.OXY.Size = new System.Drawing.Size(180, 38);
            this.OXY.TabIndex = 2;
            this.OXY.Text = "OXY";
            this.OXY.UseVisualStyleBackColor = true;
            this.OXY.Click += new System.EventHandler(this.OXY_Click);
            // 
            // OYZ
            // 
            this.OYZ.Location = new System.Drawing.Point(1016, 198);
            this.OYZ.Name = "OYZ";
            this.OYZ.Size = new System.Drawing.Size(180, 38);
            this.OYZ.TabIndex = 3;
            this.OYZ.Text = "OYZ";
            this.OYZ.UseVisualStyleBackColor = true;
            this.OYZ.Click += new System.EventHandler(this.OYZ_Click);
            // 
            // OXZ
            // 
            this.OXZ.Location = new System.Drawing.Point(1016, 227);
            this.OXZ.Name = "OXZ";
            this.OXZ.Size = new System.Drawing.Size(180, 38);
            this.OXZ.TabIndex = 4;
            this.OXZ.Text = "OXZ";
            this.OXZ.UseVisualStyleBackColor = true;
            this.OXZ.Click += new System.EventHandler(this.OXZ_Click);
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(1016, 442);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(80, 20);
            this.tbLeft.TabIndex = 5;
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(1113, 442);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(83, 20);
            this.tbRight.TabIndex = 6;
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(1055, 468);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(100, 20);
            this.tbStep.TabIndex = 7;
            // 
            // Grafouni_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 596);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.OXZ);
            this.Controls.Add(this.OYZ);
            this.Controls.Add(this.OXY);
            this.Controls.Add(this.Creation);
            this.Controls.Add(this.zMain);
            this.Name = "Grafouni_Form";
            this.Text = "Grafouni_Form";
            this.Load += new System.EventHandler(this.Grafouni_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zMain;
        private System.Windows.Forms.Button Creation;
        private System.Windows.Forms.Button OXY;
        private System.Windows.Forms.Button OYZ;
        private System.Windows.Forms.Button OXZ;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.TextBox tbStep;
    }
}