namespace RegExParser
{
    partial class MainForm
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
            this.phraseEntryBox = new System.Windows.Forms.TextBox();
            this.regexPhrase_01 = new System.Windows.Forms.TextBox();
            this.regexPhrase_02 = new System.Windows.Forms.TextBox();
            this.enableSecondPhrase = new System.Windows.Forms.CheckBox();
            this.returnCenterValue = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phraseEntryBox
            // 
            this.phraseEntryBox.Location = new System.Drawing.Point(12, 41);
            this.phraseEntryBox.Multiline = true;
            this.phraseEntryBox.Name = "phraseEntryBox";
            this.phraseEntryBox.Size = new System.Drawing.Size(1219, 515);
            this.phraseEntryBox.TabIndex = 0;
            // 
            // regexPhrase_01
            // 
            this.regexPhrase_01.Location = new System.Drawing.Point(620, 627);
            this.regexPhrase_01.Name = "regexPhrase_01";
            this.regexPhrase_01.Size = new System.Drawing.Size(611, 31);
            this.regexPhrase_01.TabIndex = 1;
            this.regexPhrase_01.TextChanged += new System.EventHandler(this.regexPhrase_01_TextChanged);
            // 
            // regexPhrase_02
            // 
            this.regexPhrase_02.Enabled = false;
            this.regexPhrase_02.Location = new System.Drawing.Point(620, 711);
            this.regexPhrase_02.Name = "regexPhrase_02";
            this.regexPhrase_02.Size = new System.Drawing.Size(611, 31);
            this.regexPhrase_02.TabIndex = 2;
            this.regexPhrase_02.TextChanged += new System.EventHandler(this.regexPhrase_02_TextChanged);
            // 
            // enableSecondPhrase
            // 
            this.enableSecondPhrase.AutoSize = true;
            this.enableSecondPhrase.Location = new System.Drawing.Point(18, 576);
            this.enableSecondPhrase.Name = "enableSecondPhrase";
            this.enableSecondPhrase.Size = new System.Drawing.Size(242, 29);
            this.enableSecondPhrase.TabIndex = 3;
            this.enableSecondPhrase.Text = "Use second phrase?";
            this.enableSecondPhrase.UseVisualStyleBackColor = true;
            this.enableSecondPhrase.CheckedChanged += new System.EventHandler(this.enableSecondPhrase_CheckedChanged);
            // 
            // returnCenterValue
            // 
            this.returnCenterValue.AutoSize = true;
            this.returnCenterValue.Location = new System.Drawing.Point(18, 611);
            this.returnCenterValue.Name = "returnCenterValue";
            this.returnCenterValue.Size = new System.Drawing.Size(244, 29);
            this.returnCenterValue.TabIndex = 4;
            this.returnCenterValue.Text = "Return center value?";
            this.returnCenterValue.UseVisualStyleBackColor = true;
            this.returnCenterValue.CheckedChanged += new System.EventHandler(this.returnCenterValue_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 764);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1219, 206);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter praragraph to search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "First RegEx Phrase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Second RegEx Phrase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Find Expression";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 1106);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.returnCenterValue);
            this.Controls.Add(this.enableSecondPhrase);
            this.Controls.Add(this.regexPhrase_02);
            this.Controls.Add(this.regexPhrase_01);
            this.Controls.Add(this.phraseEntryBox);
            this.Name = "MainForm";
            this.Text = "RegEx Phrase Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phraseEntryBox;
        private System.Windows.Forms.TextBox regexPhrase_01;
        private System.Windows.Forms.TextBox regexPhrase_02;
        private System.Windows.Forms.CheckBox enableSecondPhrase;
        private System.Windows.Forms.CheckBox returnCenterValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

