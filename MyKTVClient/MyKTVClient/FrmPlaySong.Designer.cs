namespace MyKTVClient
{
    partial class FrmPlaySong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaySong));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wmp = new AxAPlayer3Lib.AxPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(623, 366);
            this.wmp.TabIndex = 0;
            this.wmp.OnOpenSucceeded += new System.EventHandler(this.wmp_OnOpenSucceeded);
            // 
            // FrmPlaySong
            // 
            this.ClientSize = new System.Drawing.Size(623, 366);
            this.Controls.Add(this.wmp);
            this.Name = "FrmPlaySong";
            this.Load += new System.EventHandler(this.FrmPlaySong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxAPlayer3Lib.AxPlayer wmp;
        private System.Windows.Forms.Timer timer1;
    }
}