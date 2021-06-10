using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using AxWMPLib;


namespace MusQ_Player
{


    public partial class MusX : Form
    {
        public MusX()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkAutoplay.Checked = true;
            mzk.settings.volume = volumeBar.Maximum;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] muslist = Directory.GetFiles(fbd.SelectedPath, "*.mp3", SearchOption.TopDirectoryOnly);
                //cMZK.lastFolder = fbd.SelectedPath;
                for (int i = 0; i < muslist.Length; i++)
                {
                    string musfile = System.IO.Path.GetFileNameWithoutExtension(muslist[i]);
                    lbSongs.Items.Add(musfile ?? throw new NullReferenceException());
                }
                cMZK.list.AddRange(muslist);
            }
        }
        private void btnaddconcr_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] muslist = fbd.FileNames;
                for (int i = 0; i < muslist.Length; i++)
                {
                    string musfile = System.IO.Path.GetFileNameWithoutExtension(muslist[i]);
                    lbSongs.Items.Add(musfile ?? throw new NullReferenceException());
                }
                cMZK.list.AddRange(muslist);
            }
        }
        public void MakeMusic()
        {
            try
            {
                mzk.URL = cMZK.list[cMZK.Index];
                timer1.Start();
                
                customProgressBar1.Value = 0;
                
                mzk.Ctlcontrols.play();
                //System.Threading.Thread.Sleep(200);
            }
            catch
            {
                //MessageBox.Show("Opening Music Error.\n Perhaps, you chose wrong directory or damaged file",
                 //   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                lblnow.Text = @"Now Playing: " + System.IO.Path.GetFileNameWithoutExtension(cMZK.list[cMZK.Index]);
                labeltimer.Text = "00:00\n" + mzk.currentMedia.durationString;

                System.Threading.Thread.Sleep(200);
            }
            catch
            {
                throw new System.NotImplementedException();
            }
            
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            if (!cMZK.isEmpty())
            {
                mzk.Ctlcontrols.play();
                timer1.Start();
            }

        }

        private void pausebtn_Click(object sender, EventArgs e)
        {
            mzk.Ctlcontrols.pause();
            timer1.Stop();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cMZK.list.Clear();
            lbSongs.Items.Clear();
            labeltimer.Text = @"00:00";

            customProgressBar1.Value = 0;
            
            lblnow.Text = @"Now Playing: ...";
            timer1.Stop();
            mzk.Ctlcontrols.pause();
            mzk.URL = "";
        }

        public void nextbtn_Click(object sender, EventArgs e)
        {
            if (checkMixed.Checked)
            {
                cMZK.CreateRandomIndex();
                MakeMusic();
            }
            else if(cMZK.IncrementIndex()) MakeMusic();
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            if (mzk.Ctlcontrols.currentPosition < 4.0f)
            {
                if(cMZK.DecrementIndex()) MakeMusic();
            }
            //else MakeMusic();
            mzk.Ctlcontrols.currentPosition = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltimer.Text = mzk.Ctlcontrols.currentPositionString + "\n"+
                              mzk.currentMedia.durationString;

            if (mzk.currentMedia.duration > 2)
            {
                if (customProgressBar1.Maximum != (int) mzk.currentMedia.duration)
                {
                    customProgressBar1.Maximum = (int) mzk.currentMedia.duration;
                }

                if (customProgressBar1.Value < customProgressBar1.Maximum) customProgressBar1.Value++;
            }
            else
            {
            }


            if (cMZK.GetNextURL())
            {
                cMZK.MakeNextURL_false();
                if (checkMixed.Checked)
                {
                    cMZK.CreateRandomIndex();
                    MakeMusic();
                }

                else if (cMZK.Index + 1 < cMZK.list.Count)
                {
                    cMZK.IncrementIndex();
                    MakeMusic();
                }
            }

           
        }
        private void MusQ_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.L)
            {
                if (checkMixed.Checked)
                {
                    cMZK.CreateRandomIndex();
                    MakeMusic();
                }
                else if(cMZK.IncrementIndex()) MakeMusic();
            }
            if (e.KeyData == Keys.K)
            {
                if (mzk.Ctlcontrols.currentPosition < 4.0f)
                {
                    if (cMZK.DecrementIndex()) MakeMusic();
                }
                mzk.Ctlcontrols.currentPosition = 0;
            }
            if (e.KeyData == Keys.P)
            {
                mzk.Ctlcontrols.pause();
                timer1.Stop();
            }
            if (e.KeyData == Keys.O)
            {
                if (!cMZK.isEmpty())
                {
                    mzk.Ctlcontrols.play();
                    timer1.Start();
                }
            }

        }

        private void lbSongs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!cMZK.isEmpty())
            {
                cMZK.Index = lbSongs.SelectedIndex;
                MakeMusic();
            }
        }

        

        private void mzk_PlayStateChange_1(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            // 8 - media ended
            if (e.newState == 8)
            {
                if (checkAutoplay.Checked) cMZK.MakeNextURL_true();
            }
        }

        
        
        // пока не готово
        /*
        private void customProgressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            mzk.Ctlcontrols.currentPosition = customProgressBar1.SetProgressBarValue(customProgressBar1.PointToClient(Cursor.Position));
        }
        */
        private void btnmix_Click(object sender, EventArgs e)
        {
            if (cMZK.list.Count > 0)
            {
                cMZK.Shuffle();
                cMZK.Index = -1;
                lbSongs.Items.Clear();
                for (int i = 0; i < cMZK.list.Count; i++)
                {
                    string musfile = System.IO.Path.GetFileNameWithoutExtension(cMZK.list[i]);
                    lbSongs.Items.Add(musfile ?? throw new NullReferenceException());
                }
            }
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            mzk.settings.volume = volumeBar.Value/4;
        }
    }

    static class cMZK
    {
        public static List<string> list = new List<string>();
        //static public string lastFolder = "";
        //static public bool allDirectories = false;
        public static int Index = -1;

        private static bool NextURL;

        public static void MakeNextURL_true()
        {
            NextURL = true;
        }
        public static void MakeNextURL_false()
        {
            NextURL = false;
        }
        public static bool GetNextURL()
        {
            return NextURL;
        }

        public static bool IncrementIndex()
        {
            if (Index + 1 < list.Count)
            {
                Index += 1;
                return true;
            }

            return false;
        }

        public static void CreateRandomIndex()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];
            provider.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);
            Index = new Random(result).Next(0, list.Count - 1);
        }

        public static bool isEmpty()
        {
            return list.Count == 0;
        }

        public static bool DecrementIndex()
        {
            if (!isEmpty()) 
            {
                if (Index > 0) Index -= 1;
                else if (Index < 0) Index = 0;
                return true;
            }
            return false;
        }
        
        
        public static void Shuffle()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            provider.Dispose();
        }
        //static public int sec = 0;



    }
}
