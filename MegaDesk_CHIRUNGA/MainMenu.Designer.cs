namespace MegaDesk_CHIRUNGA
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addQuoteButton_Click = new System.Windows.Forms.Button();
            this.viewAllQuotesButton_Click = new System.Windows.Forms.Button();
            this.searchQuotesButton_Click = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addQuoteButton_Click);
            this.flowLayoutPanel1.Controls.Add(this.viewAllQuotesButton_Click);
            this.flowLayoutPanel1.Controls.Add(this.searchQuotesButton_Click);
            this.flowLayoutPanel1.Controls.Add(this.exitButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 462);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addQuoteButton_Click
            // 
            this.addQuoteButton_Click.Location = new System.Drawing.Point(3, 3);
            this.addQuoteButton_Click.Name = "addQuoteButton_Click";
            this.addQuoteButton_Click.Size = new System.Drawing.Size(203, 110);
            this.addQuoteButton_Click.TabIndex = 0;
            this.addQuoteButton_Click.Text = "&Add Quote";
            this.addQuoteButton_Click.UseVisualStyleBackColor = true;
            this.addQuoteButton_Click.Click += new System.EventHandler(this.addQuoteButton_Click_Click);
            // 
            // viewAllQuotesButton_Click
            // 
            this.viewAllQuotesButton_Click.Location = new System.Drawing.Point(3, 119);
            this.viewAllQuotesButton_Click.Name = "viewAllQuotesButton_Click";
            this.viewAllQuotesButton_Click.Size = new System.Drawing.Size(203, 110);
            this.viewAllQuotesButton_Click.TabIndex = 0;
            this.viewAllQuotesButton_Click.Text = "&View All Quotes";
            this.viewAllQuotesButton_Click.UseVisualStyleBackColor = true;
            this.viewAllQuotesButton_Click.Click += new System.EventHandler(this.viewAllQuotesButton_Click_Click);
            // 
            // searchQuotesButton_Click
            // 
            this.searchQuotesButton_Click.Location = new System.Drawing.Point(3, 235);
            this.searchQuotesButton_Click.Name = "searchQuotesButton_Click";
            this.searchQuotesButton_Click.Size = new System.Drawing.Size(203, 110);
            this.searchQuotesButton_Click.TabIndex = 0;
            this.searchQuotesButton_Click.Text = "&Search Quotes";
            this.searchQuotesButton_Click.UseVisualStyleBackColor = true;
            this.searchQuotesButton_Click.Click += new System.EventHandler(this.searchQoutesButton_Click_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 110);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 462);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainMenu";
            this.Text = "MainMenu_Chirunga";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addQuoteButton_Click;
        private System.Windows.Forms.Button viewAllQuotesButton_Click;
        private System.Windows.Forms.Button searchQuotesButton_Click;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

