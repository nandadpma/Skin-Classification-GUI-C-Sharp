namespace SkinClassification
{
    partial class classification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_svm_model_file_browser = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDataUji = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_dataTestin = new System.Windows.Forms.Button();
            this.gb_dataLatih = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDataLatih = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLoadDataTraining = new System.Windows.Forms.Button();
            this.btMuatHasilTraining = new System.Windows.Forms.Button();
            this.lbAkurasi = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btTesting = new System.Windows.Forms.Button();
            this.btTraining = new System.Windows.Forms.Button();
            this.gb_svm_model_file_browser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUji)).BeginInit();
            this.gb_dataLatih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataLatih)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_svm_model_file_browser
            // 
            this.gb_svm_model_file_browser.BackColor = System.Drawing.Color.Transparent;
            this.gb_svm_model_file_browser.Controls.Add(this.webBrowser1);
            this.gb_svm_model_file_browser.Location = new System.Drawing.Point(757, 3);
            this.gb_svm_model_file_browser.Name = "gb_svm_model_file_browser";
            this.gb_svm_model_file_browser.Size = new System.Drawing.Size(432, 472);
            this.gb_svm_model_file_browser.TabIndex = 44;
            this.gb_svm_model_file_browser.TabStop = false;
            this.gb_svm_model_file_browser.Text = "Hasil Training";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(422, 442);
            this.webBrowser1.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dgvDataUji);
            this.groupBox1.Controls.Add(this.gb_dataTestin);
            this.groupBox1.Location = new System.Drawing.Point(358, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 472);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Uji";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(227, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Load Data Uji";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btChooseDataTesting_Click);
            // 
            // dgvDataUji
            // 
            this.dgvDataUji.AllowUserToOrderColumns = true;
            this.dgvDataUji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataUji.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataUji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataUji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataUji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataUji.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataUji.Location = new System.Drawing.Point(5, 54);
            this.dgvDataUji.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataUji.Name = "dgvDataUji";
            this.dgvDataUji.RowHeadersVisible = false;
            this.dgvDataUji.RowTemplate.Height = 24;
            this.dgvDataUji.Size = new System.Drawing.Size(383, 410);
            this.dgvDataUji.TabIndex = 16;
            this.dgvDataUji.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataUji_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 101;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Actual Class";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 122;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Result Class";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 123;
            // 
            // gb_dataTestin
            // 
            this.gb_dataTestin.BackColor = System.Drawing.Color.SpringGreen;
            this.gb_dataTestin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_dataTestin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dataTestin.Location = new System.Drawing.Point(5, 24);
            this.gb_dataTestin.Margin = new System.Windows.Forms.Padding(2);
            this.gb_dataTestin.Name = "gb_dataTestin";
            this.gb_dataTestin.Size = new System.Drawing.Size(218, 26);
            this.gb_dataTestin.TabIndex = 15;
            this.gb_dataTestin.Text = "Load Folder Data Uji";
            this.gb_dataTestin.UseVisualStyleBackColor = false;
            this.gb_dataTestin.Click += new System.EventHandler(this.btChooseTestDir_Click);
            // 
            // gb_dataLatih
            // 
            this.gb_dataLatih.BackColor = System.Drawing.Color.Transparent;
            this.gb_dataLatih.Controls.Add(this.button1);
            this.gb_dataLatih.Controls.Add(this.dgvDataLatih);
            this.gb_dataLatih.Controls.Add(this.btLoadDataTraining);
            this.gb_dataLatih.Location = new System.Drawing.Point(16, 3);
            this.gb_dataLatih.Name = "gb_dataLatih";
            this.gb_dataLatih.Size = new System.Drawing.Size(336, 472);
            this.gb_dataLatih.TabIndex = 42;
            this.gb_dataLatih.TabStop = false;
            this.gb_dataLatih.Text = "Data Latih";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btChooseDataLatih_Click);
            // 
            // dgvDataLatih
            // 
            this.dgvDataLatih.AllowUserToOrderColumns = true;
            this.dgvDataLatih.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataLatih.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataLatih.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataLatih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataLatih.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataLatih.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataLatih.Location = new System.Drawing.Point(5, 54);
            this.dgvDataLatih.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataLatih.Name = "dgvDataLatih";
            this.dgvDataLatih.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDataLatih.RowHeadersVisible = false;
            this.dgvDataLatih.RowTemplate.Height = 24;
            this.dgvDataLatih.Size = new System.Drawing.Size(326, 410);
            this.dgvDataLatih.TabIndex = 26;
            this.dgvDataLatih.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataLatih_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 101;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Actual Class";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 122;
            // 
            // btLoadDataTraining
            // 
            this.btLoadDataTraining.BackColor = System.Drawing.Color.SpringGreen;
            this.btLoadDataTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoadDataTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadDataTraining.Location = new System.Drawing.Point(5, 24);
            this.btLoadDataTraining.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadDataTraining.Name = "btLoadDataTraining";
            this.btLoadDataTraining.Size = new System.Drawing.Size(211, 26);
            this.btLoadDataTraining.TabIndex = 25;
            this.btLoadDataTraining.Text = "Load Folder Data Training";
            this.btLoadDataTraining.UseVisualStyleBackColor = false;
            this.btLoadDataTraining.Click += new System.EventHandler(this.btChooseTrainingDir_Click);
            // 
            // btMuatHasilTraining
            // 
            this.btMuatHasilTraining.BackColor = System.Drawing.Color.SpringGreen;
            this.btMuatHasilTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMuatHasilTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMuatHasilTraining.Location = new System.Drawing.Point(15, 523);
            this.btMuatHasilTraining.Name = "btMuatHasilTraining";
            this.btMuatHasilTraining.Size = new System.Drawing.Size(204, 57);
            this.btMuatHasilTraining.TabIndex = 41;
            this.btMuatHasilTraining.Text = "Load Hasil Training";
            this.btMuatHasilTraining.UseVisualStyleBackColor = false;
            this.btMuatHasilTraining.Click += new System.EventHandler(this.btMuatHasilTraining_Click);
            // 
            // lbAkurasi
            // 
            this.lbAkurasi.AutoSize = true;
            this.lbAkurasi.BackColor = System.Drawing.Color.Transparent;
            this.lbAkurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAkurasi.Location = new System.Drawing.Point(758, 478);
            this.lbAkurasi.Name = "lbAkurasi";
            this.lbAkurasi.Size = new System.Drawing.Size(102, 25);
            this.lbAkurasi.TabIndex = 40;
            this.lbAkurasi.Text = "Akurasi : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 481);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(736, 36);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 39;
            // 
            // btTesting
            // 
            this.btTesting.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btTesting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTesting.Location = new System.Drawing.Point(377, 523);
            this.btTesting.Margin = new System.Windows.Forms.Padding(2);
            this.btTesting.Name = "btTesting";
            this.btTesting.Size = new System.Drawing.Size(136, 57);
            this.btTesting.TabIndex = 38;
            this.btTesting.Text = "Predict";
            this.btTesting.UseVisualStyleBackColor = false;
            this.btTesting.Click += new System.EventHandler(this.btTestingProses_Click);
            // 
            // btTraining
            // 
            this.btTraining.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraining.Location = new System.Drawing.Point(224, 523);
            this.btTraining.Margin = new System.Windows.Forms.Padding(2);
            this.btTraining.Name = "btTraining";
            this.btTraining.Size = new System.Drawing.Size(149, 57);
            this.btTraining.TabIndex = 37;
            this.btTraining.Text = "Training";
            this.btTraining.UseVisualStyleBackColor = false;
            this.btTraining.Click += new System.EventHandler(this.btTrainingProses_Click);
            // 
            // classification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.gb_svm_model_file_browser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_dataLatih);
            this.Controls.Add(this.btMuatHasilTraining);
            this.Controls.Add(this.lbAkurasi);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btTesting);
            this.Controls.Add(this.btTraining);
            this.Name = "classification";
            this.Size = new System.Drawing.Size(1192, 707);
            this.gb_svm_model_file_browser.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUji)).EndInit();
            this.gb_dataLatih.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataLatih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_svm_model_file_browser;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;

        public System.Windows.Forms.DataGridView dgvDataUji;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button gb_dataTestin;
        private System.Windows.Forms.GroupBox gb_dataLatih;
        private System.Windows.Forms.Button button1;

        public System.Windows.Forms.DataGridView dgvDataLatih;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.Button btLoadDataTraining;
        public System.Windows.Forms.Button btMuatHasilTraining;
        private System.Windows.Forms.Label lbAkurasi;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button btTesting;
        public System.Windows.Forms.Button btTraining;
    }
}
