namespace KepServerPlc
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
            this.disconnect_server = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.connect_server = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Server_IP = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.asyncWrite = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.syncWrite = new System.Windows.Forms.Button();
            this.asyncRead = new System.Windows.Forms.Button();
            this.syncRead = new System.Windows.Forms.Button();
            this.list_INFO = new System.Windows.Forms.ListBox();
            this.addTagname = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addGroup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // disconnect_server
            // 
            this.disconnect_server.Location = new System.Drawing.Point(285, 95);
            this.disconnect_server.Name = "disconnect_server";
            this.disconnect_server.Size = new System.Drawing.Size(75, 25);
            this.disconnect_server.TabIndex = 54;
            this.disconnect_server.Text = "断开";
            this.disconnect_server.UseVisualStyleBackColor = true;
            this.disconnect_server.Click += new System.EventHandler(this.disconnect_server_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 53;
            // 
            // connect_server
            // 
            this.connect_server.Location = new System.Drawing.Point(21, 95);
            this.connect_server.Name = "connect_server";
            this.connect_server.Size = new System.Drawing.Size(75, 25);
            this.connect_server.TabIndex = 52;
            this.connect_server.Text = "连接";
            this.connect_server.UseVisualStyleBackColor = true;
            this.connect_server.Click += new System.EventHandler(this.connect_server_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 51;
            this.label8.Text = "OPC服务器列表";
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(21, 69);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(339, 20);
            this.cmbServerName.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 49;
            this.label9.Text = "本机IP";
            // 
            // Server_IP
            // 
            this.Server_IP.Location = new System.Drawing.Point(157, 21);
            this.Server_IP.Name = "Server_IP";
            this.Server_IP.Size = new System.Drawing.Size(203, 21);
            this.Server_IP.TabIndex = 48;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(19, 19);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 25);
            this.Search.TabIndex = 47;
            this.Search.Text = "搜索";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // asyncWrite
            // 
            this.asyncWrite.Location = new System.Drawing.Point(385, 248);
            this.asyncWrite.Margin = new System.Windows.Forms.Padding(2);
            this.asyncWrite.Name = "asyncWrite";
            this.asyncWrite.Size = new System.Drawing.Size(75, 25);
            this.asyncWrite.TabIndex = 46;
            this.asyncWrite.Text = "异步写";
            this.asyncWrite.UseVisualStyleBackColor = true;
            this.asyncWrite.Click += new System.EventHandler(this.asyncWrite_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(234, 251);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(60, 21);
            this.textBox7.TabIndex = 45;
            this.textBox7.Text = "100";
            // 
            // syncWrite
            // 
            this.syncWrite.Location = new System.Drawing.Point(306, 248);
            this.syncWrite.Margin = new System.Windows.Forms.Padding(2);
            this.syncWrite.Name = "syncWrite";
            this.syncWrite.Size = new System.Drawing.Size(75, 25);
            this.syncWrite.TabIndex = 44;
            this.syncWrite.Text = "同步写";
            this.syncWrite.UseVisualStyleBackColor = true;
            this.syncWrite.Click += new System.EventHandler(this.syncWrite_Click);
            // 
            // asyncRead
            // 
            this.asyncRead.Location = new System.Drawing.Point(97, 247);
            this.asyncRead.Margin = new System.Windows.Forms.Padding(2);
            this.asyncRead.Name = "asyncRead";
            this.asyncRead.Size = new System.Drawing.Size(75, 25);
            this.asyncRead.TabIndex = 43;
            this.asyncRead.Text = "异步读";
            this.asyncRead.UseVisualStyleBackColor = true;
            this.asyncRead.Click += new System.EventHandler(this.asyncRead_Click);
            // 
            // syncRead
            // 
            this.syncRead.Location = new System.Drawing.Point(18, 247);
            this.syncRead.Margin = new System.Windows.Forms.Padding(2);
            this.syncRead.Name = "syncRead";
            this.syncRead.Size = new System.Drawing.Size(75, 25);
            this.syncRead.TabIndex = 42;
            this.syncRead.Text = "同步读";
            this.syncRead.UseVisualStyleBackColor = true;
            this.syncRead.Click += new System.EventHandler(this.syncRead_Click);
            // 
            // list_INFO
            // 
            this.list_INFO.FormattingEnabled = true;
            this.list_INFO.ItemHeight = 12;
            this.list_INFO.Location = new System.Drawing.Point(16, 342);
            this.list_INFO.Margin = new System.Windows.Forms.Padding(2);
            this.list_INFO.Name = "list_INFO";
            this.list_INFO.Size = new System.Drawing.Size(444, 220);
            this.list_INFO.TabIndex = 41;
            // 
            // addTagname
            // 
            this.addTagname.Location = new System.Drawing.Point(385, 211);
            this.addTagname.Margin = new System.Windows.Forms.Padding(2);
            this.addTagname.Name = "addTagname";
            this.addTagname.Size = new System.Drawing.Size(75, 25);
            this.addTagname.TabIndex = 40;
            this.addTagname.Text = "添加变量";
            this.addTagname.UseVisualStyleBackColor = true;
            this.addTagname.Click += new System.EventHandler(this.addTagname_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(55, 211);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(276, 21);
            this.textBox6.TabIndex = 39;
            this.textBox6.Text = "current";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "TagID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(287, 173);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 21);
            this.textBox5.TabIndex = 37;
            this.textBox5.Text = "G1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(170, 173);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 21);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "VT126";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 173);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 21);
            this.textBox3.TabIndex = 35;
            this.textBox3.Text = "GAS";
            // 
            // addGroup
            // 
            this.addGroup.Location = new System.Drawing.Point(385, 173);
            this.addGroup.Margin = new System.Windows.Forms.Padding(2);
            this.addGroup.Name = "addGroup";
            this.addGroup.Size = new System.Drawing.Size(75, 25);
            this.addGroup.TabIndex = 34;
            this.addGroup.Text = "添加组";
            this.addGroup.UseVisualStyleBackColor = true;
            this.addGroup.Click += new System.EventHandler(this.addGroup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "Dev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "Channel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "写入值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnect_server);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.connect_server);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbServerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Server_IP);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.asyncWrite);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.syncWrite);
            this.Controls.Add(this.asyncRead);
            this.Controls.Add(this.syncRead);
            this.Controls.Add(this.list_INFO);
            this.Controls.Add(this.addTagname);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.addGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disconnect_server;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button connect_server;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Server_IP;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button asyncWrite;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button syncWrite;
        private System.Windows.Forms.Button asyncRead;
        private System.Windows.Forms.Button syncRead;
        private System.Windows.Forms.ListBox list_INFO;
        private System.Windows.Forms.Button addTagname;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

