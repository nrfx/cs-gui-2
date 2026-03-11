namespace cs_gui_2
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            button1 = new Button();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(30, 42);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(30, 93);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 1;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(30, 144);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(125, 27);
            textBoxC.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(249, 66);
            button1.Name = "button1";
            button1.Size = new Size(150, 81);
            button1.TabIndex = 3;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(171, 42);
            labelA.Name = "labelA";
            labelA.Size = new Size(64, 20);
            labelA.TabIndex = 4;
            labelA.Text = "число А";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(171, 93);
            labelB.Name = "labelB";
            labelB.Size = new Size(63, 20);
            labelB.TabIndex = 5;
            labelB.Text = "число B";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(171, 147);
            labelC.Name = "labelC";
            labelC.Size = new Size(63, 20);
            labelC.TabIndex = 6;
            labelC.Text = "число C";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 20);
            label1.TabIndex = 7;
            label1.Text = "Произведение двух наименьших чисел";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 226);
            Controls.Add(label1);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(button1);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Button button1;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label label1;
    }
}
