namespace SkinClassification
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_start_classification = new System.Windows.Forms.Button();
            this.bt_configuration = new System.Windows.Forms.Button();
            this.bt_manuals = new System.Windows.Forms.Button();
            this.bt_classification = new System.Windows.Forms.Button();
            this.bt_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 959);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(999, 959);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(69, 13);
            this.lbVersion.TabIndex = 32;
            this.lbVersion.Text = "Version 0.1.7";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.bt_start_classification);
            this.panel1.Controls.Add(this.bt_configuration);
            this.panel1.Controls.Add(this.bt_manuals);
            this.panel1.Controls.Add(this.bt_classification);
            this.panel1.Controls.Add(this.bt_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 729);
            this.panel1.TabIndex = 33;
            // 
            // bt_start_classification
            // 
            this.bt_start_classification.BackColor = System.Drawing.Color.Transparent;
            this.bt_start_classification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_start_classification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start_classification.Image = global::SkinClassification.Properties.Resources.statistics;
            this.bt_start_classification.Location = new System.Drawing.Point(0, 140);
            this.bt_start_classification.Name = "bt_start_classification";
            this.bt_start_classification.Size = new System.Drawing.Size(158, 73);
            this.bt_start_classification.TabIndex = 4;
            this.bt_start_classification.Text = "   Classification";
            this.bt_start_classification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_start_classification.UseVisualStyleBackColor = false;
            this.bt_start_classification.Visible = false;
            this.bt_start_classification.Click += new System.EventHandler(this.bt_start_classification_Click);
            // 
            // bt_configuration
            // 
            this.bt_configuration.BackColor = System.Drawing.Color.Transparent;
            this.bt_configuration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_configuration.Image = global::SkinClassification.Properties.Resources.screwdriver_and_wrench;
            this.bt_configuration.Location = new System.Drawing.Point(0, 210);
            this.bt_configuration.Name = "bt_configuration";
            this.bt_configuration.Size = new System.Drawing.Size(158, 73);
            this.bt_configuration.TabIndex = 3;
            this.bt_configuration.Text = "   Configuration";
            this.bt_configuration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_configuration.UseVisualStyleBackColor = false;
            this.bt_configuration.Visible = false;
            this.bt_configuration.Click += new System.EventHandler(this.Bt_configuration_Click);
            // 
            // bt_manuals
            // 
            this.bt_manuals.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_manuals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_manuals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_manuals.Image = global::SkinClassification.Properties.Resources.study;
            this.bt_manuals.Location = new System.Drawing.Point(0, 140);
            this.bt_manuals.Name = "bt_manuals";
            this.bt_manuals.Size = new System.Drawing.Size(158, 73);
            this.bt_manuals.TabIndex = 2;
            this.bt_manuals.Text = "   Manuals";
            this.bt_manuals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_manuals.UseVisualStyleBackColor = false;
            this.bt_manuals.Click += new System.EventHandler(this.Bt_usermanuals_Click);
            // 
            // bt_classification
            // 
            this.bt_classification.BackColor = System.Drawing.Color.Transparent;
            this.bt_classification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_classification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_classification.Image = global::SkinClassification.Properties.Resources.quality;
            this.bt_classification.Location = new System.Drawing.Point(0, 70);
            this.bt_classification.Name = "bt_classification";
            this.bt_classification.Size = new System.Drawing.Size(158, 73);
            this.bt_classification.TabIndex = 1;
            this.bt_classification.Text = "Classification";
            this.bt_classification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_classification.UseVisualStyleBackColor = false;
            this.bt_classification.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_menu
            // 
            this.bt_menu.BackColor = System.Drawing.Color.Transparent;
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menu.Image = global::SkinClassification.Properties.Resources.menu_button2;
            this.bt_menu.Location = new System.Drawing.Point(0, 0);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(158, 73);
            this.bt_menu.TabIndex = 0;
            this.bt_menu.Text = "   Menu";
            this.bt_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_menu.UseVisualStyleBackColor = false;
            this.bt_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(158, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 729);
            this.panel2.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skin Classification";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.CheckedListBox clbFitur;
        private static System.Windows.Forms.CheckedListBox clbFitur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_manuals;
        private System.Windows.Forms.Button bt_classification;
        private System.Windows.Forms.Button bt_menu;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_configuration;
        private System.Windows.Forms.Button bt_start_classification;
    }
}

