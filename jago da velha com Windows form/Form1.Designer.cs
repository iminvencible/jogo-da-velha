﻿namespace jago_da_velha_com_Windows_form
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
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button14 = new Button();
            fecha = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button15 = new Button();
            button13 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(561, 672);
            button9.Name = "button9";
            button9.Size = new Size(159, 141);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(333, 672);
            button8.Name = "button8";
            button8.Size = new Size(159, 141);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(101, 672);
            button7.Name = "button7";
            button7.Size = new Size(159, 141);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(101, 451);
            button4.Name = "button4";
            button4.Size = new Size(159, 141);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(333, 451);
            button5.Name = "button5";
            button5.Size = new Size(159, 141);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(561, 451);
            button6.Name = "button6";
            button6.Size = new Size(159, 141);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 36);
            label1.TabIndex = 9;
            label1.Text = "JOGO DA VELHA";
            // 
            // button1
            // 
            button1.Location = new Point(101, 224);
            button1.Name = "button1";
            button1.Size = new Size(159, 141);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(333, 224);
            button2.Name = "button2";
            button2.Size = new Size(159, 141);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(561, 224);
            button3.Name = "button3";
            button3.Size = new Size(159, 141);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Font = new Font("Showcard Gothic", 9F);
            button14.Location = new Point(101, 889);
            button14.Name = "button14";
            button14.Size = new Size(159, 28);
            button14.TabIndex = 10;
            button14.Text = "Reinciar";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button1_Click;
            // 
            // fecha
            // 
            fecha.Font = new Font("Showcard Gothic", 9F);
            fecha.Location = new Point(333, 889);
            fecha.Name = "fecha";
            fecha.Size = new Size(159, 28);
            fecha.TabIndex = 11;
            fecha.Text = "Fechar App";
            fecha.UseVisualStyleBackColor = true;
            fecha.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 72);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 12;
            label2.Text = "Player 1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(112, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(649, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(669, 72);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 14;
            label3.Text = "Player 2";
            // 
            // button15
            // 
            button15.Font = new Font("Showcard Gothic", 9F);
            button15.Location = new Point(561, 889);
            button15.Name = "button15";
            button15.Size = new Size(159, 28);
            button15.TabIndex = 16;
            button15.Text = "Limpar";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(333, 102);
            button13.Name = "button13";
            button13.Size = new Size(159, 28);
            button13.TabIndex = 17;
            button13.Text = "Ranking";
            button13.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Showcard Gothic", 9F);
            button10.Location = new Point(601, 169);
            button10.Name = "button10";
            button10.Size = new Size(159, 28);
            button10.TabIndex = 18;
            button10.Text = "Iniciar Jogo";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 929);
            Controls.Add(button10);
            Controls.Add(button13);
            Controls.Add(button15);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(fecha);
            Controls.Add(button14);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button9;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button14;
        private Button fecha;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button15;
        private Button button13;
        private Button button10;
    }
}
