﻿namespace Connect
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
            this.data_grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_vhtt = new DevExpress.XtraEditors.LabelControl();
            this.lb_lb24h1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_bcut = new DevExpress.XtraEditors.LabelControl();
            this.button3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_udcoin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lb_ngay = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.Location = new System.Drawing.Point(26, 263);
            this.data_grid.MainView = this.gridView1;
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(763, 233);
            this.data_grid.TabIndex = 11;
            this.data_grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.data_grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.data_grid_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.data_grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(295, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 33);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "COIN MARKET";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 24);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Vốn Hóa Thị Trường";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(197, 24);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Khối Lượng Trong 24h";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(196, 24);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "BitCoin Chiếm Ưu Thế";
            // 
            // lb_vhtt
            // 
            this.lb_vhtt.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lb_vhtt.Appearance.Options.UseFont = true;
            this.lb_vhtt.Location = new System.Drawing.Point(295, 79);
            this.lb_vhtt.Name = "lb_vhtt";
            this.lb_vhtt.Size = new System.Drawing.Size(28, 24);
            this.lb_vhtt.TabIndex = 16;
            this.lb_vhtt.Text = "1 $";
            // 
            // lb_lb24h1
            // 
            this.lb_lb24h1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lb_lb24h1.Appearance.Options.UseFont = true;
            this.lb_lb24h1.Location = new System.Drawing.Point(295, 125);
            this.lb_lb24h1.Name = "lb_lb24h1";
            this.lb_lb24h1.Size = new System.Drawing.Size(28, 24);
            this.lb_lb24h1.TabIndex = 17;
            this.lb_lb24h1.Text = "2 $";
            // 
            // lb_bcut
            // 
            this.lb_bcut.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lb_bcut.Appearance.Options.UseFont = true;
            this.lb_bcut.Location = new System.Drawing.Point(295, 166);
            this.lb_bcut.Name = "lb_bcut";
            this.lb_bcut.Size = new System.Drawing.Size(59, 24);
            this.lb_bcut.TabIndex = 18;
            this.lb_bcut.Text = "100 %";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Lịch Sử Coin";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(681, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Lịch Sừ GLoBal";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_udcoin
            // 
            this.btn_udcoin.Location = new System.Drawing.Point(681, 190);
            this.btn_udcoin.Name = "btn_udcoin";
            this.btn_udcoin.Size = new System.Drawing.Size(108, 23);
            this.btn_udcoin.TabIndex = 22;
            this.btn_udcoin.Text = "UpDate Coin";
            this.btn_udcoin.Click += new System.EventHandler(this.btn_udcoin_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(26, 232);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 19);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Ngày :";
            // 
            // lb_ngay
            // 
            this.lb_ngay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_ngay.Appearance.Options.UseFont = true;
            this.lb_ngay.Location = new System.Drawing.Point(88, 232);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(66, 19);
            this.lb_ngay.TabIndex = 24;
            this.lb_ngay.Text = "4-5-2018";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 508);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btn_udcoin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lb_bcut);
            this.Controls.Add(this.lb_lb24h1);
            this.Controls.Add(this.lb_vhtt);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.data_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl data_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lb_vhtt;
        private DevExpress.XtraEditors.LabelControl lb_lb24h1;
        private DevExpress.XtraEditors.LabelControl lb_bcut;
        private DevExpress.XtraEditors.SimpleButton button3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_udcoin;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lb_ngay;
    }
}

