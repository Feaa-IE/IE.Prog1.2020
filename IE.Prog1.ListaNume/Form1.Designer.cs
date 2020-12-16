
namespace IE.Prog1.ListaNume
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxTextBoxNume = new System.Windows.Forms.TextBox();
            this.uxButtonAdauga = new System.Windows.Forms.Button();
            this.uxListBoxNume = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxTextBoxCauta = new System.Windows.Forms.TextBox();
            this.uxButtonMuta = new System.Windows.Forms.Button();
            this.uxListBoxMutate = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxListBoxNume, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uxListBoxMutate, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uxTextBoxNume);
            this.flowLayoutPanel1.Controls.Add(this.uxButtonAdauga);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 94);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // uxTextBoxNume
            // 
            this.uxTextBoxNume.Location = new System.Drawing.Point(3, 3);
            this.uxTextBoxNume.Name = "uxTextBoxNume";
            this.uxTextBoxNume.Size = new System.Drawing.Size(326, 20);
            this.uxTextBoxNume.TabIndex = 0;
            this.uxTextBoxNume.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxTextBoxNume_KeyUp);
            // 
            // uxButtonAdauga
            // 
            this.uxButtonAdauga.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonAdauga.Location = new System.Drawing.Point(335, 3);
            this.uxButtonAdauga.Name = "uxButtonAdauga";
            this.uxButtonAdauga.Size = new System.Drawing.Size(75, 23);
            this.uxButtonAdauga.TabIndex = 1;
            this.uxButtonAdauga.Text = "Adauga";
            this.uxButtonAdauga.UseVisualStyleBackColor = true;
            this.uxButtonAdauga.Click += new System.EventHandler(this.uxButtonAdauga_Click);
            // 
            // uxListBoxNume
            // 
            this.uxListBoxNume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxListBoxNume.FormattingEnabled = true;
            this.uxListBoxNume.Location = new System.Drawing.Point(3, 103);
            this.uxListBoxNume.Name = "uxListBoxNume";
            this.uxListBoxNume.Size = new System.Drawing.Size(794, 108);
            this.uxListBoxNume.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.uxTextBoxCauta);
            this.flowLayoutPanel2.Controls.Add(this.uxButtonMuta);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 228);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(794, 94);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // uxTextBoxCauta
            // 
            this.uxTextBoxCauta.Location = new System.Drawing.Point(3, 3);
            this.uxTextBoxCauta.Name = "uxTextBoxCauta";
            this.uxTextBoxCauta.Size = new System.Drawing.Size(181, 20);
            this.uxTextBoxCauta.TabIndex = 0;
            // 
            // uxButtonMuta
            // 
            this.uxButtonMuta.Location = new System.Drawing.Point(190, 3);
            this.uxButtonMuta.Name = "uxButtonMuta";
            this.uxButtonMuta.Size = new System.Drawing.Size(75, 23);
            this.uxButtonMuta.TabIndex = 1;
            this.uxButtonMuta.Text = "Muta";
            this.uxButtonMuta.UseVisualStyleBackColor = true;
            this.uxButtonMuta.Click += new System.EventHandler(this.uxButtonMuta_Click);
            // 
            // uxListBoxMutate
            // 
            this.uxListBoxMutate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxListBoxMutate.FormattingEnabled = true;
            this.uxListBoxMutate.Location = new System.Drawing.Point(3, 328);
            this.uxListBoxMutate.Name = "uxListBoxMutate";
            this.uxListBoxMutate.Size = new System.Drawing.Size(794, 108);
            this.uxListBoxMutate.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox uxTextBoxNume;
        private System.Windows.Forms.Button uxButtonAdauga;
        private System.Windows.Forms.ListBox uxListBoxNume;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox uxTextBoxCauta;
        private System.Windows.Forms.Button uxButtonMuta;
        private System.Windows.Forms.ListBox uxListBoxMutate;
    }
}

