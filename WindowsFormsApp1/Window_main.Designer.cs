namespace WindowsFormsApp1
{
    partial class Window_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window_main));
            this.username_tb = new System.Windows.Forms.TextBox();
            this.keys_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.parentHome_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generate_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.home_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.publicKey_tb = new System.Windows.Forms.TextBox();
            this.generatedCommand_tb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.group_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.system_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(22, 27);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(115, 20);
            this.username_tb.TabIndex = 0;
            // 
            // keys_tb
            // 
            this.keys_tb.Location = new System.Drawing.Point(22, 250);
            this.keys_tb.Name = "keys_tb";
            this.keys_tb.Size = new System.Drawing.Size(347, 20);
            this.keys_tb.TabIndex = 1;
            this.keys_tb.Text = "/usr/sap/interfaces/sshkeys/";
            // 
            // pass_tb
            // 
            this.pass_tb.Enabled = false;
            this.pass_tb.Location = new System.Drawing.Point(22, 81);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(115, 20);
            this.pass_tb.TabIndex = 2;
            // 
            // parentHome_tb
            // 
            this.parentHome_tb.Location = new System.Drawing.Point(22, 139);
            this.parentHome_tb.Name = "parentHome_tb";
            this.parentHome_tb.Size = new System.Drawing.Size(347, 20);
            this.parentHome_tb.TabIndex = 3;
            this.parentHome_tb.Text = "/usr/sap/interfaces/SFTP_DIR/";
            this.parentHome_tb.TextChanged += new System.EventHandler(this.parentHome_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parent path";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Keys";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // generate_bt
            // 
            this.generate_bt.Location = new System.Drawing.Point(265, 333);
            this.generate_bt.Name = "generate_bt";
            this.generate_bt.Size = new System.Drawing.Size(104, 28);
            this.generate_bt.TabIndex = 8;
            this.generate_bt.Text = "Generate";
            this.generate_bt.UseVisualStyleBackColor = true;
            this.generate_bt.Click += new System.EventHandler(this.generate_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Directories ( More directories separated with \";\" )";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // home_tb
            // 
            this.home_tb.Location = new System.Drawing.Point(22, 193);
            this.home_tb.Name = "home_tb";
            this.home_tb.Size = new System.Drawing.Size(347, 20);
            this.home_tb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Public key";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // publicKey_tb
            // 
            this.publicKey_tb.Location = new System.Drawing.Point(22, 307);
            this.publicKey_tb.Name = "publicKey_tb";
            this.publicKey_tb.Size = new System.Drawing.Size(347, 20);
            this.publicKey_tb.TabIndex = 11;
            this.publicKey_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // generatedCommand_tb
            // 
            this.generatedCommand_tb.Location = new System.Drawing.Point(390, 12);
            this.generatedCommand_tb.Name = "generatedCommand_tb";
            this.generatedCommand_tb.Size = new System.Drawing.Size(1138, 556);
            this.generatedCommand_tb.TabIndex = 7;
            this.generatedCommand_tb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Group";
            // 
            // group_tb
            // 
            this.group_tb.Location = new System.Drawing.Point(183, 27);
            this.group_tb.Name = "group_tb";
            this.group_tb.Size = new System.Drawing.Size(115, 20);
            this.group_tb.TabIndex = 13;
            this.group_tb.Text = "sapsys";
            this.group_tb.TextChanged += new System.EventHandler(this.group_tb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "System";
            // 
            // system_tb
            // 
            this.system_tb.Location = new System.Drawing.Point(183, 81);
            this.system_tb.Name = "system_tb";
            this.system_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.system_tb.Size = new System.Drawing.Size(115, 20);
            this.system_tb.TabIndex = 15;
            // 
            // Window_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 607);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.system_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.group_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.publicKey_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.home_tb);
            this.Controls.Add(this.generate_bt);
            this.Controls.Add(this.generatedCommand_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parentHome_tb);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.keys_tb);
            this.Controls.Add(this.username_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window_main";
            this.Text = "sFTP user creator by JGY";
            this.Load += new System.EventHandler(this.Window_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox keys_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox parentHome_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generate_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox home_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox publicKey_tb;
        private System.Windows.Forms.RichTextBox generatedCommand_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox group_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox system_tb;
    }
}

