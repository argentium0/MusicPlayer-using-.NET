using System.Configuration;
using System.Data.SQLite;

namespace Project_Mp
{

    public partial class Form1 : Form
    {
        string[] paths, files;
        bool isRepeat = false;
        bool isMute = false;
        public Form1()
        {
            InitializeComponent();
            //personal settings
            player.uiMode = "none";
            track_volume.Value = 50;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }



        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex -= 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadSongsFromDatabase();
        }

        private static string Loadcnn(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private void LoadSongsFromDatabase()
        {

            using (var conn = new SQLiteConnection(Loadcnn()))
            {
                conn.Open();
                string query = "SELECT * FROM Songs";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var fileList = new List<string>();
                    var pathList = new List<string>();

                    while (reader.Read())
                    {
                        track_list.Items.Add(reader["Name"].ToString());
                        fileList.Add(reader["Name"].ToString());
                        pathList.Add(reader["Path"].ToString());
                    }

                    files = fileList.ToArray();
                    paths = pathList.ToArray();
                }
            }
        }



        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (track_list.SelectedIndex < 0) return;

            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();

            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {
                pic_art.Image = null;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_track_start_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Create a file doalog obj
            ofd.Multiselect = true; //allow multiple selections
            ofd.Filter = "Audio Files|*.mp3;*.wav;*.m4a;*.wma;*.aac";
            //filter so only audio files are selected

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;

                using (var conn = new SQLiteConnection(Loadcnn()))
                {
                    conn.Open();
                    foreach (string filePath in files)
                    {
                        string fileName = Path.GetFileName(filePath);
                        track_list.Items.Add(fileName);

                        string insert = "INSERT INTO Songs (Name, Path) VALUES (@Name, @Path)";
                        using (var cmd = new SQLiteCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", fileName);
                            cmd.Parameters.AddWithValue("@Path", filePath);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            p_bar.Value = 0;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex += 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia != null)
            {
                try
                {
                    double duration = player.currentMedia.duration;
                    double current = player.Ctlcontrols.currentPosition;

                    p_bar.Maximum = (int)Math.Ceiling(duration);
                    p_bar.Value = Math.Min((int)Math.Ceiling(current), p_bar.Maximum);
                }
                catch { }

                try
                {
                    lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                    lbl_track_start.Visible = true;
                }
                catch
                {
                    lbl_track_start.Visible = false;
                }

                try
                {
                    lbl_track_end.Text = player.currentMedia.durationString;
                    lbl_track_end.Visible = true;
                }
                catch
                {
                    lbl_track_end.Visible = false;
                }
            }
            else
            {
                p_bar.Value = 0;
                lbl_track_end.Visible = false;
                lbl_track_start.Visible = false;
            }


        }


        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            lbl_vol.Text = track_volume.Value.ToString() + "%";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        private void lbl_track_end_Click(object sender, EventArgs e)
        {

        }

        private void pic_art_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    player.Ctlcontrols.pause();
                else
                    player.Ctlcontrols.play();
            }

            if (e.KeyCode == Keys.Down)
            {
                if (player.settings.volume - 5 < 0)
                {
                    player.settings.volume = 0;
                    lbl_vol.Text = "0%";
                }
                else
                {
                    player.settings.volume -= 5;
                    lbl_vol.Text = player.settings.volume.ToString() + "%";
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (player.settings.volume + 5 > 100)
                {
                    player.settings.volume = 100;
                    lbl_vol.Text = "100%";
                }
                else
                {
                    player.settings.volume += 5;
                    lbl_vol.Text = player.settings.volume.ToString() + "%";
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                btn_span_fwd_Click(btn_span_fwd, EventArgs.Empty);
            }

            if (e.KeyCode == Keys.Left)
            {
                btn_span_back_Click(btn_span_back, EventArgs.Empty);
            }

            if (e.KeyCode == Keys.M)
            {
                btn_mute_Click(btn_mute, EventArgs.Empty);
            }

            if (e.KeyCode == Keys.S)
            {
                btn_shuffle_Click(btn_shuffle, EventArgs.Empty);
            }

            if (e.KeyCode == Keys.R)
            {
                btn_repeat_Click(btn_repeat, EventArgs.Empty);
            }

            if (e.KeyCode == Keys.S)
            {
                btn_stop_Click(btn_stop, EventArgs.Empty);
            }
        }

        private void p_bar_Click(object sender, EventArgs e)
        {

        }

        private void btn_span_back_Click(object sender, EventArgs e)
        {
            if (player.Ctlcontrols.currentPosition - 5 < 0)
            {
                player.Ctlcontrols.currentPosition = 0;
            }
            else
            {
                player.Ctlcontrols.currentPosition -= 5;
            }
        }

        private void btn_span_fwd_Click(object sender, EventArgs e)
        {
            if (player.Ctlcontrols.currentPosition + 5 > player.currentMedia.duration)
            {
                player.Ctlcontrols.currentPosition = player.currentMedia.duration;
            }
            else
            {
                player.Ctlcontrols.currentPosition += 5;
            }

        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            if (!isMute)
            {
                isMute = true;
                player.settings.volume = 0;
                track_volume.Value = 0;
                lbl_vol.Text = "0%";
                btn_mute.ForeColor = Color.White;
                btn_mute.BackColor = Color.Green;
            }
            else
            {
                isMute = false;
                track_volume.Value = 10;
                lbl_vol.Text = "10%";
                player.settings.volume = 10;
                btn_mute.ForeColor = Color.FromArgb(255, 128, 0);
                btn_mute.BackColor = Color.Black;
            }

        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            isRepeat = true;
            btn_shuffle.ForeColor = Color.FromArgb(255, 128, 0);
            btn_shuffle.BackColor = Color.Black;

            btn_repeat.ForeColor = Color.White;
            btn_repeat.BackColor = Color.Green;
        }

        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            isRepeat = false;
            btn_repeat.ForeColor = Color.FromArgb(255, 128, 0);
            btn_repeat.BackColor = Color.Black;
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (isRepeat && track_list.SelectedIndex >= 0)
                {
                    player.Ctlcontrols.currentPosition = 0;
                    btn_Play_Click(btn_Play, EventArgs.Empty);
                }
                else
                {
                    if (track_list.SelectedIndex < track_list.Items.Count - 1)
                    {
                        track_list.SelectedIndex += 1;
                        btn_Play_Click(btn_Play, EventArgs.Empty);
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                string songName = track_list.SelectedItem.ToString();
                using (var conn = new SQLiteConnection(Loadcnn()))
                {
                    conn.Open();
                    string sql = "DELETE FROM Songs WHERE Name=@Name";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", songName);
                        cmd.ExecuteNonQuery();
                    }
                }
                track_list.Items.RemoveAt(track_list.SelectedIndex);
            }
        }
    }

}

