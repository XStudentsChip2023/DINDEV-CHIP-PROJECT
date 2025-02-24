namespace XStudentsChipApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_write = new System.Windows.Forms.Button();
            this.BTN_read = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BTN_write);
            this.groupBox1.Controls.Add(this.BTN_read);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(797, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "ИЗТЕГЛЯНЕ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "ПРОМЯНА";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_write
            // 
            this.BTN_write.Location = new System.Drawing.Point(204, 8);
            this.BTN_write.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_write.Name = "BTN_write";
            this.BTN_write.Size = new System.Drawing.Size(193, 53);
            this.BTN_write.TabIndex = 1;
            this.BTN_write.Text = "ДОБАВЯНЕ";
            this.BTN_write.UseVisualStyleBackColor = true;
            this.BTN_write.Click += new System.EventHandler(this.BTN_write_Click);
            // 
            // BTN_read
            // 
            this.BTN_read.Location = new System.Drawing.Point(7, 8);
            this.BTN_read.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_read.Name = "BTN_read";
            this.BTN_read.Size = new System.Drawing.Size(193, 53);
            this.BTN_read.TabIndex = 0;
            this.BTN_read.Text = "ЧЕТЕНЕ";
            this.BTN_read.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(291, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 81);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_write;
        private System.Windows.Forms.Button BTN_read;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

