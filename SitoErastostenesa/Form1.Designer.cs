namespace SitoErastostenesa
{
    partial class Form1
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
            this.tbZakres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrzesiej = new System.Windows.Forms.Button();
            this.lblTablica = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbZakres
            // 
            this.tbZakres.Location = new System.Drawing.Point(90, 15);
            this.tbZakres.Name = "tbZakres";
            this.tbZakres.Size = new System.Drawing.Size(143, 20);
            this.tbZakres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj zakres:";
            // 
            // btnPrzesiej
            // 
            this.btnPrzesiej.Location = new System.Drawing.Point(12, 44);
            this.btnPrzesiej.Name = "btnPrzesiej";
            this.btnPrzesiej.Size = new System.Drawing.Size(221, 23);
            this.btnPrzesiej.TabIndex = 2;
            this.btnPrzesiej.Text = "Przesiej";
            this.btnPrzesiej.UseVisualStyleBackColor = true;
            this.btnPrzesiej.Click += new System.EventHandler(this.btnPrzesiej_Click);
            // 
            // lblTablica
            // 
            this.lblTablica.AutoSize = true;
            this.lblTablica.Location = new System.Drawing.Point(13, 70);
            this.lblTablica.MaximumSize = new System.Drawing.Size(220, 0);
            this.lblTablica.MinimumSize = new System.Drawing.Size(220, 0);
            this.lblTablica.Name = "lblTablica";
            this.lblTablica.Size = new System.Drawing.Size(220, 13);
            this.lblTablica.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(239, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 423);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTablica);
            this.Controls.Add(this.btnPrzesiej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbZakres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sito Erastostenesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbZakres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrzesiej;
        private System.Windows.Forms.Label lblTablica;
        private System.Windows.Forms.Panel panel1;
    }
}

