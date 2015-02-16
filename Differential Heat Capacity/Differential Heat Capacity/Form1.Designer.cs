﻿namespace Differential_Heat_Capacity
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
            this.GraphBtn = new System.Windows.Forms.Button();
            this.canvasePicBox = new System.Windows.Forms.PictureBox();
            this.CxRTxt = new System.Windows.Forms.RichTextBox();
            this.frequencyRTxt = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.canvasePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphBtn
            // 
            this.GraphBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphBtn.Location = new System.Drawing.Point(515, 308);
            this.GraphBtn.Name = "GraphBtn";
            this.GraphBtn.Size = new System.Drawing.Size(75, 23);
            this.GraphBtn.TabIndex = 0;
            this.GraphBtn.Text = "Graph";
            this.GraphBtn.UseVisualStyleBackColor = true;
            this.GraphBtn.Click += new System.EventHandler(this.GraphBtn_Click);
            // 
            // canvasePicBox
            // 
            this.canvasePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasePicBox.Location = new System.Drawing.Point(48, 12);
            this.canvasePicBox.Name = "canvasePicBox";
            this.canvasePicBox.Size = new System.Drawing.Size(403, 296);
            this.canvasePicBox.TabIndex = 1;
            this.canvasePicBox.TabStop = false;
            // 
            // CxRTxt
            // 
            this.CxRTxt.BackColor = System.Drawing.SystemColors.Control;
            this.CxRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CxRTxt.Location = new System.Drawing.Point(12, 12);
            this.CxRTxt.Name = "CxRTxt";
            this.CxRTxt.Size = new System.Drawing.Size(30, 22);
            this.CxRTxt.TabIndex = 2;
            this.CxRTxt.Text = "C(w)";
            // 
            // frequencyRTxt
            // 
            this.frequencyRTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyRTxt.BackColor = System.Drawing.SystemColors.Control;
            this.frequencyRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.frequencyRTxt.Location = new System.Drawing.Point(421, 314);
            this.frequencyRTxt.Name = "frequencyRTxt";
            this.frequencyRTxt.Size = new System.Drawing.Size(30, 22);
            this.frequencyRTxt.TabIndex = 3;
            this.frequencyRTxt.Text = "w";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(466, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(466, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(30, 22);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Tk";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(466, 66);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(124, 22);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "C(w)/scaler";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(466, 94);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 340);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.frequencyRTxt);
            this.Controls.Add(this.CxRTxt);
            this.Controls.Add(this.canvasePicBox);
            this.Controls.Add(this.GraphBtn);
            this.Name = "Form1";
            this.Text = "Heat Capacity";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GraphBtn;
        private System.Windows.Forms.PictureBox canvasePicBox;
        private System.Windows.Forms.RichTextBox CxRTxt;
        private System.Windows.Forms.RichTextBox frequencyRTxt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

