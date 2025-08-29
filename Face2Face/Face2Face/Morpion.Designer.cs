namespace Face2Face
{
    partial class Morpion
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
            this.lblCaseLeftUp = new System.Windows.Forms.Label();
            this.lblCaseMiddleUp = new System.Windows.Forms.Label();
            this.lblCaseRightUp = new System.Windows.Forms.Label();
            this.lblCaseRightCenter = new System.Windows.Forms.Label();
            this.lblCaseMiddleCenter = new System.Windows.Forms.Label();
            this.lblCaseLeftCenter = new System.Windows.Forms.Label();
            this.lblCaseRightDown = new System.Windows.Forms.Label();
            this.lblCaseMiddleDown = new System.Windows.Forms.Label();
            this.lblCaseLeftDown = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaseLeftUp
            // 
            this.lblCaseLeftUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseLeftUp.Location = new System.Drawing.Point(92, 73);
            this.lblCaseLeftUp.Name = "lblCaseLeftUp";
            this.lblCaseLeftUp.Size = new System.Drawing.Size(83, 69);
            this.lblCaseLeftUp.TabIndex = 0;
            this.lblCaseLeftUp.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseMiddleUp
            // 
            this.lblCaseMiddleUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseMiddleUp.Location = new System.Drawing.Point(181, 73);
            this.lblCaseMiddleUp.Name = "lblCaseMiddleUp";
            this.lblCaseMiddleUp.Size = new System.Drawing.Size(83, 69);
            this.lblCaseMiddleUp.TabIndex = 1;
            this.lblCaseMiddleUp.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseRightUp
            // 
            this.lblCaseRightUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseRightUp.Location = new System.Drawing.Point(270, 73);
            this.lblCaseRightUp.Name = "lblCaseRightUp";
            this.lblCaseRightUp.Size = new System.Drawing.Size(83, 69);
            this.lblCaseRightUp.TabIndex = 2;
            this.lblCaseRightUp.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseRightCenter
            // 
            this.lblCaseRightCenter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseRightCenter.Location = new System.Drawing.Point(270, 151);
            this.lblCaseRightCenter.Name = "lblCaseRightCenter";
            this.lblCaseRightCenter.Size = new System.Drawing.Size(83, 69);
            this.lblCaseRightCenter.TabIndex = 5;
            this.lblCaseRightCenter.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseMiddleCenter
            // 
            this.lblCaseMiddleCenter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseMiddleCenter.Location = new System.Drawing.Point(181, 151);
            this.lblCaseMiddleCenter.Name = "lblCaseMiddleCenter";
            this.lblCaseMiddleCenter.Size = new System.Drawing.Size(83, 69);
            this.lblCaseMiddleCenter.TabIndex = 4;
            this.lblCaseMiddleCenter.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseLeftCenter
            // 
            this.lblCaseLeftCenter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseLeftCenter.Location = new System.Drawing.Point(92, 151);
            this.lblCaseLeftCenter.Name = "lblCaseLeftCenter";
            this.lblCaseLeftCenter.Size = new System.Drawing.Size(83, 69);
            this.lblCaseLeftCenter.TabIndex = 3;
            this.lblCaseLeftCenter.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseRightDown
            // 
            this.lblCaseRightDown.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseRightDown.Location = new System.Drawing.Point(270, 229);
            this.lblCaseRightDown.Name = "lblCaseRightDown";
            this.lblCaseRightDown.Size = new System.Drawing.Size(83, 69);
            this.lblCaseRightDown.TabIndex = 8;
            this.lblCaseRightDown.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseMiddleDown
            // 
            this.lblCaseMiddleDown.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseMiddleDown.Location = new System.Drawing.Point(181, 229);
            this.lblCaseMiddleDown.Name = "lblCaseMiddleDown";
            this.lblCaseMiddleDown.Size = new System.Drawing.Size(83, 69);
            this.lblCaseMiddleDown.TabIndex = 7;
            this.lblCaseMiddleDown.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblCaseLeftDown
            // 
            this.lblCaseLeftDown.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCaseLeftDown.Location = new System.Drawing.Point(92, 229);
            this.lblCaseLeftDown.Name = "lblCaseLeftDown";
            this.lblCaseLeftDown.Size = new System.Drawing.Size(83, 69);
            this.lblCaseLeftDown.TabIndex = 6;
            this.lblCaseLeftDown.Click += new System.EventHandler(this.CaseClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(139, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 9;
            // 
            // Morpion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 348);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCaseRightDown);
            this.Controls.Add(this.lblCaseMiddleDown);
            this.Controls.Add(this.lblCaseLeftDown);
            this.Controls.Add(this.lblCaseRightCenter);
            this.Controls.Add(this.lblCaseMiddleCenter);
            this.Controls.Add(this.lblCaseLeftCenter);
            this.Controls.Add(this.lblCaseRightUp);
            this.Controls.Add(this.lblCaseMiddleUp);
            this.Controls.Add(this.lblCaseLeftUp);
            this.Name = "Morpion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morpion";
            this.Load += new System.EventHandler(this.Morpion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseLeftUp;
        private System.Windows.Forms.Label lblCaseMiddleUp;
        private System.Windows.Forms.Label lblCaseRightUp;
        private System.Windows.Forms.Label lblCaseRightCenter;
        private System.Windows.Forms.Label lblCaseMiddleCenter;
        private System.Windows.Forms.Label lblCaseLeftCenter;
        private System.Windows.Forms.Label lblCaseRightDown;
        private System.Windows.Forms.Label lblCaseMiddleDown;
        private System.Windows.Forms.Label lblCaseLeftDown;
        private System.Windows.Forms.Label lblError;
    }
}