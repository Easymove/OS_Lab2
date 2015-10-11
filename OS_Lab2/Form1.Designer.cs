namespace OS_Lab2
{
    partial class appForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nominalText = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.logText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.restText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert your coin here:";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(229, 12);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(100, 20);
            this.inputText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nominal to exchange:";
            // 
            // nominalText
            // 
            this.nominalText.FormattingEnabled = true;
            this.nominalText.Location = new System.Drawing.Point(229, 44);
            this.nominalText.Name = "nominalText";
            this.nominalText.Size = new System.Drawing.Size(100, 21);
            this.nominalText.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(359, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(113, 55);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Change!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logText
            // 
            this.logText.Enabled = false;
            this.logText.Location = new System.Drawing.Point(12, 84);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(460, 181);
            this.logText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your coins:";
            // 
            // resText
            // 
            this.resText.Enabled = false;
            this.resText.Location = new System.Drawing.Point(128, 286);
            this.resText.Name = "resText";
            this.resText.Size = new System.Drawing.Size(344, 20);
            this.resText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "In machine:";
            // 
            // restText
            // 
            this.restText.Enabled = false;
            this.restText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restText.Location = new System.Drawing.Point(131, 329);
            this.restText.Name = "restText";
            this.restText.Size = new System.Drawing.Size(341, 23);
            this.restText.TabIndex = 10;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.restText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nominalText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "appForm";
            this.ShowIcon = false;
            this.Text = "Coin machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox logText;
        public System.Windows.Forms.TextBox inputText;
        public System.Windows.Forms.ComboBox nominalText;
        public System.Windows.Forms.TextBox resText;
        public System.Windows.Forms.TextBox restText;
    }
}

