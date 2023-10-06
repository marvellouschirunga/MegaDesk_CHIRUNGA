namespace MegaDesk_CHIRUNGA
{
    partial class DisplayQuote
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.EditQuotebutton = new System.Windows.Forms.Button();
            this.depthLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.surfaceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerNamelabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Quote";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(615, 276);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Exit";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditQuotebutton
            // 
            this.EditQuotebutton.Location = new System.Drawing.Point(318, 276);
            this.EditQuotebutton.Name = "EditQuotebutton";
            this.EditQuotebutton.Size = new System.Drawing.Size(129, 30);
            this.EditQuotebutton.TabIndex = 3;
            this.EditQuotebutton.Text = "Edit Quote";
            this.EditQuotebutton.UseVisualStyleBackColor = true;
            this.EditQuotebutton.Click += new System.EventHandler(this.EditQuotebutton_Click);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(48, 189);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(39, 13);
            this.depthLabel.TabIndex = 0;
            this.depthLabel.Text = "Depth:";
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(666, 189);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(48, 13);
            this.deliveryLabel.TabIndex = 0;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // surfaceLabel
            // 
            this.surfaceLabel.AutoSize = true;
            this.surfaceLabel.Location = new System.Drawing.Point(408, 189);
            this.surfaceLabel.Name = "surfaceLabel";
            this.surfaceLabel.Size = new System.Drawing.Size(87, 13);
            this.surfaceLabel.TabIndex = 0;
            this.surfaceLabel.Text = "Surface Material:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(652, 74);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 0;
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Location = new System.Drawing.Point(416, 73);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(0, 13);
            this.drawersLabel.TabIndex = 0;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(49, 74);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.EditQuotebutton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.depthLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.deliveryLabel);
            this.groupBox1.Controls.Add(this.surfaceLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.drawersLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.widthLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quotation";
            // 
            // customerNamelabel
            // 
            this.customerNamelabel.AutoSize = true;
            this.customerNamelabel.Location = new System.Drawing.Point(502, 48);
            this.customerNamelabel.Name = "customerNamelabel";
            this.customerNamelabel.Size = new System.Drawing.Size(85, 13);
            this.customerNamelabel.TabIndex = 7;
            this.customerNamelabel.Text = "Customer Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(691, 87);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 13);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Total Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Width:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Depth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Surface Material:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Delivery:";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNamelabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button EditQuotebutton;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Label surfaceLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label customerNamelabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}