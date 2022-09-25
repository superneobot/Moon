using Id3;
using NAudio.Wave;
using System;
using System.IO;
using System.Security;
using System.Linq;

namespace Lib
{
    public class Player
    {
        public IWavePlayer wo;
        public AudioFileReader af;
        public bool playing = false;
        public PlaybackState State;// = PlaybackState.Stopped;
        public bool endFile = false;
        public bool isNext { get; set; } = false;

        public Player()
        {
            wo = new WaveOut();

        }

        public void Play(string path)
        {
            try
            {
                //if (State == PlaybackState.Playing)
                //{
                //    wo.Stop();

                //}
                if (wo == null | wo != null)
                {
                    wo = new WaveOut();
                    wo.PlaybackStopped += (s, a) =>
                    {
                        {
                            wo = null; af = null;
                            //wo.Dispose(); af.Dispose();
                            State = PlaybackState.Stopped;
                        }
                    };
                }
                if (af == null | af != null)
                {
                    af = new AudioFileReader(path);
                    wo.Init(af);
                }
                wo.Play();
                //while (State == PlaybackState.Playing)
                //{
                //    Thread.Sleep(1000);
                //}
                State = PlaybackState.Playing;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void PlayNext(string path)
        {
            if (wo != null && af != null)
            {
                wo.Stop();
                //af.Dispose(); wo.Dispose();
                //af = null; wo = null;
                wo = new WaveOut();
                af = new AudioFileReader(path);
                wo.PlaybackStopped += (s, a) => { { wo.Dispose(); wo = null; af.Dispose(); af = null; State = PlaybackState.Stopped; endFile = true; } };

                wo.Init(af);
            }
            //if(State == PlaybackState.Playing)
            wo.Play();

            State = PlaybackState.Playing;
        }

        public void Next()
        {
            //
        }

        public float getVolume()
        {
            var v = wo.Volume;
            return v;
        }

        public void setVolume(float id)
        {
            wo.Volume = id;
        }

        public void Resume()
        {
            wo.Play();
            State = PlaybackState.Playing;
        }

        public void setPosition(int pos)
        {
            af.Position = pos;
        }

        public void Pause()
        {
            wo.Pause();
            State = PlaybackState.Paused;
        }

        public void Stop()
        {
            wo?.Stop();
            wo?.Dispose();
            af?.Dispose();
            wo = null;
            af = null;
            State = PlaybackState.Stopped;
        }

        public long CurrentPosition()
        {
            long pos = 0;
            try
            {
                pos = af.Position;
            }
            catch { }
            return pos;
        }

        public long TotalTime()
        {
            long total = 0;
            try
            {
                total = af.Length;
            }
            catch { }
            return total;
        }

        public string TotalTime_String()
        {
            string total = "00:00";
            try
            {
                total = af.TotalTime.ToString(@"mm\:ss");
            }
            catch { }
            return total;
        }

        public string CurrentPosition_Stirng()
        {
            string pos = "00:00";
            try
            {
                pos = af.CurrentTime.ToString(@"mm\:ss");
            }
            catch { }
            return pos;
        }
    }
    [Serializable]
    public class Mp3MusicFile
    {
        public string Title;
        public string Artist;
        public string Duration;
        public TimeSpan Length;
        public string FilePath;
        public string FileSize;

        public Mp3MusicFile(string file)
        {
            Title = GetTitle(file);
            Artist = GetArtist(file);
            Duration = GetDuration(file);
            FilePath = GetPath(file);
            Length = GetLength(file);
            FileSize = GetFileSize(file);
        }

        private string GetFileSize(string file)
        {
            string sz = "";
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    var s = fs.Length;
                    var a = (s / 1024) / 1024;
                    sz = $"{a} Mb";
                }
            }
            catch { }
            return sz;
        }

        private TimeSpan GetLength(string file)
        {
            TimeSpan length = TimeSpan.Zero;
            try
            {
                Mp3FileReader reader = new Mp3FileReader(file);
                length = reader.TotalTime;
            }
            catch { }
            return length;
        }

        private string GetPath(string file)
        {
            string path = "";
            try
            {
                path = Path.GetFullPath(file);
            }
            catch { }
            return path;
        }

        private string GetDuration(string file)
        {
            string duration = "";
            try
            {
                Mp3FileReader reader = new Mp3FileReader(file);
                duration = reader.TotalTime.ToString(@"mm\:ss");
            }
            catch { }
            return duration;
        }

        private string GetArtist(string file)
        {
            string artist = "";
            try
            {
                using (var mp3 = new Mp3(file))
                {
                    // try
                    // {
                    Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X);
                    artist = tag.Artists;
                    //  }
                    //  catch { }
                    return artist;
                }
            }
            catch { artist = ""; return artist; }
        }

        private string GetTitle(string file)
        {
            string title = "";
            try
            {
                using (var mp3 = new Mp3(file))
                {
                    //try
                    //{
                    Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X);
                    title = tag.Title;
                    // }
                    // catch { }
                    return title;
                }
            }
            catch
            {
                title = Path.GetFileNameWithoutExtension(file);
                return title;
            }
        }
    }
}
