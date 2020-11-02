namespace Pinger
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.dataGridView_Display = new System.Windows.Forms.DataGridView();
            this.Col_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col_cluster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_machineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_Ping = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon_LOP = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker_worker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip_status = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar_pingProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_pingLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_credit = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Display)).BeginInit();
            this.statusStrip_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Display
            // 
            this.dataGridView_Display.AllowUserToAddRows = false;
            this.dataGridView_Display.AllowUserToDeleteRows = false;
            this.dataGridView_Display.AllowUserToOrderColumns = true;
            this.dataGridView_Display.AllowUserToResizeRows = false;
            this.dataGridView_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_image,
            this.Col_cluster,
            this.Col_machineName,
            this.Col_IP,
            this.Col_comments});
            this.dataGridView_Display.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Display.MultiSelect = false;
            this.dataGridView_Display.Name = "dataGridView_Display";
            this.dataGridView_Display.ReadOnly = true;
            this.dataGridView_Display.RowHeadersVisible = false;
            this.dataGridView_Display.Size = new System.Drawing.Size(530, 273);
            this.dataGridView_Display.TabIndex = 0;
            this.dataGridView_Display.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Display_CellDoubleClick);
            // 
            // Col_image
            // 
            this.Col_image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Col_image.FillWeight = 20F;
            this.Col_image.HeaderText = "Status";
            this.Col_image.Name = "Col_image";
            this.Col_image.ReadOnly = true;
            this.Col_image.Width = 43;
            // 
            // Col_cluster
            // 
            this.Col_cluster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_cluster.HeaderText = "Cluster";
            this.Col_cluster.Name = "Col_cluster";
            this.Col_cluster.ReadOnly = true;
            // 
            // Col_machineName
            // 
            this.Col_machineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_machineName.FillWeight = 145F;
            this.Col_machineName.HeaderText = "Machine Name";
            this.Col_machineName.Name = "Col_machineName";
            this.Col_machineName.ReadOnly = true;
            // 
            // Col_IP
            // 
            this.Col_IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_IP.HeaderText = "Address";
            this.Col_IP.Name = "Col_IP";
            this.Col_IP.ReadOnly = true;
            // 
            // Col_comments
            // 
            this.Col_comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_comments.FillWeight = 150F;
            this.Col_comments.HeaderText = "Comments";
            this.Col_comments.Name = "Col_comments";
            this.Col_comments.ReadOnly = true;
            // 
            // timer_Ping
            // 
            this.timer_Ping.Enabled = true;
            this.timer_Ping.Interval = 30000;
            this.timer_Ping.Tick += new System.EventHandler(this.timer_Ping_Tick);
            // 
            // notifyIcon_LOP
            // 
            this.notifyIcon_LOP.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_LOP.Icon")));
            this.notifyIcon_LOP.Text = "Pinger";
            this.notifyIcon_LOP.Visible = true;
            this.notifyIcon_LOP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_LOP_MouseDoubleClick);
            // 
            // backgroundWorker_worker
            // 
            this.backgroundWorker_worker.WorkerSupportsCancellation = true;
            this.backgroundWorker_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_worker_DoWork);
            // 
            // statusStrip_status
            // 
            this.statusStrip_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar_pingProgress,
            this.toolStripStatusLabel_pingLabel,
            this.toolStripStatusLabel_credit});
            this.statusStrip_status.Location = new System.Drawing.Point(0, 251);
            this.statusStrip_status.Name = "statusStrip_status";
            this.statusStrip_status.Size = new System.Drawing.Size(530, 22);
            this.statusStrip_status.TabIndex = 1;
            this.statusStrip_status.Text = "statusStrip_status";
            // 
            // toolStripProgressBar_pingProgress
            // 
            this.toolStripProgressBar_pingProgress.Name = "toolStripProgressBar_pingProgress";
            this.toolStripProgressBar_pingProgress.Size = new System.Drawing.Size(300, 16);
            // 
            // toolStripStatusLabel_pingLabel
            // 
            this.toolStripStatusLabel_pingLabel.Name = "toolStripStatusLabel_pingLabel";
            this.toolStripStatusLabel_pingLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_credit
            // 
            this.toolStripStatusLabel_credit.Font = new System.Drawing.Font("Tahoma", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel_credit.Name = "toolStripStatusLabel_credit";
            this.toolStripStatusLabel_credit.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel_credit.Text = "©Chezzi";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 273);
            this.Controls.Add(this.statusStrip_status);
            this.Controls.Add(this.dataGridView_Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_main";
            this.Text = "Pinger";
            this.Shown += new System.EventHandler(this.Form_main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Display)).EndInit();
            this.statusStrip_status.ResumeLayout(false);
            this.statusStrip_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Display;
        private System.Windows.Forms.Timer timer_Ping;
        private System.Windows.Forms.NotifyIcon notifyIcon_LOP;
        private System.Windows.Forms.DataGridViewImageColumn Col_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_cluster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_machineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_comments;
        private System.ComponentModel.BackgroundWorker backgroundWorker_worker;
        private System.Windows.Forms.StatusStrip statusStrip_status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_pingProgress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_pingLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_credit;
    }
}

