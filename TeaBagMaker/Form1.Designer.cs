namespace TeaBagMaker
{
    partial class TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.teaList = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // teaList
            // 
            this.teaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teaList.FormattingEnabled = true;
            this.teaList.Location = new System.Drawing.Point(12, 12);
            this.teaList.Name = "teaList";
            this.teaList.Size = new System.Drawing.Size(293, 20);
            this.teaList.TabIndex = 0;
            this.teaList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(13, 39);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(93, 12);
            this.time.TabIndex = 1;
            this.time.Text = "해당 차의 시간: ";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(15, 66);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(290, 41);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "담그기";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // txtCountDown
            // 
            this.txtCountDown.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCountDown.Location = new System.Drawing.Point(15, 122);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(290, 38);
            this.txtCountDown.TabIndex = 3;
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "3214 이유진";
            // 
            // TeaBagMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.time);
            this.Controls.Add(this.teaList);
            this.Name = "TeaBagMaker";
            this.Text = "TeaBagMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teaList;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.TextBox textBox1;
    }
}

