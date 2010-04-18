namespace teeworlds_srv_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maplist = new System.Windows.Forms.CheckedListBox();
            this.upd_ml = new System.Windows.Forms.Button();
            this.startmap = new System.Windows.Forms.TextBox();
            this.startmap_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.debugbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.srv_init = new System.Windows.Forms.Button();
            this.srv_stop = new System.Windows.Forms.Button();
            this.Srv_Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maplist
            // 
            this.maplist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.maplist.CheckOnClick = true;
            this.maplist.FormattingEnabled = true;
            this.maplist.HorizontalScrollbar = true;
            this.maplist.Location = new System.Drawing.Point(1, 48);
            this.maplist.Name = "maplist";
            this.maplist.Size = new System.Drawing.Size(170, 499);
            this.maplist.TabIndex = 0;
            this.maplist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.maplist_ItemCheck);
            // 
            // upd_ml
            // 
            this.upd_ml.Location = new System.Drawing.Point(12, 19);
            this.upd_ml.Name = "upd_ml";
            this.upd_ml.Size = new System.Drawing.Size(159, 23);
            this.upd_ml.TabIndex = 1;
            this.upd_ml.Text = "Update Maplist";
            this.upd_ml.UseVisualStyleBackColor = true;
            this.upd_ml.Click += new System.EventHandler(this.upd_ml_Click);
            // 
            // startmap
            // 
            this.startmap.Enabled = false;
            this.startmap.Location = new System.Drawing.Point(287, 48);
            this.startmap.Name = "startmap";
            this.startmap.Size = new System.Drawing.Size(152, 20);
            this.startmap.TabIndex = 2;
            // 
            // startmap_btn
            // 
            this.startmap_btn.Location = new System.Drawing.Point(177, 48);
            this.startmap_btn.Name = "startmap_btn";
            this.startmap_btn.Size = new System.Drawing.Size(104, 27);
            this.startmap_btn.TabIndex = 3;
            this.startmap_btn.Text = "Startmap ->";
            this.startmap_btn.UseVisualStyleBackColor = true;
            this.startmap_btn.Click += new System.EventHandler(this.startmap_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Startmap:";
            // 
            // debugbox
            // 
            this.debugbox.Location = new System.Drawing.Point(219, 9);
            this.debugbox.Name = "debugbox";
            this.debugbox.Size = new System.Drawing.Size(335, 20);
            this.debugbox.TabIndex = 5;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(341, 272);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(156, 33);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "spara knapp/debug knapp";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // srv_init
            // 
            this.srv_init.Location = new System.Drawing.Point(338, 197);
            this.srv_init.Name = "srv_init";
            this.srv_init.Size = new System.Drawing.Size(178, 54);
            this.srv_init.TabIndex = 7;
            this.srv_init.Text = "starta server";
            this.srv_init.UseVisualStyleBackColor = true;
            this.srv_init.Click += new System.EventHandler(this.srv_init_Click);
            // 
            // srv_stop
            // 
            this.srv_stop.Location = new System.Drawing.Point(341, 137);
            this.srv_stop.Name = "srv_stop";
            this.srv_stop.Size = new System.Drawing.Size(174, 45);
            this.srv_stop.TabIndex = 8;
            this.srv_stop.Text = "stoppa";
            this.srv_stop.UseVisualStyleBackColor = true;
            this.srv_stop.Click += new System.EventHandler(this.srv_stop_Click);
            // 
            // Srv_Output
            // 
            this.Srv_Output.Location = new System.Drawing.Point(219, 342);
            this.Srv_Output.Multiline = true;
            this.Srv_Output.Name = "Srv_Output";
            this.Srv_Output.ReadOnly = true;
            this.Srv_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Srv_Output.Size = new System.Drawing.Size(335, 205);
            this.Srv_Output.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 559);
            this.Controls.Add(this.Srv_Output);
            this.Controls.Add(this.srv_stop);
            this.Controls.Add(this.srv_init);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.debugbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startmap_btn);
            this.Controls.Add(this.startmap);
            this.Controls.Add(this.upd_ml);
            this.Controls.Add(this.maplist);
            this.Name = "Form1";
            this.Text = "Teeworlds server config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox maplist;
        private System.Windows.Forms.Button upd_ml;
        private System.Windows.Forms.TextBox startmap;
        private System.Windows.Forms.Button startmap_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox debugbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button srv_init;
        private System.Windows.Forms.Button srv_stop;
        private System.Windows.Forms.TextBox Srv_Output;
    }
}

