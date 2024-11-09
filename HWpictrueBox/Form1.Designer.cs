namespace HWpictrueBox
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptBox1 = new System.Windows.Forms.PictureBox();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimeEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptBox1
            // 
            this.ptBox1.Location = new System.Drawing.Point(136, 38);
            this.ptBox1.Name = "ptBox1";
            this.ptBox1.Size = new System.Drawing.Size(400, 300);
            this.ptBox1.TabIndex = 0;
            this.ptBox1.TabStop = false;
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(136, 353);
            this.txbPath.Multiline = true;
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(400, 22);
            this.txbPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "圖片路徑";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(54, 405);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(111, 23);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "選擇路徑(*.png)";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(245, 405);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "<<";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(342, 405);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = ">>";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(473, 405);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 6;
            this.btnTime.Text = "幻燈片";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimeEnd
            // 
            this.btnTimeEnd.Location = new System.Drawing.Point(554, 405);
            this.btnTimeEnd.Name = "btnTimeEnd";
            this.btnTimeEnd.Size = new System.Drawing.Size(75, 23);
            this.btnTimeEnd.TabIndex = 7;
            this.btnTimeEnd.Text = "結束幻燈片";
            this.btnTimeEnd.UseVisualStyleBackColor = true;
            this.btnTimeEnd.Click += new System.EventHandler(this.btnTimeEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 466);
            this.Controls.Add(this.btnTimeEnd);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.ptBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptBox1;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTimeEnd;
    }
}

