namespace Music_Player
{
    partial class MMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMain));
            this.ptitle = new System.Windows.Forms.Panel();
            this.psmall = new System.Windows.Forms.PictureBox();
            this.pbig = new System.Windows.Forms.PictureBox();
            this.pclose = new System.Windows.Forms.PictureBox();
            this.demoName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pMusiccondition = new System.Windows.Forms.PictureBox();
            this.pkbVolbar = new System.Windows.Forms.Panel();
            this.pkbMovebar = new System.Windows.Forms.Panel();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.lbcurrTime = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pkbVol = new System.Windows.Forms.PictureBox();
            this.pkbMove = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MusicData = new System.Windows.Forms.ListBox();
            this.PsmallShow = new System.Windows.Forms.Panel();
            this.MusicName = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.albumart = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectMusic = new System.Windows.Forms.Label();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.lanumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MusicDate = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tool = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.play = new System.Windows.Forms.ToolStripMenuItem();
            this.nextplay = new System.Windows.Forms.ToolStripMenuItem();
            this.openDic = new System.Windows.Forms.ToolStripMenuItem();
            this.remove = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tpmgressbar = new System.Windows.Forms.Timer(this.components);
            this.pshow = new System.Windows.Forms.Panel();
            this.LlrcShow = new System.Windows.Forms.ListBox();
            this.tlrc = new System.Windows.Forms.Timer(this.components);
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbigimage = new System.Windows.Forms.PictureBox();
            this.pshrink = new System.Windows.Forms.PictureBox();
            this.ptitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMusiccondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkbVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkbMove)).BeginInit();
            this.panel3.SuspendLayout();
            this.PsmallShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumart)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tool.SuspendLayout();
            this.pshow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbigimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pshrink)).BeginInit();
            this.SuspendLayout();
            // 
            // ptitle
            // 
            this.ptitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(131)))));
            this.ptitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptitle.Controls.Add(this.psmall);
            this.ptitle.Controls.Add(this.pbig);
            this.ptitle.Controls.Add(this.pclose);
            this.ptitle.Controls.Add(this.demoName);
            this.ptitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptitle.Location = new System.Drawing.Point(0, 0);
            this.ptitle.Name = "ptitle";
            this.ptitle.Size = new System.Drawing.Size(1210, 46);
            this.ptitle.TabIndex = 0;
            this.ptitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ptitle_MouseDown);
            this.ptitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ptitle_MouseMove);
            this.ptitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ptitle_MouseUp);
            // 
            // psmall
            // 
            this.psmall.Image = global::Music_Player.Properties.Resources.缩小;
            this.psmall.Location = new System.Drawing.Point(1073, 1);
            this.psmall.Name = "psmall";
            this.psmall.Size = new System.Drawing.Size(40, 40);
            this.psmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.psmall.TabIndex = 3;
            this.psmall.TabStop = false;
            this.psmall.Click += new System.EventHandler(this.PboxList_Click);
            // 
            // pbig
            // 
            this.pbig.Image = global::Music_Player.Properties.Resources.放大;
            this.pbig.Location = new System.Drawing.Point(1119, 1);
            this.pbig.Name = "pbig";
            this.pbig.Size = new System.Drawing.Size(40, 40);
            this.pbig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbig.TabIndex = 2;
            this.pbig.TabStop = false;
            this.pbig.Click += new System.EventHandler(this.PboxList_Click);
            // 
            // pclose
            // 
            this.pclose.Image = global::Music_Player.Properties.Resources.关闭;
            this.pclose.Location = new System.Drawing.Point(1165, 1);
            this.pclose.Name = "pclose";
            this.pclose.Size = new System.Drawing.Size(40, 40);
            this.pclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pclose.TabIndex = 1;
            this.pclose.TabStop = false;
            this.pclose.Click += new System.EventHandler(this.PboxList_Click);
            // 
            // demoName
            // 
            this.demoName.AutoSize = true;
            this.demoName.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.demoName.Location = new System.Drawing.Point(545, 9);
            this.demoName.Name = "demoName";
            this.demoName.Size = new System.Drawing.Size(175, 33);
            this.demoName.TabIndex = 0;
            this.demoName.Text = "Music Play";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pMusiccondition);
            this.panel2.Controls.Add(this.pkbVolbar);
            this.panel2.Controls.Add(this.pkbMovebar);
            this.panel2.Controls.Add(this.lbEndTime);
            this.panel2.Controls.Add(this.lbcurrTime);
            this.panel2.Controls.Add(this.pbNext);
            this.panel2.Controls.Add(this.pbVolume);
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Controls.Add(this.pbPlay);
            this.panel2.Controls.Add(this.pkbVol);
            this.panel2.Controls.Add(this.pkbMove);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 616);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 63);
            this.panel2.TabIndex = 1;
            // 
            // pMusiccondition
            // 
            this.pMusiccondition.Image = global::Music_Player.Properties.Resources.顺序;
            this.pMusiccondition.Location = new System.Drawing.Point(1160, 20);
            this.pMusiccondition.Name = "pMusiccondition";
            this.pMusiccondition.Size = new System.Drawing.Size(24, 24);
            this.pMusiccondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pMusiccondition.TabIndex = 30;
            this.pMusiccondition.TabStop = false;
            this.pMusiccondition.Click += new System.EventHandler(this.PboxList_Click);
            this.pMusiccondition.MouseEnter += new System.EventHandler(this.EnterList_MouseEnter);
            this.pMusiccondition.MouseLeave += new System.EventHandler(this.LeaveList_MouseLeave);
            // 
            // pkbVolbar
            // 
            this.pkbVolbar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pkbVolbar.Location = new System.Drawing.Point(1020, 32);
            this.pkbVolbar.Name = "pkbVolbar";
            this.pkbVolbar.Size = new System.Drawing.Size(117, 6);
            this.pkbVolbar.TabIndex = 27;
            this.pkbVolbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MovebarList_MouseClick);
            // 
            // pkbMovebar
            // 
            this.pkbMovebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pkbMovebar.Location = new System.Drawing.Point(276, 32);
            this.pkbMovebar.Name = "pkbMovebar";
            this.pkbMovebar.Size = new System.Drawing.Size(645, 6);
            this.pkbMovebar.TabIndex = 26;
            this.pkbMovebar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MovebarList_MouseClick);
            // 
            // lbEndTime
            // 
            this.lbEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lbEndTime.ForeColor = System.Drawing.Color.Black;
            this.lbEndTime.Location = new System.Drawing.Point(922, 29);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(59, 15);
            this.lbEndTime.TabIndex = 25;
            this.lbEndTime.Text = "00:00";
            // 
            // lbcurrTime
            // 
            this.lbcurrTime.BackColor = System.Drawing.Color.Transparent;
            this.lbcurrTime.ForeColor = System.Drawing.Color.Black;
            this.lbcurrTime.Location = new System.Drawing.Point(204, 29);
            this.lbcurrTime.Name = "lbcurrTime";
            this.lbcurrTime.Size = new System.Drawing.Size(37, 15);
            this.lbcurrTime.TabIndex = 24;
            this.lbcurrTime.Text = "00:00";
            // 
            // pbNext
            // 
            this.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNext.Image = global::Music_Player.Properties.Resources.next;
            this.pbNext.Location = new System.Drawing.Point(121, 6);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(48, 48);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 23;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.PboxList_Click);
            this.pbNext.MouseEnter += new System.EventHandler(this.EnterList_MouseEnter);
            this.pbNext.MouseLeave += new System.EventHandler(this.LeaveList_MouseLeave);
            // 
            // pbVolume
            // 
            this.pbVolume.Image = global::Music_Player.Properties.Resources.音量;
            this.pbVolume.Location = new System.Drawing.Point(987, 20);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(24, 24);
            this.pbVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVolume.TabIndex = 20;
            this.pbVolume.TabStop = false;
            this.pbVolume.Click += new System.EventHandler(this.PboxList_Click);
            this.pbVolume.MouseEnter += new System.EventHandler(this.EnterList_MouseEnter);
            this.pbVolume.MouseLeave += new System.EventHandler(this.LeaveList_MouseLeave);
            // 
            // pbBack
            // 
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::Music_Player.Properties.Resources.up;
            this.pbBack.Location = new System.Drawing.Point(13, 6);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(48, 48);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 22;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.PboxList_Click);
            this.pbBack.MouseEnter += new System.EventHandler(this.EnterList_MouseEnter);
            this.pbBack.MouseLeave += new System.EventHandler(this.LeaveList_MouseLeave);
            // 
            // pbPlay
            // 
            this.pbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Image = global::Music_Player.Properties.Resources.play;
            this.pbPlay.Location = new System.Drawing.Point(67, 6);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(48, 48);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlay.TabIndex = 21;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.PbPlay_Click);
            this.pbPlay.MouseEnter += new System.EventHandler(this.EnterList_MouseEnter);
            this.pbPlay.MouseLeave += new System.EventHandler(this.LeaveList_MouseLeave);
            // 
            // pkbVol
            // 
            this.pkbVol.BackColor = System.Drawing.Color.Transparent;
            this.pkbVol.BackgroundImage = global::Music_Player.Properties.Resources.圆圈;
            this.pkbVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pkbVol.Image = global::Music_Player.Properties.Resources.圆圈;
            this.pkbVol.Location = new System.Drawing.Point(1067, 24);
            this.pkbVol.Name = "pkbVol";
            this.pkbVol.Size = new System.Drawing.Size(20, 20);
            this.pkbVol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pkbVol.TabIndex = 29;
            this.pkbVol.TabStop = false;
            // 
            // pkbMove
            // 
            this.pkbMove.BackColor = System.Drawing.Color.Transparent;
            this.pkbMove.BackgroundImage = global::Music_Player.Properties.Resources.圆圈;
            this.pkbMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pkbMove.Image = global::Music_Player.Properties.Resources.圆圈;
            this.pkbMove.Location = new System.Drawing.Point(273, 24);
            this.pkbMove.Name = "pkbMove";
            this.pkbMove.Size = new System.Drawing.Size(20, 20);
            this.pkbMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pkbMove.TabIndex = 28;
            this.pkbMove.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.MusicData);
            this.panel3.Controls.Add(this.PsmallShow);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 570);
            this.panel3.TabIndex = 2;
            // 
            // MusicData
            // 
            this.MusicData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.MusicData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusicData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MusicData.ForeColor = System.Drawing.Color.Transparent;
            this.MusicData.FormattingEnabled = true;
            this.MusicData.ItemHeight = 12;
            this.MusicData.Location = new System.Drawing.Point(0, 31);
            this.MusicData.Name = "MusicData";
            this.MusicData.Size = new System.Drawing.Size(248, 458);
            this.MusicData.TabIndex = 4;
            this.MusicData.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MusicData_DrawItem);
            this.MusicData.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MusicData_MeasureItem);
            // 
            // PsmallShow
            // 
            this.PsmallShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PsmallShow.Controls.Add(this.MusicName);
            this.PsmallShow.Controls.Add(this.author);
            this.PsmallShow.Controls.Add(this.albumart);
            this.PsmallShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PsmallShow.Location = new System.Drawing.Point(0, 489);
            this.PsmallShow.Name = "PsmallShow";
            this.PsmallShow.Size = new System.Drawing.Size(248, 79);
            this.PsmallShow.TabIndex = 3;
            this.PsmallShow.MouseEnter += new System.EventHandler(this.PsmallShow_MouseEnter);
            this.PsmallShow.MouseLeave += new System.EventHandler(this.PsmallShow_MouseLeave);
            // 
            // MusicName
            // 
            this.MusicName.AutoSize = true;
            this.MusicName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicName.Location = new System.Drawing.Point(97, 12);
            this.MusicName.Name = "MusicName";
            this.MusicName.Size = new System.Drawing.Size(63, 14);
            this.MusicName.TabIndex = 2;
            this.MusicName.Text = "歌曲名字";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.author.Location = new System.Drawing.Point(98, 52);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(49, 14);
            this.author.TabIndex = 1;
            this.author.Text = "歌唱者";
            // 
            // albumart
            // 
            this.albumart.BackgroundImage = global::Music_Player.Properties.Resources.未知;
            this.albumart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumart.Dock = System.Windows.Forms.DockStyle.Left;
            this.albumart.Location = new System.Drawing.Point(0, 0);
            this.albumart.Name = "albumart";
            this.albumart.Size = new System.Drawing.Size(85, 77);
            this.albumart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumart.TabIndex = 0;
            this.albumart.TabStop = false;
            this.albumart.Click += new System.EventHandler(this.PboxList_Click);
            this.albumart.MouseEnter += new System.EventHandler(this.PsmallShow_MouseEnter);
            this.albumart.MouseLeave += new System.EventHandler(this.PsmallShow_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 31);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "列表";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.MusicDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(960, 570);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.selectMusic);
            this.panel1.Controls.Add(this.tsearch);
            this.panel1.Controls.Add(this.lanumber);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 59);
            this.panel1.TabIndex = 2;
            // 
            // selectMusic
            // 
            this.selectMusic.AutoSize = true;
            this.selectMusic.BackColor = System.Drawing.Color.White;
            this.selectMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(115)))), ((int)(((byte)(194)))));
            this.selectMusic.Location = new System.Drawing.Point(686, 32);
            this.selectMusic.Name = "selectMusic";
            this.selectMusic.Size = new System.Drawing.Size(63, 14);
            this.selectMusic.TabIndex = 4;
            this.selectMusic.Text = "添加音乐";
            this.selectMusic.Click += new System.EventHandler(this.SelectMusic_Click);
            // 
            // tsearch
            // 
            this.tsearch.BackColor = System.Drawing.Color.White;
            this.tsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tsearch.Location = new System.Drawing.Point(770, 23);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(132, 16);
            this.tsearch.TabIndex = 2;
            this.tsearch.Text = "搜索本地音乐";
            this.tsearch.TextChanged += new System.EventHandler(this.Tsearch_TextChanged);
            this.tsearch.Enter += new System.EventHandler(this.Tsearch_Enter);
            this.tsearch.Leave += new System.EventHandler(this.Tsearch_Leave);
            // 
            // lanumber
            // 
            this.lanumber.AutoSize = true;
            this.lanumber.Location = new System.Drawing.Point(115, 25);
            this.lanumber.Name = "lanumber";
            this.lanumber.Size = new System.Drawing.Size(0, 14);
            this.lanumber.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Music_Player.Properties.Resources.搜索框;
            this.pictureBox1.Location = new System.Drawing.Point(755, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "本地音乐";
            // 
            // MusicDate
            // 
            this.MusicDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusicDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.MName,
            this.oName,
            this.Album,
            this.MTime,
            this.MSize});
            this.MusicDate.ContextMenuStrip = this.Tool;
            this.MusicDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicDate.FullRowSelect = true;
            this.MusicDate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MusicDate.HideSelection = false;
            this.MusicDate.Location = new System.Drawing.Point(0, 58);
            this.MusicDate.Name = "MusicDate";
            this.MusicDate.Scrollable = false;
            this.MusicDate.Size = new System.Drawing.Size(960, 512);
            this.MusicDate.TabIndex = 1;
            this.MusicDate.UseCompatibleStateImageBehavior = false;
            this.MusicDate.View = System.Windows.Forms.View.Details;
            this.MusicDate.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.MusicDate_DrawColumnHeader);
            this.MusicDate.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.MusicDate_DrawSubItem);
            this.MusicDate.DoubleClick += new System.EventHandler(this.MusicDate_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = " ";
            this.ID.Width = 51;
            // 
            // MName
            // 
            this.MName.Text = "音乐标题";
            this.MName.Width = 273;
            // 
            // oName
            // 
            this.oName.Text = "歌手";
            this.oName.Width = 200;
            // 
            // Album
            // 
            this.Album.Text = "专辑";
            this.Album.Width = 192;
            // 
            // MTime
            // 
            this.MTime.Text = "时长";
            this.MTime.Width = 145;
            // 
            // MSize
            // 
            this.MSize.Text = "大小";
            this.MSize.Width = 98;
            // 
            // Tool
            // 
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.play,
            this.nextplay,
            this.openDic,
            this.remove,
            this.delete});
            this.Tool.Name = "Tool";
            this.Tool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Tool.Size = new System.Drawing.Size(194, 136);
            this.Tool.Text = " ";
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(193, 22);
            this.play.Text = "播放";
            this.play.Click += new System.EventHandler(this.Tool_Click);
            // 
            // nextplay
            // 
            this.nextplay.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextplay.Name = "nextplay";
            this.nextplay.Size = new System.Drawing.Size(193, 22);
            this.nextplay.Text = "下一首播放";
            this.nextplay.Click += new System.EventHandler(this.Tool_Click);
            // 
            // openDic
            // 
            this.openDic.Font = new System.Drawing.Font("宋体", 9F);
            this.openDic.Name = "openDic";
            this.openDic.Size = new System.Drawing.Size(193, 22);
            this.openDic.Text = "打开文件所在目录";
            this.openDic.Click += new System.EventHandler(this.Tool_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("宋体", 9F);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(193, 22);
            this.remove.Text = "从列表中删除(Delete)";
            this.remove.Click += new System.EventHandler(this.Tool_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("宋体", 9F);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(193, 22);
            this.delete.Text = "从磁盘删除";
            this.delete.Click += new System.EventHandler(this.Tool_Click);
            // 
            // tpmgressbar
            // 
            this.tpmgressbar.Tick += new System.EventHandler(this.Tpmgressbar_Tick);
            // 
            // pshow
            // 
            this.pshow.Controls.Add(this.panel4);
            this.pshow.Controls.Add(this.panel3);
            this.pshow.Location = new System.Drawing.Point(0, 47);
            this.pshow.Name = "pshow";
            this.pshow.Size = new System.Drawing.Size(1210, 570);
            this.pshow.TabIndex = 5;
            // 
            // LlrcShow
            // 
            this.LlrcShow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LlrcShow.FormattingEnabled = true;
            this.LlrcShow.ItemHeight = 12;
            this.LlrcShow.Location = new System.Drawing.Point(593, 66);
            this.LlrcShow.Name = "LlrcShow";
            this.LlrcShow.Size = new System.Drawing.Size(440, 544);
            this.LlrcShow.TabIndex = 7;
            this.LlrcShow.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LlrcShow_DrawItem);
            this.LlrcShow.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MusicData_MeasureItem);
            // 
            // tlrc
            // 
            this.tlrc.Tick += new System.EventHandler(this.Tlrc_Tick);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(481, 78);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(204, 99);
            this.WMP.TabIndex = 3;
            this.WMP.Visible = false;
            this.WMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMP_PlayStateChange);
            // 
            // pbigimage
            // 
            this.pbigimage.Location = new System.Drawing.Point(22, 114);
            this.pbigimage.Name = "pbigimage";
            this.pbigimage.Size = new System.Drawing.Size(400, 400);
            this.pbigimage.TabIndex = 6;
            this.pbigimage.TabStop = false;
            // 
            // pshrink
            // 
            this.pshrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.pshrink.Image = ((System.Drawing.Image)(resources.GetObject("pshrink.Image")));
            this.pshrink.Location = new System.Drawing.Point(1083, 66);
            this.pshrink.Name = "pshrink";
            this.pshrink.Size = new System.Drawing.Size(55, 33);
            this.pshrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pshrink.TabIndex = 8;
            this.pshrink.TabStop = false;
            this.pshrink.Click += new System.EventHandler(this.PboxList_Click);
            // 
            // MMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1210, 679);
            this.ControlBox = false;
            this.Controls.Add(this.pshow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptitle);
            this.Controls.Add(this.pbigimage);
            this.Controls.Add(this.LlrcShow);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.pshrink);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ptitle.ResumeLayout(false);
            this.ptitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pMusiccondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkbVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkbMove)).EndInit();
            this.panel3.ResumeLayout(false);
            this.PsmallShow.ResumeLayout(false);
            this.PsmallShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tool.ResumeLayout(false);
            this.pshow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbigimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pshrink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ptitle;
        private System.Windows.Forms.Label demoName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel PsmallShow;
        private System.Windows.Forms.ListBox MusicData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbcurrTime;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox albumart;
        private System.Windows.Forms.Label MusicName;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.ListView MusicDate;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader MName;
        private System.Windows.Forms.ColumnHeader oName;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ColumnHeader MTime;
        private System.Windows.Forms.ColumnHeader MSize;
        private System.Windows.Forms.Timer tpmgressbar;
        private System.Windows.Forms.Panel pshow;
        private System.Windows.Forms.PictureBox pbigimage;
        private System.Windows.Forms.ListBox LlrcShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lanumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tlrc;
        private System.Windows.Forms.Panel pkbMovebar;
        private System.Windows.Forms.Panel pkbVolbar;
        private System.Windows.Forms.PictureBox pkbVol;
        private System.Windows.Forms.PictureBox pkbMove;
        private System.Windows.Forms.Label selectMusic;
        private System.Windows.Forms.PictureBox pMusiccondition;
        private System.Windows.Forms.PictureBox pshrink;
        private System.Windows.Forms.PictureBox psmall;
        private System.Windows.Forms.PictureBox pbig;
        private System.Windows.Forms.PictureBox pclose;
        private System.Windows.Forms.ContextMenuStrip Tool;
        private System.Windows.Forms.ToolStripMenuItem play;
        private System.Windows.Forms.ToolStripMenuItem nextplay;
        private System.Windows.Forms.ToolStripMenuItem openDic;
        private System.Windows.Forms.ToolStripMenuItem remove;
        private System.Windows.Forms.ToolStripMenuItem delete;
    }
}

