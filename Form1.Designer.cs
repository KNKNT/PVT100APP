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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 258);
            this.panel1.TabIndex = 1;
            // 
            // TemperatureLb
            // 
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
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectButton.Location = new System.Drawing.Point(12, 285);
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
            this.panel2.Location = new System.Drawing.Point(540, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 257);
            this.panel2.TabIndex = 2;
            // 
            // WetLb
            // 
            this.WetLb.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WetLb.Location = new System.Drawing.Point(5, 152);
            this.WetLb.Name = "WetLb";
            this.WetLb.Size = new System.Drawing.Size(244, 104);
            this.WetLb.TabIndex = 3;
            this.WetLb.Text = "0 °С";
            this.WetLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 104);
            this.label2.TabIndex = 0;
            this.label2.Text = "Измеренное значение влажности:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.DewPointLb);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(276, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 257);
            this.panel3.TabIndex = 3;
            // 
            // DewPointLb
            // 
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
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 104);
            this.label3.TabIndex = 0;
            this.label3.Text = "Расчетное значение точки росы:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 373);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(820, 420);
            this.MinimumSize = new System.Drawing.Size(820, 420);
            this.Name = "Form1";
            this.Text = "Показания ПВТ100";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

