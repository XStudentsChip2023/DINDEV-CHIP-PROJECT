namespace XStudentsChipApp
{
    partial class RadiUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadiUpdate));
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_secondName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_secondName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_id.Location = new System.Drawing.Point(72, 37);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(40, 26);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_name.Location = new System.Drawing.Point(50, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 26);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Име:";
            // 
            // lbl_secondName
            // 
            this.lbl_secondName.AutoSize = true;
            this.lbl_secondName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_secondName.Location = new System.Drawing.Point(3, 140);
            this.lbl_secondName.Name = "lbl_secondName";
            this.lbl_secondName.Size = new System.Drawing.Size(109, 26);
            this.lbl_secondName.TabIndex = 2;
            this.lbl_secondName.Text = "Презиме:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_lastName.Location = new System.Drawing.Point(3, 194);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(114, 26);
            this.lbl_lastName.TabIndex = 3;
            this.lbl_lastName.Text = "Фамилия:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_id.Location = new System.Drawing.Point(118, 34);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(650, 32);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_name.Location = new System.Drawing.Point(118, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(650, 32);
            this.txt_name.TabIndex = 5;
            // 
            // txt_secondName
            // 
            this.txt_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_secondName.Location = new System.Drawing.Point(118, 140);
            this.txt_secondName.Name = "txt_secondName";
            this.txt_secondName.Size = new System.Drawing.Size(650, 32);
            this.txt_secondName.TabIndex = 6;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_lastName.Location = new System.Drawing.Point(118, 194);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(650, 32);
            this.txt_lastName.TabIndex = 7;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 370);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btn_change.FlatAppearance.BorderSize = 2;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(594, 638);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(174, 41);
            this.btn_change.TabIndex = 9;
            this.btn_change.Text = "Промени";
            this.btn_change.UseVisualStyleBackColor = false;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btn_show.FlatAppearance.BorderSize = 2;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Location = new System.Drawing.Point(118, 634);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(208, 45);
            this.btn_show.TabIndex = 10;
            this.btn_show.Text = "Покажи всички";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(790, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 227);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RadiUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_secondName);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_secondName);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Name = "RadiUpdate";
            this.Size = new System.Drawing.Size(991, 700);
            this.Load += new System.EventHandler(this.RadiUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_secondName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_secondName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
