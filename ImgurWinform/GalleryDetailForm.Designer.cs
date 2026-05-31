namespace ImgurWinform
{
    partial class GalleryDetailForm
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
            this.Ups = new System.Windows.Forms.Label();
            this.Downs = new System.Windows.Forms.Label();
            this.Like = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Point = new System.Windows.Forms.Label();
            this.CommendCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.圖檔上傳ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.CommentID = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ups
            // 
            this.Ups.AutoSize = true;
            this.Ups.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ups.Location = new System.Drawing.Point(44, 73);
            this.Ups.Name = "Ups";
            this.Ups.Size = new System.Drawing.Size(40, 48);
            this.Ups.TabIndex = 0;
            this.Ups.Tag = "up";
            this.Ups.Text = "⬆︎";
            this.Ups.Click += new System.EventHandler(this.VoteClick);
            // 
            // Downs
            // 
            this.Downs.AutoSize = true;
            this.Downs.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Downs.Location = new System.Drawing.Point(44, 156);
            this.Downs.Name = "Downs";
            this.Downs.Size = new System.Drawing.Size(40, 48);
            this.Downs.TabIndex = 1;
            this.Downs.Tag = "down";
            this.Downs.Text = "⬇︎";
            this.Downs.Click += new System.EventHandler(this.VoteClick);
            // 
            // Like
            // 
            this.Like.AutoSize = true;
            this.Like.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Like.Location = new System.Drawing.Point(41, 219);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(45, 48);
            this.Like.TabIndex = 2;
            this.Like.Text = "♡";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Comment.Location = new System.Drawing.Point(37, 281);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(54, 37);
            this.Comment.TabIndex = 3;
            this.Comment.Text = "💬";
            // 
            // Title
            // 
            this.Title.AutoEllipsis = true;
            this.Title.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.Location = new System.Drawing.Point(116, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(430, 45);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.GetID);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 579);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Point.Location = new System.Drawing.Point(12, 130);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(100, 23);
            this.Point.TabIndex = 6;
            this.Point.Text = "32";
            this.Point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommendCount
            // 
            this.CommendCount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CommendCount.Location = new System.Drawing.Point(12, 320);
            this.CommendCount.Name = "CommendCount";
            this.CommendCount.Size = new System.Drawing.Size(100, 23);
            this.CommendCount.TabIndex = 7;
            this.CommendCount.Text = "50";
            this.CommendCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(593, 130);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(430, 522);
            this.flowLayoutPanel2.TabIndex = 8;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.CommentItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(593, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 81);
            this.textBox1.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.圖檔上傳ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // 圖檔上傳ToolStripMenuItem
            // 
            this.圖檔上傳ToolStripMenuItem.Name = "圖檔上傳ToolStripMenuItem";
            this.圖檔上傳ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.圖檔上傳ToolStripMenuItem.Text = "圖檔上傳";
            this.圖檔上傳ToolStripMenuItem.Click += new System.EventHandler(this.圖檔上傳ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "發送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommentID
            // 
            this.CommentID.AutoSize = true;
            this.CommentID.Location = new System.Drawing.Point(598, 103);
            this.CommentID.Name = "CommentID";
            this.CommentID.Size = new System.Drawing.Size(33, 12);
            this.CommentID.TabIndex = 11;
            this.CommentID.Text = "label1";
            // 
            // GalleryDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1061, 679);
            this.Controls.Add(this.CommentID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.CommendCount);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Like);
            this.Controls.Add(this.Downs);
            this.Controls.Add(this.Ups);
            this.Name = "GalleryDetailForm";
            this.Text = "GalleryDetailForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ups;
        private System.Windows.Forms.Label Downs;
        private System.Windows.Forms.Label Like;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.Label CommendCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CommentID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 圖檔上傳ToolStripMenuItem;
    }
}