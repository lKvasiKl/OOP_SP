namespace Lab_1
{
    partial class Lab_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.arrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.orderTimeIntervalLabel = new System.Windows.Forms.Label();
            this.fulfilmentTimeTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.ordersGrupBox = new System.Windows.Forms.GroupBox();
            this.currentOrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderLineTextBox = new System.Windows.Forms.TextBox();
            this.kitchenGroupBox = new System.Windows.Forms.GroupBox();
            this.oredersAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderNumberGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparingOrderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.waitingCustomersNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderAvailableForPickupTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.arrivalTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.fulfilmentTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.ordersGrupBox.SuspendLayout();
            this.kitchenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulfilmentTimeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimeLabel.Location = new System.Drawing.Point(12, 113);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(231, 19);
            this.arrivalTimeLabel.TabIndex = 0;
            this.arrivalTimeLabel.Text = "Customer arrival time interval";
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(12, 135);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(100, 29);
            this.arrivalTimeTextBox.TabIndex = 1;
            // 
            // orderTimeIntervalLabel
            // 
            this.orderTimeIntervalLabel.AutoSize = true;
            this.orderTimeIntervalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderTimeIntervalLabel.Location = new System.Drawing.Point(12, 186);
            this.orderTimeIntervalLabel.Name = "orderTimeIntervalLabel";
            this.orderTimeIntervalLabel.Size = new System.Drawing.Size(222, 19);
            this.orderTimeIntervalLabel.TabIndex = 2;
            this.orderTimeIntervalLabel.Text = "Order fulfilment time interval";
            // 
            // fulfilmentTimeTextBox
            // 
            this.fulfilmentTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fulfilmentTimeTextBox.Location = new System.Drawing.Point(12, 208);
            this.fulfilmentTimeTextBox.Name = "fulfilmentTimeTextBox";
            this.fulfilmentTimeTextBox.Size = new System.Drawing.Size(100, 29);
            this.fulfilmentTimeTextBox.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(12, 253);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 45);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ordersGrupBox
            // 
            this.ordersGrupBox.Controls.Add(this.currentOrderNumberTextBox);
            this.ordersGrupBox.Controls.Add(this.label2);
            this.ordersGrupBox.Controls.Add(this.label1);
            this.ordersGrupBox.Controls.Add(this.orderLineTextBox);
            this.ordersGrupBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ordersGrupBox.Location = new System.Drawing.Point(296, 22);
            this.ordersGrupBox.Name = "ordersGrupBox";
            this.ordersGrupBox.Size = new System.Drawing.Size(295, 185);
            this.ordersGrupBox.TabIndex = 5;
            this.ordersGrupBox.TabStop = false;
            this.ordersGrupBox.Text = "Orders";
            // 
            // currentOrderNumberTextBox
            // 
            this.currentOrderNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentOrderNumberTextBox.Enabled = false;
            this.currentOrderNumberTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.currentOrderNumberTextBox.Location = new System.Drawing.Point(178, 111);
            this.currentOrderNumberTextBox.Name = "currentOrderNumberTextBox";
            this.currentOrderNumberTextBox.Size = new System.Drawing.Size(74, 34);
            this.currentOrderNumberTextBox.TabIndex = 8;
            this.currentOrderNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order number currently\r\nbeing taken\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "The number of customers \r\nwaiting to place orders\r\n";
            // 
            // orderLineTextBox
            // 
            this.orderLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderLineTextBox.Enabled = false;
            this.orderLineTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.orderLineTextBox.Location = new System.Drawing.Point(178, 41);
            this.orderLineTextBox.Name = "orderLineTextBox";
            this.orderLineTextBox.Size = new System.Drawing.Size(74, 34);
            this.orderLineTextBox.TabIndex = 0;
            this.orderLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kitchenGroupBox
            // 
            this.kitchenGroupBox.Controls.Add(this.oredersAmountTextBox);
            this.kitchenGroupBox.Controls.Add(this.label4);
            this.kitchenGroupBox.Controls.Add(this.orderNumberGridView);
            this.kitchenGroupBox.Controls.Add(this.preparingOrderTextBox);
            this.kitchenGroupBox.Controls.Add(this.label3);
            this.kitchenGroupBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitchenGroupBox.Location = new System.Drawing.Point(628, 22);
            this.kitchenGroupBox.Name = "kitchenGroupBox";
            this.kitchenGroupBox.Size = new System.Drawing.Size(308, 399);
            this.kitchenGroupBox.TabIndex = 6;
            this.kitchenGroupBox.TabStop = false;
            this.kitchenGroupBox.Text = "Kitchen";
            // 
            // oredersAmountTextBox
            // 
            this.oredersAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oredersAmountTextBox.Enabled = false;
            this.oredersAmountTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.oredersAmountTextBox.Location = new System.Drawing.Point(168, 111);
            this.oredersAmountTextBox.Name = "oredersAmountTextBox";
            this.oredersAmountTextBox.Size = new System.Drawing.Size(74, 34);
            this.oredersAmountTextBox.TabIndex = 12;
            this.oredersAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Orders amount";
            // 
            // orderNumberGridView
            // 
            this.orderNumberGridView.AllowUserToAddRows = false;
            this.orderNumberGridView.AllowUserToDeleteRows = false;
            this.orderNumberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderNumberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.orderNumberGridView.Location = new System.Drawing.Point(6, 167);
            this.orderNumberGridView.Name = "orderNumberGridView";
            this.orderNumberGridView.ReadOnly = true;
            this.orderNumberGridView.RowTemplate.Height = 25;
            this.orderNumberGridView.Size = new System.Drawing.Size(169, 215);
            this.orderNumberGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // preparingOrderTextBox
            // 
            this.preparingOrderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preparingOrderTextBox.Enabled = false;
            this.preparingOrderTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.preparingOrderTextBox.Location = new System.Drawing.Point(168, 41);
            this.preparingOrderTextBox.Name = "preparingOrderTextBox";
            this.preparingOrderTextBox.Size = new System.Drawing.Size(74, 34);
            this.preparingOrderTextBox.TabIndex = 9;
            this.preparingOrderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order number that is\r\npreparing\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.waitingCustomersNumberTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.orderAvailableForPickupTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(296, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pickup area";
            // 
            // waitingCustomersNumberTextBox
            // 
            this.waitingCustomersNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waitingCustomersNumberTextBox.Enabled = false;
            this.waitingCustomersNumberTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.waitingCustomersNumberTextBox.Location = new System.Drawing.Point(178, 105);
            this.waitingCustomersNumberTextBox.Name = "waitingCustomersNumberTextBox";
            this.waitingCustomersNumberTextBox.Size = new System.Drawing.Size(74, 34);
            this.waitingCustomersNumberTextBox.TabIndex = 11;
            this.waitingCustomersNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of customers \r\nwaiting in the serving line";
            // 
            // orderAvailableForPickupTextBox
            // 
            this.orderAvailableForPickupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderAvailableForPickupTextBox.Enabled = false;
            this.orderAvailableForPickupTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.orderAvailableForPickupTextBox.Location = new System.Drawing.Point(178, 42);
            this.orderAvailableForPickupTextBox.Name = "orderAvailableForPickupTextBox";
            this.orderAvailableForPickupTextBox.Size = new System.Drawing.Size(74, 34);
            this.orderAvailableForPickupTextBox.TabIndex = 9;
            this.orderAvailableForPickupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order number currently\r\navailable for pickup";
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(143, 253);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 45);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // arrivalTimeUpDown
            // 
            this.arrivalTimeUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimeUpDown.Location = new System.Drawing.Point(15, 133);
            this.arrivalTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arrivalTimeUpDown.Name = "arrivalTimeUpDown";
            this.arrivalTimeUpDown.Size = new System.Drawing.Size(97, 29);
            this.arrivalTimeUpDown.TabIndex = 9;
            this.arrivalTimeUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // fulfilmentTimeUpDown
            // 
            this.fulfilmentTimeUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fulfilmentTimeUpDown.Location = new System.Drawing.Point(15, 208);
            this.fulfilmentTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fulfilmentTimeUpDown.Name = "fulfilmentTimeUpDown";
            this.fulfilmentTimeUpDown.Size = new System.Drawing.Size(97, 29);
            this.fulfilmentTimeUpDown.TabIndex = 10;
            this.fulfilmentTimeUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Lab_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 478);
            this.Controls.Add(this.fulfilmentTimeUpDown);
            this.Controls.Add(this.arrivalTimeUpDown);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kitchenGroupBox);
            this.Controls.Add(this.ordersGrupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.fulfilmentTimeTextBox);
            this.Controls.Add(this.orderTimeIntervalLabel);
            this.Controls.Add(this.arrivalTimeTextBox);
            this.Controls.Add(this.arrivalTimeLabel);
            this.Name = "Lab_1";
            this.Text = "Lab_1";
            this.ordersGrupBox.ResumeLayout(false);
            this.ordersGrupBox.PerformLayout();
            this.kitchenGroupBox.ResumeLayout(false);
            this.kitchenGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulfilmentTimeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label arrivalTimeLabel;
        private TextBox arrivalTimeTextBox;
        private Label orderTimeIntervalLabel;
        private TextBox fulfilmentTimeTextBox;
        private Button startButton;
        private GroupBox ordersGrupBox;
        private TextBox orderLineTextBox;
        private TextBox currentOrderNumberTextBox;
        private Label label2;
        private Label label1;
        private GroupBox kitchenGroupBox;
        private Label label4;
        private DataGridView orderNumberGridView;
        private DataGridViewTextBoxColumn Column1;
        private TextBox preparingOrderTextBox;
        private Label label3;
        private TextBox oredersAmountTextBox;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox orderAvailableForPickupTextBox;
        private TextBox waitingCustomersNumberTextBox;
        private Label label6;
        private Button stopButton;
        private NumericUpDown arrivalTimeUpDown;
        private NumericUpDown fulfilmentTimeUpDown;
    }
}