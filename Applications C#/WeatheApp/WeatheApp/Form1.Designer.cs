﻿namespace WeatheApp
{
    partial class Form1
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
            this.diaplayWeatherData = new System.Windows.Forms.RichTextBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.inputCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxWind = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.mainGroupBox.SuspendLayout();
            this.groupBoxWind.SuspendLayout();
            this.SuspendLayout();
            // 
            // diaplayWeatherData
            // 
            this.diaplayWeatherData.Location = new System.Drawing.Point(12, 12);
            this.diaplayWeatherData.Name = "diaplayWeatherData";
            this.diaplayWeatherData.Size = new System.Drawing.Size(403, 48);
            this.diaplayWeatherData.TabIndex = 0;
            this.diaplayWeatherData.Text = "";
            this.diaplayWeatherData.TextChanged += new System.EventHandler(this.diaplayWeatherData_TextChanged);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.label8);
            this.mainGroupBox.Controls.Add(this.inputCity);
            this.mainGroupBox.Controls.Add(this.button1);
            this.mainGroupBox.Controls.Add(this.groupBoxWind);
            this.mainGroupBox.Controls.Add(this.label5);
            this.mainGroupBox.Controls.Add(this.label4);
            this.mainGroupBox.Controls.Add(this.label3);
            this.mainGroupBox.Controls.Add(this.label2);
            this.mainGroupBox.Controls.Add(this.label1);
            this.mainGroupBox.Controls.Add(this.panel1);
            this.mainGroupBox.Location = new System.Drawing.Point(13, 108);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(402, 263);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Погода";
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(277, 158);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(100, 20);
            this.inputCity.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxWind
            // 
            this.groupBoxWind.Controls.Add(this.label7);
            this.groupBoxWind.Controls.Add(this.label6);
            this.groupBoxWind.Location = new System.Drawing.Point(7, 142);
            this.groupBoxWind.Name = "groupBoxWind";
            this.groupBoxWind.Size = new System.Drawing.Size(146, 121);
            this.groupBoxWind.TabIndex = 6;
            this.groupBoxWind.TabStop = false;
            this.groupBoxWind.Text = "Ветер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ветер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Скорость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Давление";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Влажность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Средняя температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главное";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 103);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Введите город";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(180, 92);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(46, 13);
            this.city.TabIndex = 2;
            this.city.Text = "Ivanovo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 383);
            this.Controls.Add(this.city);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.diaplayWeatherData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.groupBoxWind.ResumeLayout(false);
            this.groupBoxWind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox diaplayWeatherData;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox groupBoxWind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label city;
    }
}

