namespace WebTester
{
    partial class AddHeader
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
            this.gvHeaders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.clKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvHeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHeaders
            // 
            this.gvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clKey,
            this.clValue});
            this.gvHeaders.Location = new System.Drawing.Point(12, 12);
            this.gvHeaders.Name = "gvHeaders";
            this.gvHeaders.RowTemplate.Height = 27;
            this.gvHeaders.Size = new System.Drawing.Size(443, 150);
            this.gvHeaders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "键";
            // 
            // cbKey
            // 
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Items.AddRange(new object[] {
            "Host",
            "Referer",
            "Accept",
            "Accept-Encoding",
            "Accept-Language",
            "Cookie",
            "User-Agent"});
            this.cbKey.Location = new System.Drawing.Point(57, 190);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(398, 23);
            this.cbKey.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(57, 219);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(400, 25);
            this.txtValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "值";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(201, 269);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除选中";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(311, 269);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "完成";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // clKey
            // 
            this.clKey.DataPropertyName = "Key";
            this.clKey.HeaderText = "键";
            this.clKey.Name = "clKey";
            this.clKey.Width = 200;
            // 
            // clValue
            // 
            this.clValue.DataPropertyName = "Value";
            this.clValue.HeaderText = "值";
            this.clValue.Name = "clValue";
            this.clValue.Width = 200;
            // 
            // AddHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 312);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cbKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvHeaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加Http头";
            ((System.ComponentModel.ISupportInitialize)(this.gvHeaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvHeaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValue;
    }
}