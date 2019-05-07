namespace LAB_
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.firstSearched = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.threeDicTimeLabel = new System.Windows.Forms.Label();
            this.twoDicTimeLabel = new System.Windows.Forms.Label();
            this.readTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(33, 31);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(238, 20);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // firstSearched
            // 
            this.firstSearched.AutoSize = true;
            this.firstSearched.Location = new System.Drawing.Point(145, 72);
            this.firstSearched.Name = "firstSearched";
            this.firstSearched.Size = new System.Drawing.Size(10, 13);
            this.firstSearched.TabIndex = 1;
            this.firstSearched.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pierwszy wyszukany:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Czas odczytu:";
            // 
            // threeDicTimeLabel
            // 
            this.threeDicTimeLabel.AutoSize = true;
            this.threeDicTimeLabel.Location = new System.Drawing.Point(541, 127);
            this.threeDicTimeLabel.Name = "threeDicTimeLabel";
            this.threeDicTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.threeDicTimeLabel.TabIndex = 4;
            this.threeDicTimeLabel.Text = " ";
            // 
            // twoDicTimeLabel
            // 
            this.twoDicTimeLabel.AutoSize = true;
            this.twoDicTimeLabel.Location = new System.Drawing.Point(541, 99);
            this.twoDicTimeLabel.Name = "twoDicTimeLabel";
            this.twoDicTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.twoDicTimeLabel.TabIndex = 5;
            this.twoDicTimeLabel.Text = " ";
            // 
            // readTimeLabel
            // 
            this.readTimeLabel.AutoSize = true;
            this.readTimeLabel.Location = new System.Drawing.Point(395, 72);
            this.readTimeLabel.Name = "readTimeLabel";
            this.readTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.readTimeLabel.TabIndex = 6;
            this.readTimeLabel.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Czas tworzenia struktury dla trzech znaków:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Czas tworzenia struktury dla dwuch znaków:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.readTimeLabel);
            this.Controls.Add(this.twoDicTimeLabel);
            this.Controls.Add(this.threeDicTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstSearched);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label firstSearched;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label threeDicTimeLabel;
        private System.Windows.Forms.Label twoDicTimeLabel;
        private System.Windows.Forms.Label readTimeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

