namespace KakaoTalkDelAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.step01 = new System.Windows.Forms.Label();
            this.step02 = new System.Windows.Forms.Label();
            this.step03 = new System.Windows.Forms.Label();
            this.step00 = new System.Windows.Forms.Label();
            this.waitForKatalk = new System.Windows.Forms.Timer(this.components);
            this.waitForExit = new System.Windows.Forms.Timer(this.components);
            this.btnShowLog = new System.Windows.Forms.Button();
            this.weblink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // step01
            // 
            this.step01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.step01.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.step01.Location = new System.Drawing.Point(40, 53);
            this.step01.Margin = new System.Windows.Forms.Padding(0);
            this.step01.Name = "step01";
            this.step01.Size = new System.Drawing.Size(300, 44);
            this.step01.TabIndex = 0;
            this.step01.Text = "Launching KakaoTalk\r\n카카오톡 실행 중";
            this.step01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step02
            // 
            this.step02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.step02.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.step02.Location = new System.Drawing.Point(40, 97);
            this.step02.Margin = new System.Windows.Forms.Padding(0);
            this.step02.Name = "step02";
            this.step02.Size = new System.Drawing.Size(300, 44);
            this.step02.TabIndex = 0;
            this.step02.Text = "Hiding ads from KakaoTalk\r\n카카오톡에서 광고 숨기는 중";
            this.step02.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step03
            // 
            this.step03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.step03.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.step03.Location = new System.Drawing.Point(40, 141);
            this.step03.Margin = new System.Windows.Forms.Padding(0);
            this.step03.Name = "step03";
            this.step03.Size = new System.Drawing.Size(300, 44);
            this.step03.TabIndex = 0;
            this.step03.Text = "Finished. This window will close in few seconds.\r\n완료. 수 초 내로 종료됩니다.";
            this.step03.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step00
            // 
            this.step00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.step00.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.step00.Location = new System.Drawing.Point(40, 9);
            this.step00.Margin = new System.Windows.Forms.Padding(0);
            this.step00.Name = "step00";
            this.step00.Size = new System.Drawing.Size(300, 44);
            this.step00.TabIndex = 0;
            this.step00.Text = "Searching KakaoTalk\r\n카카오톡 찾는 중";
            this.step00.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // waitForKatalk
            // 
            this.waitForKatalk.Interval = 1000;
            this.waitForKatalk.Tick += new System.EventHandler(this.waitForKatalk_Tick);
            // 
            // waitForExit
            // 
            this.waitForExit.Interval = 1000;
            this.waitForExit.Tick += new System.EventHandler(this.waitForExit_Tick);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnShowLog.Location = new System.Drawing.Point(17, 181);
            this.btnShowLog.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(350, 31);
            this.btnShowLog.TabIndex = 1;
            this.btnShowLog.Text = "Show logs | 로그 보기";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // weblink
            // 
            this.weblink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weblink.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Underline);
            this.weblink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.weblink.Location = new System.Drawing.Point(40, 218);
            this.weblink.Margin = new System.Windows.Forms.Padding(0);
            this.weblink.Name = "weblink";
            this.weblink.Size = new System.Drawing.Size(300, 15);
            this.weblink.TabIndex = 2;
            this.weblink.Text = "GitHub";
            this.weblink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.weblink.Click += new System.EventHandler(this.weblink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 240);
            this.Controls.Add(this.weblink);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.step03);
            this.Controls.Add(this.step02);
            this.Controls.Add(this.step00);
            this.Controls.Add(this.step01);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KakaoTalkDelAD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label step01;
        private System.Windows.Forms.Label step02;
        private System.Windows.Forms.Label step03;
        private System.Windows.Forms.Label step00;
        private System.Windows.Forms.Timer waitForKatalk;
        private System.Windows.Forms.Timer waitForExit;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Label weblink;
    }
}

