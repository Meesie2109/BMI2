namespace BMI_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnberekenen = new System.Windows.Forms.Button();
            this.txtlengte = new System.Windows.Forms.TextBox();
            this.txtgewicht = new System.Windows.Forms.TextBox();
            this.txtleeftijd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.lbladvies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnberekenen
            // 
            this.btnberekenen.Location = new System.Drawing.Point(335, 234);
            this.btnberekenen.Name = "btnberekenen";
            this.btnberekenen.Size = new System.Drawing.Size(132, 30);
            this.btnberekenen.TabIndex = 2;
            this.btnberekenen.Text = "BMI Berekenen";
            this.btnberekenen.UseVisualStyleBackColor = true;
            this.btnberekenen.Click += new System.EventHandler(this.btnberekenen_Click);
            // 
            // txtlengte
            // 
            this.txtlengte.Location = new System.Drawing.Point(346, 138);
            this.txtlengte.Name = "txtlengte";
            this.txtlengte.Size = new System.Drawing.Size(100, 26);
            this.txtlengte.TabIndex = 3;
            // 
            // txtgewicht
            // 
            this.txtgewicht.Location = new System.Drawing.Point(346, 170);
            this.txtgewicht.Name = "txtgewicht";
            this.txtgewicht.Size = new System.Drawing.Size(100, 26);
            this.txtgewicht.TabIndex = 4;
            // 
            // txtleeftijd
            // 
            this.txtleeftijd.Location = new System.Drawing.Point(346, 202);
            this.txtleeftijd.Name = "txtleeftijd";
            this.txtleeftijd.Size = new System.Drawing.Size(100, 26);
            this.txtleeftijd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lengte in cm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "gewicht in kg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "leeftijd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "BMI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Advies";
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Location = new System.Drawing.Point(346, 290);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(51, 20);
            this.lblbmi.TabIndex = 11;
            this.lblbmi.Text = "label7";
            // 
            // lbladvies
            // 
            this.lbladvies.AutoSize = true;
            this.lbladvies.Location = new System.Drawing.Point(346, 311);
            this.lbladvies.Name = "lbladvies";
            this.lbladvies.Size = new System.Drawing.Size(51, 20);
            this.lbladvies.TabIndex = 12;
            this.lbladvies.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbladvies);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtleeftijd);
            this.Controls.Add(this.txtgewicht);
            this.Controls.Add(this.txtlengte);
            this.Controls.Add(this.btnberekenen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnberekenen;
        private System.Windows.Forms.TextBox txtlengte;
        private System.Windows.Forms.TextBox txtgewicht;
        private System.Windows.Forms.TextBox txtleeftijd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.Label lbladvies;
    }
}

