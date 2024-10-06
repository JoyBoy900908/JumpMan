namespace final_4
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.plat1 = new System.Windows.Forms.PictureBox();
            this.plat2 = new System.Windows.Forms.PictureBox();
            this.plat3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.plat4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat4)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Peru;
            this.ground.Location = new System.Drawing.Point(-12, 418);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(600, 110);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // plat1
            // 
            this.plat1.BackColor = System.Drawing.SystemColors.Highlight;
            this.plat1.Location = new System.Drawing.Point(179, 346);
            this.plat1.Name = "plat1";
            this.plat1.Size = new System.Drawing.Size(146, 10);
            this.plat1.TabIndex = 1;
            this.plat1.TabStop = false;
            // 
            // plat2
            // 
            this.plat2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plat2.Location = new System.Drawing.Point(310, 230);
            this.plat2.Name = "plat2";
            this.plat2.Size = new System.Drawing.Size(153, 10);
            this.plat2.TabIndex = 2;
            this.plat2.TabStop = false;
            // 
            // plat3
            // 
            this.plat3.BackColor = System.Drawing.SystemColors.Highlight;
            this.plat3.Location = new System.Drawing.Point(59, 152);
            this.plat3.Name = "plat3";
            this.plat3.Size = new System.Drawing.Size(146, 10);
            this.plat3.TabIndex = 3;
            this.plat3.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(411, 359);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(33, 53);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "左右鍵移動，空白鍵跳躍，按住可蓄力";
            // 
            // plat4
            // 
            this.plat4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plat4.Location = new System.Drawing.Point(48, 270);
            this.plat4.Name = "plat4";
            this.plat4.Size = new System.Drawing.Size(153, 10);
            this.plat4.TabIndex = 6;
            this.plat4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 509);
            this.Controls.Add(this.plat4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.plat3);
            this.Controls.Add(this.plat2);
            this.Controls.Add(this.plat1);
            this.Controls.Add(this.ground);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox plat1;
        private System.Windows.Forms.PictureBox plat2;
        private System.Windows.Forms.PictureBox plat3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox plat4;
    }
}

