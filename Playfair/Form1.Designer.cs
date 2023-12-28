namespace Playfair
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
            SuspendLayout();
            // 
            // plainTextInput
            // 
            plainTextInput.Location = new Point(269, 101);
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
            encryptOutput.Location = new Point(97, 226);
            encryptOutput.Name = "encryptOutput";
            encryptOutput.Size = new Size(252, 27);
            encryptOutput.TabIndex = 3;
            // 
            // decryptOutput
            // 
            decryptOutput.Location = new Point(438, 226);
            decryptOutput.Name = "decryptOutput";
            decryptOutput.Size = new Size(252, 27);
            decryptOutput.TabIndex = 4;
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(165, 170);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(94, 29);
            encryptBtn.TabIndex = 5;
            encryptBtn.Text = "Encrypt";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(510, 170);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(94, 29);
            decryptBtn.TabIndex = 6;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = true;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Plain Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 64);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 8;
            label3.Text = "Key";
            // 
            // keyTextInput
            // 
            keyTextInput.Location = new Point(269, 61);
            keyTextInput.Name = "keyTextInput";
            keyTextInput.Size = new Size(252, 27);
            keyTextInput.TabIndex = 9;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(349, 172);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
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
    }
}
