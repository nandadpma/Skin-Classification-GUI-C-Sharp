namespace SkinClassification
{
    partial class configuration
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
            this.pnSVM = new System.Windows.Forms.Panel();
            this.pnGLCM = new System.Windows.Forms.Panel();
            this.btUpdateGLCM = new System.Windows.Forms.Button();
            this.clbFit = new System.Windows.Forms.CheckedListBox();
            this.lbFitur = new System.Windows.Forms.Label();
            this.clbDir = new System.Windows.Forms.CheckedListBox();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.lbDirection = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.pnGLCM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSVM
            // 
            this.pnSVM.BackColor = System.Drawing.Color.Transparent;
            this.pnSVM.Location = new System.Drawing.Point(556, 3);
            this.pnSVM.Name = "pnSVM";
            this.pnSVM.Size = new System.Drawing.Size(516, 230);
            this.pnSVM.TabIndex = 5;
            // 
            // pnGLCM
            // 
            this.pnGLCM.BackColor = System.Drawing.Color.Transparent;
            this.pnGLCM.Controls.Add(this.btUpdateGLCM);
            this.pnGLCM.Controls.Add(this.clbFit);
            this.pnGLCM.Controls.Add(this.lbFitur);
            this.pnGLCM.Controls.Add(this.clbDir);
            this.pnGLCM.Controls.Add(this.numDistance);
            this.pnGLCM.Controls.Add(this.lbDirection);
            this.pnGLCM.Controls.Add(this.lbDistance);
            this.pnGLCM.Location = new System.Drawing.Point(18, 3);
            this.pnGLCM.Name = "pnGLCM";
            this.pnGLCM.Size = new System.Drawing.Size(532, 230);
            this.pnGLCM.TabIndex = 4;
            // 
            // btUpdateGLCM
            // 
            this.btUpdateGLCM.Location = new System.Drawing.Point(399, 182);
            this.btUpdateGLCM.Name = "btUpdateGLCM";
            this.btUpdateGLCM.Size = new System.Drawing.Size(121, 38);
            this.btUpdateGLCM.TabIndex = 13;
            this.btUpdateGLCM.Text = "Simpan";
            this.btUpdateGLCM.UseVisualStyleBackColor = true;
            this.btUpdateGLCM.Click += new System.EventHandler(this.btUpdateGLCM_Click);
            // 
            // clbFit
            // 
            this.clbFit.AllowDrop = true;
            this.clbFit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbFit.CheckOnClick = true;
            this.clbFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbFit.FormattingEnabled = true;
            this.clbFit.Location = new System.Drawing.Point(92, 118);
            this.clbFit.Name = "clbFit";
            this.clbFit.Size = new System.Drawing.Size(121, 102);
            this.clbFit.TabIndex = 12;
            // 
            // lbFitur
            // 
            this.lbFitur.AutoSize = true;
            this.lbFitur.Location = new System.Drawing.Point(3, 118);
            this.lbFitur.Name = "lbFitur";
            this.lbFitur.Size = new System.Drawing.Size(36, 13);
            this.lbFitur.TabIndex = 11;
            this.lbFitur.Text = "Fitur : ";
            // 
            // clbDir
            // 
            this.clbDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDir.CheckOnClick = true;
            this.clbDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDir.FormattingEnabled = true;
            this.clbDir.Location = new System.Drawing.Point(93, 39);
            this.clbDir.Name = "clbDir";
            this.clbDir.Size = new System.Drawing.Size(121, 68);
            this.clbDir.TabIndex = 10;
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(93, 7);
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(120, 20);
            this.numDistance.TabIndex = 9;
            this.numDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDirection
            // 
            this.lbDirection.AutoSize = true;
            this.lbDirection.Location = new System.Drawing.Point(2, 39);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(58, 13);
            this.lbDirection.TabIndex = 8;
            this.lbDirection.Text = "Direction : ";
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.Location = new System.Drawing.Point(3, 9);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(58, 13);
            this.lbDistance.TabIndex = 7;
            this.lbDistance.Text = "Distance : ";
            // 
            // configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnSVM);
            this.Controls.Add(this.pnGLCM);
            this.Name = "configuration";
            this.Size = new System.Drawing.Size(1192, 707);
            this.pnGLCM.ResumeLayout(false);
            this.pnGLCM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSVM;
        private System.Windows.Forms.Panel pnGLCM;
        private System.Windows.Forms.Button btUpdateGLCM;
        public System.Windows.Forms.CheckedListBox clbFit;
        private System.Windows.Forms.Label lbFitur;
        public System.Windows.Forms.CheckedListBox clbDir;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.Label lbDirection;
        private System.Windows.Forms.Label lbDistance;
    }
}
