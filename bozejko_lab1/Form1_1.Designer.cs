namespace bozejko_lab1
{
    partial class Form1_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbModulo = new System.Windows.Forms.Label();
            this.lbCelling = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFractional = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbModulo);
            this.groupBox1.Controls.Add(this.lbCelling);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbFloor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbFractional);
            this.groupBox1.Location = new System.Drawing.Point(204, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(185, 158);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "floor (x)";
            // 
            // lbModulo
            // 
            this.lbModulo.AutoSize = true;
            this.lbModulo.Location = new System.Drawing.Point(123, 123);
            this.lbModulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModulo.Name = "lbModulo";
            this.lbModulo.Size = new System.Drawing.Size(10, 13);
            this.lbModulo.TabIndex = 12;
            this.lbModulo.Text = "-";
            // 
            // lbCelling
            // 
            this.lbCelling.AutoSize = true;
            this.lbCelling.Location = new System.Drawing.Point(123, 29);
            this.lbCelling.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelling.Name = "lbCelling";
            this.lbCelling.Size = new System.Drawing.Size(10, 13);
            this.lbCelling.TabIndex = 9;
            this.lbCelling.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "x mod y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "celling (x)";
            // 
            // lbFloor
            // 
            this.lbFloor.AutoSize = true;
            this.lbFloor.Location = new System.Drawing.Point(123, 58);
            this.lbFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(10, 13);
            this.lbFloor.TabIndex = 10;
            this.lbFloor.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "fractional part x";
            // 
            // lbFractional
            // 
            this.lbFractional.AutoSize = true;
            this.lbFractional.Location = new System.Drawing.Point(123, 90);
            this.lbFractional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFractional.Name = "lbFractional";
            this.lbFractional.Size = new System.Drawing.Size(10, 13);
            this.lbFractional.TabIndex = 11;
            this.lbFractional.Text = "-";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(48, 69);
            this.tbY.Margin = new System.Windows.Forms.Padding(2);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(68, 20);
            this.tbY.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "y (int)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "x";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(38, 113);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(78, 22);
            this.btCalculate.TabIndex = 15;
            this.btCalculate.Text = "Oblicz";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(48, 26);
            this.tbX.Margin = new System.Windows.Forms.Padding(2);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(68, 20);
            this.tbX.TabIndex = 14;
            // 
            // Form1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbX);
            this.Name = "Form1_1";
            this.Text = "Zadanie 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbModulo;
        private System.Windows.Forms.Label lbCelling;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFractional;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.TextBox tbX;

    }
}