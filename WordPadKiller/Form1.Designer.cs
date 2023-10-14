namespace WordPadKiller
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
            panel1 = new Panel();
            Save_btn = new Button();
            load_btn = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            align_lbl = new Label();
            Color_btn = new Button();
            Font_btn = new Button();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Save_btn);
            panel1.Controls.Add(load_btn);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(align_lbl);
            panel1.Controls.Add(Color_btn);
            panel1.Controls.Add(Font_btn);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 83);
            panel1.TabIndex = 0;
            // 
            // Save_btn
            // 
            Save_btn.BackColor = SystemColors.ControlDarkDark;
            Save_btn.FlatStyle = FlatStyle.Flat;
            Save_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Save_btn.Location = new Point(430, 48);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(92, 32);
            Save_btn.TabIndex = 7;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.Click += Save_btn_Click;
            // 
            // load_btn
            // 
            load_btn.BackColor = SystemColors.ControlDarkDark;
            load_btn.FlatStyle = FlatStyle.Flat;
            load_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            load_btn.Location = new Point(430, 9);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(92, 33);
            load_btn.TabIndex = 6;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(352, 37);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(32, 19);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "V";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(313, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(33, 19);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "C";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(276, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "L";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // align_lbl
            // 
            align_lbl.AutoSize = true;
            align_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            align_lbl.Location = new Point(279, 9);
            align_lbl.Name = "align_lbl";
            align_lbl.Size = new Size(100, 25);
            align_lbl.TabIndex = 2;
            align_lbl.Text = "AlignMent";
            // 
            // Color_btn
            // 
            Color_btn.BackColor = SystemColors.ControlDarkDark;
            Color_btn.FlatStyle = FlatStyle.Flat;
            Color_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Color_btn.Location = new Point(140, 9);
            Color_btn.Name = "Color_btn";
            Color_btn.Size = new Size(96, 43);
            Color_btn.TabIndex = 1;
            Color_btn.Text = "Color";
            Color_btn.UseVisualStyleBackColor = false;
            Color_btn.Click += Color_btn_Click;
            // 
            // Font_btn
            // 
            Font_btn.BackColor = SystemColors.ControlDarkDark;
            Font_btn.FlatStyle = FlatStyle.Flat;
            Font_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Font_btn.Location = new Point(10, 9);
            Font_btn.Name = "Font_btn";
            Font_btn.Size = new Size(96, 43);
            Font_btn.TabIndex = 0;
            Font_btn.Text = "Font";
            Font_btn.UseVisualStyleBackColor = false;
            Font_btn.Click += Font_btn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, 92);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(524, 355);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 450);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label align_lbl;
        private Button Color_btn;
        private Button Font_btn;
        private Button Save_btn;
        private Button load_btn;
        private RichTextBox richTextBox1;
    }
}