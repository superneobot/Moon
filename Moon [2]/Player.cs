using Lib;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Moon__2_
{
    public partial class Player : Form
    {
        static List<Mp3MusicFile> musicFiles;
        static List<Mp3MusicFile> temp;
        static Lib.Player player;
        public bool rnd = false;
        public int[] history_index = new int[3]; //0 prev, 1 current, 2 new

        int selected_index = 0;
        string file_to_play = "";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Player()
        {
            InitializeComponent();

            musicFiles = new List<Mp3MusicFile>();
            temp = new List<Mp3MusicFile>();
            player = new Lib.Player();

            icon.MouseMove += (s, a) => { { try { icon.Text = $"Moon Player - {musicFiles[selected_index].Artist} - {musicFiles[selected_index].Title}"; } catch { } } };
        }

        public Player(string file)
        {
            InitializeComponent();
            musicFiles = new List<Mp3MusicFile>();
            player = new Lib.Player();
            musicFiles.Add(new Mp3MusicFile(file));
            play_list.Items.Add("[" + musicFiles[0].Duration + "] " + musicFiles[0].Artist + " - " + musicFiles[0].Title + "[" + musicFiles[0].FileSize + "]");
            
            player.Play(file);
        }

        private void caption_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            icon.Dispose();
            var left = Left;
            var top = Top;
            var volume = volume_control.Value;
            File.WriteAllLines(AppContext.BaseDirectory + "settings.ini", new string[] { left.ToString(), top.ToString(), volume.ToString() });
        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            //TODO hiding form to tray
            this.Hide();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Mp3 music *.mp3|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    temp.Clear();
                    int id = musicFiles.Count;

                    foreach (var item in ofd.FileNames)
                    {
                        temp.Add(new Mp3MusicFile(item));
                        id++;
                    }
                }
                foreach (var item in temp)
                {
                    musicFiles.Add(item);
                }
                play_list.Items.Clear();
                foreach (var file in musicFiles)
                {
                    play_list.Items.Add("["+ file.Duration + "] " + file.Artist + " - " + file.Title + "["+file.FileSize+"]");
                }
                if (player.State == NAudio.Wave.PlaybackState.Playing)
                {
                    play_list.SelectedItem = play_list.Items[0];
                }
            }
        }

        private void play_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (play_list.SelectedIndex != -1)
            {
                selected_index = play_list.SelectedIndex;
                file_to_play = musicFiles[selected_index].FilePath;
                play_list.SelectedItem = play_list.Items[selected_index];

            }
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            if (player.State == NAudio.Wave.PlaybackState.Playing)
            {
                player.Pause();
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (play_list.Items.Count > 0)
            {
                if (play_list.Items.Count == 1)
                {
                    play_list.SelectedIndex = 0;
                }
                if (play_list.SelectedIndex == -1)
                {
                    selected_index = 0;
                    play_list.SelectedItem = play_list.Items[selected_index];
                }
                if (player.State != NAudio.Wave.PlaybackState.Playing)
                {
                    player.Play(file_to_play);
                    total_time.Text = player.TotalTime_String();
                    Slider.Maximum = player.TotalTime();
                    timer.Start();
                    play_list.SelectedItem = play_list.Items[selected_index];
                    next_btn.Enabled = true;
                    prev_btn.Enabled = true;
                    Slider.Enabled = true;
                    
                }
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                current_time.Text = player.CurrentPosition_Stirng();
                title.Text = $"Moon Player - {player.State}";
                Slider.Value = player.CurrentPosition();
                global.Start();
            }
            catch { }
        }

        private void Slider_Scroll(object sender, ScrollEventArgs e)
        {
            var pos = Slider.Value;
            player.setPosition((int)pos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(AppContext.BaseDirectory + "settings.ini"))
            {
                var file = File.ReadAllLines(AppContext.BaseDirectory + "settings.ini");
                var left = Int32.Parse(file[0]);
                var top = Int32.Parse(file[1]);
                var volume = (float)Int32.Parse(file[2]) / 100;
                Left = left; Top = top;
                //volume_state.Text = $"Громкость - {volume * 100}";
                volume_control.Value = (int)(volume * 100);
                player.setVolume(volume);
            }
            title.Text = $"Moon Player - {player.State}";
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            global.Stop();
            timer.Stop();
            player.Stop();
            current_time.Text = "00:00";
            total_time.Text = "00:00";
            Slider.Value = 0;
            title.Text = $"Moon Player - {player.State}";
            next_btn.Enabled = false;
            prev_btn.Enabled = false;
            Slider.Enabled = false;
        }

        private void volume_control_Scroll(object sender, EventArgs e)
        {
            var s = (float)volume_control.Value / 100;
            //volume_state.Text = $"Громкость - {s * 100}";
            tip.SetToolTip(volume_control, $"Громкость - {s*100}");
            player.setVolume(s);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (play_list.Items.Count > 1)
            {
                try
                {
                    if (rnd)
                    {
                        selected_index = Random(play_list.Items.Count);
                        history_index[1] = selected_index;
                        //MessageBox.Show($"{selected_index}");
                    }
                    else
                    {
                        selected_index++;
                    }
                    player.Stop();
                    file_to_play = musicFiles[selected_index].FilePath;
                    player.Play(file_to_play);
                    total_time.Text = player.TotalTime_String();
                    Slider.Maximum = player.TotalTime();
                    play_list.SelectedItem = play_list.Items[selected_index];
                }
                catch
                {
                    selected_index = 0;
                    player.Stop();
                    file_to_play = musicFiles[selected_index].FilePath;
                    player.Play(file_to_play);
                    total_time.Text = player.TotalTime_String();
                    Slider.Maximum = player.TotalTime();
                    play_list.SelectedItem = play_list.Items[selected_index];
                }
            }
        }

        private int Random(int max)
        {
            Random rnd = new Random();
            var i = rnd.Next(max);
            history_index[2] = i;
            return i;
        }

        private void global_Tick(object sender, EventArgs e)
        {
            //title.Text = $" {player.endReached}";
            if (player.State == NAudio.Wave.PlaybackState.Stopped)
            {
                try
                {
                    if (rnd)
                    {
                        selected_index = Random(play_list.Items.Count);
                    }
                    else
                    {
                        selected_index++;
                    }
                    //player.Stop();
                    file_to_play = musicFiles[selected_index].FilePath;
                    player.Play(file_to_play);
                    total_time.Text = player.TotalTime_String();
                    Slider.Maximum = player.TotalTime();
                    play_list.SelectedItem = play_list.Items[selected_index];
                    global.Stop();
                }
                catch
                {
                    selected_index = 0;
                    //player.Stop();
                    file_to_play = musicFiles[selected_index].FilePath;
                    player.Play(file_to_play);
                    total_time.Text = player.TotalTime_String();
                    Slider.Maximum = player.TotalTime();
                    play_list.SelectedItem = play_list.Items[selected_index];
                    global.Stop();
                }
            }
        }

        private void play_list_Leave(object sender, EventArgs e)
        {
            play_list.Focus();
        }

        private void play_list_MeasureItem(object sender, MeasureItemEventArgs e)
        {

        }

        private void play_list_Click(object sender, EventArgs e)
        {
            if (play_list.SelectedIndex == -1)
            {
                //play_list.SelectedItem = play_list.Items[selected_index];
                //MessageBox.Show($"{play_list.SelectedIndex}");
            }
        }

        private void rnd_index_Click(object sender, EventArgs e)
        {
            if (rnd_index.Checked)
                rnd = true;
            else
                rnd = false;
        }

        private void clear_list_Click(object sender, EventArgs e)
        {
            play_list.Items.Clear();
            musicFiles.Clear();
            temp.Clear();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (play_list.Items.Count > 1)
            {
                try
                {
                    if (rnd)
                    {
                        selected_index = history_index[0];
                        //MessageBox.Show($"{selected_index}");
                    }
                    else
                    {
                        selected_index--;
                    }
                    player.Stop();
                    file_to_play = musicFiles[selected_index].FilePath;
                    player.Play(file_to_play);
                    total_time.Text = player.TotalTime_String();
                    Slider.Maximum = player.TotalTime();
                    play_list.SelectedItem = play_list.Items[selected_index];
                }
                catch
                {
                    selected_index = 0;
                    player.Stop();
                    file_to_play = musicFiles[selected_index].FilePath;
                    player.Play(file_to_play);
                    total_time.Text = player.TotalTime_String();
                    Slider.Maximum = player.TotalTime();
                    play_list.SelectedItem = play_list.Items[selected_index];
                }
            }
        }

        private void icon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Slider_MouseMove(object sender, MouseEventArgs e)
        {
            long Faktor = (player.TotalTime() / Slider.Width)/360;
            var time_pos = Faktor * e.X;
            var time_tip = TimeSpan.FromMilliseconds(time_pos).ToString();
            var index = time_tip.IndexOf('.');
            if (index >= 0)
            {
                time_tip = time_tip.Substring(0, index);
            }

            tip.SetToolTip(Slider, time_tip);
        }

        private void add_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(add_btn, "Добавить файлы");
        }

        private void prev_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(prev_btn, "Предыдущий файл");
        }

        private void play_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(play_btn, "Воспроизведение");
        }

        private void pause_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(pause_btn, "Пауза");
        }

        private void stop_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(stop_btn, "Стоп");
        }

        private void next_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(next_btn, "Следующий файл");
        }

        private void rnd_index_MouseMove(object sender, MouseEventArgs e)
        {
            if (rnd)
                tip.SetToolTip(rnd_index, "Выключить случайное воспроизведение");
            else
                tip.SetToolTip(rnd_index, "Включить случайное воспроизведение");
        }

        private void clear_list_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(clear_list, "Очистить список файлов");
        }

        private void current_time_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(current_time, "Текущее время");
        }

        private void total_time_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(total_time, "Длина файла");
        }

        private void exit_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(exit_btn, "Закрыть программу");
        }

        private void hide_btn_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(hide_btn, "Свернуть программу");
        }

        private void load_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(load, "Загрузить список");
        }

        private void save_MouseMove(object sender, MouseEventArgs e)
        {
            tip.SetToolTip(save, "Сохранить список");
        }

        private void SaveList(string path)
        {
            var list = JsonConvert.SerializeObject(musicFiles, Formatting.Indented);
            File.WriteAllText(path, list);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveList(AppContext.BaseDirectory + "default.json");
            System.Windows.Forms.MessageBox.Show("Список сохранен", "Moon Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<Mp3MusicFile> LoadList(string path)
        {
            var list = File.ReadAllText(path);
            var files = JsonConvert.DeserializeObject<List<Mp3MusicFile>>(list);
            return files;
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppContext.BaseDirectory + "default.json"))
            {
                musicFiles = LoadList(AppContext.BaseDirectory + "default.json");
                foreach (var file in musicFiles)
                {
                    play_list.Items.Add("[" + file.Duration + "] " + file.Artist + " - " + file.Title + "[" + file.FileSize + "]");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Нет сохраненного списка","Moon Player",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
