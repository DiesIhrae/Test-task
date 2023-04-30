namespace AccountingApp.Forms
{
    partial class DeptsAccounting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptsAccounting));
            this.tabelUchetaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelUchetaDataSet = new AccountingApp.TabelUchetaDataSet();
            this.pictureClear = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.dgvDepts = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ExitCLick = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelUchetaDataSetBindingSource
            // 
            this.tabelUchetaDataSetBindingSource.DataSource = this.tabelUchetaDataSet;
            this.tabelUchetaDataSetBindingSource.Position = 0;
            // 
            // tabelUchetaDataSet
            // 
            this.tabelUchetaDataSet.DataSetName = "TabelUchetaDataSet";
            this.tabelUchetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureClear
            // 
            this.pictureClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureClear.Image")));
            this.pictureClear.Location = new System.Drawing.Point(381, 10);
            this.pictureClear.Name = "pictureClear";
            this.pictureClear.Size = new System.Drawing.Size(42, 40);
            this.pictureClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClear.TabIndex = 27;
            this.pictureClear.TabStop = false;
            this.pictureClear.Click += new System.EventHandler(this.pictureClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(237)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(58)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(253)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch.Location = new System.Drawing.Point(11, 236);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 35);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название департамента";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(82, 67);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(197, 31);
            this.textName.TabIndex = 17;
            // 
            // dgvDepts
            // 
            this.dgvDepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDepts.Location = new System.Drawing.Point(381, 56);
            this.dgvDepts.Name = "dgvDepts";
            this.dgvDepts.Size = new System.Drawing.Size(541, 222);
            this.dgvDepts.TabIndex = 11;
            this.dgvDepts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepts_CellDoubleClick);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(115, 245);
            this.textSearch.MinimumSize = new System.Drawing.Size(4, 22);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(245, 22);
            this.textSearch.TabIndex = 10;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(237)))));
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(58)))));
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(253)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateButton.Location = new System.Drawing.Point(201, 140);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(174, 42);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Редактировать";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(237)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(58)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(253)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(3, 188);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(174, 42);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(237)))));
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(58)))));
            this.InsertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(253)))));
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.InsertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertButton.Location = new System.Drawing.Point(3, 140);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(174, 42);
            this.InsertButton.TabIndex = 7;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ExitCLick
            // 
            this.ExitCLick.AutoSize = true;
            this.ExitCLick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.ExitCLick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitCLick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCLick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitCLick.Location = new System.Drawing.Point(898, 8);
            this.ExitCLick.Name = "ExitCLick";
            this.ExitCLick.Size = new System.Drawing.Size(24, 24);
            this.ExitCLick.TabIndex = 1;
            this.ExitCLick.Text = "X";
            this.ExitCLick.Click += new System.EventHandler(this.ExitCLick_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureClear);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.dgvDepts);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.InsertButton);
            this.panel1.Controls.Add(this.ExitCLick);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 297);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 123);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(237)))));
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(58)))));
            this.ReturnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(253)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReturnButton.Location = new System.Drawing.Point(201, 188);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(174, 42);
            this.ReturnButton.TabIndex = 29;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // DeptsAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 297);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeptsAccounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeptsAccounting";
            this.Load += new System.EventHandler(this.DeptsAccounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tabelUchetaDataSetBindingSource;
        private TabelUchetaDataSet tabelUchetaDataSet;
        private System.Windows.Forms.PictureBox pictureClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DataGridView dgvDepts;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label ExitCLick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReturnButton;
    }
}