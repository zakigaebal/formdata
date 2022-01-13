namespace formdata
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.BirthDatepicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(43, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(124, 39);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "이름";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgeLabel
            // 
            this.AgeLabel.Location = new System.Drawing.Point(43, 106);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(124, 39);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "나이";
            this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(43, 204);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(124, 39);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "연락처";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthLabel
            // 
            this.BirthLabel.Location = new System.Drawing.Point(43, 281);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(124, 39);
            this.BirthLabel.TabIndex = 3;
            this.BirthLabel.Text = "생일";
            this.BirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(216, 33);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 21);
            this.NameTxt.TabIndex = 4;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(216, 116);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(100, 21);
            this.AgeTxt.TabIndex = 5;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(216, 214);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(100, 21);
            this.PhoneTxt.TabIndex = 6;
            // 
            // BirthDatepicker
            // 
            this.BirthDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDatepicker.Location = new System.Drawing.Point(216, 288);
            this.BirthDatepicker.Name = "BirthDatepicker";
            this.BirthDatepicker.Size = new System.Drawing.Size(100, 21);
            this.BirthDatepicker.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(81, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(228, 345);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "초기화";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 431);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.BirthDatepicker);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.AgeTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.DateTimePicker BirthDatepicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnReset;
    }
}

