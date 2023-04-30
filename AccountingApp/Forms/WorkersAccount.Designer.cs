namespace AccountingApp.Forms
{
    partial class WorkersAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textTabel = new System.Windows.Forms.TextBox();
            this.cbDepart = new System.Windows.Forms.ComboBox();
            this.chekRemote = new System.Windows.Forms.CheckBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.textBirth = new System.Windows.Forms.TextBox();
            this.textFio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.pictureClear = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dgvTabel = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ExitCLick = new System.Windows.Forms.Label();
            this.tabelUchetaDataSet = new AccountingApp.TabelUchetaDataSet();
            this.tabelUchetaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.pictureClear);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.dgvTabel);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.InsertButton);
            this.panel1.Controls.Add(this.ExitCLick);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 515);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textTabel);
            this.groupBox1.Controls.Add(this.cbDepart);
            this.groupBox1.Controls.Add(this.chekRemote);
            this.groupBox1.Controls.Add(this.textAdres);
            this.groupBox1.Controls.Add(this.textBirth);
            this.groupBox1.Controls.Add(this.textFio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textPost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 357);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "ФИО";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Департамент";
            // 
            // textTabel
            // 
            this.textTabel.Location = new System.Drawing.Point(72, 143);
            this.textTabel.MaxLength = 6;
            this.textTabel.Name = "textTabel";
            this.textTabel.Size = new System.Drawing.Size(197, 20);
            this.textTabel.TabIndex = 13;
            // 
            // cbDepart
            // 
            this.cbDepart.FormattingEnabled = true;
            this.cbDepart.Location = new System.Drawing.Point(54, 323);
            this.cbDepart.Name = "cbDepart";
            this.cbDepart.Size = new System.Drawing.Size(242, 21);
            this.cbDepart.TabIndex = 29;
            // 
            // chekRemote
            // 
            this.chekRemote.AutoSize = true;
            this.chekRemote.Location = new System.Drawing.Point(254, 228);
            this.chekRemote.Name = "chekRemote";
            this.chekRemote.Size = new System.Drawing.Size(15, 14);
            this.chekRemote.TabIndex = 21;
            this.chekRemote.UseVisualStyleBackColor = true;
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(77, 272);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(197, 20);
            this.textAdres.TabIndex = 14;
            // 
            // textBirth
            // 
            this.textBirth.Location = new System.Drawing.Point(72, 192);
            this.textBirth.Name = "textBirth";
            this.textBirth.Size = new System.Drawing.Size(197, 20);
            this.textBirth.TabIndex = 16;
            // 
            // textFio
            // 
            this.textFio.Location = new System.Drawing.Point(72, 43);
            this.textFio.Name = "textFio";
            this.textFio.Size = new System.Drawing.Size(197, 20);
            this.textFio.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Должность";
            // 
            // textPost
            // 
            this.textPost.Location = new System.Drawing.Point(72, 93);
            this.textPost.Name = "textPost";
            this.textPost.Size = new System.Drawing.Size(197, 20);
            this.textPost.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Удаленная работа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Табельный номер";
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
            this.ReturnButton.Location = new System.Drawing.Point(209, 422);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(174, 42);
            this.ReturnButton.TabIndex = 28;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // pictureClear
            // 
            this.pictureClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureClear.Image")));
            this.pictureClear.Location = new System.Drawing.Point(389, 15);
            this.pictureClear.Name = "pictureClear";
            this.pictureClear.Size = new System.Drawing.Size(42, 40);
            this.pictureClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClear.TabIndex = 27;
            this.pictureClear.TabStop = false;
            this.pictureClear.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.buttonSearch.Location = new System.Drawing.Point(19, 470);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 35);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dgvTabel
            // 
            this.dgvTabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTabel.Location = new System.Drawing.Point(389, 61);
            this.dgvTabel.Name = "dgvTabel";
            this.dgvTabel.Size = new System.Drawing.Size(1038, 444);
            this.dgvTabel.TabIndex = 11;
            this.dgvTabel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabel_CellDoubleClick);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(123, 479);
            this.textSearch.MinimumSize = new System.Drawing.Size(4, 22);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(245, 20);
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
            this.UpdateButton.Location = new System.Drawing.Point(209, 374);
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
            this.DeleteButton.Location = new System.Drawing.Point(11, 422);
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
            this.InsertButton.Location = new System.Drawing.Point(11, 374);
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
            this.ExitCLick.Location = new System.Drawing.Point(1403, 0);
            this.ExitCLick.Name = "ExitCLick";
            this.ExitCLick.Size = new System.Drawing.Size(24, 24);
            this.ExitCLick.TabIndex = 1;
            this.ExitCLick.Text = "X";
            this.ExitCLick.Click += new System.EventHandler(this.ExitCLick_Click);
            // 
            // tabelUchetaDataSet
            // 
            this.tabelUchetaDataSet.DataSetName = "TabelUchetaDataSet";
            this.tabelUchetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelUchetaDataSetBindingSource
            // 
            this.tabelUchetaDataSetBindingSource.DataSource = this.tabelUchetaDataSet;
            this.tabelUchetaDataSetBindingSource.Position = 0;
            // 
            // WorkersAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 515);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkersAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabelWork";
            this.Load += new System.EventHandler(this.TabelWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUchetaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitCLick;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridView dgvTabel;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.TextBox textTabel;
        private System.Windows.Forms.CheckBox chekRemote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFio;
        private System.Windows.Forms.TextBox textBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private TabelUchetaDataSet tabelUchetaDataSet;
        private System.Windows.Forms.BindingSource tabelUchetaDataSetBindingSource;
        private System.Windows.Forms.TextBox textPost;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureClear;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDepart;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}