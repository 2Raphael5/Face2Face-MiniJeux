namespace Face2Face
{
    partial class Bataille
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
            this.pbxJ2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxJ1 = new System.Windows.Forms.PictureBox();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJ1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxJ2
            // 
            this.pbxJ2.Image = global::Face2Face.Properties.Resources.b1fv;
            this.pbxJ2.Location = new System.Drawing.Point(420, 132);
            this.pbxJ2.Name = "pbxJ2";
            this.pbxJ2.Size = new System.Drawing.Size(130, 166);
            this.pbxJ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJ2.TabIndex = 0;
            this.pbxJ2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appuyé sur Espace pour commencer";
            // 
            // pbxJ1
            // 
            this.pbxJ1.Image = global::Face2Face.Properties.Resources.b1fv;
            this.pbxJ1.Location = new System.Drawing.Point(82, 132);
            this.pbxJ1.Name = "pbxJ1";
            this.pbxJ1.Size = new System.Drawing.Size(130, 166);
            this.pbxJ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJ1.TabIndex = 3;
            this.pbxJ1.TabStop = false;
            // 
            // lblScore2
            // 
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(420, 93);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(130, 34);
            this.lblScore2.TabIndex = 4;
            this.lblScore2.Text = "Score: 0";
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore1
            // 
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(82, 93);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(130, 34);
            this.lblScore1.TabIndex = 5;
            this.lblScore1.Text = "Score: 0";
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bataille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.pbxJ1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxJ2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bataille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bataille";
            this.Load += new System.EventHandler(this.Bataille_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Bataille_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJ1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxJ2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxJ1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
    }
}