namespace ComboBoxControlStudy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSimple = new System.Windows.Forms.ComboBox();
            this.comboDropDown = new System.Windows.Forms.ComboBox();
            this.comboDropDownList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "DropDown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "DropDownList";
            // 
            // comboSimple
            // 
            this.comboSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboSimple.FormattingEnabled = true;
            this.comboSimple.Location = new System.Drawing.Point(14, 24);
            this.comboSimple.Name = "comboSimple";
            this.comboSimple.Size = new System.Drawing.Size(121, 150);
            this.comboSimple.TabIndex = 3;
            // 
            // comboDropDown
            // 
            this.comboDropDown.FormattingEnabled = true;
            this.comboDropDown.Location = new System.Drawing.Point(141, 24);
            this.comboDropDown.Name = "comboDropDown";
            this.comboDropDown.Size = new System.Drawing.Size(121, 20);
            this.comboDropDown.TabIndex = 4;
            this.comboDropDown.SelectedIndexChanged += new System.EventHandler(this.comboDropDown_SelectedIndexChanged);
            // 
            // comboDropDownList
            // 
            this.comboDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDropDownList.FormattingEnabled = true;
            this.comboDropDownList.Location = new System.Drawing.Point(268, 24);
            this.comboDropDownList.Name = "comboDropDownList";
            this.comboDropDownList.Size = new System.Drawing.Size(121, 20);
            this.comboDropDownList.TabIndex = 5;
            this.comboDropDownList.SelectedIndexChanged += new System.EventHandler(this.comboDropDownList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 180);
            this.Controls.Add(this.comboDropDownList);
            this.Controls.Add(this.comboDropDown);
            this.Controls.Add(this.comboSimple);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSimple;
        private System.Windows.Forms.ComboBox comboDropDown;
        private System.Windows.Forms.ComboBox comboDropDownList;
    }
}

