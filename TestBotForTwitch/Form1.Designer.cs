namespace TestBotForTwitch
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.общаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отдельнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.twitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.командыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.бунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.смехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.диалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.любопытныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оДаунахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 361);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Крутить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(110, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(25, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.командыToolStripMenuItem,
            this.диалогToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(586, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// регистрацияToolStripMenuItem
			// 
			this.регистрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общаяToolStripMenuItem,
            this.отдельнаяToolStripMenuItem});
			this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
			this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.регистрацияToolStripMenuItem.Text = "Регистрация";
			// 
			// общаяToolStripMenuItem
			// 
			this.общаяToolStripMenuItem.Name = "общаяToolStripMenuItem";
			this.общаяToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.общаяToolStripMenuItem.Text = "Общая";
			// 
			// отдельнаяToolStripMenuItem
			// 
			this.отдельнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.twitchToolStripMenuItem});
			this.отдельнаяToolStripMenuItem.Name = "отдельнаяToolStripMenuItem";
			this.отдельнаяToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.отдельнаяToolStripMenuItem.Text = "Отдельная";
			// 
			// emailToolStripMenuItem
			// 
			this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
			this.emailToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.emailToolStripMenuItem.Text = "Email";
			// 
			// twitchToolStripMenuItem
			// 
			this.twitchToolStripMenuItem.Name = "twitchToolStripMenuItem";
			this.twitchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.twitchToolStripMenuItem.Text = "Twitch";
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proxyToolStripMenuItem});
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			// 
			// proxyToolStripMenuItem
			// 
			this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
			this.proxyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.proxyToolStripMenuItem.Text = "Proxy";
			this.proxyToolStripMenuItem.Click += new System.EventHandler(this.proxyToolStripMenuItem_Click);
			// 
			// командыToolStripMenuItem
			// 
			this.командыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бунтToolStripMenuItem,
            this.смехToolStripMenuItem});
			this.командыToolStripMenuItem.Name = "командыToolStripMenuItem";
			this.командыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.командыToolStripMenuItem.Text = "Команды";
			// 
			// бунтToolStripMenuItem
			// 
			this.бунтToolStripMenuItem.Name = "бунтToolStripMenuItem";
			this.бунтToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.бунтToolStripMenuItem.Text = "Бунт";
			this.бунтToolStripMenuItem.Click += new System.EventHandler(this.бунтToolStripMenuItem_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 79);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(129, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Сколько крутить";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Стример";
			// 
			// смехToolStripMenuItem
			// 
			this.смехToolStripMenuItem.Name = "смехToolStripMenuItem";
			this.смехToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.смехToolStripMenuItem.Text = "Смех";
			this.смехToolStripMenuItem.Click += new System.EventHandler(this.смехToolStripMenuItem_Click);
			// 
			// диалогToolStripMenuItem
			// 
			this.диалогToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.любопытныйToolStripMenuItem,
            this.оДаунахToolStripMenuItem});
			this.диалогToolStripMenuItem.Name = "диалогToolStripMenuItem";
			this.диалогToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.диалогToolStripMenuItem.Text = "Диалог";
			// 
			// любопытныйToolStripMenuItem
			// 
			this.любопытныйToolStripMenuItem.Name = "любопытныйToolStripMenuItem";
			this.любопытныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.любопытныйToolStripMenuItem.Text = "Любопытный";
			this.любопытныйToolStripMenuItem.Click += new System.EventHandler(this.любопытныйToolStripMenuItem_Click);
			// 
			// оДаунахToolStripMenuItem
			// 
			this.оДаунахToolStripMenuItem.Name = "оДаунахToolStripMenuItem";
			this.оДаунахToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.оДаунахToolStripMenuItem.Text = "О даунах";
			this.оДаунахToolStripMenuItem.Click += new System.EventHandler(this.оДаунахToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 396);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem общаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отдельнаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem twitchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem командыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem бунтToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem смехToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem диалогToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem любопытныйToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оДаунахToolStripMenuItem;
    }
}

