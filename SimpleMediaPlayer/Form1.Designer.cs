namespace SimpleMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listFile = new System.Windows.Forms.ListBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(820, 12);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(285, 316);
            this.listFile.TabIndex = 8;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(1035, 334);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(70, 24);
            this.btn_Open.TabIndex = 9;
            this.btn_Open.Text = "&Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(802, 560);
            this.axWindowsMediaPlayer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 581);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Name = "Form1";
            this.Text = "Simple Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button btn_Open;
    }
}

