using Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Moon
{
    public partial class mainform : Form
    {
        Player player;
        List<Mp3MusicFile> musicFiles;
        const string def_file = "data.moon";
        //
        int left, top;
        bool autosave_added_files = false;
        public int loc;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public mainform()
        {
            InitializeComponent();
            player = new Player();
            musicFiles = new List<Mp3MusicFile>();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            play_list.Items.Clear();
            size_base.Text = "0 files";
            if (File.Exists(AppContext.BaseDirectory + def_file))
            {
                File.Delete(AppContext.BaseDirectory + def_file);
            }
            tip.Text = "No files selected";
            Text = "Moon []";
        }

        private void file_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (play_list.Items.Count != -1)
            {
                var index = play_list.Items.IndexOf(play_list.SelectedItems[0]);
                file_path.Text = musicFiles[index].FilePath;
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Mp3 music *.mp3|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    progress.Visible = true;
                    status.Visible = true;
                    musicFiles.Clear();
                    play_list.Items.Clear();
                    var file = ofd.FileNames;
                    progress.Maximum = file.Length - 1;
                    status.Text = "Loading";
                    for (int i = 0; i < file.Length; i++)
                    {
                        progress.Value = i;
                        //play_list.Items.Add(Path.GetFileNameWithoutExtension(file[i]) + $"[]");
                        //filelist.AddFile(Path.GetFileName(file[i]), file[i]);
                        musicFiles.Add(new Mp3MusicFile(file[i]));
                    }
                    size_base.Text = $"{musicFiles.Count} files";
                    progress.Value = 0;
                    status.Text = "Done";
                    progress.Visible = false;
                    status.Visible = false;
                }
                foreach (var file in musicFiles)
                {
                    play_list.Items.Add(file.Title + "- " + file.Artist + " - " + file.Length);
                }
            }
            if (autosave_added_files)
            {

            }
        }

        private void play_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adding_state_Click(object sender, EventArgs e)
        {
            if (!adding_state.Checked)
            {
                adding_state.Checked = true;
                autosave_added_files = true;
            }
            else
            {
                adding_state.Checked = false;
                autosave_added_files = false; ;
            }
        }

        private void save_tool_Click(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {
            var file = File.ReadAllLines(AppContext.BaseDirectory + "settings.ini");
            var a = Int32.Parse(file[0]);
            var b = Int32.Parse(file[1]);
            Left = a; Top = b;
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (musicFiles.Count != 0)
            {
                int index = play_list.SelectedIndex;
                var fil_to_play = musicFiles[index].FilePath;
                var file_name = musicFiles[index].FilePath;
                player.Play(file_name);
                //play_list.SelectedItem = index;
                timer.Start();
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(() =>
            {
                player.Stop();
            });
            tr.IsBackground = true;
            tr.Start();
            timer.Stop();
            //seeker.Value = 0;
            //seeker.Maximum = 0;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void top_p_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void play_list_Leave(object sender, EventArgs e)
        {
            //play_list.SelectedItem = play_list.Items[index];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int index = play_list.SelectedIndex;
            var t = player.CurrentPosition(musicFiles[index].FilePath);
            var s = player.TotalTime(musicFiles[index].FilePath);
            var t_str = player.CurrentPosition_Stirng(musicFiles[index].FilePath);
            var s_str = player.TotalTime_String(musicFiles[index].FilePath);
            musicSeeker.CurrentTime = t_str;
            musicSeeker.TotalTime = s_str;
            musicSeeker.Maximum = (int)s;
            musicSeeker.Value = (int)t;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void musicSeeker_MouseMove(object sender, MouseEventArgs e)
        {
            loc = e.Location.X;
            Text = $"{loc}";
            
        }

        private void musicSeeker_Click(object sender, EventArgs e)
        {
            player.setPosition(loc);
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            left = Left;
            top = Top;
            File.WriteAllLines(AppContext.BaseDirectory + "settings.ini", new string[] { left.ToString(), top.ToString() });
        }
    }
}
