using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace teeworlds_srv_app
{
    public partial class Form1 : Form
    {
        private bool ml_changed = false;
        private TextReader tr = null;
        private Process proc;// = new Process();
        public delegate void UpdateOutputCallback(String text);
        public UpdateOutputCallback updateoutput;

        private string line = null;
        private string[] cur = null;
        private string cmaplist = null;
        private string[] maps = null;
        
        public Form1()
        {
            InitializeComponent();
            this.updateoutput = new UpdateOutputCallback(addupdateoutput);
            
        }

        public void addupdateoutput(string text)
        {
            /* insert method for parsing output
             * */
            this.Srv_Output.Text += text + Environment.NewLine;
            this.Srv_Output.SelectionStart = this.Srv_Output.Text.Length;
            this.Srv_Output.ScrollToCaret();
        }

        public void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                this.Srv_Output.Invoke(new UpdateOutputCallback(this.updateoutput), new object[] { e.Data });
            }
        }
        private void proc_start(string fName)
        {
            if (proc == null)
            {
                proc = new Process();
                proc.StartInfo.FileName = fName;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.EnableRaisingEvents = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.ErrorDataReceived += new DataReceivedEventHandler(proc_DataReceived);
                proc.OutputDataReceived += new DataReceivedEventHandler(proc_DataReceived);
                proc.Start();
                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();
            }
        }

        private void proc_stop()
        {
            if (proc != null)
            {
                proc.Kill();
                proc = null;
            }
        }
        private void startmap_btn_Click(object sender, EventArgs e)
        {
            if (this.maplist.SelectedItem != null)
            {
                this.startmap.Text = this.maplist.SelectedItem.ToString();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // this is gonna be the save button.

            int i = 0;
            int count = this.maplist.CheckedItems.Count;
            if (ml_changed)
            {
                this.debugbox.Text = "";
                while (i < count)
                {
                    if ((i + 1) == count)
                    {
                        this.debugbox.Text += this.maplist.CheckedItems[i].ToString();
                    }
                    else
                    {
                        this.debugbox.Text += this.maplist.CheckedItems[i].ToString() + " ";
                    }
                    i++;
                }
            }
            if (this.startmap.Text == "")
            {
                if (this.maplist.CheckedItems.Count != 0)
                {
                    this.startmap.Text = this.maplist.CheckedItems[0].ToString();
                }
            }
        }

        private void maplist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.ml_changed = true;
        }

        private void upd_ml_Click(object sender, EventArgs e)
        {
            // input maplist code.
            // list stuff in maps dir and put it in this.maplist
            // this.maplist.Items.Add(); // row from dir.
            // make sure there are no duplicates either
            // maybe clear it first or check whats in there and add new stuff after
            // make suggestion that maps should start with gamemode aswell
            // so when the gamemode is selected you can take out the correct maps.
            this.maplist.Items.Clear();
            foreach (string curfile in System.IO.Directory.GetFiles(@"maps")) {
                string[] Split = curfile.Split(new char[] {'\\'});
                string[] Split2 = Split[Split.Length - 1].Split(new char[] {'.'});
                this.maplist.Items.Add(Split2[0]);
            }

            try
            {
                //open file for read.
                tr = new StreamReader("my_srv.cfg");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Config file not Found: "+ e.ToString(), "Config file not found.", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                //Console.WriteLine("Config file not Found: " + e.ToString());
            }

            if (tr != null)
            {
                while (tr.Peek() >= 0) // loop through the file.
                {
                    line = tr.ReadLine();
                    cur = line.Split((new char[] { ' ' }), (2));
                    if (cur[0] == "sv_maprotation")
                    {
                        cmaplist = cur[1];
                        maps = cur[1].Split(" ".ToCharArray()[0]);
                        for (int i = 0; i < maps.Length; i++)
                        {
                            string curmap;
                            curmap = maps[i];
                            this.debugbox.Text += this.maplist.Items.IndexOf(curmap).ToString();
                            this.maplist.SetItemChecked(this.maplist.Items.IndexOf(maps[i]), true);
                        }
                    }
                    else if (cur[0] == "sv_map")
                    {
                        if (this.maplist.Items.IndexOf(cur[1]) > 0)
                        {
                            this.maplist.SetSelected(this.maplist.Items.IndexOf(cur[1]), true);
                        }
                        this.startmap.Text = cur[1];
                    }
                    else if (cur[0] == "sv_port")
                    {
                        
                    }
                }

                // close the file
                tr.Close();
            }
        }

        private void srv_init_Click(object sender, EventArgs e)
        {
            this.proc_start("D:\\teeworlds\\teeworlds_srv.exe");

            this.srv_init.Enabled = false;
            this.srv_stop.Enabled = true;
        }

        private void srv_stop_Click(object sender, EventArgs e)
        {
            this.proc_stop();

            this.srv_init.Enabled = true;
            this.srv_stop.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.proc_stop();
        }
    }
}