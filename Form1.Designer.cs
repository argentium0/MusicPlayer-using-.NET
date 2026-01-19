using AxWMPLib;
using WMPLib;


namespace Project_Mp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_preview = new Button();
            btn_Next = new Button();
            btn_Play = new Button();
            btn_open = new Button();
            btn_stop = new Button();
            btn_pause = new Button();
            p_bar = new ProgressBar();
            track_list = new ListBox();
            pic_art = new PictureBox();
            player = new AxWindowsMediaPlayer();
            track_volume = new TrackBar();
            lbl_volume = new Label();
            lbl_track_start = new Label();
            lbl_track_end = new Label();
            panel1 = new Panel();
            btn_remove = new Button();
            btn_mute = new Button();
            btn_repeat = new Button();
            btn_shuffle = new Button();
            lbl_vol = new Label();
            btn_span_fwd = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_span_back = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pic_art).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)track_volume).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_preview
            // 
            btn_preview.FlatStyle = FlatStyle.Flat;
            btn_preview.Font = new Font("Microsoft Sans Serif", 14F);
            btn_preview.Location = new Point(13, 292);
            btn_preview.Name = "btn_preview";
            btn_preview.Size = new Size(94, 38);
            btn_preview.TabIndex = 0;
            btn_preview.Text = "⏮\r\n";
            btn_preview.UseVisualStyleBackColor = true;
            btn_preview.Click += btn_preview_Click;
            // 
            // btn_Next
            // 
            btn_Next.FlatStyle = FlatStyle.Flat;
            btn_Next.Font = new Font("Microsoft Sans Serif", 14F);
            btn_Next.Location = new Point(113, 292);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(94, 38);
            btn_Next.TabIndex = 1;
            btn_Next.Text = "⏭\r\n";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Play
            // 
            btn_Play.FlatStyle = FlatStyle.Flat;
            btn_Play.Font = new Font("Microsoft Sans Serif", 14F);
            btn_Play.Location = new Point(213, 292);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(94, 38);
            btn_Play.TabIndex = 2;
            btn_Play.Text = "▶\r\n";
            btn_Play.UseVisualStyleBackColor = true;
            btn_Play.Click += btn_Play_Click;
            // 
            // btn_open
            // 
            btn_open.FlatStyle = FlatStyle.Flat;
            btn_open.Font = new Font("Microsoft Sans Serif", 10F);
            btn_open.Location = new Point(513, 292);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(108, 38);
            btn_open.TabIndex = 3;
            btn_open.Text = "Add";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_stop
            // 
            btn_stop.FlatStyle = FlatStyle.Flat;
            btn_stop.Font = new Font("Microsoft Sans Serif", 14F);
            btn_stop.Location = new Point(413, 292);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(94, 38);
            btn_stop.TabIndex = 4;
            btn_stop.Text = "⏹\r\n";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_pause
            // 
            btn_pause.BackColor = Color.Black;
            btn_pause.FlatStyle = FlatStyle.Flat;
            btn_pause.Font = new Font("Microsoft Sans Serif", 14F);
            btn_pause.Image = (Image)resources.GetObject("btn_pause.Image");
            btn_pause.Location = new Point(313, 292);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(94, 38);
            btn_pause.TabIndex = 5;
            btn_pause.Text = "⏸\r\n";
            btn_pause.UseVisualStyleBackColor = false;
            btn_pause.Click += btn_pause_Click;
            // 
            // p_bar
            // 
            p_bar.Location = new Point(61, 270);
            p_bar.Name = "p_bar";
            p_bar.Size = new Size(510, 12);
            p_bar.TabIndex = 6;
            p_bar.Click += p_bar_Click;
            p_bar.MouseDown += p_bar_MouseDown;
            // 
            // track_list
            // 
            track_list.BackColor = SystemColors.WindowFrame;
            track_list.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            track_list.ForeColor = Color.White;
            track_list.FormattingEnabled = true;
            track_list.Location = new Point(180, 3);
            track_list.Name = "track_list";
            track_list.Size = new Size(379, 144);
            track_list.TabIndex = 7;
            track_list.SelectedIndexChanged += track_list_SelectedIndexChanged;
            // 
            // pic_art
            // 
            pic_art.BackgroundImageLayout = ImageLayout.Stretch;
            pic_art.Image = (Image)resources.GetObject("pic_art.Image");
            pic_art.Location = new Point(3, 5);
            pic_art.Name = "pic_art";
            pic_art.Size = new Size(170, 136);
            pic_art.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_art.TabIndex = 8;
            pic_art.TabStop = false;
            pic_art.Click += pic_art_Click;
            // 
            // player
            // 
            player.Dock = DockStyle.Top;
            player.Enabled = true;
            player.Location = new Point(0, 0);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(632, 69);
            player.TabIndex = 9;
            player.PlayStateChange += player_PlayStateChange;
            // 
            // track_volume
            // 
            track_volume.BackColor = Color.FromArgb(192, 0, 0);
            track_volume.Location = new Point(573, 28);
            track_volume.Maximum = 100;
            track_volume.Name = "track_volume";
            track_volume.Orientation = Orientation.Vertical;
            track_volume.Size = new Size(56, 122);
            track_volume.TabIndex = 10;
            track_volume.TickStyle = TickStyle.TopLeft;
            track_volume.Scroll += track_volume_Scroll;
            // 
            // lbl_volume
            // 
            lbl_volume.AutoSize = true;
            lbl_volume.BackColor = Color.FromArgb(192, 0, 0);
            lbl_volume.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_volume.ForeColor = Color.White;
            lbl_volume.Location = new Point(565, 144);
            lbl_volume.Name = "lbl_volume";
            lbl_volume.Size = new Size(56, 19);
            lbl_volume.TabIndex = 11;
            lbl_volume.Text = "Volume";
            lbl_volume.Click += label1_Click;
            // 
            // lbl_track_start
            // 
            lbl_track_start.AutoSize = true;
            lbl_track_start.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_start.ForeColor = Color.Transparent;
            lbl_track_start.Location = new Point(-2, 21);
            lbl_track_start.Name = "lbl_track_start";
            lbl_track_start.Size = new Size(108, 35);
            lbl_track_start.TabIndex = 12;
            lbl_track_start.Text = "00:00";
            lbl_track_start.Click += lbl_track_start_Click;
            // 
            // lbl_track_end
            // 
            lbl_track_end.AutoSize = true;
            lbl_track_end.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_end.ForeColor = Color.Transparent;
            lbl_track_end.Location = new Point(529, 21);
            lbl_track_end.Name = "lbl_track_end";
            lbl_track_end.Size = new Size(108, 35);
            lbl_track_end.TabIndex = 13;
            lbl_track_end.Text = "00:00";
            lbl_track_end.Click += lbl_track_end_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(btn_remove);
            panel1.Controls.Add(btn_mute);
            panel1.Controls.Add(btn_repeat);
            panel1.Controls.Add(btn_shuffle);
            panel1.Controls.Add(pic_art);
            panel1.Controls.Add(lbl_vol);
            panel1.Controls.Add(track_list);
            panel1.Controls.Add(lbl_volume);
            panel1.Controls.Add(track_volume);
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 182);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Black;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Location = new Point(322, 150);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(85, 29);
            btn_remove.TabIndex = 19;
            btn_remove.Text = "Remove\n";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_mute
            // 
            btn_mute.BackColor = Color.Black;
            btn_mute.FlatStyle = FlatStyle.Flat;
            btn_mute.Location = new Point(113, 147);
            btn_mute.Name = "btn_mute";
            btn_mute.Size = new Size(46, 29);
            btn_mute.TabIndex = 18;
            btn_mute.Text = "🔇\r\n";
            btn_mute.UseVisualStyleBackColor = false;
            btn_mute.Click += btn_mute_Click;
            // 
            // btn_repeat
            // 
            btn_repeat.BackColor = Color.Black;
            btn_repeat.FlatStyle = FlatStyle.Flat;
            btn_repeat.Location = new Point(13, 147);
            btn_repeat.Name = "btn_repeat";
            btn_repeat.Size = new Size(46, 29);
            btn_repeat.TabIndex = 17;
            btn_repeat.Text = "🔁\r\n";
            btn_repeat.UseVisualStyleBackColor = false;
            btn_repeat.Click += btn_repeat_Click;
            // 
            // btn_shuffle
            // 
            btn_shuffle.BackColor = Color.Black;
            btn_shuffle.FlatStyle = FlatStyle.Flat;
            btn_shuffle.Location = new Point(61, 147);
            btn_shuffle.Name = "btn_shuffle";
            btn_shuffle.Size = new Size(46, 29);
            btn_shuffle.TabIndex = 16;
            btn_shuffle.Text = "🔀\r\n";
            btn_shuffle.UseVisualStyleBackColor = false;
            btn_shuffle.Click += btn_shuffle_Click;
            // 
            // lbl_vol
            // 
            lbl_vol.AutoSize = true;
            lbl_vol.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_vol.ForeColor = Color.White;
            lbl_vol.Location = new Point(573, 17);
            lbl_vol.Name = "lbl_vol";
            lbl_vol.Size = new Size(40, 18);
            lbl_vol.TabIndex = 15;
            lbl_vol.Text = "50%";
            // 
            // btn_span_fwd
            // 
            btn_span_fwd.Font = new Font("Showcard Gothic", 8F, FontStyle.Bold);
            btn_span_fwd.Location = new Point(577, 263);
            btn_span_fwd.Name = "btn_span_fwd";
            btn_span_fwd.Size = new Size(44, 25);
            btn_span_fwd.TabIndex = 15;
            btn_span_fwd.Text = "+5";
            btn_span_fwd.UseVisualStyleBackColor = true;
            btn_span_fwd.Click += btn_span_fwd_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btn_span_back
            // 
            btn_span_back.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_span_back.Location = new Point(13, 263);
            btn_span_back.Name = "btn_span_back";
            btn_span_back.Size = new Size(44, 25);
            btn_span_back.TabIndex = 16;
            btn_span_back.Text = "-5";
            btn_span_back.UseVisualStyleBackColor = true;
            btn_span_back.Click += btn_span_back_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(632, 333);
            Controls.Add(btn_span_back);
            Controls.Add(btn_span_fwd);
            Controls.Add(lbl_track_end);
            Controls.Add(lbl_track_start);
            Controls.Add(p_bar);
            Controls.Add(btn_pause);
            Controls.Add(btn_stop);
            Controls.Add(btn_open);
            Controls.Add(btn_Play);
            Controls.Add(btn_Next);
            Controls.Add(btn_preview);
            Controls.Add(panel1);
            Controls.Add(player);
            ForeColor = Color.FromArgb(255, 128, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(650, 380);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViConnect";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pic_art).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)track_volume).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion

        private Button btn_preview;
        private Button btn_Next;
        private Button btn_Play;
        private Button btn_open;
        private Button btn_stop;
        private Button btn_pause;
        private ProgressBar p_bar;
        private ListBox track_list;
        private PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private TrackBar track_volume;
        private Label lbl_volume;
        private Label lbl_track_start;
        private Label lbl_track_end;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_vol;
        private Button btn_span_fwd;
        private Button btn_span_back;
        private Button btn_repeat;
        private Button btn_shuffle;
        private Button btn_mute;
        private System.Windows.Forms.Timer timer2;
        private Button btn_remove;
    }
}
