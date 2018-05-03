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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_coin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_nameCoin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Coin";
            // 
            // dgv_coin
            // 
            this.dgv_coin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coin.Location = new System.Drawing.Point(47, 222);
            this.dgv_coin.Name = "dgv_coin";
            this.dgv_coin.Size = new System.Drawing.Size(706, 185);
            this.dgv_coin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_nameCoin
            // 
            this.cbb_nameCoin.FormattingEnabled = true;
            this.cbb_nameCoin.Location = new System.Drawing.Point(98, 99);
            this.cbb_nameCoin.Name = "cbb_nameCoin";
            this.cbb_nameCoin.Size = new System.Drawing.Size(121, 21);
            this.cbb_nameCoin.TabIndex = 5;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb_nameCoin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_coin);
            this.Controls.Add(this.label1);
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_coin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbb_nameCoin;
    }
}