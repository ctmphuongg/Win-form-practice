﻿namespace BTVN
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "A. 10";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm số cạnh của đa giác lồi biết rằng số đường chéo gấp 5 lần số cạnh của đa giác" +
    ".";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "B. 35";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "C. 13";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "D. 19";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Câu hỏi 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}