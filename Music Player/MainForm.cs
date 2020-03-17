using Music_Player.Properties;
using MusicBll;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Music_Player
{
    public partial class MMain : Form
    {
        BasicPlay bll = new BasicPlay(Application.StartupPath+ "\\MusicData.db");
        //音乐对应的信息集合
        List<Model.MusicInfo> musicInfos;
        //列标题
        List<string> Title = new List<string>();
        //列表图标
        List<Image> listImage = new List<Image>();
        //延时播放队列
        Queue<int> MusicDelay = new Queue<int>();
        //设置播放顺序
        Model.Playorder order;
        //全局使用的音乐信息
        Model.MusicInfo globalInfo;
        Random random=new Random(new Guid().GetHashCode());//随机音乐

        public MMain()
        {
            InitializeComponent();
        }
        //界面加载
        private void Main_Load(object sender, EventArgs e)
        {
            //加载歌曲到listview上
            LoadListView();
            //加载列表清单到list上
            LoadList();
        }

        private void LoadList()
        {
            MusicData.Items.Add("本地音乐");
            MusicData.Items.Add("我的收藏");
            MusicData.Items.Add("近期播放");
            MusicData.Items.Add("下载管理");
            MusicData.Items.Add("发现音乐");
            MusicData.Items.Add("私人FM");
            MusicData.Items.Add("视频");
            MusicData.Items.Add("朋友");
            Title.Add("本地音乐");
            Title.Add("我的收藏");
            Title.Add("近期播放");
            Title.Add("下载管理");
            Title.Add("发现音乐");
            Title.Add("私人FM");
            Title.Add("视频");
            Title.Add("朋友");
            listImage.Add(Resources._1);
            listImage.Add(Resources._2);
            listImage.Add(Resources._3);
            listImage.Add(Resources._4);
            listImage.Add(Resources._5);
            listImage.Add(Resources._6);
            listImage.Add(Resources._7);
            listImage.Add(Resources._8);
            MusicData.SelectedIndex = 0;
        }

        private void LoadListView()
        {
            //加载固定文件下的音乐文件
            string Mpath;
            string Mapth2;
            Mpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Music");
            musicInfos = bll.GetMusicInfo(Mpath);
            if ((Mapth2 = bll.select()) != null)
            {
                string[] str = Mapth2.Split(new string[] { "[]" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < str.Length; i++)
                {
                    musicInfos.Add(bll.SingleAdd(str[i]));
                }
            }
            string ID;
            for (int i = 0; i < musicInfos.Count; i++)
            {
                ID = i + 1 > 10 ? i.ToString() : "0" + i;
                musicInfos[i].Id = i+1;
                ListViewItem item = new ListViewItem(ID);
                item.SubItems.Add(musicInfos[i].Mname.Split('-')[1]);
                item.SubItems.Add(musicInfos[i].Author);
                item.SubItems.Add(musicInfos[i].Album);
                item.SubItems.Add(musicInfos[i].Mtime);
                item.SubItems.Add(musicInfos[i].Msize);

                //加载歌曲到listview上
                MusicDate.Items.Add(item);
            }
            lanumber.Text = "共" + musicInfos.Count + "首";
        }
        
        //界面移动
        Point point;
        private void Ptitle_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
            ptitle.ForeColor = Color.White;
        }

        private void Ptitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }

        private void Ptitle_MouseUp(object sender, MouseEventArgs e)
        {
            ptitle.ForeColor = Color.Gray;
        }
        
        //处理ui界面
        private void MusicData_DrawItem(object sender, DrawItemEventArgs e)
        {
            //设置画布的大小
            Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);

            int index = e.Index;
            Graphics g = e.Graphics;
            Graphics graphics = Graphics.FromImage(bitmap);

            Rectangle rectangle = e.Bounds;
            //获取要绘制的文本
            string text = this.Title[index];

            //绘制选中时的背景，后绘制的会覆盖前面的
            Color backgroundColor = Color.FromArgb(245, 245, 247);//背景
            Color guideTagColor = Color.FromArgb(59, 186, 125);//提示色
            Color selectBackgroundColor = Color.FromArgb(230, 231, 234);//选中时的背景颜色

            Color fontColor = Color.FromArgb(92, 92, 92);//字体颜色
            Color selectFontColor = Color.Black;
            Image image = listImage[index];

            //设置字体
            Font txtfont = new Font("宋体", 12,FontStyle.Bold);

            //绘制的单项矩形大小内容分配
            Rectangle backgroundRec = new Rectangle(0, 0, rectangle.Width, rectangle.Height);
            Rectangle guideTagRec = new Rectangle(0, 0, 4, rectangle.Height);
            Rectangle fontRec = new Rectangle(55, 0, rectangle.Width, rectangle.Height);
            Rectangle imRect = new Rectangle(20, 4, 22, rectangle.Height - 5);

            //选中时
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundColor = selectBackgroundColor;
                fontColor = selectFontColor;
            }
            else
            {
                //提示点击的是哪行
                guideTagColor = backgroundColor;
            }

            //开始绘制
            //绘制控件背景
            graphics.FillRectangle(new SolidBrush(backgroundColor), backgroundRec);
            //绘制提示色
            graphics.FillRectangle(new SolidBrush(guideTagColor), guideTagRec);
            //绘制列表图标
            graphics.DrawImage(image, imRect);
            //文本 垂直左对齐
            TextRenderer.DrawText(graphics, text, txtfont, fontRec, fontColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            g.DrawImage(bitmap, rectangle.X, rectangle.Y, bitmap.Width, bitmap.Height);

            graphics.Dispose();
        }

        private void MusicData_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            //设置行高
            e.ItemHeight = 30;
        }

        private void MusicDate_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            //绘制播放列表列题            
            int index = e.ColumnIndex;
            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(Color.FromArgb(250, 250, 250)), e.Bounds);
            string text = MusicDate.Columns[e.ColumnIndex].Text;
            //字体设置
            Font textFont = new Font("微软雅黑", 12, FontStyle.Regular);
            //设置文本的颜色
            Color textColor = Color.FromArgb(102, 102, 102);
            //绘制文本
            TextRenderer.DrawText(e.Graphics, text, textFont, e.Bounds, textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            Pen pen = new Pen(Color.FromArgb(225, 225, 226));
            //规定矩形的大小
            Point p = new Point(e.Bounds.Left - 1, e.Bounds.Top + 1);
            Size s = new Size(e.Bounds.Width, e.Bounds.Height - 2);
            Rectangle r = new Rectangle(p, s);
            g.DrawRectangle(pen, r);
            g.Dispose();
        }

        private void MusicDate_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ItemIndex < 0)
            {
                return;
            }

            //单双列显示不同
            if (e.ItemIndex % 2 == 0)
            {
                e.SubItem.BackColor = Color.FromArgb(245, 245, 247);
                e.DrawBackground();
            }

            if (e.ColumnIndex == 1)
            {
                e.SubItem.ForeColor = Color.FromArgb(51, 51, 51);
            }
            else
            {
                e.SubItem.ForeColor = Color.FromArgb(102, 102, 102);
            }

            //选中
            if ((e.ItemState & ListViewItemStates.Selected) == ListViewItemStates.Selected)
            {
                //e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(228, 228, 230)), e.Bounds);
            }
            //绘制字体
            if (!string.IsNullOrEmpty(e.SubItem.Text))
            {
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, new Font("宋体", 10), e.SubItem.Bounds, e.SubItem.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        //进度条移动委托
        private void Tpmgressbar_Tick(object sender, EventArgs e)
        {
            lbcurrTime.Text = WMP.Ctlcontrols.currentPositionString;
            double x = WMP.Ctlcontrols.currentPosition / WMP.currentMedia.duration;
            pkbMove.Location = new Point(273 + (int)(x*(pkbMovebar.Width-14)), pkbMove.Location.Y);
        }
        
        //保存歌词
        List<Model.lyrics> liy;
        int present;
        //加载歌词
        private void LoadLrc()
        {
            if (liy.Count<0)
            {
                LlrcShow.Items.Add("暂无歌词");
            }
            for (int i = 0; i < liy.Count; i++)
            {
                LlrcShow.Items.Add(liy[i].StrLyric);
            }
        }

        //歌词滚动
        private void Tlrc_Tick(object sender, EventArgs e)
        {
            //当前播放时间
            double time = WMP.Ctlcontrols.currentPosition;

            //歌词移动换行
            if (present + 1 < globalInfo.Lyric.Count && time > globalInfo.Lyric[present + 1].Totsecond)
            {   //下一行
                present++;
                LlrcShow.SelectedIndex = present;
            }
        }

        //双击加载信息,并且播放
        private void MusicDate_DoubleClick(object sender, EventArgs e)
        {
            //获取对应的信息打印对应到位置
            globalInfo = StampInfo();
            WMP.URL = globalInfo.Path;
            WMP.Ctlcontrols.play();
        }

        private Model.MusicInfo StampInfo(int index=-1)
        {
            //返回指定的索引来获取音乐信息
            if (index==-1)
            {
                index = MusicDate.Items.IndexOf(MusicDate.FocusedItem);
            }
            if (index < 0)
            {
                return null;
            }
            //根据指定的索引打印出对应的音乐信息
            Model.MusicInfo info = musicInfos[index];
            string musictitle = info.Mname.Split('-')[1];
            MusicName.Text = musictitle.Length > 10 ? musictitle.Substring(0, 10) + "..." : musictitle;
            author.Text = info.Author.Length > 5 ? info.Author.Substring(0, 5) + "..." : info.Author;
            lbEndTime.Text = info.Mtime;
            albumart.BackgroundImage = info.Image;
            pbigimage.Image = info.Bigimage;
            // 没有歌词
            if (bll.GetLrc(info))
            {
                liy =null;
            }
            liy = info.Lyric;
            //把对应的歌曲的编号放入到图片的tag
            albumart.Tag = index;
            return info;
        }

        private void SelectItem()
        {
            if (MusicDate.SelectedItems.Count > 0)//选择了一个音乐
            {
                globalInfo = StampInfo();
                WMP.URL = globalInfo.Path;
                WMP.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("未选择歌曲");
            }
        }

        //播放
        private void PbPlay_Click(object sender, EventArgs e)
        {
            if (WMP.playState.ToString().Equals("wmppsPlaying"))//播放->暂停
            {
                WMP.Ctlcontrols.pause();                
                return;
            }
            if (WMP.playState.ToString().Equals("wmppsPaused"))//暂停->播放
            {
                WMP.Ctlcontrols.play();                
                return;
            }
            SelectItem();
        }
        
        //播放状态
        private void WMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:    // Undefined
                    
                    break;

                case 1:    // Stopped                    
                    GetIndex(false);
                    tpmgressbar.Enabled = false;
                    break;

                case 2:    // Paused
                    pbPlay.Image = Resources.play;
                    tpmgressbar.Enabled = false;
                    break;

                case 3:
                    if (globalInfo.Lyric!=null)
                    {
                        LoadLrc();
                        tlrc.Enabled = true;
                    }
                    pbPlay.Image = Resources.暂停深;                    
                    //开启进度条
                    tpmgressbar.Enabled = true;
                    break;

                case 4:    // ScanForward
                   
                    break;

                case 5:    // ScanReverse
                    
                    break;

                case 6:    // Buffering
                    
                    break;

                case 7:    // Waiting
                   
                    break;

                case 8:    // MediaEnded
                    
                    break;

                case 9:    // Transitioning
                    
                    break;

                case 10:   // Ready
                    
                    break;

                case 11:   // Reconnecting
                    
                    break;

                case 12:   // Last
                    
                    break;

                default:
                    
                    break;
            }
        }

        private void CutUpNext(bool isup)
        {
            if (albumart.Tag == null)
            {
                return;
            }
            GetIndex(isup);
        }

        private void GetIndex(bool isup)
        {
            int index = -1;
            if (MusicDelay.Count <= 0)
            {
                switch ((int)order)
                {
                    case 0:
                    case 1:
                        if (isup)
                            index = Convert.ToInt32(albumart.Tag) - 1 >= 0 ? Convert.ToInt32(albumart.Tag) - 1 : musicInfos.Count - 1;
                        else
                            index = Convert.ToInt32(albumart.Tag) + 1 > musicInfos.Count - 1 ? 0 : Convert.ToInt32(albumart.Tag) + 1;
                        break;
                    case 2: index = Convert.ToInt32(albumart.Tag); break;
                    case 3: index = random.Next(0, musicInfos.Count); break;
                }
            }
            else
            {
                index = MusicDelay.Dequeue();
            }
            //清空歌词
            globalInfo.Lyric = null;
            liy.Clear();
            LlrcShow.Items.Clear();
            if (index != -1)
            {
                globalInfo = StampInfo(index);
                WMP.URL = globalInfo.Path;
                WMP.Ctlcontrols.play();
            }
        }

        private Image PlayorderCut(bool isok)
        {
            int odr = (int)order;
            Image image=null;
            switch (odr)
            {
                //当前为顺序播放
                case 0:
                    if (isok)
                        image = Resources.顺序深;
                    else
                        image = Resources.顺序;
                    break;
                //当前为列表循环
                case 1:
                    if (isok)
                        image = Resources.列表深;
                    else
                        image = Resources.列表;
                    break;
                //当前为单曲循环
                case 2:
                    if (isok)
                        image = Resources.单曲深;
                    else
                        image = Resources.单曲;
                    break;
                //当前为随机播放
                case 3:
                    if (isok)
                        image = Resources.随机深;
                    else
                        image = Resources.随机;
                    break;
            }
            return image;
        }

        //PicBox移入事件合集
        private void EnterList_MouseEnter(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            string pname = picture.Name;
            Image image = null;
            switch (pname)
            {
                case "pbPlay":
                    if (WMP.playState.ToString()== "wmppsPlaying")//播放时
                    {
                        image = Resources.暂停深; 
                    }
                    else
                    {
                        image = Resources.paly深;
                    }
                    break;
                case "pbVolume":
                    //1017, 24 音量小点的初始位置
                    if (picture.Location.X == 1017)
                    {
                        image = Resources.静音深;
                    }
                    else
                    {
                        image = Resources.音量深;
                    }
                    break;
                case "pbBack": image = Resources.up深; break;
                case "pbNext": image = Resources.next深; break;
                case "pMusiccondition": image = PlayorderCut(true);break;
                case "psmall": image = Resources.缩小深; break;
                case "pbig": image = Resources.放大深; break;
                case "pclose": image = Resources.关闭深; break;
            }
            picture.Image = image;
        }

        //PicBox移出事件合集
        private void LeaveList_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            string pname = picture.Name;
            Image image=null;
            switch (pname)
            {
                //播放按钮的多样
                case "pbPlay":
                    if (WMP.playState.ToString() == "wmppsPlaying")//播放时
                    {
                        image = Resources.暂停;
                    }
                    else
                    {
                        image = Resources.play;
                    }
                    break;
                //音量按钮的多样
                case "pbVolume":
                    if (picture.Location.X == 1017)
                    {
                        image = Resources.静音;
                    }
                    else
                    {
                        image = Resources.音量;
                    }
                    break;
                case "pbBack": image = Resources.up; break;
                case "pbNext": image = Resources.next; break;
                case "pMusiccondition": image = PlayorderCut(false);break;
                case "psmall": image = Resources.缩小; break;
                case "pbig": image = Resources.放大; break;
                case "pclose": image = Resources.关闭; break;
            }
            picture.Image = image;
        }
           
        //展示封面图和歌词
        private void PsmallShow_MouseEnter(object sender, EventArgs e)
        {
            albumart.Image = Resources.展开;
        }

        private void PsmallShow_MouseLeave(object sender, EventArgs e)
        {
            albumart.Image = null ;
        }

        //pictbox的点击事件集合
        private void PboxList_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            string name = box.Name;
            switch (name)
            {
                //音量静|开
                case "pbVolume": VolumeOpen(box); break;
                //播放顺序
                case "pMusiccondition": Playorder(box); break;
                //上一曲
                case "pbBack": CutUpNext(true); break;
                //下一曲
                case "pbNext": CutUpNext(false); break;
                //关闭封面
                case "pshrink": pshow.Visible = true; break;
                //开启封面
                case "albumart": pshow.Visible = false;break;
                //缩小
                case "psmall": this.WindowState = FormWindowState.Minimized; break;
                    //放大
                case "pbig":
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                    break;
                    //关闭
                case "pclose":
                    WMP.Ctlcontrols.stop();
                    Application.Exit(); break;
            }
        }
        
        private void Playorder(PictureBox box)
        {
            int odr = (int)order;
            switch (odr)
            {
                //当前为列表循环
                case 0:
                    order = Model.Playorder.listplay;
                    box.Image = Resources.列表深;
                    break;
                //当前为顺序播放
                case 1:
                    order = Model.Playorder.singleplay;
                    box.Image = Resources.单曲深;
                    break;
                //当前为单曲循环
                case 2:
                    order = Model.Playorder.randomplay;
                    box.Image = Resources.随机深;
                    break;
                //当前为随机播放
                case 3:
                    order = Model.Playorder.orderplay;
                    box.Image = Resources.顺序深;
                    break;
            }
        }

        private void VolumeOpen(PictureBox box)
        {
            //pkbVol.Location.X == 1017
            if (pkbVol.Location.X != 1017)// 有声->静音
            {
                pkbVol.Tag = pkbVol.Location.X;
                box.Image = Resources.静音深;
                pkbVol.Location = new Point(1017, 24);
                WMP.settings.volume = 0;
            }
            else//恢复之前的音量
            {
                int value = (int)pkbVol.Tag;
                box.Image = Resources.音量深;
                pkbVol.Location = new Point(value, 24);
                WMP.settings.volume = (int)(value - 1017);
            }
        }

        //音量|进度切换
        private void MovebarList_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)sender;
            int x = e.X - 17 < 0 ? 0:e.X - 14;
            Console.WriteLine(x);
            int lox = p.Location.X;
            switch (p.Name)
            {
                case "pkbMovebar"://进度条
                    //移动百分比
                    double percent = ((double)(x) / (p.Width - 31));
                    double MoveX = percent * WMP.currentMedia.duration;
                    WMP.Ctlcontrols.currentPosition = MoveX;
                    //指针移动
                    pkbMove.Location = new Point(x + lox -3, 24);
                    //歌词移动
                    LrcMove(percent, MoveX);
                    break;
                case "pkbVolbar"://音量条
                    WMP.settings.volume = (int)(((double)x  / (p.Width-15)) * 100);
                    Console.WriteLine(WMP.settings.volume);
                    pkbVol.Location = new Point(x + lox-3 ,24);
                    break;
            }
           
        }

        private void LrcMove(double percent, double x)
        {
            if (liy != null)
            {
                int index = Convert.ToInt32(liy.Count * percent) - 5;
                if (index < 0)
                {
                    index = 0;
                }
                //从移动的百分比附近查找对应的歌词位置
                for (int i = index; i < liy.Count; i++)
                {
                    if (x <= liy[i].Totsecond)
                    {
                        present = i;
                        LlrcShow.SelectedIndex = present;
                        break;
                    }
                }
            }
        }
        //记录路径
        private void SelectMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                Filter = "媒体文件|*.mp3",//;*.wav;*.wma;*.avi;*.mpg;*.asf;*.wmv";
                Multiselect = true
            };
            if (open.ShowDialog()==DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.Length; i++)
                {
                    //获取完整路径
                    string path = open.FileNames[i];
                    if (!bll.Myexists(musicInfos, path))
                    {
                        Model.MusicInfo music = bll.SingleAdd(path);
                        music.Id = musicInfos.Count;
                        musicInfos.Add(music);
                        string ID = musicInfos.Count > 10 ? musicInfos.Count.ToString() : "0" + (musicInfos.Count - 1) ;                        
                        ListViewItem item = new ListViewItem(ID);
                        item.SubItems.Add(music.Mname.Split('-')[1]);
                        item.SubItems.Add(music.Author);
                        item.SubItems.Add(music.Album);
                        item.SubItems.Add(music.Mtime);
                        item.SubItems.Add(music.Msize);
                        MusicDate.Items.Add(item);
                        bll.Add(music);
                    }
                }
                lanumber.Text = "共" + musicInfos.Count + "首";
            }
        }

        //查找对应的音乐打印到了listview上 列表搜索
        private void Tsearch_TextChanged(object sender, EventArgs e)
        {
            string searchvalue = tsearch.Text.Trim();
            if (searchvalue.Equals("搜索本地音乐"))
            {
                return;
            }
            string search = @"" + tsearch.Text.Trim();
            Regex regex = new Regex(searchvalue, RegexOptions.IgnoreCase);
            List<Model.MusicInfo> temporary = new List<Model.MusicInfo>();
            for (int i = 0; i < musicInfos.Count; i++)
            {
                if (regex.IsMatch(musicInfos[i].Mname))
                {
                    //如果有就清空
                    temporary.Add(musicInfos[i]);
                }
            }
            if (temporary.Count > 0)//有数据清空listview重新打印
            {
                MusicDate.Items.Clear();
                string ID;
                int i;
                for (i = 0; i < temporary.Count; i++)
                {
                    ID = i + 1 > 10 ? i.ToString() : "0" + i;
                    ListViewItem item = new ListViewItem(ID);
                    item.SubItems.Add(temporary[i].Mname.Split('-')[1]);
                    item.SubItems.Add(temporary[i].Author);
                    item.SubItems.Add(temporary[i].Album);
                    item.SubItems.Add(temporary[i].Mtime);
                    item.SubItems.Add(temporary[i].Msize);

                    //加载歌曲到listview上
                    MusicDate.Items.Add(item);
                }
            }
        }

        private void Tsearch_Enter(object sender, EventArgs e)
        {
            if (tsearch.Text.Equals("搜索本地音乐"))            
                tsearch.Text = "";            
        }

        private void Tsearch_Leave(object sender, EventArgs e)
        {
            if (tsearch.Text.Equals(""))
                tsearch.Text = "搜索本地音乐";
        }

        //绘制歌词listbox
        private void LlrcShow_DrawItem(object sender, DrawItemEventArgs e)
        {
            Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);

            int index = e.Index;
            Graphics g = e.Graphics;
            Graphics graphics = Graphics.FromImage(bitmap);

            Rectangle rectangle = e.Bounds;
            //获取要绘制的文本
            string text = liy[index].StrLyric;

            //绘制选中时的背景，后绘制的会覆盖前面的
            Color backgroundColor = Color.FromArgb(245, 245, 247);//背景
            Color guideTagColor = Color.FromArgb(59, 186, 125);//提示色
            Color selectBackgroundColor = Color.FromArgb(230, 231, 234);//选中时的背景颜色

            Color fontColor = Color.FromArgb(92, 92, 92);//字体颜色
            Color selectFontColor = Color.Black;

            //设置字体
            Font txtfont = new Font("宋体", 12, FontStyle.Bold);

            //绘制的单项矩形大小内容分配
            Rectangle backgroundRec = new Rectangle(0, 0, rectangle.Width, rectangle.Height);
            Rectangle guideTagRec = new Rectangle(0, 0, 4, rectangle.Height);
            Rectangle fontRec = new Rectangle(55, 0, rectangle.Width, rectangle.Height);
            Rectangle imRect = new Rectangle(20, 4, 22, rectangle.Height - 5);

            //选中时
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundColor = selectBackgroundColor;
                fontColor = selectFontColor;
            }
            else
            {
                //提示点击的是哪行
                guideTagColor = backgroundColor;
            }
            //开始绘制
            //绘制控件背景
            graphics.FillRectangle(new SolidBrush(backgroundColor), backgroundRec);
                                    
            //文本 垂直左对齐
            TextRenderer.DrawText(graphics, text, txtfont, fontRec, fontColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            g.DrawImage(bitmap, rectangle.X, rectangle.Y, bitmap.Width, bitmap.Height);

            graphics.Dispose();            

        }

        //小工具菜单点击事件集合
        private void Tool_Click(object sender, EventArgs e)
        {
            int index = MusicDate.Items.IndexOf(MusicDate.FocusedItem);
            Model.MusicInfo info = musicInfos[index];
            ToolStripMenuItem item =(ToolStripMenuItem)sender;
            switch (item.Name)
            {
                case "play": SelectItem();  break;
                case "nextplay": GetIndex(false); break;
                case "openDic": OpenFile(info); break;
                case "remove":
                    MusicDate.Items.RemoveAt(index);
                    info = musicInfos[index];
                    bll.Delete(info);
                    // 刷新界面
                    break;
                case "delete": bll.Remove(info);  break;
            }
        }

        private void OpenFile(Model.MusicInfo info)
        {
            string v_OpenFolderPath = bll.OPenDirectory(info.Path);

            System.Diagnostics.Process.Start("explorer.exe", v_OpenFolderPath);
        }
    }
}
