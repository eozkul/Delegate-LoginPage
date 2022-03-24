namespace BilgeAdam.Events
{
    partial class frmMain
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
            this.lstParents = new System.Windows.Forms.ListBox();
            this.grbNewParent = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grbMatch = new System.Windows.Forms.GroupBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.cmbParents = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisplayBirthDate = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.grbNewParent.SuspendLayout();
            this.grbMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstParents
            // 
            this.lstParents.FormattingEnabled = true;
            this.lstParents.ItemHeight = 15;
            this.lstParents.Location = new System.Drawing.Point(12, 12);
            this.lstParents.Name = "lstParents";
            this.lstParents.Size = new System.Drawing.Size(258, 454);
            this.lstParents.TabIndex = 0;
            this.lstParents.SelectedIndexChanged += new System.EventHandler(this.lstParents_SelectedIndexChanged);
            // 
            // grbNewParent
            // 
            this.grbNewParent.Controls.Add(this.btnSave);
            this.grbNewParent.Controls.Add(this.rdbMale);
            this.grbNewParent.Controls.Add(this.rdbFemale);
            this.grbNewParent.Controls.Add(this.dtpBirthDate);
            this.grbNewParent.Controls.Add(this.label2);
            this.grbNewParent.Controls.Add(this.label1);
            this.grbNewParent.Controls.Add(this.txtName);
            this.grbNewParent.Location = new System.Drawing.Point(301, 12);
            this.grbNewParent.Name = "grbNewParent";
            this.grbNewParent.Size = new System.Drawing.Size(334, 197);
            this.grbNewParent.TabIndex = 1;
            this.grbNewParent.TabStop = false;
            this.grbNewParent.Text = "Yeni Kişi tanımı";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(164, 117);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(53, 19);
            this.rdbMale.TabIndex = 3;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Erkek";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(103, 117);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(55, 19);
            this.rdbFemale.TabIndex = 3;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Kadın";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(103, 73);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(213, 23);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 23);
            this.txtName.TabIndex = 0;
            // 
            // grbMatch
            // 
            this.grbMatch.Controls.Add(this.btnMatch);
            this.grbMatch.Controls.Add(this.cmbParents);
            this.grbMatch.Controls.Add(this.label4);
            this.grbMatch.Controls.Add(this.label3);
            this.grbMatch.Controls.Add(this.txtDisplayBirthDate);
            this.grbMatch.Controls.Add(this.txtDisplayName);
            this.grbMatch.Location = new System.Drawing.Point(301, 229);
            this.grbMatch.Name = "grbMatch";
            this.grbMatch.Size = new System.Drawing.Size(334, 197);
            this.grbMatch.TabIndex = 1;
            this.grbMatch.TabStop = false;
            this.grbMatch.Text = "Nikah Masası";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(227, 146);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 3;
            this.btnMatch.Text = "Eşleştir";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // cmbParents
            // 
            this.cmbParents.FormattingEnabled = true;
            this.cmbParents.Location = new System.Drawing.Point(103, 108);
            this.cmbParents.Name = "cmbParents";
            this.cmbParents.Size = new System.Drawing.Size(199, 23);
            this.cmbParents.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad Soyad";
            // 
            // txtDisplayBirthDate
            // 
            this.txtDisplayBirthDate.Location = new System.Drawing.Point(104, 64);
            this.txtDisplayBirthDate.Name = "txtDisplayBirthDate";
            this.txtDisplayBirthDate.Size = new System.Drawing.Size(198, 23);
            this.txtDisplayBirthDate.TabIndex = 0;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(104, 35);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(198, 23);
            this.txtDisplayName.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 491);
            this.Controls.Add(this.grbMatch);
            this.Controls.Add(this.grbNewParent);
            this.Controls.Add(this.lstParents);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbNewParent.ResumeLayout(false);
            this.grbNewParent.PerformLayout();
            this.grbMatch.ResumeLayout(false);
            this.grbMatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstParents;
        private GroupBox grbNewParent;
        private Button btnSave;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private DateTimePicker dtpBirthDate;
        private Label label1;
        private TextBox txtName;
        private GroupBox grbMatch;
        private Label label2;
        private Button btnMatch;
        private ComboBox cmbParents;
        private Label label4;
        private Label label3;
        private TextBox txtDisplayBirthDate;
        private TextBox txtDisplayName;
    }
}