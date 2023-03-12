namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoctorsGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecializationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Specializations = new System.Windows.Forms.TabPage();
            this.DocWithSpecLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateSpecButton = new System.Windows.Forms.Button();
            this.DeleteSpecButton = new System.Windows.Forms.Button();
            this.CreateSpecButton = new System.Windows.Forms.Button();
            this.NameSpec = new System.Windows.Forms.TextBox();
            this.NameSpecLabel = new System.Windows.Forms.Label();
            this.SpecializationsGridView = new System.Windows.Forms.DataGridView();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctors = new System.Windows.Forms.TabPage();
            this.SpecId = new System.Windows.Forms.ComboBox();
            this.lastCertLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteDocButton = new System.Windows.Forms.Button();
            this.UpdateDocButton = new System.Windows.Forms.Button();
            this.CreateDocButton = new System.Windows.Forms.Button();
            this.DocName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Certificates = new System.Windows.Forms.TabPage();
            this.DocId = new System.Windows.Forms.ComboBox();
            this.SpecTypeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteCertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateCertButton = new System.Windows.Forms.Button();
            this.CreateCertButton = new System.Windows.Forms.Button();
            this.Descripption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CertificatesGridView = new System.Windows.Forms.DataGridView();
            this.Iddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Specializations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecializationsGridView)).BeginInit();
            this.Doctors.SuspendLayout();
            this.Certificates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorsGridView
            // 
            this.DoctorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SpecializationId,
            this.Name});
            this.DoctorsGridView.Location = new System.Drawing.Point(6, 6);
            this.DoctorsGridView.Name = "DoctorsGridView";
            this.DoctorsGridView.ReadOnly = true;
            this.DoctorsGridView.RowHeadersWidth = 82;
            this.DoctorsGridView.RowTemplate.Height = 41;
            this.DoctorsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorsGridView.Size = new System.Drawing.Size(920, 437);
            this.DoctorsGridView.TabIndex = 0;
            this.DoctorsGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseDoctorsClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 200;
            // 
            // SpecializationId
            // 
            this.SpecializationId.HeaderText = "SpecializationId";
            this.SpecializationId.MinimumWidth = 10;
            this.SpecializationId.Name = "SpecializationId";
            this.SpecializationId.ReadOnly = true;
            this.SpecializationId.Width = 200;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Specializations);
            this.tabControl1.Controls.Add(this.Doctors);
            this.tabControl1.Controls.Add(this.Certificates);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 689);
            this.tabControl1.TabIndex = 1;
            // 
            // Specializations
            // 
            this.Specializations.Controls.Add(this.DocWithSpecLabel);
            this.Specializations.Controls.Add(this.label6);
            this.Specializations.Controls.Add(this.UpdateSpecButton);
            this.Specializations.Controls.Add(this.DeleteSpecButton);
            this.Specializations.Controls.Add(this.CreateSpecButton);
            this.Specializations.Controls.Add(this.NameSpec);
            this.Specializations.Controls.Add(this.NameSpecLabel);
            this.Specializations.Controls.Add(this.SpecializationsGridView);
            this.Specializations.Location = new System.Drawing.Point(8, 46);
            this.Specializations.Name = "Specializations";
            this.Specializations.Padding = new System.Windows.Forms.Padding(3);
            this.Specializations.Size = new System.Drawing.Size(1153, 635);
            this.Specializations.TabIndex = 1;
            this.Specializations.Text = "Specializations";
            this.Specializations.UseVisualStyleBackColor = true;
            // 
            // DocWithSpecLabel
            // 
            this.DocWithSpecLabel.AutoSize = true;
            this.DocWithSpecLabel.Location = new System.Drawing.Point(371, 524);
            this.DocWithSpecLabel.Name = "DocWithSpecLabel";
            this.DocWithSpecLabel.Size = new System.Drawing.Size(0, 32);
            this.DocWithSpecLabel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doctors with such specialization:";
            // 
            // UpdateSpecButton
            // 
            this.UpdateSpecButton.Location = new System.Drawing.Point(452, 449);
            this.UpdateSpecButton.Name = "UpdateSpecButton";
            this.UpdateSpecButton.Size = new System.Drawing.Size(150, 46);
            this.UpdateSpecButton.TabIndex = 7;
            this.UpdateSpecButton.Text = "Update";
            this.UpdateSpecButton.UseVisualStyleBackColor = true;
            this.UpdateSpecButton.Visible = false;
            this.UpdateSpecButton.Click += new System.EventHandler(this.UpdateSpecButton_Click);
            // 
            // DeleteSpecButton
            // 
            this.DeleteSpecButton.Location = new System.Drawing.Point(932, 6);
            this.DeleteSpecButton.Name = "DeleteSpecButton";
            this.DeleteSpecButton.Size = new System.Drawing.Size(150, 46);
            this.DeleteSpecButton.TabIndex = 6;
            this.DeleteSpecButton.Text = "Delete";
            this.DeleteSpecButton.UseVisualStyleBackColor = true;
            this.DeleteSpecButton.Visible = false;
            this.DeleteSpecButton.Click += new System.EventHandler(this.DeleteSpecButton_Click);
            // 
            // CreateSpecButton
            // 
            this.CreateSpecButton.Location = new System.Drawing.Point(296, 449);
            this.CreateSpecButton.Name = "CreateSpecButton";
            this.CreateSpecButton.Size = new System.Drawing.Size(150, 46);
            this.CreateSpecButton.TabIndex = 5;
            this.CreateSpecButton.Text = "Create";
            this.CreateSpecButton.UseVisualStyleBackColor = true;
            this.CreateSpecButton.Click += new System.EventHandler(this.CreateSpecButton_Click);
            // 
            // NameSpec
            // 
            this.NameSpec.Location = new System.Drawing.Point(90, 449);
            this.NameSpec.Name = "NameSpec";
            this.NameSpec.Size = new System.Drawing.Size(200, 39);
            this.NameSpec.TabIndex = 4;
            // 
            // NameSpecLabel
            // 
            this.NameSpecLabel.AutoSize = true;
            this.NameSpecLabel.Location = new System.Drawing.Point(6, 446);
            this.NameSpecLabel.Name = "NameSpecLabel";
            this.NameSpecLabel.Size = new System.Drawing.Size(78, 32);
            this.NameSpecLabel.TabIndex = 3;
            this.NameSpecLabel.Text = "Name";
            // 
            // SpecializationsGridView
            // 
            this.SpecializationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecializationsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.Namme});
            this.SpecializationsGridView.Location = new System.Drawing.Point(6, 6);
            this.SpecializationsGridView.Name = "SpecializationsGridView";
            this.SpecializationsGridView.ReadOnly = true;
            this.SpecializationsGridView.RowHeadersWidth = 82;
            this.SpecializationsGridView.RowTemplate.Height = 41;
            this.SpecializationsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecializationsGridView.Size = new System.Drawing.Size(920, 437);
            this.SpecializationsGridView.TabIndex = 2;
            this.SpecializationsGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseSpecializationsClick);
            // 
            // Idd
            // 
            this.Idd.HeaderText = "Id";
            this.Idd.MinimumWidth = 10;
            this.Idd.Name = "Idd";
            this.Idd.ReadOnly = true;
            this.Idd.Width = 200;
            // 
            // Namme
            // 
            this.Namme.HeaderText = "Name";
            this.Namme.MinimumWidth = 10;
            this.Namme.Name = "Namme";
            this.Namme.ReadOnly = true;
            this.Namme.Width = 200;
            // 
            // Doctors
            // 
            this.Doctors.Controls.Add(this.SpecId);
            this.Doctors.Controls.Add(this.lastCertLabel);
            this.Doctors.Controls.Add(this.label8);
            this.Doctors.Controls.Add(this.DeleteDocButton);
            this.Doctors.Controls.Add(this.UpdateDocButton);
            this.Doctors.Controls.Add(this.CreateDocButton);
            this.Doctors.Controls.Add(this.DocName);
            this.Doctors.Controls.Add(this.label2);
            this.Doctors.Controls.Add(this.label1);
            this.Doctors.Controls.Add(this.DoctorsGridView);
            this.Doctors.Location = new System.Drawing.Point(8, 46);
            this.Doctors.Name = "Doctors";
            this.Doctors.Padding = new System.Windows.Forms.Padding(3);
            this.Doctors.Size = new System.Drawing.Size(1153, 635);
            this.Doctors.TabIndex = 0;
            this.Doctors.Text = "Doctors";
            this.Doctors.UseVisualStyleBackColor = true;
            // 
            // SpecId
            // 
            this.SpecId.FormattingEnabled = true;
            this.SpecId.Location = new System.Drawing.Point(192, 451);
            this.SpecId.Name = "SpecId";
            this.SpecId.Size = new System.Drawing.Size(200, 40);
            this.SpecId.TabIndex = 16;
            // 
            // lastCertLabel
            // 
            this.lastCertLabel.AutoSize = true;
            this.lastCertLabel.Location = new System.Drawing.Point(830, 560);
            this.lastCertLabel.Name = "lastCertLabel";
            this.lastCertLabel.Size = new System.Drawing.Size(0, 32);
            this.lastCertLabel.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date of the last certificate:";
            // 
            // DeleteDocButton
            // 
            this.DeleteDocButton.Location = new System.Drawing.Point(932, 6);
            this.DeleteDocButton.Name = "DeleteDocButton";
            this.DeleteDocButton.Size = new System.Drawing.Size(126, 46);
            this.DeleteDocButton.TabIndex = 13;
            this.DeleteDocButton.Text = "Delete";
            this.DeleteDocButton.UseVisualStyleBackColor = true;
            this.DeleteDocButton.Visible = false;
            this.DeleteDocButton.Click += new System.EventHandler(this.DeleteDocButton_Click);
            // 
            // UpdateDocButton
            // 
            this.UpdateDocButton.Location = new System.Drawing.Point(530, 449);
            this.UpdateDocButton.Name = "UpdateDocButton";
            this.UpdateDocButton.Size = new System.Drawing.Size(126, 46);
            this.UpdateDocButton.TabIndex = 12;
            this.UpdateDocButton.Text = "Update";
            this.UpdateDocButton.UseVisualStyleBackColor = true;
            this.UpdateDocButton.Visible = false;
            this.UpdateDocButton.Click += new System.EventHandler(this.UpdateDocButton_Click);
            // 
            // CreateDocButton
            // 
            this.CreateDocButton.Location = new System.Drawing.Point(398, 449);
            this.CreateDocButton.Name = "CreateDocButton";
            this.CreateDocButton.Size = new System.Drawing.Size(126, 46);
            this.CreateDocButton.TabIndex = 11;
            this.CreateDocButton.Text = "Create";
            this.CreateDocButton.UseVisualStyleBackColor = true;
            this.CreateDocButton.Click += new System.EventHandler(this.CreateDocButton_Click);
            // 
            // DocName
            // 
            this.DocName.Location = new System.Drawing.Point(192, 497);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(200, 39);
            this.DocName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "SpecializationId";
            // 
            // Certificates
            // 
            this.Certificates.Controls.Add(this.DocId);
            this.Certificates.Controls.Add(this.SpecTypeLabel);
            this.Certificates.Controls.Add(this.label7);
            this.Certificates.Controls.Add(this.dateTimePicker);
            this.Certificates.Controls.Add(this.DeleteCertButton);
            this.Certificates.Controls.Add(this.label5);
            this.Certificates.Controls.Add(this.UpdateCertButton);
            this.Certificates.Controls.Add(this.CreateCertButton);
            this.Certificates.Controls.Add(this.Descripption);
            this.Certificates.Controls.Add(this.label3);
            this.Certificates.Controls.Add(this.label4);
            this.Certificates.Controls.Add(this.CertificatesGridView);
            this.Certificates.Location = new System.Drawing.Point(8, 46);
            this.Certificates.Name = "Certificates";
            this.Certificates.Size = new System.Drawing.Size(1153, 635);
            this.Certificates.TabIndex = 2;
            this.Certificates.Text = "Certificates";
            this.Certificates.UseVisualStyleBackColor = true;
            // 
            // DocId
            // 
            this.DocId.FormattingEnabled = true;
            this.DocId.Location = new System.Drawing.Point(144, 440);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(200, 40);
            this.DocId.TabIndex = 25;
            // 
            // SpecTypeLabel
            // 
            this.SpecTypeLabel.AutoSize = true;
            this.SpecTypeLabel.Location = new System.Drawing.Point(768, 533);
            this.SpecTypeLabel.Name = "SpecTypeLabel";
            this.SpecTypeLabel.Size = new System.Drawing.Size(0, 32);
            this.SpecTypeLabel.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Type of specialization:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(144, 533);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(290, 39);
            this.dateTimePicker.TabIndex = 22;
            // 
            // DeleteCertButton
            // 
            this.DeleteCertButton.Location = new System.Drawing.Point(1024, 3);
            this.DeleteCertButton.Name = "DeleteCertButton";
            this.DeleteCertButton.Size = new System.Drawing.Size(126, 46);
            this.DeleteCertButton.TabIndex = 21;
            this.DeleteCertButton.Text = "Delete";
            this.DeleteCertButton.UseVisualStyleBackColor = true;
            this.DeleteCertButton.Visible = false;
            this.DeleteCertButton.Click += new System.EventHandler(this.DeleteCertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date";
            // 
            // UpdateCertButton
            // 
            this.UpdateCertButton.Location = new System.Drawing.Point(579, 443);
            this.UpdateCertButton.Name = "UpdateCertButton";
            this.UpdateCertButton.Size = new System.Drawing.Size(126, 46);
            this.UpdateCertButton.TabIndex = 18;
            this.UpdateCertButton.Text = "Update";
            this.UpdateCertButton.UseVisualStyleBackColor = true;
            this.UpdateCertButton.Visible = false;
            this.UpdateCertButton.Click += new System.EventHandler(this.UpdateCertButton_Click);
            // 
            // CreateCertButton
            // 
            this.CreateCertButton.Location = new System.Drawing.Point(447, 443);
            this.CreateCertButton.Name = "CreateCertButton";
            this.CreateCertButton.Size = new System.Drawing.Size(126, 46);
            this.CreateCertButton.TabIndex = 17;
            this.CreateCertButton.Text = "Create";
            this.CreateCertButton.UseVisualStyleBackColor = true;
            this.CreateCertButton.Click += new System.EventHandler(this.CreateCertButton_Click);
            // 
            // Descripption
            // 
            this.Descripption.Location = new System.Drawing.Point(144, 488);
            this.Descripption.Name = "Descripption";
            this.Descripption.Size = new System.Drawing.Size(200, 39);
            this.Descripption.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "DoctorId";
            // 
            // CertificatesGridView
            // 
            this.CertificatesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CertificatesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iddd,
            this.DoctorId,
            this.Description,
            this.Date});
            this.CertificatesGridView.Location = new System.Drawing.Point(3, 0);
            this.CertificatesGridView.Name = "CertificatesGridView";
            this.CertificatesGridView.ReadOnly = true;
            this.CertificatesGridView.RowHeadersWidth = 82;
            this.CertificatesGridView.RowTemplate.Height = 41;
            this.CertificatesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CertificatesGridView.Size = new System.Drawing.Size(1015, 437);
            this.CertificatesGridView.TabIndex = 3;
            this.CertificatesGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseCertificatesClick);
            // 
            // Iddd
            // 
            this.Iddd.HeaderText = "Id";
            this.Iddd.MinimumWidth = 10;
            this.Iddd.Name = "Iddd";
            this.Iddd.ReadOnly = true;
            this.Iddd.Width = 200;
            // 
            // DoctorId
            // 
            this.DoctorId.HeaderText = "DoctorId";
            this.DoctorId.MinimumWidth = 10;
            this.DoctorId.Name = "DoctorId";
            this.DoctorId.ReadOnly = true;
            this.DoctorId.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 10;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 740);
            this.Controls.Add(this.tabControl1);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Specializations.ResumeLayout(false);
            this.Specializations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecializationsGridView)).EndInit();
            this.Doctors.ResumeLayout(false);
            this.Doctors.PerformLayout();
            this.Certificates.ResumeLayout(false);
            this.Certificates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DoctorsGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SpecializationId;
        private DataGridViewTextBoxColumn Name;
        private TabControl tabControl1;
        private TabPage Doctors;
        private TabPage Specializations;
        private DataGridView SpecializationsGridView;
        private DataGridViewTextBoxColumn Idd;
        private DataGridViewTextBoxColumn Namme;
        private TabPage Certificates;
        private DataGridView CertificatesGridView;
        private DataGridViewTextBoxColumn Iddd;
        private DataGridViewTextBoxColumn DoctorId;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private Label NameSpecLabel;
        private TextBox NameSpec;
        private Button CreateSpecButton;
        private Button DeleteSpecButton;
        private Button UpdateSpecButton;
        private Button CreateDocButton;
        private TextBox DocName;
        private Label label2;
        private Label label1;
        private Button DeleteDocButton;
        private Button UpdateDocButton;
        private DateTimePicker dateTimePicker;
        private Button DeleteCertButton;
        private Label label5;
        private Button UpdateCertButton;
        private Button CreateCertButton;
        private TextBox Descripption;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label DocWithSpecLabel;
        private Label SpecTypeLabel;
        private Label label7;
        private Label lastCertLabel;
        private Label label8;
        private ComboBox SpecId;
        private ComboBox DocId;
    }
}