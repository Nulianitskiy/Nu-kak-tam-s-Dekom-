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
            this.zOXY = new ZedGraph.ZedGraphControl();
            this.Creation = new System.Windows.Forms.Button();
            this.zOYZ = new ZedGraph.ZedGraphControl();
            this.zOXZ = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zOXY
            // 
            this.zOXY.Location = new System.Drawing.Point(0, 0);
            this.zOXY.Name = "zOXY";
            this.zOXY.ScrollGrace = 0D;
            this.zOXY.ScrollMaxX = 0D;
            this.zOXY.ScrollMaxY = 0D;
            this.zOXY.ScrollMaxY2 = 0D;
            this.zOXY.ScrollMinX = 0D;
            this.zOXY.ScrollMinY = 0D;
            this.zOXY.ScrollMinY2 = 0D;
            this.zOXY.Size = new System.Drawing.Size(500, 300);
            this.zOXY.TabIndex = 0;
            this.zOXY.UseExtendedPrintDialog = true;
            // 
            // Creation
            // 
            this.Creation.Location = new System.Drawing.Point(336, 306);
            this.Creation.Name = "Creation";
            this.Creation.Size = new System.Drawing.Size(119, 62);
            this.Creation.TabIndex = 1;
            this.Creation.Text = "Построить";
            this.Creation.UseVisualStyleBackColor = true;
            this.Creation.Click += new System.EventHandler(this.Creation_Click);
            // 
            // zOYZ
            // 
            this.zOYZ.Location = new System.Drawing.Point(500, 0);
            this.zOYZ.Name = "zOYZ";
            this.zOYZ.ScrollGrace = 0D;
            this.zOYZ.ScrollMaxX = 0D;
            this.zOYZ.ScrollMaxY = 0D;
            this.zOYZ.ScrollMaxY2 = 0D;
            this.zOYZ.ScrollMinX = 0D;
            this.zOYZ.ScrollMinY = 0D;
            this.zOYZ.ScrollMinY2 = 0D;
            this.zOYZ.Size = new System.Drawing.Size(500, 300);
            this.zOYZ.TabIndex = 2;
            this.zOYZ.UseExtendedPrintDialog = true;
            // 
            // zOXZ
            // 
            this.zOXZ.Location = new System.Drawing.Point(500, 300);
            this.zOXZ.Name = "zOXZ";
            this.zOXZ.ScrollGrace = 0D;
            this.zOXZ.ScrollMaxX = 0D;
            this.zOXZ.ScrollMaxY = 0D;
            this.zOXZ.ScrollMaxY2 = 0D;
            this.zOXZ.ScrollMinX = 0D;
            this.zOXZ.ScrollMinY = 0D;
            this.zOXZ.ScrollMinY2 = 0D;
            this.zOXZ.Size = new System.Drawing.Size(500, 300);
            this.zOXZ.TabIndex = 3;
            this.zOXZ.UseExtendedPrintDialog = true;
            // 
            // Grafouni_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 596);
            this.Controls.Add(this.zOXZ);
            this.Controls.Add(this.zOYZ);
            this.Controls.Add(this.Creation);
            this.Controls.Add(this.zOXY);
            this.Name = "Grafouni_Form";
            this.Text = "Grafouni_Form";
            this.Load += new System.EventHandler(this.Grafouni_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zOXY;
        private System.Windows.Forms.Button Creation;
        private ZedGraph.ZedGraphControl zOYZ;
        private ZedGraph.ZedGraphControl zOXZ;
    }
}