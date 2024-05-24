namespace TheBestShop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.buttonDel1 = new System.Windows.Forms.Button();
            this.buttonChange1 = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.TabPage();
            this.buttonDel2 = new System.Windows.Forms.Button();
            this.buttonChange2 = new System.Windows.Forms.Button();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Invoices1 = new System.Windows.Forms.TabPage();
            this.buttonDel3 = new System.Windows.Forms.Button();
            this.buttonChange3 = new System.Windows.Forms.Button();
            this.buttonAdd3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Report = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.buttonReport1 = new System.Windows.Forms.Button();
            this.Invoices = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Invoices1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Controls.Add(this.Invoices1);
            this.tabControl1.Controls.Add(this.Report);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.Honeydew;
            this.Customers.Controls.Add(this.buttonDel1);
            this.Customers.Controls.Add(this.buttonChange1);
            this.Customers.Controls.Add(this.buttonAdd1);
            this.Customers.Controls.Add(this.dataGridView1);
            this.Customers.Location = new System.Drawing.Point(4, 34);
            this.Customers.Margin = new System.Windows.Forms.Padding(4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(4);
            this.Customers.Size = new System.Drawing.Size(959, 478);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Покупатели";
            // 
            // buttonDel1
            // 
            this.buttonDel1.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel1.Location = new System.Drawing.Point(448, 414);
            this.buttonDel1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel1.Name = "buttonDel1";
            this.buttonDel1.Size = new System.Drawing.Size(212, 52);
            this.buttonDel1.TabIndex = 3;
            this.buttonDel1.Text = "УДАЛИТЬ";
            this.buttonDel1.UseVisualStyleBackColor = false;
            this.buttonDel1.Click += new System.EventHandler(this.buttonDel1_Click);
            // 
            // buttonChange1
            // 
            this.buttonChange1.BackColor = System.Drawing.Color.Transparent;
            this.buttonChange1.Location = new System.Drawing.Point(228, 414);
            this.buttonChange1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChange1.Name = "buttonChange1";
            this.buttonChange1.Size = new System.Drawing.Size(212, 52);
            this.buttonChange1.TabIndex = 2;
            this.buttonChange1.Text = "ИЗМЕНИТЬ";
            this.buttonChange1.UseVisualStyleBackColor = false;
            this.buttonChange1.Click += new System.EventHandler(this.buttonChange1_Click);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd1.Location = new System.Drawing.Point(8, 414);
            this.buttonAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(212, 52);
            this.buttonAdd1.TabIndex = 1;
            this.buttonAdd1.Text = "ДОБАВИТЬ";
            this.buttonAdd1.UseVisualStyleBackColor = false;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(940, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Honeydew;
            this.Products.Controls.Add(this.buttonDel2);
            this.Products.Controls.Add(this.buttonChange2);
            this.Products.Controls.Add(this.buttonAdd2);
            this.Products.Controls.Add(this.dataGridView2);
            this.Products.Location = new System.Drawing.Point(4, 34);
            this.Products.Margin = new System.Windows.Forms.Padding(4);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(4);
            this.Products.Size = new System.Drawing.Size(959, 478);
            this.Products.TabIndex = 1;
            this.Products.Text = "Товары";
            // 
            // buttonDel2
            // 
            this.buttonDel2.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel2.Location = new System.Drawing.Point(448, 414);
            this.buttonDel2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel2.Name = "buttonDel2";
            this.buttonDel2.Size = new System.Drawing.Size(212, 52);
            this.buttonDel2.TabIndex = 7;
            this.buttonDel2.Text = "УДАЛИТЬ";
            this.buttonDel2.UseVisualStyleBackColor = false;
            this.buttonDel2.Click += new System.EventHandler(this.buttonDel2_Click);
            // 
            // buttonChange2
            // 
            this.buttonChange2.BackColor = System.Drawing.Color.Transparent;
            this.buttonChange2.Location = new System.Drawing.Point(228, 414);
            this.buttonChange2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChange2.Name = "buttonChange2";
            this.buttonChange2.Size = new System.Drawing.Size(212, 52);
            this.buttonChange2.TabIndex = 6;
            this.buttonChange2.Text = "ИЗМЕНИТЬ";
            this.buttonChange2.UseVisualStyleBackColor = false;
            this.buttonChange2.Click += new System.EventHandler(this.buttonСhange2_Click);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd2.Location = new System.Drawing.Point(8, 414);
            this.buttonAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(212, 52);
            this.buttonAdd2.TabIndex = 5;
            this.buttonAdd2.Text = "ДОБАВИТЬ";
            this.buttonAdd2.UseVisualStyleBackColor = false;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 7);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(940, 399);
            this.dataGridView2.TabIndex = 4;
            // 
            // Invoices1
            // 
            this.Invoices1.BackColor = System.Drawing.Color.Honeydew;
            this.Invoices1.Controls.Add(this.buttonDel3);
            this.Invoices1.Controls.Add(this.buttonChange3);
            this.Invoices1.Controls.Add(this.buttonAdd3);
            this.Invoices1.Controls.Add(this.dataGridView3);
            this.Invoices1.Location = new System.Drawing.Point(4, 34);
            this.Invoices1.Margin = new System.Windows.Forms.Padding(4);
            this.Invoices1.Name = "Invoices1";
            this.Invoices1.Size = new System.Drawing.Size(959, 478);
            this.Invoices1.TabIndex = 2;
            this.Invoices1.Text = "Заказы";
            // 
            // buttonDel3
            // 
            this.buttonDel3.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel3.Location = new System.Drawing.Point(448, 414);
            this.buttonDel3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel3.Name = "buttonDel3";
            this.buttonDel3.Size = new System.Drawing.Size(212, 52);
            this.buttonDel3.TabIndex = 11;
            this.buttonDel3.Text = "УДАЛИТЬ";
            this.buttonDel3.UseVisualStyleBackColor = false;
            this.buttonDel3.Click += new System.EventHandler(this.buttonDel3_Click);
            // 
            // buttonChange3
            // 
            this.buttonChange3.BackColor = System.Drawing.Color.Transparent;
            this.buttonChange3.Location = new System.Drawing.Point(228, 414);
            this.buttonChange3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChange3.Name = "buttonChange3";
            this.buttonChange3.Size = new System.Drawing.Size(212, 52);
            this.buttonChange3.TabIndex = 10;
            this.buttonChange3.Text = "ИЗМЕНИТЬ";
            this.buttonChange3.UseVisualStyleBackColor = false;
            this.buttonChange3.Click += new System.EventHandler(this.buttonChange3_Click);
            // 
            // buttonAdd3
            // 
            this.buttonAdd3.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd3.Location = new System.Drawing.Point(8, 414);
            this.buttonAdd3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd3.Name = "buttonAdd3";
            this.buttonAdd3.Size = new System.Drawing.Size(212, 52);
            this.buttonAdd3.TabIndex = 9;
            this.buttonAdd3.Text = "ДОБАВИТЬ";
            this.buttonAdd3.UseVisualStyleBackColor = false;
            this.buttonAdd3.Click += new System.EventHandler(this.buttonAdd3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(944, 402);
            this.dataGridView3.TabIndex = 8;
            // 
            // Report
            // 
            this.Report.Controls.Add(this.chart2);
            this.Report.Controls.Add(this.chart1);
            this.Report.Controls.Add(this.label2);
            this.Report.Controls.Add(this.label4);
            this.Report.Controls.Add(this.label3);
            this.Report.Controls.Add(this.buttonReport2);
            this.Report.Controls.Add(this.buttonReport1);
            this.Report.Location = new System.Drawing.Point(4, 34);
            this.Report.Margin = new System.Windows.Forms.Padding(4);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(959, 478);
            this.Report.TabIndex = 3;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(507, 86);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(387, 342);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "chart2";
            title1.Name = "Соотношение";
            title1.Text = "Соотношение ";
            this.chart2.Titles.Add(title1);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(45, 129);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(329, 299);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Заказы";
            this.chart1.Titles.Add(title2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(503, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Соотношение сумм доставок ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = " но не доставленных товаров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cписок заказанных,";
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(770, 20);
            this.buttonReport2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(133, 44);
            this.buttonReport2.TabIndex = 13;
            this.buttonReport2.Text = "Сформировать отчёт";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // buttonReport1
            // 
            this.buttonReport1.Location = new System.Drawing.Point(45, 73);
            this.buttonReport1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReport1.Name = "buttonReport1";
            this.buttonReport1.Size = new System.Drawing.Size(133, 44);
            this.buttonReport1.TabIndex = 7;
            this.buttonReport1.Text = "Сформировать отчёт";
            this.buttonReport1.UseVisualStyleBackColor = true;
            this.buttonReport1.Click += new System.EventHandler(this.buttonReport1_Click);
            // 
            // Invoices
            // 
            this.Invoices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Invoices.Location = new System.Drawing.Point(4, 29);
            this.Invoices.Name = "Invoices";
            this.Invoices.Size = new System.Drawing.Size(717, 386);
            this.Invoices.TabIndex = 2;
            this.Invoices.Text = "Счета-фактуры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 545);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Склад";
            this.tabControl1.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Invoices1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.Button buttonDel1;
        private System.Windows.Forms.Button buttonChange1;
        private System.Windows.Forms.Button buttonDel2;
        private System.Windows.Forms.Button buttonChange2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage Invoices1;
        private System.Windows.Forms.TabPage Invoices;
        private System.Windows.Forms.Button buttonDel3;
        private System.Windows.Forms.Button buttonChange3;
        private System.Windows.Forms.Button buttonAdd3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage Report;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonReport1;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

