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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_write = new System.Windows.Forms.Button();
            this.BTN_read = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radiUpdate1 = new XStudentsChipApp.RadiUpdate();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BTN_write);
            this.groupBox1.Controls.Add(this.BTN_read);
            this.groupBox1.Location = new System.Drawing.Point(-4, -6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1020, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(704, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "ИЗТЕГЛЯНЕ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(511, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "ПРОМЯНА";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_write
            // 
            this.BTN_write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_write.FlatAppearance.BorderSize = 2;
            this.BTN_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BTN_write.ForeColor = System.Drawing.Color.White;
            this.BTN_write.Location = new System.Drawing.Point(314, 17);
            this.BTN_write.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_write.Name = "BTN_write";
            this.BTN_write.Size = new System.Drawing.Size(193, 48);
            this.BTN_write.TabIndex = 1;
            this.BTN_write.Text = "ДОБАВЯНЕ";
            this.BTN_write.UseVisualStyleBackColor = false;
            this.BTN_write.Click += new System.EventHandler(this.BTN_write_Click);
            // 
            // BTN_read
            // 
            this.BTN_read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_read.FlatAppearance.BorderSize = 2;
            this.BTN_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BTN_read.ForeColor = System.Drawing.Color.White;
            this.BTN_read.Location = new System.Drawing.Point(117, 17);
            this.BTN_read.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_read.Name = "BTN_read";
            this.BTN_read.Size = new System.Drawing.Size(193, 48);
            this.BTN_read.TabIndex = 0;
            this.BTN_read.Text = "ЧЕТЕНЕ";
            this.BTN_read.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(791, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 209);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // radiUpdate1
            // 
            this.radiUpdate1.BackColor = System.Drawing.Color.Transparent;
            this.radiUpdate1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radiUpdate1.BackgroundImage")));
            this.radiUpdate1.Location = new System.Drawing.Point(-4, 74);
            this.radiUpdate1.Name = "radiUpdate1";
            this.radiUpdate1.Size = new System.Drawing.Size(1020, 700);
            this.radiUpdate1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 761);
            this.Controls.Add(this.radiUpdate1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_write;
        private System.Windows.Forms.Button BTN_read;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RadiUpdate radiUpdate1;
    }
}

