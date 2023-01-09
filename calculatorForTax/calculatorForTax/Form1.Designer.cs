namespace calculatorForTax
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.calkbutton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calkbutton
            // 
            this.calkbutton.Location = new System.Drawing.Point(483, 289);
            this.calkbutton.Name = "calkbutton";
            this.calkbutton.Size = new System.Drawing.Size(174, 68);
            this.calkbutton.TabIndex = 0;
            this.calkbutton.Text = "計算する";
            this.calkbutton.UseVisualStyleBackColor = true;
            this.calkbutton.Click += new System.EventHandler(this.calcButtonClicked);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(163, 105);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(379, 19);
            this.priceBox.TabIndex = 1;
            // 
            // taxBox
            // 
            this.taxBox.Enabled = false;
            this.taxBox.Location = new System.Drawing.Point(163, 201);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(379, 19);
            this.taxBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "税抜き価格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "税込み価格";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(714, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.calkbutton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button calkbutton;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

