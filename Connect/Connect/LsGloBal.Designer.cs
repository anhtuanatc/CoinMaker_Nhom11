namespace Connect
{
    partial class LsGloBal
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
            this.dtg_global = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_vhttln = new DevExpress.XtraEditors.LabelControl();
            this.lb_kl24hln = new DevExpress.XtraEditors.LabelControl();
            this.lb_bccutln = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_global)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_global
            // 
            this.dtg_global.Location = new System.Drawing.Point(12, 214);
            this.dtg_global.MainView = this.gridView1;
            this.dtg_global.Name = "dtg_global";
            this.dtg_global.Size = new System.Drawing.Size(776, 224);
            this.dtg_global.TabIndex = 0;
            this.dtg_global.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dtg_global;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(234, 33);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "LỊCH SỬ TOÀN CẦU";
            // 
            // lb_vhttln
            // 
            this.lb_vhttln.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_vhttln.Appearance.Options.UseFont = true;
            this.lb_vhttln.Location = new System.Drawing.Point(12, 71);
            this.lb_vhttln.Name = "lb_vhttln";
            this.lb_vhttln.Size = new System.Drawing.Size(216, 19);
            this.lb_vhttln.TabIndex = 2;
            this.lb_vhttln.Text = "Vốn Hóa Thị Trường Lớn Nhất";
            // 
            // lb_kl24hln
            // 
            this.lb_kl24hln.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_kl24hln.Appearance.Options.UseFont = true;
            this.lb_kl24hln.Location = new System.Drawing.Point(12, 114);
            this.lb_kl24hln.Name = "lb_kl24hln";
            this.lb_kl24hln.Size = new System.Drawing.Size(230, 19);
            this.lb_kl24hln.TabIndex = 3;
            this.lb_kl24hln.Text = "Khối Lượng Trong 24h Lớn Nhất";
            // 
            // lb_bccutln
            // 
            this.lb_bccutln.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_bccutln.Appearance.Options.UseFont = true;
            this.lb_bccutln.Location = new System.Drawing.Point(12, 160);
            this.lb_bccutln.Name = "lb_bccutln";
            this.lb_bccutln.Size = new System.Drawing.Size(227, 19);
            this.lb_bccutln.TabIndex = 4;
            this.lb_bccutln.Text = "BitCoin Chiếm Ưu Thế Lớn Nhất";
            // 
            // LsGloBal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_bccutln);
            this.Controls.Add(this.lb_kl24hln);
            this.Controls.Add(this.lb_vhttln);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtg_global);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LsGloBal";
            this.Text = "LsGloBal";
            this.Load += new System.EventHandler(this.LsGloBal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_global)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtg_global;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_vhttln;
        private DevExpress.XtraEditors.LabelControl lb_kl24hln;
        private DevExpress.XtraEditors.LabelControl lb_bccutln;
    }
}