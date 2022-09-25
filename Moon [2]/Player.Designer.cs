namespace Moon__2_
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.main_panel = new System.Windows.Forms.Panel();
            this.pl_panel = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.play_list = new PlayListBox.PlayList();
            this.head_panel = new System.Windows.Forms.Panel();
            this.caption_panel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.sys_but_panel = new System.Windows.Forms.Panel();
            this.hide_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.controls_panel = new System.Windows.Forms.Panel();
            this.clear_list = new System.Windows.Forms.Button();
            this.rnd_index = new System.Windows.Forms.CheckBox();
            this.volume_control = new System.Windows.Forms.TrackBar();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.slider_panel = new System.Windows.Forms.Panel();
            this.Slider = new ColorSlider.ColorSlider();
            this.total_time_panel = new System.Windows.Forms.Panel();
            this.total_time = new System.Windows.Forms.Label();
            this.cur_time_panel = new System.Windows.Forms.Panel();
            this.current_time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.global = new System.Windows.Forms.Timer(this.components);
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.main_panel.SuspendLayout();
            this.pl_panel.SuspendLayout();
            this.head_panel.SuspendLayout();
            this.caption_panel.SuspendLayout();
            this.sys_but_panel.SuspendLayout();
            this.controls_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_control)).BeginInit();
            this.slider_panel.SuspendLayout();
            this.total_time_panel.SuspendLayout();
            this.cur_time_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_panel.Controls.Add(this.pl_panel);
            this.main_panel.Controls.Add(this.head_panel);
            this.main_panel.Controls.Add(this.controls_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(519, 754);
            this.main_panel.TabIndex = 1;
            // 
            // pl_panel
            // 
            this.pl_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pl_panel.Controls.Add(this.save);
            this.pl_panel.Controls.Add(this.load);
            this.pl_panel.Controls.Add(this.play_list);
            this.pl_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_panel.Location = new System.Drawing.Point(0, 30);
            this.pl_panel.Name = "pl_panel";
            this.pl_panel.Size = new System.Drawing.Size(517, 653);
            this.pl_panel.TabIndex = 2;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Motiva Sans", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(475, 634);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(16, 16);
            this.save.TabIndex = 1;
            this.save.Text = "S";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseMove += new System.Windows.Forms.MouseEventHandler(this.save_MouseMove);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Motiva Sans", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.load.Location = new System.Drawing.Point(497, 634);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(16, 16);
            this.load.TabIndex = 1;
            this.load.Text = "L";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            this.load.MouseMove += new System.Windows.Forms.MouseEventHandler(this.load_MouseMove);
            // 
            // play_list
            // 
            this.play_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.play_list.BaseColor = System.Drawing.Color.Black;
            this.play_list.BorderColor = System.Drawing.Color.Black;
            this.play_list.BorderSize = 0;
            this.play_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.play_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.play_list.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_list.ForeColor = System.Drawing.Color.Gainsboro;
            this.play_list.ItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.play_list.ItemHeight = 18;
            this.play_list.Location = new System.Drawing.Point(0, 0);
            this.play_list.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.play_list.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.play_list.Name = "play_list";
            this.play_list.SelectedFontColor = System.Drawing.Color.Black;
            this.play_list.SelecteditemColor = System.Drawing.Color.DarkGray;
            this.play_list.Size = new System.Drawing.Size(517, 653);
            this.play_list.TabIndex = 0;
            this.play_list.TextColor = System.Drawing.Color.WhiteSmoke;
            this.play_list.Click += new System.EventHandler(this.play_list_Click);
            this.play_list.SelectedIndexChanged += new System.EventHandler(this.play_list_SelectedIndexChanged);
            this.play_list.Leave += new System.EventHandler(this.play_list_Leave);
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.head_panel.Controls.Add(this.caption_panel);
            this.head_panel.Controls.Add(this.sys_but_panel);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(517, 30);
            this.head_panel.TabIndex = 1;
            // 
            // caption_panel
            // 
            this.caption_panel.Controls.Add(this.title);
            this.caption_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caption_panel.Location = new System.Drawing.Point(0, 0);
            this.caption_panel.Name = "caption_panel";
            this.caption_panel.Size = new System.Drawing.Size(457, 30);
            this.caption_panel.TabIndex = 1;
            this.caption_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.caption_panel_MouseDown);
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.Gainsboro;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(457, 30);
            this.title.TabIndex = 0;
            this.title.Text = "Moon Player";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.caption_panel_MouseDown);
            // 
            // sys_but_panel
            // 
            this.sys_but_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.sys_but_panel.Controls.Add(this.hide_btn);
            this.sys_but_panel.Controls.Add(this.exit_btn);
            this.sys_but_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sys_but_panel.Location = new System.Drawing.Point(457, 0);
            this.sys_but_panel.Name = "sys_but_panel";
            this.sys_but_panel.Size = new System.Drawing.Size(60, 30);
            this.sys_but_panel.TabIndex = 0;
            // 
            // hide_btn
            // 
            this.hide_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hide_btn.FlatAppearance.BorderSize = 0;
            this.hide_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hide_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_btn.Location = new System.Drawing.Point(5, 3);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(24, 24);
            this.hide_btn.TabIndex = 1;
            this.hide_btn.Text = "_";
            this.hide_btn.UseVisualStyleBackColor = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            this.hide_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hide_btn_MouseMove);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(33, 3);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(24, 24);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_btn_MouseMove);
            // 
            // controls_panel
            // 
            this.controls_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.controls_panel.Controls.Add(this.clear_list);
            this.controls_panel.Controls.Add(this.rnd_index);
            this.controls_panel.Controls.Add(this.volume_control);
            this.controls_panel.Controls.Add(this.prev_btn);
            this.controls_panel.Controls.Add(this.next_btn);
            this.controls_panel.Controls.Add(this.stop_btn);
            this.controls_panel.Controls.Add(this.pause_btn);
            this.controls_panel.Controls.Add(this.play_btn);
            this.controls_panel.Controls.Add(this.add_btn);
            this.controls_panel.Controls.Add(this.slider_panel);
            this.controls_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controls_panel.Location = new System.Drawing.Point(0, 683);
            this.controls_panel.Name = "controls_panel";
            this.controls_panel.Size = new System.Drawing.Size(517, 69);
            this.controls_panel.TabIndex = 0;
            this.controls_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.caption_panel_MouseDown);
            // 
            // clear_list
            // 
            this.clear_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clear_list.FlatAppearance.BorderSize = 0;
            this.clear_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.clear_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clear_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_list.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear_list.Location = new System.Drawing.Point(312, 34);
            this.clear_list.Name = "clear_list";
            this.clear_list.Size = new System.Drawing.Size(75, 23);
            this.clear_list.TabIndex = 9;
            this.clear_list.Text = "Clear";
            this.clear_list.UseVisualStyleBackColor = false;
            this.clear_list.Click += new System.EventHandler(this.clear_list_Click);
            this.clear_list.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clear_list_MouseMove);
            // 
            // rnd_index
            // 
            this.rnd_index.AutoSize = true;
            this.rnd_index.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rnd_index.Location = new System.Drawing.Point(241, 37);
            this.rnd_index.Name = "rnd_index";
            this.rnd_index.Size = new System.Drawing.Size(65, 18);
            this.rnd_index.TabIndex = 8;
            this.rnd_index.Text = "Random";
            this.rnd_index.UseVisualStyleBackColor = true;
            this.rnd_index.Click += new System.EventHandler(this.rnd_index_Click);
            this.rnd_index.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rnd_index_MouseMove);
            // 
            // volume_control
            // 
            this.volume_control.LargeChange = 1;
            this.volume_control.Location = new System.Drawing.Point(393, 34);
            this.volume_control.Maximum = 100;
            this.volume_control.Name = "volume_control";
            this.volume_control.Size = new System.Drawing.Size(120, 45);
            this.volume_control.TabIndex = 5;
            this.volume_control.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_control.Value = 50;
            this.volume_control.Scroll += new System.EventHandler(this.volume_control_Scroll);
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.prev_btn.Enabled = false;
            this.prev_btn.FlatAppearance.BorderSize = 0;
            this.prev_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.prev_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.prev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_btn.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prev_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.prev_btn.Location = new System.Drawing.Point(49, 28);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(32, 32);
            this.prev_btn.TabIndex = 4;
            this.prev_btn.Text = "<<";
            this.prev_btn.UseVisualStyleBackColor = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            this.prev_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.prev_btn_MouseMove);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.next_btn.Enabled = false;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.next_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.next_btn.Location = new System.Drawing.Point(203, 28);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(32, 32);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = ">>";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            this.next_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.next_btn_MouseMove);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.stop_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.stop_btn.Location = new System.Drawing.Point(165, 28);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(32, 32);
            this.stop_btn.TabIndex = 4;
            this.stop_btn.Text = "[]";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            this.stop_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stop_btn_MouseMove);
            // 
            // pause_btn
            // 
            this.pause_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pause_btn.FlatAppearance.BorderSize = 0;
            this.pause_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pause_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_btn.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pause_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.pause_btn.Location = new System.Drawing.Point(127, 28);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(32, 32);
            this.pause_btn.TabIndex = 4;
            this.pause_btn.Text = "||";
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            this.pause_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pause_btn_MouseMove);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.play_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.play_btn.Location = new System.Drawing.Point(89, 28);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(32, 32);
            this.play_btn.TabIndex = 4;
            this.play_btn.Text = ">";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            this.play_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.play_btn_MouseMove);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.add_btn.Location = new System.Drawing.Point(11, 28);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(32, 32);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.add_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.add_btn_MouseMove);
            // 
            // slider_panel
            // 
            this.slider_panel.Controls.Add(this.Slider);
            this.slider_panel.Controls.Add(this.total_time_panel);
            this.slider_panel.Controls.Add(this.cur_time_panel);
            this.slider_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.slider_panel.Location = new System.Drawing.Point(0, 0);
            this.slider_panel.Name = "slider_panel";
            this.slider_panel.Size = new System.Drawing.Size(517, 22);
            this.slider_panel.TabIndex = 3;
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Slider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Slider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Slider.BorderRoundRectSize = new System.Drawing.Size(2, 2);
            this.Slider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Slider.DrawSemitransparentThumb = false;
            this.Slider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Slider.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Slider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Slider.Enabled = false;
            this.Slider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Slider.ForeColor = System.Drawing.Color.White;
            this.Slider.LargeChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Slider.Location = new System.Drawing.Point(50, 0);
            this.Slider.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Slider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Slider.Name = "Slider";
            this.Slider.ScaleDivisions = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Slider.ScaleSubDivisions = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Slider.ShowDivisionsText = false;
            this.Slider.ShowSmallScale = false;
            this.Slider.Size = new System.Drawing.Size(417, 22);
            this.Slider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Slider.TabIndex = 3;
            this.Slider.Text = "Slider";
            this.Slider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Slider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Slider.ThumbRoundRectSize = new System.Drawing.Size(12, 12);
            this.Slider.ThumbSize = new System.Drawing.Size(12, 12);
            this.Slider.TickAdd = 0F;
            this.Slider.TickColor = System.Drawing.Color.White;
            this.Slider.TickDivide = 0F;
            this.Slider.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Slider_Scroll);
            this.Slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMove);
            // 
            // total_time_panel
            // 
            this.total_time_panel.Controls.Add(this.total_time);
            this.total_time_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.total_time_panel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.total_time_panel.Location = new System.Drawing.Point(467, 0);
            this.total_time_panel.Name = "total_time_panel";
            this.total_time_panel.Size = new System.Drawing.Size(50, 22);
            this.total_time_panel.TabIndex = 1;
            // 
            // total_time
            // 
            this.total_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_time.Location = new System.Drawing.Point(0, 0);
            this.total_time.Name = "total_time";
            this.total_time.Size = new System.Drawing.Size(50, 22);
            this.total_time.TabIndex = 0;
            this.total_time.Text = "00:00";
            this.total_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total_time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.total_time_MouseMove);
            // 
            // cur_time_panel
            // 
            this.cur_time_panel.Controls.Add(this.current_time);
            this.cur_time_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cur_time_panel.Location = new System.Drawing.Point(0, 0);
            this.cur_time_panel.Name = "cur_time_panel";
            this.cur_time_panel.Size = new System.Drawing.Size(50, 22);
            this.cur_time_panel.TabIndex = 0;
            // 
            // current_time
            // 
            this.current_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.current_time.ForeColor = System.Drawing.Color.Gainsboro;
            this.current_time.Location = new System.Drawing.Point(0, 0);
            this.current_time.Name = "current_time";
            this.current_time.Size = new System.Drawing.Size(50, 22);
            this.current_time.TabIndex = 0;
            this.current_time.Text = "00:00";
            this.current_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.current_time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.current_time_MouseMove);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // global
            // 
            this.global.Interval = 1;
            this.global.Tick += new System.EventHandler(this.global_Tick);
            // 
            // icon
            // 
            this.icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            this.icon.Text = "Moon Player";
            this.icon.Visible = true;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 754);
            this.Controls.Add(this.main_panel);
            this.Font = new System.Drawing.Font("Motiva Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.pl_panel.ResumeLayout(false);
            this.head_panel.ResumeLayout(false);
            this.caption_panel.ResumeLayout(false);
            this.sys_but_panel.ResumeLayout(false);
            this.controls_panel.ResumeLayout(false);
            this.controls_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_control)).EndInit();
            this.slider_panel.ResumeLayout(false);
            this.total_time_panel.ResumeLayout(false);
            this.cur_time_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel pl_panel;
        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Panel controls_panel;
        private System.Windows.Forms.Panel caption_panel;
        private System.Windows.Forms.Panel sys_but_panel;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.Button exit_btn;
        private PlayListBox.PlayList play_list;
        private System.Windows.Forms.Panel slider_panel;
        private ColorSlider.ColorSlider Slider;
        private System.Windows.Forms.Panel total_time_panel;
        private System.Windows.Forms.Panel cur_time_panel;
        private System.Windows.Forms.Label total_time;
        private System.Windows.Forms.Label current_time;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.TrackBar volume_control;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Timer global;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.CheckBox rnd_index;
        private System.Windows.Forms.Button clear_list;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
    }
}

