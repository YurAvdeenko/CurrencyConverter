
namespace CurrencyConverter.View
{
    partial class CashierDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.setTimeButton = new System.Windows.Forms.Button();
            this.setLimitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sellRublsLabel = new System.Windows.Forms.Label();
            this.buyRublsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sellEuroLabel = new System.Windows.Forms.Label();
            this.buyEuroLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sellDollarLabel = new System.Windows.Forms.Label();
            this.buyDollarLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeDollarRateButton = new System.Windows.Forms.Button();
            this.changeEuroRateButton = new System.Windows.Forms.Button();
            this.changeRublsRateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.historyButton);
            this.groupBox1.Controls.Add(this.setTimeButton);
            this.groupBox1.Controls.Add(this.setLimitButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.historyButton.Location = new System.Drawing.Point(379, 16);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(147, 50);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // setTimeButton
            // 
            this.setTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.setTimeButton.Location = new System.Drawing.Point(194, 16);
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.Size = new System.Drawing.Size(147, 50);
            this.setTimeButton.TabIndex = 1;
            this.setTimeButton.Text = "Set time";
            this.setTimeButton.UseVisualStyleBackColor = true;
            this.setTimeButton.Click += new System.EventHandler(this.setTimeButton_Click);
            // 
            // setLimitButton
            // 
            this.setLimitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.setLimitButton.Location = new System.Drawing.Point(7, 16);
            this.setLimitButton.Name = "setLimitButton";
            this.setLimitButton.Size = new System.Drawing.Size(147, 50);
            this.setLimitButton.TabIndex = 0;
            this.setLimitButton.Text = "Set limit";
            this.setLimitButton.UseVisualStyleBackColor = true;
            this.setLimitButton.Click += new System.EventHandler(this.setLimitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exchange rates";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.sellRublsLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.buyRublsLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.sellEuroLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buyEuroLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.sellDollarLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buyDollarLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.changeDollarRateButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.changeEuroRateButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.changeRublsRateButton, 3, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 174);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // sellRublsLabel
            // 
            this.sellRublsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellRublsLabel.AutoSize = true;
            this.sellRublsLabel.Location = new System.Drawing.Point(302, 145);
            this.sellRublsLabel.Name = "sellRublsLabel";
            this.sellRublsLabel.Size = new System.Drawing.Size(41, 13);
            this.sellRublsLabel.TabIndex = 20;
            this.sellRublsLabel.Text = "label13";
            // 
            // buyRublsLabel
            // 
            this.buyRublsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buyRublsLabel.AutoSize = true;
            this.buyRublsLabel.Location = new System.Drawing.Point(173, 145);
            this.buyRublsLabel.Name = "buyRublsLabel";
            this.buyRublsLabel.Size = new System.Drawing.Size(41, 13);
            this.buyRublsLabel.TabIndex = 19;
            this.buyRublsLabel.Text = "label12";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Russian rubls";
            // 
            // sellEuroLabel
            // 
            this.sellEuroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellEuroLabel.AutoSize = true;
            this.sellEuroLabel.Location = new System.Drawing.Point(302, 101);
            this.sellEuroLabel.Name = "sellEuroLabel";
            this.sellEuroLabel.Size = new System.Drawing.Size(41, 13);
            this.sellEuroLabel.TabIndex = 17;
            this.sellEuroLabel.Text = "label10";
            // 
            // buyEuroLabel
            // 
            this.buyEuroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buyEuroLabel.AutoSize = true;
            this.buyEuroLabel.Location = new System.Drawing.Point(176, 101);
            this.buyEuroLabel.Name = "buyEuroLabel";
            this.buyEuroLabel.Size = new System.Drawing.Size(35, 13);
            this.buyEuroLabel.TabIndex = 16;
            this.buyEuroLabel.Text = "label9";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Euro";
            // 
            // sellDollarLabel
            // 
            this.sellDollarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellDollarLabel.AutoSize = true;
            this.sellDollarLabel.Location = new System.Drawing.Point(305, 58);
            this.sellDollarLabel.Name = "sellDollarLabel";
            this.sellDollarLabel.Size = new System.Drawing.Size(35, 13);
            this.sellDollarLabel.TabIndex = 14;
            this.sellDollarLabel.Text = "label7";
            // 
            // buyDollarLabel
            // 
            this.buyDollarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buyDollarLabel.AutoSize = true;
            this.buyDollarLabel.Location = new System.Drawing.Point(176, 58);
            this.buyDollarLabel.Name = "buyDollarLabel";
            this.buyDollarLabel.Size = new System.Drawing.Size(35, 13);
            this.buyDollarLabel.TabIndex = 13;
            this.buyDollarLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dollar";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sell";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buy";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency";
            // 
            // changeDollarRateButton
            // 
            this.changeDollarRateButton.Location = new System.Drawing.Point(390, 46);
            this.changeDollarRateButton.Name = "changeDollarRateButton";
            this.changeDollarRateButton.Size = new System.Drawing.Size(126, 37);
            this.changeDollarRateButton.TabIndex = 6;
            this.changeDollarRateButton.Text = "change rate";
            this.changeDollarRateButton.UseVisualStyleBackColor = true;
            this.changeDollarRateButton.Click += new System.EventHandler(this.changeDollarRateButton_Click);
            // 
            // changeEuroRateButton
            // 
            this.changeEuroRateButton.Location = new System.Drawing.Point(390, 89);
            this.changeEuroRateButton.Name = "changeEuroRateButton";
            this.changeEuroRateButton.Size = new System.Drawing.Size(126, 37);
            this.changeEuroRateButton.TabIndex = 7;
            this.changeEuroRateButton.Text = "change rate";
            this.changeEuroRateButton.UseVisualStyleBackColor = true;
            this.changeEuroRateButton.Click += new System.EventHandler(this.changeEuroRateButton_Click);
            // 
            // changeRublsRateButton
            // 
            this.changeRublsRateButton.Location = new System.Drawing.Point(390, 132);
            this.changeRublsRateButton.Name = "changeRublsRateButton";
            this.changeRublsRateButton.Size = new System.Drawing.Size(126, 39);
            this.changeRublsRateButton.TabIndex = 8;
            this.changeRublsRateButton.Text = "change rate";
            this.changeRublsRateButton.UseVisualStyleBackColor = true;
            this.changeRublsRateButton.Click += new System.EventHandler(this.changeRublsRateButton_Click);
            // 
            // CashierDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CashierDialog";
            this.Text = "CashierDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button setTimeButton;
        private System.Windows.Forms.Button setLimitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label sellRublsLabel;
        private System.Windows.Forms.Label buyRublsLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sellEuroLabel;
        private System.Windows.Forms.Label buyEuroLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label sellDollarLabel;
        private System.Windows.Forms.Label buyDollarLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeDollarRateButton;
        private System.Windows.Forms.Button changeEuroRateButton;
        private System.Windows.Forms.Button changeRublsRateButton;
    }
}