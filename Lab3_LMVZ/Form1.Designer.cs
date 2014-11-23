namespace Lab3_LMVZ
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StartPanel.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "Добро пожаловать!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.StartPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 659);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 660);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // StartPanel
            // 
            this.StartPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartPanel.BackgroundImage")));
            this.StartPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartPanel.Controls.Add(this.SettingPanel);
            this.StartPanel.Controls.Add(this.ExitBtn);
            this.StartPanel.Controls.Add(this.SettingBtn);
            this.StartPanel.Controls.Add(this.StartGameBtn);
            this.StartPanel.Location = new System.Drawing.Point(3, 402);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(196, 115);
            this.StartPanel.TabIndex = 0;
            // 
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingPanel.Controls.Add(this.button1);
            this.SettingPanel.Controls.Add(this.label2);
            this.SettingPanel.Controls.Add(this.label1);
            this.SettingPanel.Controls.Add(this.checkBox1);
            this.SettingPanel.Controls.Add(this.textBox1);
            this.SettingPanel.Controls.Add(this.trackBar1);
            this.SettingPanel.Location = new System.Drawing.Point(12, 224);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(409, 303);
            this.SettingPanel.TabIndex = 3;
            this.SettingPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(379, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Громкость музыки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя игрока";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(156, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Какая то функция";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(156, 96);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(179, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitBtn.Location = new System.Drawing.Point(579, 421);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(109, 45);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // SettingBtn
            // 
            this.SettingBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SettingBtn.Location = new System.Drawing.Point(579, 370);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(109, 45);
            this.SettingBtn.TabIndex = 1;
            this.SettingBtn.Text = "Настройки";
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            this.SettingBtn.MouseEnter += new System.EventHandler(this.SettingBtn_MouseEnter);
            this.SettingBtn.MouseLeave += new System.EventHandler(this.SettingBtn_MouseLeave);
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGameBtn.Location = new System.Drawing.Point(579, 319);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(109, 45);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = "Играть";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            this.StartGameBtn.MouseLeave += new System.EventHandler(this.StartGameBtn_MouseLeave);
            this.StartGameBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartGameBtn_MouseMove);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1214, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гоночная игра";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.StartPanel.ResumeLayout(false);
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}

