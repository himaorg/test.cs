namespace test
{
    partial class index
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.titleChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.termsOfUse_check = new System.Windows.Forms.CheckBox();
            this.privacyPolicy_check = new System.Windows.Forms.CheckBox();
            this.messegeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(180, 40);
            this.title.TabIndex = 0;
            this.title.Text = "HIMAORG";
            this.title.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // titleChange
            // 
            this.titleChange.Location = new System.Drawing.Point(19, 52);
            this.titleChange.Name = "titleChange";
            this.titleChange.Size = new System.Drawing.Size(186, 55);
            this.titleChange.TabIndex = 1;
            this.titleChange.Text = "titleChange";
            this.titleChange.UseVisualStyleBackColor = true;
            this.titleChange.MouseLeave += new System.EventHandler(this.titleChange_MouseLeave);
            this.titleChange.MouseHover += new System.EventHandler(this.titleChange_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "ゲームを開始するためには以下に同意する必要があります";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(12, 331);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(122, 39);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // termsOfUse_check
            // 
            this.termsOfUse_check.AutoSize = true;
            this.termsOfUse_check.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.termsOfUse_check.Location = new System.Drawing.Point(19, 197);
            this.termsOfUse_check.Name = "termsOfUse_check";
            this.termsOfUse_check.Size = new System.Drawing.Size(323, 38);
            this.termsOfUse_check.TabIndex = 4;
            this.termsOfUse_check.Text = "利用規約に同意する";
            this.termsOfUse_check.UseVisualStyleBackColor = true;
            // 
            // privacyPolicy_check
            // 
            this.privacyPolicy_check.AutoSize = true;
            this.privacyPolicy_check.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.privacyPolicy_check.Location = new System.Drawing.Point(19, 241);
            this.privacyPolicy_check.Name = "privacyPolicy_check";
            this.privacyPolicy_check.Size = new System.Drawing.Size(451, 38);
            this.privacyPolicy_check.TabIndex = 5;
            this.privacyPolicy_check.Text = "プライバシーポリシーに同意する";
            this.privacyPolicy_check.UseVisualStyleBackColor = true;
            // 
            // messegeBox
            // 
            this.messegeBox.AutoSize = true;
            this.messegeBox.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.messegeBox.Location = new System.Drawing.Point(760, 336);
            this.messegeBox.Name = "messegeBox";
            this.messegeBox.Size = new System.Drawing.Size(49, 34);
            this.messegeBox.TabIndex = 6;
            this.messegeBox.Text = "…";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 525);
            this.Controls.Add(this.messegeBox);
            this.Controls.Add(this.privacyPolicy_check);
            this.Controls.Add(this.termsOfUse_check);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleChange);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "HIMAORG-test-app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button titleChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.CheckBox termsOfUse_check;
        private System.Windows.Forms.CheckBox privacyPolicy_check;
        private System.Windows.Forms.Label messegeBox;
    }
}

