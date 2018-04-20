namespace CoinMaker
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
            this.button2 = new System.Windows.Forms.Button();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vhtt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(84, 187);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.Size = new System.Drawing.Size(651, 187);
            this.dtg_show.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vốn Hóa Thị Trường";
            // 
            // tb_vhtt
            // 
            this.tb_vhtt.Location = new System.Drawing.Point(212, 52);
            this.tb_vhtt.Name = "tb_vhtt";
            this.tb_vhtt.Size = new System.Drawing.Size(100, 20);
            this.tb_vhtt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.tb_vhtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_vhtt;
    }
}

