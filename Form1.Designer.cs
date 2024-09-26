namespace Windows
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
            this.Messagelabel = new System.Windows.Forms.Label();
            this.Actionbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Messagelabel.Location = new System.Drawing.Point(422, 166);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(161, 38);
            this.Messagelabel.TabIndex = 0;
            this.Messagelabel.Text = "操作を表示";
            // 
            // Actionbutton
            // 
            this.Actionbutton.AutoSize = true;
            this.Actionbutton.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Actionbutton.Location = new System.Drawing.Point(185, 162);
            this.Actionbutton.Name = "Actionbutton";
            this.Actionbutton.Size = new System.Drawing.Size(134, 47);
            this.Actionbutton.TabIndex = 1;
            this.Actionbutton.Text = "Action";
            this.Actionbutton.UseVisualStyleBackColor = true;
            this.Actionbutton.Click += new System.EventHandler(this.Actionbutton_Click);
            this.Actionbutton.MouseLeave += new System.EventHandler(this.Actionbutton_MouseLeave);
            this.Actionbutton.MouseHover += new System.EventHandler(this.Actionbutton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Actionbutton);
            this.Controls.Add(this.Messagelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.Button Actionbutton;
    }
}

