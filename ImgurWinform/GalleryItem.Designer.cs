namespace ImgurWinform
{
    partial class GalleryItem
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryItem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ups = new System.Windows.Forms.Label();
            this.Downs = new System.Windows.Forms.Label();
            this.CommentCount = new System.Windows.Forms.Label();
            this.Views = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoEllipsis = true;
            this.Title.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.Location = new System.Drawing.Point(3, 181);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(220, 33);
            this.Title.TabIndex = 1;
            this.Title.Text = resources.GetString("Title.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(4, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "⬆︎";
            this.label2.Click += new System.EventHandler(this.Like_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(49, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "⬇︎";
            this.label3.Click += new System.EventHandler(this.Unlike_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(96, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "💬";
            this.label4.Click += new System.EventHandler(this.Comment_ClickAsync);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(158, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "👁️‍🗨️";
            // 
            // Ups
            // 
            this.Ups.AutoSize = true;
            this.Ups.Location = new System.Drawing.Point(23, 227);
            this.Ups.Name = "Ups";
            this.Ups.Size = new System.Drawing.Size(17, 12);
            this.Ups.TabIndex = 6;
            this.Ups.Text = "20";
            // 
            // Downs
            // 
            this.Downs.AutoSize = true;
            this.Downs.Location = new System.Drawing.Point(68, 227);
            this.Downs.Name = "Downs";
            this.Downs.Size = new System.Drawing.Size(17, 12);
            this.Downs.TabIndex = 7;
            this.Downs.Text = "15";
            // 
            // CommentCount
            // 
            this.CommentCount.AutoSize = true;
            this.CommentCount.Location = new System.Drawing.Point(134, 227);
            this.CommentCount.Name = "CommentCount";
            this.CommentCount.Size = new System.Drawing.Size(11, 12);
            this.CommentCount.TabIndex = 8;
            this.CommentCount.Text = "5";
            // 
            // Views
            // 
            this.Views.AutoSize = true;
            this.Views.Location = new System.Drawing.Point(197, 227);
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(23, 12);
            this.Views.TabIndex = 9;
            this.Views.Text = "100";
            // 
            // GalleryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Views);
            this.Controls.Add(this.CommentCount);
            this.Controls.Add(this.Downs);
            this.Controls.Add(this.Ups);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GalleryItem";
            this.Size = new System.Drawing.Size(232, 247);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ups;
        private System.Windows.Forms.Label Downs;
        private System.Windows.Forms.Label CommentCount;
        private System.Windows.Forms.Label Views;
    }
}
