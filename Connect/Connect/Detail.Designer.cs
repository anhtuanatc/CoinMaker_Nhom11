namespace Connect
{
    partial class Detail
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.dgv_coin = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_showCoin = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_nameCoin = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_dht = new DevExpress.XtraEditors.LabelControl();
            this.lb_nameCoin = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.modelChartCoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_slgiatri = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelChartCoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_coin
            // 
            this.dgv_coin.Location = new System.Drawing.Point(50, 270);
            this.dgv_coin.MainView = this.gridView1;
            this.dgv_coin.Name = "dgv_coin";
            this.dgv_coin.Size = new System.Drawing.Size(706, 229);
            this.dgv_coin.TabIndex = 6;
            this.dgv_coin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv_coin;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btn_showCoin
            // 
            this.btn_showCoin.Location = new System.Drawing.Point(50, 141);
            this.btn_showCoin.Name = "btn_showCoin";
            this.btn_showCoin.Size = new System.Drawing.Size(75, 23);
            this.btn_showCoin.TabIndex = 7;
            this.btn_showCoin.Text = "Show";
            this.btn_showCoin.Click += new System.EventHandler(this.btn_showCoin_Click);
            // 
            // cbb_nameCoin
            // 
            this.cbb_nameCoin.FormattingEnabled = true;
            this.cbb_nameCoin.Location = new System.Drawing.Point(143, 99);
            this.cbb_nameCoin.Name = "cbb_nameCoin";
            this.cbb_nameCoin.Size = new System.Drawing.Size(121, 21);
            this.cbb_nameCoin.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(145, 33);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Lịch Sử Coin";
            // 
            // lb_dht
            // 
            this.lb_dht.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_dht.Appearance.Options.UseFont = true;
            this.lb_dht.Location = new System.Drawing.Point(50, 181);
            this.lb_dht.Name = "lb_dht";
            this.lb_dht.Size = new System.Drawing.Size(134, 23);
            this.lb_dht.TabIndex = 10;
            this.lb_dht.Text = "Đang Hiển Thị :";
            // 
            // lb_nameCoin
            // 
            this.lb_nameCoin.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_nameCoin.Appearance.Options.UseFont = true;
            this.lb_nameCoin.Location = new System.Drawing.Point(190, 181);
            this.lb_nameCoin.Name = "lb_nameCoin";
            this.lb_nameCoin.Size = new System.Drawing.Size(0, 23);
            this.lb_nameCoin.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 19);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Chọn Coin";
            // 
            // chartControl1
            // 
            this.chartControl1.DataBindings = null;
            this.chartControl1.DataSource = this.modelChartCoinBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "gtri";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(391, 42);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "last_updated";
            series1.ColorDataMember = "price_usd";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Series 1";
            series1.ToolTipHintDataMember = "price_usd";
            series1.ValueDataMembersSerializable = "price_usd";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "last_updated";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "price_usd";
            this.chartControl1.Size = new System.Drawing.Size(365, 162);
            this.chartControl1.TabIndex = 13;
            chartTitle1.Text = "Thống Kê";
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // modelChartCoinBindingSource
            // 
            this.modelChartCoinBindingSource.DataSource = typeof(Connect.ModelChartCoin);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(50, 224);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 23);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Có :";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // lb_slgiatri
            // 
            this.lb_slgiatri.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_slgiatri.Appearance.Options.UseFont = true;
            this.lb_slgiatri.Location = new System.Drawing.Point(107, 224);
            this.lb_slgiatri.Name = "lb_slgiatri";
            this.lb_slgiatri.Size = new System.Drawing.Size(0, 23);
            this.lb_slgiatri.TabIndex = 15;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 511);
            this.Controls.Add(this.lb_slgiatri);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lb_nameCoin);
            this.Controls.Add(this.lb_dht);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbb_nameCoin);
            this.Controls.Add(this.btn_showCoin);
            this.Controls.Add(this.dgv_coin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelChartCoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgv_coin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_showCoin;
        private System.Windows.Forms.ComboBox cbb_nameCoin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_dht;
        private DevExpress.XtraEditors.LabelControl lb_nameCoin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource modelChartCoinBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lb_slgiatri;
    }
}