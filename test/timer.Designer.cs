namespace test
{
    partial class timer
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.sonudSlect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slectedSound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 40);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(256, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "起床アラーム機能";
            // 
            // sonudSlect
            // 
            this.sonudSlect.Location = new System.Drawing.Point(262, 221);
            this.sonudSlect.Name = "sonudSlect";
            this.sonudSlect.Size = new System.Drawing.Size(145, 63);
            this.sonudSlect.TabIndex = 2;
            this.sonudSlect.Text = "soundSlect";
            this.sonudSlect.UseVisualStyleBackColor = true;
            this.sonudSlect.Click += new System.EventHandler(this.sonudSlect_Click);
            // 
            // slectedSound
            // 
            this.slectedSound.AutoSize = true;
            this.slectedSound.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.slectedSound.Location = new System.Drawing.Point(258, 195);
            this.slectedSound.Name = "slectedSound";
            this.slectedSound.Size = new System.Drawing.Size(196, 23);
            this.slectedSound.TabIndex = 3;
            this.slectedSound.Text = "音を選択してください";
            // 
            // timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slectedSound);
            this.Controls.Add(this.sonudSlect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "timer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sonudSlect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label slectedSound;
    }
}