namespace LPR2
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            buttonA3 = new Button();
            buttonA2 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(171, 88);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 0;
            button1.Text = "Atividade 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 41);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 2;
            label1.Text = "Atividades LP";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 146);
            button2.Name = "button2";
            button2.Size = new Size(88, 35);
            button2.TabIndex = 3;
            button2.Text = "Atividade 5";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(453, 88);
            button3.Name = "button3";
            button3.Size = new Size(88, 35);
            button3.TabIndex = 4;
            button3.Text = "Atividade 4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonA3
            // 
            buttonA3.Location = new Point(359, 88);
            buttonA3.Name = "buttonA3";
            buttonA3.Size = new Size(88, 35);
            buttonA3.TabIndex = 5;
            buttonA3.Text = "Atividade 3";
            buttonA3.UseVisualStyleBackColor = true;
            buttonA3.Click += buttonA3_Click;
            // 
            // buttonA2
            // 
            buttonA2.Location = new Point(265, 88);
            buttonA2.Name = "buttonA2";
            buttonA2.Size = new Size(88, 35);
            buttonA2.TabIndex = 6;
            buttonA2.Text = "Atividade 2";
            buttonA2.UseVisualStyleBackColor = true;
            buttonA2.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(453, 146);
            button6.Name = "button6";
            button6.Size = new Size(88, 35);
            button6.TabIndex = 7;
            button6.Text = "Atividade 8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(359, 146);
            button7.Name = "button7";
            button7.Size = new Size(88, 35);
            button7.TabIndex = 8;
            button7.Text = "Atividade 7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(265, 146);
            button8.Name = "button8";
            button8.Size = new Size(88, 35);
            button8.TabIndex = 9;
            button8.Text = "Atividade 6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(buttonA2);
            Controls.Add(buttonA3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button buttonA3;
        private Button buttonA2;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}