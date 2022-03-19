namespace BilgeAdam.ADONET.LoginPage
{
    partial class frmForgotPassword
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSecurityQuestionArea = new System.Windows.Forms.GroupBox();
            this.btnSendAnswer = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSecurityQuestionArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(247, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(268, 23);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email adresinizi giriniz.";
            // 
            // grpSecurityQuestionArea
            // 
            this.grpSecurityQuestionArea.Controls.Add(this.btnSendAnswer);
            this.grpSecurityQuestionArea.Controls.Add(this.lbl_Question);
            this.grpSecurityQuestionArea.Controls.Add(this.label3);
            this.grpSecurityQuestionArea.Controls.Add(this.label2);
            this.grpSecurityQuestionArea.Controls.Add(this.txtAnswer);
            this.grpSecurityQuestionArea.Location = new System.Drawing.Point(247, 238);
            this.grpSecurityQuestionArea.Name = "grpSecurityQuestionArea";
            this.grpSecurityQuestionArea.Size = new System.Drawing.Size(268, 268);
            this.grpSecurityQuestionArea.TabIndex = 2;
            this.grpSecurityQuestionArea.TabStop = false;
            this.grpSecurityQuestionArea.Visible = false;
            // 
            // btnSendAnswer
            // 
            this.btnSendAnswer.Location = new System.Drawing.Point(73, 200);
            this.btnSendAnswer.Name = "btnSendAnswer";
            this.btnSendAnswer.Size = new System.Drawing.Size(126, 45);
            this.btnSendAnswer.TabIndex = 2;
            this.btnSendAnswer.Text = "Gönder";
            this.btnSendAnswer.UseVisualStyleBackColor = true;
            this.btnSendAnswer.Click += new System.EventHandler(this.btnSendAnswer_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(16, 66);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(0, 15);
            this.lbl_Question.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cevap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(6, 157);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PlaceholderText = "Answer";
            this.txtAnswer.Size = new System.Drawing.Size(256, 23);
            this.txtAnswer.TabIndex = 0;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(320, 146);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(126, 45);
            this.btnSendEmail.TabIndex = 2;
            this.btnSendEmail.Text = "Gönder";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 574);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.grpSecurityQuestionArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password Page";
            this.grpSecurityQuestionArea.ResumeLayout(false);
            this.grpSecurityQuestionArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private GroupBox grpSecurityQuestionArea;
        private Label lbl_Question;
        private Label label2;
        private Label label3;
        private TextBox txtAnswer;
        private Button btnSendAnswer;
        private Button btnSendEmail;
        private ErrorProvider erp;
    }
}