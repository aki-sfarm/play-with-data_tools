namespace MockSalesDataGenerator
{
    partial class Form1
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
            button_GenerateData = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_accessRate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox_purchaseFactor = new TextBox();
            label8 = new Label();
            textBox_cancellationRate = new TextBox();
            label9 = new Label();
            checkBox1 = new CheckBox();
            dateTimePicker3 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker4 = new DateTimePicker();
            textBox_DiscountRate = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label14 = new Label();
            textBox_AccelerationRate = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            textBox_NumOfUsers = new TextBox();
            textBox_FolderPath = new TextBox();
            label16 = new Label();
            button_Browse = new Button();
            DataGridViewProducts = new DataGridView();
            label17 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // button_GenerateData
            // 
            button_GenerateData.Cursor = Cursors.No;
            button_GenerateData.Location = new Point(424, 714);
            button_GenerateData.Name = "button_GenerateData";
            button_GenerateData.Size = new Size(154, 66);
            button_GenerateData.TabIndex = 0;
            button_GenerateData.Text = "データ生成";
            button_GenerateData.UseVisualStyleBackColor = true;
            button_GenerateData.Click += button_GenerateData_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(69, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(366, 75);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "データ生成範囲";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "開始日";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 52);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "終了日";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 583);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "アクセス率";
            // 
            // textBox_accessRate
            // 
            textBox_accessRate.Location = new Point(76, 601);
            textBox_accessRate.Name = "textBox_accessRate";
            textBox_accessRate.Size = new Size(63, 23);
            textBox_accessRate.TabIndex = 7;
            textBox_accessRate.Text = "15";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 604);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 8;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 583);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 9;
            label6.Text = "購入率係数";
            // 
            // textBox_purchaseFactor
            // 
            textBox_purchaseFactor.Location = new Point(251, 601);
            textBox_purchaseFactor.Name = "textBox_purchaseFactor";
            textBox_purchaseFactor.Size = new Size(76, 23);
            textBox_purchaseFactor.TabIndex = 10;
            textBox_purchaseFactor.Text = "10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 583);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 12;
            label8.Text = "キャンセル率";
            // 
            // textBox_cancellationRate
            // 
            textBox_cancellationRate.Location = new Point(433, 601);
            textBox_cancellationRate.Name = "textBox_cancellationRate";
            textBox_cancellationRate.Size = new Size(76, 23);
            textBox_cancellationRate.TabIndex = 13;
            textBox_cancellationRate.Text = "10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(515, 604);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 14;
            label9.Text = "%";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(4, 11);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "キャンペーン";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(42, 61);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 43);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 18;
            label10.Text = "開始日";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(339, 43);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 19;
            label11.Text = "終了日";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(339, 61);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 20;
            // 
            // textBox_DiscountRate
            // 
            textBox_DiscountRate.Location = new Point(65, 127);
            textBox_DiscountRate.Name = "textBox_DiscountRate";
            textBox_DiscountRate.Size = new Size(63, 23);
            textBox_DiscountRate.TabIndex = 21;
            textBox_DiscountRate.Text = "20";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 109);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 22;
            label12.Text = "割引";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(134, 130);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 23;
            label13.Text = "%";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(322, 130);
            label15.Name = "label15";
            label15.Size = new Size(17, 15);
            label15.TabIndex = 23;
            label15.Text = "%";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(240, 109);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 24;
            label14.Text = "アクセラレート";
            // 
            // textBox_AccelerationRate
            // 
            textBox_AccelerationRate.Location = new Point(253, 127);
            textBox_AccelerationRate.Name = "textBox_AccelerationRate";
            textBox_AccelerationRate.Size = new Size(63, 23);
            textBox_AccelerationRate.TabIndex = 25;
            textBox_AccelerationRate.Text = "100";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox_AccelerationRate);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox_DiscountRate);
            panel1.Controls.Add(dateTimePicker4);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(27, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 174);
            panel1.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 507);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 27;
            label7.Text = "ユーザー数";
            // 
            // textBox_NumOfUsers
            // 
            textBox_NumOfUsers.Location = new Point(76, 525);
            textBox_NumOfUsers.Name = "textBox_NumOfUsers";
            textBox_NumOfUsers.Size = new Size(86, 23);
            textBox_NumOfUsers.TabIndex = 28;
            textBox_NumOfUsers.Text = "300";
            // 
            // textBox_FolderPath
            // 
            textBox_FolderPath.Location = new Point(38, 665);
            textBox_FolderPath.Name = "textBox_FolderPath";
            textBox_FolderPath.Size = new Size(483, 23);
            textBox_FolderPath.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Enabled = false;
            label16.Location = new Point(37, 647);
            label16.Name = "label16";
            label16.Size = new Size(113, 15);
            label16.TabIndex = 30;
            label16.Text = "CSV出力先ディレクトリ";
            // 
            // button_Browse
            // 
            button_Browse.Location = new Point(527, 665);
            button_Browse.Name = "button_Browse";
            button_Browse.Size = new Size(75, 23);
            button_Browse.TabIndex = 31;
            button_Browse.Text = "参照";
            button_Browse.UseVisualStyleBackColor = true;
            button_Browse.Click += button_Browse_Click;
            // 
            // DataGridViewProducts
            // 
            DataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProducts.Location = new Point(27, 333);
            DataGridViewProducts.Name = "DataGridViewProducts";
            DataGridViewProducts.RowTemplate.Height = 25;
            DataGridViewProducts.Size = new Size(589, 150);
            DataGridViewProducts.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(31, 315);
            label17.Name = "label17";
            label17.Size = new Size(56, 15);
            label17.TabIndex = 33;
            label17.Text = "製品リスト";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 792);
            Controls.Add(label17);
            Controls.Add(DataGridViewProducts);
            Controls.Add(button_Browse);
            Controls.Add(label16);
            Controls.Add(textBox_FolderPath);
            Controls.Add(textBox_NumOfUsers);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(textBox_cancellationRate);
            Controls.Add(label8);
            Controls.Add(textBox_purchaseFactor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_accessRate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button_GenerateData);
            Name = "Form1";
            Text = "MockSalesDataGenerator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_GenerateData;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_accessRate;
        private Label label5;
        private Label label6;
        private TextBox textBox_purchaseFactor;
        private Label label8;
        private TextBox textBox_cancellationRate;
        private Label label9;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker3;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker4;
        private TextBox textBox_DiscountRate;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label14;
        private TextBox textBox_AccelerationRate;
        private Panel panel1;
        private Label label7;
        private TextBox textBox_NumOfUsers;
        private TextBox textBox_FolderPath;
        private Label label16;
        private Button button_Browse;
        private DataGridView DataGridViewProducts;
        private Label label17;
    }
}