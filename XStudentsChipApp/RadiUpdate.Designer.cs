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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_secondName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_secondName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_id.Location = new System.Drawing.Point(107, 64);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(40, 26);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_name.Location = new System.Drawing.Point(85, 101);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 26);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Име:";
            // 
            // lbl_secondName
            // 
            this.lbl_secondName.AutoSize = true;
            this.lbl_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_secondName.Location = new System.Drawing.Point(38, 142);
            this.lbl_secondName.Name = "lbl_secondName";
            this.lbl_secondName.Size = new System.Drawing.Size(109, 26);
            this.lbl_secondName.TabIndex = 2;
            this.lbl_secondName.Text = "Презиме:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_lastName.Location = new System.Drawing.Point(33, 179);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(114, 26);
            this.lbl_lastName.TabIndex = 3;
            this.lbl_lastName.Text = "Фамилия:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_id.Location = new System.Drawing.Point(153, 61);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(633, 32);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_name.Location = new System.Drawing.Point(153, 100);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(633, 32);
            this.txt_name.TabIndex = 5;
            // 
            // txt_secondName
            // 
            this.txt_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_secondName.Location = new System.Drawing.Point(153, 141);
            this.txt_secondName.Name = "txt_secondName";
            this.txt_secondName.Size = new System.Drawing.Size(633, 32);
            this.txt_secondName.TabIndex = 6;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_lastName.Location = new System.Drawing.Point(153, 178);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(633, 32);
            this.txt_lastName.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 196);
            this.dataGridView1.TabIndex = 8;
            // 
            // RadiUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(815, 454);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
