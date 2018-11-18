namespace ComSend
{
    partial class FrmComSend
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ComName = new System.IO.Ports.SerialPort(this.components);
            this.BtnRead = new System.Windows.Forms.Button();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtSeparator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPackageHead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPackageTail = new System.Windows.Forms.TextBox();
            this.BtnSent = new System.Windows.Forms.Button();
            this.TxtComPortName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtComSet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnComOpen = new System.Windows.Forms.Button();
            this.LabelComStatus = new System.Windows.Forms.Label();
            this.TxtTimeInteval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCharNums = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(181, 172);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(100, 23);
            this.BtnRead.TabIndex = 0;
            this.BtnRead.Text = "读数据处理";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(125, 13);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(165, 21);
            this.TxtFileName.TabIndex = 1;
            this.TxtFileName.Text = "aaa.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据文件名：";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TxtSeparator
            // 
            this.TxtSeparator.Location = new System.Drawing.Point(125, 44);
            this.TxtSeparator.Name = "TxtSeparator";
            this.TxtSeparator.Size = new System.Drawing.Size(218, 21);
            this.TxtSeparator.TabIndex = 4;
            this.TxtSeparator.Text = "@00,*\\r";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "分割符(用,割开)可以使用转义字符";
            // 
            // TxtPackageHead
            // 
            this.TxtPackageHead.Location = new System.Drawing.Point(125, 77);
            this.TxtPackageHead.Name = "TxtPackageHead";
            this.TxtPackageHead.Size = new System.Drawing.Size(165, 21);
            this.TxtPackageHead.TabIndex = 6;
            this.TxtPackageHead.Text = "@00";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "包头字符（可以使用转义字符）";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "包尾字符（可以使用转义字符）";
            // 
            // TxtPackageTail
            // 
            this.TxtPackageTail.Location = new System.Drawing.Point(125, 114);
            this.TxtPackageTail.Name = "TxtPackageTail";
            this.TxtPackageTail.Size = new System.Drawing.Size(165, 21);
            this.TxtPackageTail.TabIndex = 8;
            this.TxtPackageTail.Text = "*\\r";
            // 
            // BtnSent
            // 
            this.BtnSent.Location = new System.Drawing.Point(199, 289);
            this.BtnSent.Name = "BtnSent";
            this.BtnSent.Size = new System.Drawing.Size(91, 23);
            this.BtnSent.TabIndex = 10;
            this.BtnSent.Text = "发送";
            this.BtnSent.UseVisualStyleBackColor = true;
            this.BtnSent.Click += new System.EventHandler(this.BtnSent_Click);
            // 
            // TxtComPortName
            // 
            this.TxtComPortName.Location = new System.Drawing.Point(75, 221);
            this.TxtComPortName.Name = "TxtComPortName";
            this.TxtComPortName.Size = new System.Drawing.Size(100, 21);
            this.TxtComPortName.TabIndex = 11;
            this.TxtComPortName.Text = "COM5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "串口号";
            // 
            // TxtComSet
            // 
            this.TxtComSet.Location = new System.Drawing.Point(75, 249);
            this.TxtComSet.Name = "TxtComSet";
            this.TxtComSet.Size = new System.Drawing.Size(100, 21);
            this.TxtComSet.TabIndex = 13;
            this.TxtComSet.Text = "9600,N,8,1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "串口设置";
            // 
            // BtnComOpen
            // 
            this.BtnComOpen.Location = new System.Drawing.Point(181, 241);
            this.BtnComOpen.Name = "BtnComOpen";
            this.BtnComOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnComOpen.TabIndex = 15;
            this.BtnComOpen.Text = "打开";
            this.BtnComOpen.UseVisualStyleBackColor = true;
            this.BtnComOpen.Click += new System.EventHandler(this.BtnComOpen_Click);
            // 
            // LabelComStatus
            // 
            this.LabelComStatus.AutoSize = true;
            this.LabelComStatus.Location = new System.Drawing.Point(262, 246);
            this.LabelComStatus.Name = "LabelComStatus";
            this.LabelComStatus.Size = new System.Drawing.Size(65, 12);
            this.LabelComStatus.TabIndex = 16;
            this.LabelComStatus.Text = "串口未打开";
            // 
            // TxtTimeInteval
            // 
            this.TxtTimeInteval.Location = new System.Drawing.Point(91, 289);
            this.TxtTimeInteval.Name = "TxtTimeInteval";
            this.TxtTimeInteval.Size = new System.Drawing.Size(84, 21);
            this.TxtTimeInteval.TabIndex = 17;
            this.TxtTimeInteval.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "时间间隔(毫秒)";
            // 
            // TxtCharNums
            // 
            this.TxtCharNums.Location = new System.Drawing.Point(125, 145);
            this.TxtCharNums.Name = "TxtCharNums";
            this.TxtCharNums.Size = new System.Drawing.Size(78, 21);
            this.TxtCharNums.TabIndex = 19;
            this.TxtCharNums.Text = "0";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "当不分割时输入发送的字符数";
            // 
            // FrmComSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 330);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCharNums);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTimeInteval);
            this.Controls.Add(this.LabelComStatus);
            this.Controls.Add(this.BtnComOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtComSet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtComPortName);
            this.Controls.Add(this.BtnSent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPackageTail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPackageHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSeparator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.BtnRead);
            this.MaximizeBox = false;
            this.Name = "FrmComSend";
            this.Text = "ComSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort ComName;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.TextBox TxtSeparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPackageHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPackageTail;
        private System.Windows.Forms.Button BtnSent;
        private System.Windows.Forms.TextBox TxtComPortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtComSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnComOpen;
        private System.Windows.Forms.Label LabelComStatus;
        private System.Windows.Forms.TextBox TxtTimeInteval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCharNums;
        private System.Windows.Forms.Label label8;
    }
}

