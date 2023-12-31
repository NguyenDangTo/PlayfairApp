namespace Playfair
{
    partial class Playfair
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
            plainTextInput = new TextBox();
            label1 = new Label();
            encryptOutput = new TextBox();
            decryptOutput = new TextBox();
            encryptBtn = new Button();
            decryptBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            keyTextInput = new TextBox();
            clearBtn = new Button();
            label4 = new Label();
            Matrix = new GroupBox();
            button25 = new Button();
            button24 = new Button();
            button23 = new Button();
            button22 = new Button();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Matrix.SuspendLayout();
            SuspendLayout();
            // 
            // plainTextInput
            // 
            plainTextInput.Location = new Point(97, 101);
            plainTextInput.Name = "plainTextInput";
            plainTextInput.Size = new Size(252, 27);
            plainTextInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 2;
            label1.Text = "PLAYFAIR ";
            // 
            // encryptOutput
            // 
            encryptOutput.Location = new Point(12, 262);
            encryptOutput.Name = "encryptOutput";
            encryptOutput.Size = new Size(337, 27);
            encryptOutput.TabIndex = 3;
            // 
            // decryptOutput
            // 
            decryptOutput.Location = new Point(12, 372);
            decryptOutput.Name = "decryptOutput";
            decryptOutput.Size = new Size(337, 27);
            decryptOutput.TabIndex = 4;
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(12, 213);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(337, 29);
            encryptBtn.TabIndex = 5;
            encryptBtn.Text = "Encrypt";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(12, 319);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(337, 29);
            decryptBtn.TabIndex = 6;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = true;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Plain Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 8;
            label3.Text = "Key";
            // 
            // keyTextInput
            // 
            keyTextInput.Location = new Point(97, 61);
            keyTextInput.Name = "keyTextInput";
            keyTextInput.Size = new Size(252, 27);
            keyTextInput.TabIndex = 9;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(120, 165);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(281, 20);
            label4.TabIndex = 11;
            label4.Text = "Maximum length should be 16 characters";
            // 
            // Matrix
            // 
            Matrix.Controls.Add(button25);
            Matrix.Controls.Add(button24);
            Matrix.Controls.Add(button23);
            Matrix.Controls.Add(button22);
            Matrix.Controls.Add(button21);
            Matrix.Controls.Add(button20);
            Matrix.Controls.Add(button19);
            Matrix.Controls.Add(button18);
            Matrix.Controls.Add(button17);
            Matrix.Controls.Add(button16);
            Matrix.Controls.Add(button15);
            Matrix.Controls.Add(button14);
            Matrix.Controls.Add(button13);
            Matrix.Controls.Add(button12);
            Matrix.Controls.Add(button11);
            Matrix.Controls.Add(button10);
            Matrix.Controls.Add(button9);
            Matrix.Controls.Add(button8);
            Matrix.Controls.Add(button7);
            Matrix.Controls.Add(button6);
            Matrix.Controls.Add(button5);
            Matrix.Controls.Add(button4);
            Matrix.Controls.Add(button3);
            Matrix.Controls.Add(button2);
            Matrix.Controls.Add(button1);
            Matrix.Location = new Point(407, 50);
            Matrix.Name = "Matrix";
            Matrix.Size = new Size(350, 350);
            Matrix.TabIndex = 12;
            Matrix.TabStop = false;
            // 
            // button25
            // 
            button25.Location = new Point(280, 279);
            button25.Name = "button25";
            button25.Size = new Size(60, 60);
            button25.TabIndex = 24;
            button25.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Location = new Point(214, 279);
            button24.Name = "button24";
            button24.Size = new Size(60, 60);
            button24.TabIndex = 23;
            button24.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Location = new Point(148, 279);
            button23.Name = "button23";
            button23.Size = new Size(60, 60);
            button23.TabIndex = 22;
            button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(82, 279);
            button22.Name = "button22";
            button22.Size = new Size(60, 60);
            button22.TabIndex = 21;
            button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(16, 279);
            button21.Name = "button21";
            button21.Size = new Size(60, 60);
            button21.TabIndex = 20;
            button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(280, 213);
            button20.Name = "button20";
            button20.Size = new Size(60, 60);
            button20.TabIndex = 19;
            button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(214, 212);
            button19.Name = "button19";
            button19.Size = new Size(60, 60);
            button19.TabIndex = 18;
            button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(148, 213);
            button18.Name = "button18";
            button18.Size = new Size(60, 60);
            button18.TabIndex = 17;
            button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(82, 213);
            button17.Name = "button17";
            button17.Size = new Size(60, 60);
            button17.TabIndex = 16;
            button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(16, 213);
            button16.Name = "button16";
            button16.Size = new Size(60, 60);
            button16.TabIndex = 15;
            button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(280, 147);
            button15.Name = "button15";
            button15.Size = new Size(60, 60);
            button15.TabIndex = 14;
            button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(214, 147);
            button14.Name = "button14";
            button14.Size = new Size(60, 60);
            button14.TabIndex = 13;
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(148, 147);
            button13.Name = "button13";
            button13.Size = new Size(60, 60);
            button13.TabIndex = 12;
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(82, 147);
            button12.Name = "button12";
            button12.Size = new Size(60, 60);
            button12.TabIndex = 11;
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(16, 147);
            button11.Name = "button11";
            button11.Size = new Size(60, 60);
            button11.TabIndex = 10;
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(280, 81);
            button10.Name = "button10";
            button10.Size = new Size(60, 60);
            button10.TabIndex = 9;
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(214, 81);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(148, 81);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(82, 81);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(16, 81);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(280, 18);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(214, 18);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(148, 18);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(82, 18);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(16, 18);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // Playfair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Matrix);
            Controls.Add(label4);
            Controls.Add(clearBtn);
            Controls.Add(keyTextInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(decryptBtn);
            Controls.Add(encryptBtn);
            Controls.Add(decryptOutput);
            Controls.Add(encryptOutput);
            Controls.Add(label1);
            Controls.Add(plainTextInput);
            Name = "Playfair";
            Text = "Form1";
            Matrix.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox plainTextInput;
        private Label label1;
        private TextBox encryptOutput;
        private TextBox decryptOutput;
        private Button encryptBtn;
        private Button decryptBtn;
        private Label label2;
        private Label label3;
        private TextBox keyTextInput;
        private Button clearBtn;
        private Label label4;
        private GroupBox Matrix;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
