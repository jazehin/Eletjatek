namespace EletjatekGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbSor = new ComboBox();
            cbOszlop = new ComboBox();
            btnUj = new Button();
            btnMentes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Mátrix mérete [sor x oszlop]:";
            // 
            // cbSor
            // 
            cbSor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSor.FormattingEnabled = true;
            cbSor.Location = new Point(175, 17);
            cbSor.Name = "cbSor";
            cbSor.Size = new Size(49, 23);
            cbSor.TabIndex = 1;
            // 
            // cbOszlop
            // 
            cbOszlop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOszlop.FormattingEnabled = true;
            cbOszlop.Location = new Point(230, 17);
            cbOszlop.Name = "cbOszlop";
            cbOszlop.Size = new Size(49, 23);
            cbOszlop.TabIndex = 2;
            // 
            // btnUj
            // 
            btnUj.Location = new Point(12, 52);
            btnUj.Name = "btnUj";
            btnUj.Size = new Size(145, 23);
            btnUj.TabIndex = 3;
            btnUj.Text = "Üres mátrix létrehozása";
            btnUj.UseVisualStyleBackColor = true;
            btnUj.Click += btnUj_Click;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(175, 52);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(104, 23);
            btnMentes.TabIndex = 4;
            btnMentes.Text = "Állás mentése";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += btnMentes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 450);
            Controls.Add(btnMentes);
            Controls.Add(btnUj);
            Controls.Add(cbOszlop);
            Controls.Add(cbSor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Életjáték álláskészítő";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbSor;
        private ComboBox cbOszlop;
        private Button btnUj;
        private Button btnMentes;
    }
}