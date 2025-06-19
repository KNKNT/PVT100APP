namespace PVT100APP
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TemperatureLb = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WetLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DewPointLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CheckConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.WetCheck = new System.Windows.Forms.CheckBox();
            this.DotCheck = new System.Windows.Forms.CheckBox();
            this.TemperatureCheck = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ChartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Измеренное значение температуры:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.TemperatureLb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 258);
            this.panel1.TabIndex = 1;
            // 
            // TemperatureLb
            // 
            this.TemperatureLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemperatureLb.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureLb.Location = new System.Drawing.Point(3, 153);
            this.TemperatureLb.Name = "TemperatureLb";
            this.TemperatureLb.Size = new System.Drawing.Size(244, 104);
            this.TemperatureLb.TabIndex = 1;
            this.TemperatureLb.Text = "0 °С";
            this.TemperatureLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectButton.Location = new System.Drawing.Point(12, 317);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(250, 61);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Подключиться к прибору";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.WetLb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(524, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 258);
            this.panel2.TabIndex = 2;
            // 
            // WetLb
            // 
            this.WetLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WetLb.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WetLb.Location = new System.Drawing.Point(5, 152);
            this.WetLb.Name = "WetLb";
            this.WetLb.Size = new System.Drawing.Size(244, 105);
            this.WetLb.TabIndex = 3;
            this.WetLb.Text = "0 °С";
            this.WetLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 105);
            this.label2.TabIndex = 0;
            this.label2.Text = "Измеренное значение влажности:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.DewPointLb);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(268, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 257);
            this.panel3.TabIndex = 3;
            // 
            // DewPointLb
            // 
            this.DewPointLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DewPointLb.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DewPointLb.Location = new System.Drawing.Point(3, 152);
            this.DewPointLb.Name = "DewPointLb";
            this.DewPointLb.Size = new System.Drawing.Size(244, 104);
            this.DewPointLb.TabIndex = 2;
            this.DewPointLb.Text = "0 %RH";
            this.DewPointLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 104);
            this.label3.TabIndex = 0;
            this.label3.Text = "Расчетное значение точки росы:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connect,
            this.Disconnect,
            this.toolStripMenuItem1,
            this.CheckConnection,
            this.toolStripMenuItem2,
            this.Settings,
            this.Close});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.настройкиToolStripMenuItem.Text = "Соединение";
            // 
            // Connect
            // 
            this.Connect.Name = "Connect";
            this.Connect.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.Connect.Size = new System.Drawing.Size(257, 26);
            this.Connect.Text = "Подключиться";
            this.Connect.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.Disconnect.Size = new System.Drawing.Size(257, 26);
            this.Disconnect.Text = "Отключиться";
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // CheckConnection
            // 
            this.CheckConnection.Name = "CheckConnection";
            this.CheckConnection.Size = new System.Drawing.Size(257, 26);
            this.CheckConnection.Text = "Проверить соединение";
            this.CheckConnection.Click += new System.EventHandler(this.CheckConnection_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(254, 6);
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(257, 26);
            this.Settings.Text = "Параметры";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(257, 26);
            this.Close.Text = "Выход";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataStyle});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // DataStyle
            // 
            this.DataStyle.Checked = true;
            this.DataStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DataStyle.Name = "DataStyle";
            this.DataStyle.Size = new System.Drawing.Size(224, 26);
            this.DataStyle.Text = "Подписи данных";
            this.DataStyle.Click += new System.EventHandler(this.DataStyle_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // DemoButton
            // 
            this.DemoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DemoButton.Location = new System.Drawing.Point(12, 384);
            this.DemoButton.Name = "DemoButton";
            this.DemoButton.Size = new System.Drawing.Size(250, 61);
            this.DemoButton.TabIndex = 5;
            this.DemoButton.Text = "Демо";
            this.DemoButton.UseVisualStyleBackColor = true;
            this.DemoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.BorderColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(276, 302);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(514, 371);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.WetCheck);
            this.ChartPanel.Controls.Add(this.DotCheck);
            this.ChartPanel.Controls.Add(this.TemperatureCheck);
            this.ChartPanel.Controls.Add(this.panel7);
            this.ChartPanel.Controls.Add(this.panel6);
            this.ChartPanel.Controls.Add(this.panel5);
            this.ChartPanel.Controls.Add(this.label4);
            this.ChartPanel.Location = new System.Drawing.Point(12, 462);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(249, 210);
            this.ChartPanel.TabIndex = 7;
            this.ChartPanel.Visible = false;
            // 
            // WetCheck
            // 
            this.WetCheck.AutoSize = true;
            this.WetCheck.Checked = true;
            this.WetCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WetCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WetCheck.Location = new System.Drawing.Point(8, 99);
            this.WetCheck.Name = "WetCheck";
            this.WetCheck.Size = new System.Drawing.Size(98, 21);
            this.WetCheck.TabIndex = 12;
            this.WetCheck.Text = "Влажность";
            this.WetCheck.UseVisualStyleBackColor = true;
            this.WetCheck.CheckedChanged += new System.EventHandler(this.WetCheck_CheckedChanged);
            // 
            // DotCheck
            // 
            this.DotCheck.AutoSize = true;
            this.DotCheck.Checked = true;
            this.DotCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DotCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotCheck.Location = new System.Drawing.Point(8, 73);
            this.DotCheck.Name = "DotCheck";
            this.DotCheck.Size = new System.Drawing.Size(105, 21);
            this.DotCheck.TabIndex = 11;
            this.DotCheck.Text = "Точка росы";
            this.DotCheck.UseVisualStyleBackColor = true;
            this.DotCheck.CheckedChanged += new System.EventHandler(this.DotCheck_CheckedChanged);
            // 
            // TemperatureCheck
            // 
            this.TemperatureCheck.AutoSize = true;
            this.TemperatureCheck.Checked = true;
            this.TemperatureCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TemperatureCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureCheck.Location = new System.Drawing.Point(8, 47);
            this.TemperatureCheck.Name = "TemperatureCheck";
            this.TemperatureCheck.Size = new System.Drawing.Size(117, 21);
            this.TemperatureCheck.TabIndex = 8;
            this.TemperatureCheck.Text = "Температура";
            this.TemperatureCheck.UseVisualStyleBackColor = true;
            this.TemperatureCheck.CheckedChanged += new System.EventHandler(this.TemperatureCheck_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel7.Location = new System.Drawing.Point(150, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 20);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel6.Location = new System.Drawing.Point(150, 73);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 20);
            this.panel6.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(150, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(38, 20);
            this.panel5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Параметры графика";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.DemoButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Показания ПВТ100";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ChartPanel.ResumeLayout(false);
            this.ChartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TemperatureLb;
        private System.Windows.Forms.Label WetLb;
        private System.Windows.Forms.Label DewPointLb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Connect;
        private System.Windows.Forms.ToolStripMenuItem Disconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CheckConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataStyle;
        private System.Windows.Forms.Button DemoButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox WetCheck;
        private System.Windows.Forms.CheckBox DotCheck;
        private System.Windows.Forms.CheckBox TemperatureCheck;
    }
}

