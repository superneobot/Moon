using Lib;

namespace Moon
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.strip = new System.Windows.Forms.StatusStrip();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.size_base = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.save_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.adding_state = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.load_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.add_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.controls_pan = new System.Windows.Forms.Panel();
            this.stop_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.Label();
            this.load_btn = new System.Windows.Forms.Button();
            this.file_path = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.pl_pan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.musicSeeker = new MySeeker.MusicSeeker();
            this.play_list = new PlayListBox.PlayList();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.strip.SuspendLayout();
            this.controls_pan.SuspendLayout();
            this.pl_pan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // strip
            // 
            this.strip.BackColor = System.Drawing.SystemColors.Control;
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress,
            this.status,
            this.size_base,
            this.menu});
            this.strip.Location = new System.Drawing.Point(0, 514);
            this.strip.Name = "strip";
            this.strip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.strip.Size = new System.Drawing.Size(658, 22);
            this.strip.TabIndex = 6;
            this.strip.Text = "statusStrip1";
            // 
            // progress
            // 
            this.progress.Margin = new System.Windows.Forms.Padding(5, 3, 1, 3);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(117, 16);
            this.progress.Step = 1;
            // 
            // status
            // 
            this.status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(26, 17);
            this.status.Text = "Idle";
            this.status.Visible = false;
            // 
            // size_base
            // 
            this.size_base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.size_base.ForeColor = System.Drawing.Color.Black;
            this.size_base.Name = "size_base";
            this.size_base.Size = new System.Drawing.Size(37, 17);
            this.size_base.Text = "0 files";
            // 
            // menu
            // 
            this.menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save_tool,
            this.adding_state,
            this.clear_tool,
            this.load_tool,
            this.add_tool});
            this.menu.ForeColor = System.Drawing.Color.Black;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(51, 20);
            this.menu.Text = "Menu";
            // 
            // save_tool
            // 
            this.save_tool.Name = "save_tool";
            this.save_tool.Size = new System.Drawing.Size(140, 22);
            this.save_tool.Text = "Prevent save";
            this.save_tool.Click += new System.EventHandler(this.save_tool_Click);
            // 
            // adding_state
            // 
            this.adding_state.Name = "adding_state";
            this.adding_state.Size = new System.Drawing.Size(140, 22);
            this.adding_state.Text = "Autosave";
            this.adding_state.Click += new System.EventHandler(this.adding_state_Click);
            // 
            // clear_tool
            // 
            this.clear_tool.Name = "clear_tool";
            this.clear_tool.Size = new System.Drawing.Size(140, 22);
            this.clear_tool.Text = "Clear";
            this.clear_tool.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // load_tool
            // 
            this.load_tool.Name = "load_tool";
            this.load_tool.Size = new System.Drawing.Size(140, 22);
            this.load_tool.Text = "Load";
            this.load_tool.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // add_tool
            // 
            this.add_tool.Name = "add_tool";
            this.add_tool.Size = new System.Drawing.Size(140, 22);
            this.add_tool.Text = "Add";
            this.add_tool.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // controls_pan
            // 
            this.controls_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.controls_pan.Controls.Add(this.stop_btn);
            this.controls_pan.Controls.Add(this.play_btn);
            this.controls_pan.Controls.Add(this.clear_btn);
            this.controls_pan.Controls.Add(this.tip);
            this.controls_pan.Controls.Add(this.load_btn);
            this.controls_pan.Controls.Add(this.file_path);
            this.controls_pan.Controls.Add(this.add_btn);
            this.controls_pan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controls_pan.Location = new System.Drawing.Point(0, 453);
            this.controls_pan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.controls_pan.Name = "controls_pan";
            this.controls_pan.Size = new System.Drawing.Size(658, 61);
            this.controls_pan.TabIndex = 8;
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.stop_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.stop_btn.Location = new System.Drawing.Point(169, 6);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(48, 48);
            this.stop_btn.TabIndex = 12;
            this.stop_btn.Text = "stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.play_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.play_btn.Location = new System.Drawing.Point(115, 6);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(48, 48);
            this.play_btn.TabIndex = 11;
            this.play_btn.Text = "play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clear_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.clear_btn.Location = new System.Drawing.Point(434, 6);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(48, 48);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tip.Location = new System.Drawing.Point(224, 104);
            this.tip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(92, 13);
            this.tip.TabIndex = 9;
            this.tip.Text = "No files selected";
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.load_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.load_btn.FlatAppearance.BorderSize = 0;
            this.load_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.load_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.load_btn.Location = new System.Drawing.Point(60, 6);
            this.load_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(48, 48);
            this.load_btn.TabIndex = 8;
            this.load_btn.Text = "load";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // file_path
            // 
            this.file_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.file_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file_path.Font = new System.Drawing.Font("Motiva Sans", 9F);
            this.file_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.file_path.Location = new System.Drawing.Point(224, 6);
            this.file_path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(202, 22);
            this.file_path.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.add_btn.Location = new System.Drawing.Point(4, 6);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(48, 48);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // pl_pan
            // 
            this.pl_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pl_pan.Controls.Add(this.panel1);
            this.pl_pan.Controls.Add(this.controls_pan);
            this.pl_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_pan.Location = new System.Drawing.Point(0, 0);
            this.pl_pan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pl_pan.Name = "pl_pan";
            this.pl_pan.Size = new System.Drawing.Size(658, 514);
            this.pl_pan.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.musicSeeker);
            this.panel1.Controls.Add(this.play_list);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 453);
            this.panel1.TabIndex = 10;
            // 
            // musicSeeker
            // 
            this.musicSeeker.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.musicSeeker.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.musicSeeker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.musicSeeker.BorderSize = 1;
            this.musicSeeker.CurrentTime = "00:00";
            this.musicSeeker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicSeeker.Location = new System.Drawing.Point(0, 433);
            this.musicSeeker.Maximum = 100;
            this.musicSeeker.Minimum = 0;
            this.musicSeeker.Name = "musicSeeker";
            this.musicSeeker.Size = new System.Drawing.Size(658, 20);
            this.musicSeeker.Step = 1;
            this.musicSeeker.TabIndex = 1;
            this.musicSeeker.TotalTime = "00:00";
            this.musicSeeker.Value = 0;
            this.musicSeeker.Click += new System.EventHandler(this.musicSeeker_Click);
            this.musicSeeker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.musicSeeker_MouseMove);
            // 
            // play_list
            // 
            this.play_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.play_list.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.play_list.BorderColor = System.Drawing.Color.Crimson;
            this.play_list.BorderSize = 1;
            this.play_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.play_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.play_list.ForeColor = System.Drawing.Color.Black;
            this.play_list.FormattingEnabled = true;
            this.play_list.ItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.play_list.Location = new System.Drawing.Point(0, 0);
            this.play_list.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.play_list.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.play_list.Name = "play_list";
            this.play_list.SelecteditemColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.play_list.Size = new System.Drawing.Size(658, 453);
            this.play_list.TabIndex = 0;
            this.play_list.TextColor = System.Drawing.Color.Black;
            this.play_list.SelectedIndexChanged += new System.EventHandler(this.file_list_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(658, 536);
            this.Controls.Add(this.pl_pan);
            this.Controls.Add(this.strip);
            this.Font = new System.Drawing.Font("Motiva Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(658, 500);
            this.Name = "mainform";
            this.ShowInTaskbar = false;
            this.Text = "Moon []";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.controls_pan.ResumeLayout(false);
            this.controls_pan.PerformLayout();
            this.pl_pan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip strip;
        private System.Windows.Forms.Panel controls_pan;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.TextBox file_path;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel pl_pan;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripStatusLabel size_base;
        private System.Windows.Forms.ToolStripDropDownButton menu;
        private System.Windows.Forms.ToolStripMenuItem clear_tool;
        private System.Windows.Forms.ToolStripMenuItem load_tool;
        private System.Windows.Forms.ToolStripMenuItem add_tool;
        private System.Windows.Forms.ToolStripMenuItem adding_state;
        private System.Windows.Forms.ToolStripMenuItem save_tool;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private MySeeker.MusicSeeker musicSeeker;
        private PlayListBox.PlayList play_list;
    }
}

