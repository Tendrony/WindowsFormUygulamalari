﻿namespace FormdaRenkDegistirme
{
    partial class FormMain
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
            this.btnBackcolorChange = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBackcolorChange
            // 
            this.btnBackcolorChange.Location = new System.Drawing.Point(12, 12);
            this.btnBackcolorChange.Name = "btnBackcolorChange";
            this.btnBackcolorChange.Size = new System.Drawing.Size(184, 64);
            this.btnBackcolorChange.TabIndex = 0;
            this.btnBackcolorChange.Text = "Arka Plan Rengini Değiştir";
            this.btnBackcolorChange.UseVisualStyleBackColor = true;
            this.btnBackcolorChange.Click += new System.EventHandler(this.btnBackcolorChange_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackcolorChange);
            this.Name = "FormMain";
            this.Text = "Renk Değiştirme";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackcolorChange;
        private System.Windows.Forms.Timer timer1;
    }
}

