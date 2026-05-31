namespace ImgurWinform
{
    partial class CommentItem
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
            this.ID = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Label();
            this.Point = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ID.Location = new System.Drawing.Point(22, 17);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(30, 19);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down.Location = new System.Drawing.Point(64, 106);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(30, 35);
            this.down.TabIndex = 5;
            this.down.Tag = "down";
            this.down.Text = "⬇︎";
            this.down.Click += new System.EventHandler(this.Voteclicks);
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up.Location = new System.Drawing.Point(19, 105);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(30, 35);
            this.up.TabIndex = 4;
            this.up.Tag = "up";
            this.up.Text = "⬆︎";
            this.up.Click += new System.EventHandler(this.Voteclicks);
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Point.Location = new System.Drawing.Point(46, 117);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(21, 15);
            this.Point.TabIndex = 7;
            this.Point.Text = "20";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 144);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 420);
            this.flowLayoutPanel1.TabIndex = 9;
        
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Replies+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 41);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 65);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // CommentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.ID);
            this.Name = "CommentItem";
            this.Size = new System.Drawing.Size(328, 578);      
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label down;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
