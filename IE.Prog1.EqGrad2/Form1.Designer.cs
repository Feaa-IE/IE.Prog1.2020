
namespace IE.Prog1.EqGrad2
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
            this.uxTextBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxTextBoxB = new System.Windows.Forms.TextBox();
            this.uxTextBoxC = new System.Windows.Forms.TextBox();
            this.uxButtonRezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // uxTextBoxA
            // 
            this.uxTextBoxA.Location = new System.Drawing.Point(76, 67);
            this.uxTextBoxA.Name = "uxTextBoxA";
            this.uxTextBoxA.Size = new System.Drawing.Size(100, 20);
            this.uxTextBoxA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "c";
            // 
            // uxTextBoxB
            // 
            this.uxTextBoxB.Location = new System.Drawing.Point(76, 122);
            this.uxTextBoxB.Name = "uxTextBoxB";
            this.uxTextBoxB.Size = new System.Drawing.Size(100, 20);
            this.uxTextBoxB.TabIndex = 4;
            // 
            // uxTextBoxC
            // 
            this.uxTextBoxC.Location = new System.Drawing.Point(79, 180);
            this.uxTextBoxC.Name = "uxTextBoxC";
            this.uxTextBoxC.Size = new System.Drawing.Size(100, 20);
            this.uxTextBoxC.TabIndex = 5;
            // 
            // uxButtonRezultat
            // 
            this.uxButtonRezultat.Location = new System.Drawing.Point(79, 245);
            this.uxButtonRezultat.Name = "uxButtonRezultat";
            this.uxButtonRezultat.Size = new System.Drawing.Size(75, 23);
            this.uxButtonRezultat.TabIndex = 6;
            this.uxButtonRezultat.Text = "Rezultat";
            this.uxButtonRezultat.UseVisualStyleBackColor = true;
            this.uxButtonRezultat.Click += new System.EventHandler(this.uxButtonRezultat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxButtonRezultat);
            this.Controls.Add(this.uxTextBoxC);
            this.Controls.Add(this.uxTextBoxB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxTextBoxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ecuatia grad 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxTextBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxTextBoxB;
        private System.Windows.Forms.TextBox uxTextBoxC;
        private System.Windows.Forms.Button uxButtonRezultat;
    }
}

