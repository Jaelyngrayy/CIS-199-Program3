
namespace Program3
{
    partial class GroceryCalculator
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
            this.farmComboBox = new System.Windows.Forms.ComboBox();
            this.farmLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.initialCostLabel = new System.Windows.Forms.Label();
            this.discountedCostLabel = new System.Windows.Forms.Label();
            this.shipmentCostLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.initialCostOutLabel = new System.Windows.Forms.Label();
            this.discountedCostOutLabel = new System.Windows.Forms.Label();
            this.shipmentCostOutLabel = new System.Windows.Forms.Label();
            this.totalPriceOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // farmComboBox
            // 
            this.farmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.farmComboBox.FormattingEnabled = true;
            this.farmComboBox.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.farmComboBox.Location = new System.Drawing.Point(111, 20);
            this.farmComboBox.Name = "farmComboBox";
            this.farmComboBox.Size = new System.Drawing.Size(111, 21);
            this.farmComboBox.TabIndex = 0;
            // 
            // farmLabel
            // 
            this.farmLabel.AutoSize = true;
            this.farmLabel.Location = new System.Drawing.Point(64, 23);
            this.farmLabel.Name = "farmLabel";
            this.farmLabel.Size = new System.Drawing.Size(33, 13);
            this.farmLabel.TabIndex = 1;
            this.farmLabel.Text = "Farm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity (lbs):";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(111, 48);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(111, 20);
            this.itemTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(111, 74);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(111, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(129, 100);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // initialCostLabel
            // 
            this.initialCostLabel.AutoSize = true;
            this.initialCostLabel.Location = new System.Drawing.Point(39, 150);
            this.initialCostLabel.Name = "initialCostLabel";
            this.initialCostLabel.Size = new System.Drawing.Size(58, 13);
            this.initialCostLabel.TabIndex = 7;
            this.initialCostLabel.Text = "Initial Cost:";
            // 
            // discountedCostLabel
            // 
            this.discountedCostLabel.AutoSize = true;
            this.discountedCostLabel.Location = new System.Drawing.Point(9, 174);
            this.discountedCostLabel.Name = "discountedCostLabel";
            this.discountedCostLabel.Size = new System.Drawing.Size(88, 13);
            this.discountedCostLabel.TabIndex = 8;
            this.discountedCostLabel.Text = "Discounted Cost:";
            // 
            // shipmentCostLabel
            // 
            this.shipmentCostLabel.AutoSize = true;
            this.shipmentCostLabel.Location = new System.Drawing.Point(19, 201);
            this.shipmentCostLabel.Name = "shipmentCostLabel";
            this.shipmentCostLabel.Size = new System.Drawing.Size(78, 13);
            this.shipmentCostLabel.TabIndex = 9;
            this.shipmentCostLabel.Text = "Shipment Cost:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(36, 226);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 10;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // initialCostOutLabel
            // 
            this.initialCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutLabel.Location = new System.Drawing.Point(111, 149);
            this.initialCostOutLabel.Name = "initialCostOutLabel";
            this.initialCostOutLabel.Size = new System.Drawing.Size(111, 19);
            this.initialCostOutLabel.TabIndex = 11;
            // 
            // discountedCostOutLabel
            // 
            this.discountedCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountedCostOutLabel.Location = new System.Drawing.Point(111, 173);
            this.discountedCostOutLabel.Name = "discountedCostOutLabel";
            this.discountedCostOutLabel.Size = new System.Drawing.Size(111, 19);
            this.discountedCostOutLabel.TabIndex = 12;
            // 
            // shipmentCostOutLabel
            // 
            this.shipmentCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentCostOutLabel.Location = new System.Drawing.Point(111, 200);
            this.shipmentCostOutLabel.Name = "shipmentCostOutLabel";
            this.shipmentCostOutLabel.Size = new System.Drawing.Size(111, 19);
            this.shipmentCostOutLabel.TabIndex = 13;
            // 
            // totalPriceOutLabel
            // 
            this.totalPriceOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutLabel.Location = new System.Drawing.Point(111, 225);
            this.totalPriceOutLabel.Name = "totalPriceOutLabel";
            this.totalPriceOutLabel.Size = new System.Drawing.Size(111, 19);
            this.totalPriceOutLabel.TabIndex = 14;
            // 
            // GroceryCalculator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 277);
            this.Controls.Add(this.totalPriceOutLabel);
            this.Controls.Add(this.shipmentCostOutLabel);
            this.Controls.Add(this.discountedCostOutLabel);
            this.Controls.Add(this.initialCostOutLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.shipmentCostLabel);
            this.Controls.Add(this.discountedCostLabel);
            this.Controls.Add(this.initialCostLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.farmLabel);
            this.Controls.Add(this.farmComboBox);
            this.Name = "GroceryCalculator";
            this.Text = "uPickItGocery Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox farmComboBox;
        private System.Windows.Forms.Label farmLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label initialCostLabel;
        private System.Windows.Forms.Label discountedCostLabel;
        private System.Windows.Forms.Label shipmentCostLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label initialCostOutLabel;
        private System.Windows.Forms.Label discountedCostOutLabel;
        private System.Windows.Forms.Label shipmentCostOutLabel;
        private System.Windows.Forms.Label totalPriceOutLabel;
    }
}

