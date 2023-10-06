namespace MegaDesk_CHIRUNGA
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitQuotebutton = new System.Windows.Forms.Button();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.numberOfDrawersComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(523, 63);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberOfDrawersComboBox);
            this.groupBox1.Controls.Add(this.surfaceMaterialComboBox);
            this.groupBox1.Controls.Add(this.deliveryComboBox);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.submitQuotebutton);
            this.groupBox1.Controls.Add(this.depthTextBox);
            this.groupBox1.Controls.Add(this.widthTextBox);
            this.groupBox1.Controls.Add(this.depthLabel);
            this.groupBox1.Controls.Add(this.deliveryLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.widthLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 348);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Information";
            // 
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.FormattingEnabled = true;
            this.surfaceMaterialComboBox.Location = new System.Drawing.Point(419, 186);
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            this.surfaceMaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.surfaceMaterialComboBox.TabIndex = 4;
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Location = new System.Drawing.Point(668, 189);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(121, 21);
            this.deliveryComboBox.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(668, 276);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitQuotebutton
            // 
            this.submitQuotebutton.Location = new System.Drawing.Point(419, 276);
            this.submitQuotebutton.Name = "submitQuotebutton";
            this.submitQuotebutton.Size = new System.Drawing.Size(129, 30);
            this.submitQuotebutton.TabIndex = 3;
            this.submitQuotebutton.Text = "Submit";
            this.submitQuotebutton.UseVisualStyleBackColor = true;
            this.submitQuotebutton.Click += new System.EventHandler(this.submitQuotebutton_Click);
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(48, 182);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 1;
            this.depthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthTextBox_Validating);
            this.depthTextBox.Validated += new System.EventHandler(this.depthTextBox_Validated);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(47, 66);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 1;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            this.widthTextBox.Validated += new System.EventHandler(this.widthTextBox_Validated);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(6, 189);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(39, 13);
            this.depthLabel.TabIndex = 0;
            this.depthLabel.Text = "Depth:";
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(613, 189);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(48, 13);
            this.deliveryLabel.TabIndex = 0;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Surface Material:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of drawers:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(5, 74);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width:";
            // 
            // numberOfDrawersComboBox
            // 
            this.numberOfDrawersComboBox.FormattingEnabled = true;
            this.numberOfDrawersComboBox.Location = new System.Drawing.Point(419, 66);
            this.numberOfDrawersComboBox.Name = "numberOfDrawersComboBox";
            this.numberOfDrawersComboBox.Size = new System.Drawing.Size(121, 21);
            this.numberOfDrawersComboBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(651, 73);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQoute";
            this.Load += new System.EventHandler(this.AddQoute_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitQuotebutton;
        private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
        private System.Windows.Forms.ComboBox deliveryComboBox;
        private System.Windows.Forms.ComboBox numberOfDrawersComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label dateLabel;
    }
}