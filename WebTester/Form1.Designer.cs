namespace WebTester
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.rbPost = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetHeader = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.txtHtml = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetHtml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.rbJsonPath = new System.Windows.Forms.RadioButton();
            this.rbXpath = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRedirect = new System.Windows.Forms.CheckBox();
            this.cbShowCount = new System.Windows.Forms.CheckBox();
            this.cbShowPath = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(70, 18);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(395, 25);
            this.txtURL.TabIndex = 1;
            // 
            // rbGet
            // 
            this.rbGet.AutoSize = true;
            this.rbGet.Checked = true;
            this.rbGet.Location = new System.Drawing.Point(75, 60);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(52, 19);
            this.rbGet.TabIndex = 2;
            this.rbGet.TabStop = true;
            this.rbGet.Text = "GET";
            this.rbGet.UseVisualStyleBackColor = true;
            // 
            // rbPost
            // 
            this.rbPost.AutoSize = true;
            this.rbPost.Location = new System.Drawing.Point(133, 60);
            this.rbPost.Name = "rbPost";
            this.rbPost.Size = new System.Drawing.Size(60, 19);
            this.rbPost.TabIndex = 3;
            this.rbPost.Text = "POST";
            this.rbPost.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "模式:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "报文头：";
            // 
            // btnSetHeader
            // 
            this.btnSetHeader.Location = new System.Drawing.Point(321, 58);
            this.btnSetHeader.Name = "btnSetHeader";
            this.btnSetHeader.Size = new System.Drawing.Size(103, 23);
            this.btnSetHeader.TabIndex = 7;
            this.btnSetHeader.Text = "设置";
            this.btnSetHeader.UseVisualStyleBackColor = true;
            this.btnSetHeader.Click += new System.EventHandler(this.btnSetHeader_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "PostData：";
            // 
            // txtPostData
            // 
            this.txtPostData.Location = new System.Drawing.Point(104, 91);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostData.Size = new System.Drawing.Size(361, 77);
            this.txtPostData.TabIndex = 9;
            // 
            // txtHtml
            // 
            this.txtHtml.Location = new System.Drawing.Point(24, 207);
            this.txtHtml.Multiline = true;
            this.txtHtml.Name = "txtHtml";
            this.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHtml.Size = new System.Drawing.Size(441, 450);
            this.txtHtml.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRedirect);
            this.groupBox1.Controls.Add(this.btnGetHtml);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.txtHtml);
            this.groupBox1.Controls.Add(this.rbGet);
            this.groupBox1.Controls.Add(this.txtPostData);
            this.groupBox1.Controls.Add(this.rbPost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSetHeader);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 670);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnGetHtml
            // 
            this.btnGetHtml.Location = new System.Drawing.Point(321, 174);
            this.btnGetHtml.Name = "btnGetHtml";
            this.btnGetHtml.Size = new System.Drawing.Size(103, 23);
            this.btnGetHtml.TabIndex = 11;
            this.btnGetHtml.Text = "获取";
            this.btnGetHtml.UseVisualStyleBackColor = true;
            this.btnGetHtml.Click += new System.EventHandler(this.btnGetHtml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbShowPath);
            this.groupBox2.Controls.Add(this.cbShowCount);
            this.groupBox2.Controls.Add(this.btnAnalysis);
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtExpression);
            this.groupBox2.Controls.Add(this.rbJsonPath);
            this.groupBox2.Controls.Add(this.rbXpath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(508, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 670);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(435, 46);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(103, 23);
            this.btnAnalysis.TabIndex = 12;
            this.btnAnalysis.Text = "解析";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(17, 73);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(547, 584);
            this.txtResult.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "表达式";
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(341, 16);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(216, 25);
            this.txtExpression.TabIndex = 3;
            // 
            // rbJsonPath
            // 
            this.rbJsonPath.AutoSize = true;
            this.rbJsonPath.Location = new System.Drawing.Point(171, 19);
            this.rbJsonPath.Name = "rbJsonPath";
            this.rbJsonPath.Size = new System.Drawing.Size(92, 19);
            this.rbJsonPath.TabIndex = 2;
            this.rbJsonPath.Text = "JsonPath";
            this.rbJsonPath.UseVisualStyleBackColor = true;
            // 
            // rbXpath
            // 
            this.rbXpath.AutoSize = true;
            this.rbXpath.Checked = true;
            this.rbXpath.Location = new System.Drawing.Point(97, 19);
            this.rbXpath.Name = "rbXpath";
            this.rbXpath.Size = new System.Drawing.Size(68, 19);
            this.rbXpath.TabIndex = 1;
            this.rbXpath.TabStop = true;
            this.rbXpath.Text = "Xpath";
            this.rbXpath.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "解析模式";
            // 
            // cbRedirect
            // 
            this.cbRedirect.AutoSize = true;
            this.cbRedirect.Location = new System.Drawing.Point(40, 181);
            this.cbRedirect.Name = "cbRedirect";
            this.cbRedirect.Size = new System.Drawing.Size(89, 19);
            this.cbRedirect.TabIndex = 12;
            this.cbRedirect.Text = "自动跳转";
            this.cbRedirect.UseVisualStyleBackColor = true;
            // 
            // cbShowCount
            // 
            this.cbShowCount.AutoSize = true;
            this.cbShowCount.Location = new System.Drawing.Point(17, 50);
            this.cbShowCount.Name = "cbShowCount";
            this.cbShowCount.Size = new System.Drawing.Size(89, 19);
            this.cbShowCount.TabIndex = 13;
            this.cbShowCount.Text = "显示总数";
            this.cbShowCount.UseVisualStyleBackColor = true;
            // 
            // cbShowPath
            // 
            this.cbShowPath.AutoSize = true;
            this.cbShowPath.Location = new System.Drawing.Point(112, 50);
            this.cbShowPath.Name = "cbShowPath";
            this.cbShowPath.Size = new System.Drawing.Size(121, 19);
            this.cbShowPath.TabIndex = 14;
            this.cbShowPath.Text = "显示实际Path";
            this.cbShowPath.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xpath、JsonPath测试工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.RadioButton rbGet;
        private System.Windows.Forms.RadioButton rbPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostData;
        private System.Windows.Forms.TextBox txtHtml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.RadioButton rbJsonPath;
        private System.Windows.Forms.RadioButton rbXpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetHtml;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.CheckBox cbRedirect;
        private System.Windows.Forms.CheckBox cbShowPath;
        private System.Windows.Forms.CheckBox cbShowCount;
    }
}

