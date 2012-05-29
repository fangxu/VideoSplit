namespace VideoSplit
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textVideo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxEndSec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxEndMin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxEndHour = new System.Windows.Forms.ComboBox();
            this.boxStartSec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxStartMin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxStartHour = new System.Windows.Forms.ComboBox();
            this.radioStract = new System.Windows.Forms.RadioButton();
            this.boxPartNum = new System.Windows.Forms.ComboBox();
            this.boxPartSec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPartMin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxPartHour = new System.Windows.Forms.ComboBox();
            this.radioNum = new System.Windows.Forms.RadioButton();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.labelStatu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textVideo
            // 
            this.textVideo.Location = new System.Drawing.Point(66, 12);
            this.textVideo.Name = "textVideo";
            this.textVideo.Size = new System.Drawing.Size(399, 21);
            this.textVideo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 218);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.boxEndSec);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.boxEndMin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.boxEndHour);
            this.groupBox1.Controls.Add(this.boxStartSec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.boxStartMin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.boxStartHour);
            this.groupBox1.Controls.Add(this.radioStract);
            this.groupBox1.Controls.Add(this.boxPartNum);
            this.groupBox1.Controls.Add(this.boxPartSec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxPartMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxPartHour);
            this.groupBox1.Controls.Add(this.radioNum);
            this.groupBox1.Controls.Add(this.radioTime);
            this.groupBox1.Location = new System.Drawing.Point(14, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "End:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Start:";
            // 
            // boxEndSec
            // 
            this.boxEndSec.FormattingEnabled = true;
            this.boxEndSec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.boxEndSec.Location = new System.Drawing.Point(294, 139);
            this.boxEndSec.Name = "boxEndSec";
            this.boxEndSec.Size = new System.Drawing.Size(41, 20);
            this.boxEndSec.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = ":";
            // 
            // boxEndMin
            // 
            this.boxEndMin.FormattingEnabled = true;
            this.boxEndMin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.boxEndMin.Location = new System.Drawing.Point(232, 139);
            this.boxEndMin.Name = "boxEndMin";
            this.boxEndMin.Size = new System.Drawing.Size(41, 20);
            this.boxEndMin.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = ":";
            // 
            // boxEndHour
            // 
            this.boxEndHour.FormattingEnabled = true;
            this.boxEndHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.boxEndHour.Location = new System.Drawing.Point(170, 139);
            this.boxEndHour.Name = "boxEndHour";
            this.boxEndHour.Size = new System.Drawing.Size(41, 20);
            this.boxEndHour.TabIndex = 14;
            // 
            // boxStartSec
            // 
            this.boxStartSec.FormattingEnabled = true;
            this.boxStartSec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.boxStartSec.Location = new System.Drawing.Point(294, 110);
            this.boxStartSec.Name = "boxStartSec";
            this.boxStartSec.Size = new System.Drawing.Size(41, 20);
            this.boxStartSec.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // boxStartMin
            // 
            this.boxStartMin.FormattingEnabled = true;
            this.boxStartMin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.boxStartMin.Location = new System.Drawing.Point(232, 110);
            this.boxStartMin.Name = "boxStartMin";
            this.boxStartMin.Size = new System.Drawing.Size(41, 20);
            this.boxStartMin.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // boxStartHour
            // 
            this.boxStartHour.FormattingEnabled = true;
            this.boxStartHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.boxStartHour.Location = new System.Drawing.Point(170, 110);
            this.boxStartHour.Name = "boxStartHour";
            this.boxStartHour.Size = new System.Drawing.Size(41, 20);
            this.boxStartHour.TabIndex = 9;
            // 
            // radioStract
            // 
            this.radioStract.AutoSize = true;
            this.radioStract.Location = new System.Drawing.Point(7, 114);
            this.radioStract.Name = "radioStract";
            this.radioStract.Size = new System.Drawing.Size(65, 16);
            this.radioStract.TabIndex = 8;
            this.radioStract.TabStop = true;
            this.radioStract.Text = "stract:";
            this.radioStract.UseVisualStyleBackColor = true;
            // 
            // boxPartNum
            // 
            this.boxPartNum.FormattingEnabled = true;
            this.boxPartNum.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.boxPartNum.Location = new System.Drawing.Point(170, 60);
            this.boxPartNum.Name = "boxPartNum";
            this.boxPartNum.Size = new System.Drawing.Size(57, 20);
            this.boxPartNum.TabIndex = 7;
            // 
            // boxPartSec
            // 
            this.boxPartSec.FormattingEnabled = true;
            this.boxPartSec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.boxPartSec.Location = new System.Drawing.Point(294, 17);
            this.boxPartSec.Name = "boxPartSec";
            this.boxPartSec.Size = new System.Drawing.Size(41, 20);
            this.boxPartSec.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // boxPartMin
            // 
            this.boxPartMin.FormattingEnabled = true;
            this.boxPartMin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.boxPartMin.Location = new System.Drawing.Point(232, 17);
            this.boxPartMin.Name = "boxPartMin";
            this.boxPartMin.Size = new System.Drawing.Size(41, 20);
            this.boxPartMin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // boxPartHour
            // 
            this.boxPartHour.FormattingEnabled = true;
            this.boxPartHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.boxPartHour.Location = new System.Drawing.Point(170, 17);
            this.boxPartHour.Name = "boxPartHour";
            this.boxPartHour.Size = new System.Drawing.Size(41, 20);
            this.boxPartHour.TabIndex = 2;
            // 
            // radioNum
            // 
            this.radioNum.AutoSize = true;
            this.radioNum.Location = new System.Drawing.Point(7, 65);
            this.radioNum.Name = "radioNum";
            this.radioNum.Size = new System.Drawing.Size(113, 16);
            this.radioNum.TabIndex = 1;
            this.radioNum.TabStop = true;
            this.radioNum.Text = "number of part:";
            this.radioNum.UseVisualStyleBackColor = true;
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(7, 21);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(101, 16);
            this.radioTime.TabIndex = 0;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "time of part:";
            this.radioTime.UseVisualStyleBackColor = true;
            // 
            // labelStatu
            // 
            this.labelStatu.AutoSize = true;
            this.labelStatu.Location = new System.Drawing.Point(0, 245);
            this.labelStatu.Name = "labelStatu";
            this.labelStatu.Size = new System.Drawing.Size(41, 12);
            this.labelStatu.TabIndex = 4;
            this.labelStatu.Text = "label2";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 266);
            this.Controls.Add(this.labelStatu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textVideo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "VideoSplit";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox boxPartSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxPartMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxPartHour;
        private System.Windows.Forms.RadioButton radioNum;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.Label labelStatu;
        private System.Windows.Forms.RadioButton radioStract;
        private System.Windows.Forms.ComboBox boxPartNum;
        private System.Windows.Forms.ComboBox boxEndSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox boxEndMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox boxEndHour;
        private System.Windows.Forms.ComboBox boxStartSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxStartMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boxStartHour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

