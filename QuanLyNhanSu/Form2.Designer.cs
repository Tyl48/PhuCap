namespace QuanLyNhanSu
{
    partial class Form2
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
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.txtHSPC = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Export = new System.Windows.Forms.Button();
            this.Ma_chuc_vu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.He_so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.He_so_phu_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(13, 221);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(152, 221);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(300, 221);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ma chuc vu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "He so luong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "He so phu cap";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(178, 13);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(179, 22);
            this.txtCV.TabIndex = 6;
            // 
            // txtHSL
            // 
            this.txtHSL.Location = new System.Drawing.Point(178, 59);
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(179, 22);
            this.txtHSL.TabIndex = 7;
            // 
            // txtHSPC
            // 
            this.txtHSPC.Location = new System.Drawing.Point(178, 106);
            this.txtHSPC.Name = "txtHSPC";
            this.txtHSPC.Size = new System.Drawing.Size(179, 22);
            this.txtHSPC.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_chuc_vu,
            this.He_so_luong,
            this.He_so_phu_cap});
            this.dataGridView1.Location = new System.Drawing.Point(16, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 228);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Chon_dong);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Chon_dong);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(442, 221);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(110, 23);
            this.Export.TabIndex = 10;
            this.Export.Text = "Export Excel";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Ma_chuc_vu
            // 
            this.Ma_chuc_vu.DataPropertyName = "Ma_chuc_vu";
            this.Ma_chuc_vu.HeaderText = "Ma chuc vu";
            this.Ma_chuc_vu.MinimumWidth = 6;
            this.Ma_chuc_vu.Name = "Ma_chuc_vu";
            this.Ma_chuc_vu.Width = 125;
            // 
            // He_so_luong
            // 
            this.He_so_luong.DataPropertyName = "He_so_luong";
            this.He_so_luong.HeaderText = "He so luong";
            this.He_so_luong.MinimumWidth = 6;
            this.He_so_luong.Name = "He_so_luong";
            this.He_so_luong.Width = 125;
            // 
            // He_so_phu_cap
            // 
            this.He_so_phu_cap.DataPropertyName = "He_so_phu_cap";
            this.He_so_phu_cap.HeaderText = "He so phu cap";
            this.He_so_phu_cap.MinimumWidth = 6;
            this.He_so_phu_cap.Name = "He_so_phu_cap";
            this.He_so_phu_cap.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHSPC);
            this.Controls.Add(this.txtHSL);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.TextBox txtHSPC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_chuc_vu;
        private System.Windows.Forms.DataGridViewTextBoxColumn He_so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn He_so_phu_cap;
    }
}