namespace Speaker
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
            this.button1 = new System.Windows.Forms.Button();
            this._lblText = new System.Windows.Forms.Label();
            this._lblText2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lblText
            // 
            this._lblText.AutoSize = true;
            this._lblText.Location = new System.Drawing.Point(54, 138);
            this._lblText.Name = "_lblText";
            this._lblText.Size = new System.Drawing.Size(35, 13);
            this._lblText.TabIndex = 1;
            this._lblText.Text = "label1";
            // 
            // _lblText2
            // 
            this._lblText2.AutoSize = true;
            this._lblText2.Location = new System.Drawing.Point(45, 205);
            this._lblText2.Name = "_lblText2";
            this._lblText2.Size = new System.Drawing.Size(35, 13);
            this._lblText2.TabIndex = 2;
            this._lblText2.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bấm ở đây";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInPut
            // 
            this.txtInPut.Location = new System.Drawing.Point(12, 21);
            this.txtInPut.Multiline = true;
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(249, 20);
            this.txtInPut.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtInPut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._lblText2);
            this.Controls.Add(this._lblText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _lblText;
        private System.Windows.Forms.Label _lblText2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInPut;
    }
}

