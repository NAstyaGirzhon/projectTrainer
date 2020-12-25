namespace WindowsFormsApp1
{
    partial class WindowDoctor
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.VeloCheck = new System.Windows.Forms.CheckBox();
            this.PowerCheck = new System.Windows.Forms.CheckBox();
            this.RunCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pressureCheck = new System.Windows.Forms.CheckBox();
            this.temperatureCheck = new System.Windows.Forms.CheckBox();
            this.pulseCheck = new System.Windows.Forms.CheckBox();
            this.GotoWindowDG = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.skinTemperatureSensor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wetCheck = new System.Windows.Forms.CheckBox();
            this.electroCheck = new System.Windows.Forms.CheckBox();
            this.BloodPressureSensor = new System.Windows.Forms.Label();
            this.heartRateSensor = new System.Windows.Forms.Label();
            this.electricalCoductivitySensor = new System.Windows.Forms.Label();
            this.skinmoistureSensor = new System.Windows.Forms.Label();
            this.RevitalizButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация обследования";
            // 
            // VeloCheck
            // 
            this.VeloCheck.AutoSize = true;
            this.VeloCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VeloCheck.Location = new System.Drawing.Point(55, 115);
            this.VeloCheck.Name = "VeloCheck";
            this.VeloCheck.Size = new System.Drawing.Size(63, 21);
            this.VeloCheck.TabIndex = 3;
            this.VeloCheck.Text = "Вело";
            this.VeloCheck.UseVisualStyleBackColor = true;
            // 
            // PowerCheck
            // 
            this.PowerCheck.AutoSize = true;
            this.PowerCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerCheck.Location = new System.Drawing.Point(55, 142);
            this.PowerCheck.Name = "PowerCheck";
            this.PowerCheck.Size = new System.Drawing.Size(150, 21);
            this.PowerCheck.TabIndex = 4;
            this.PowerCheck.Text = "Силовые нагрузки";
            this.PowerCheck.UseVisualStyleBackColor = true;
            // 
            // RunCheck
            // 
            this.RunCheck.AutoSize = true;
            this.RunCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunCheck.Location = new System.Drawing.Point(55, 169);
            this.RunCheck.Name = "RunCheck";
            this.RunCheck.Size = new System.Drawing.Size(52, 21);
            this.RunCheck.TabIndex = 5;
            this.RunCheck.Text = "Бег";
            this.RunCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "тип физической нагрузки ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Датчики";
            // 
            // pressureCheck
            // 
            this.pressureCheck.AutoSize = true;
            this.pressureCheck.Location = new System.Drawing.Point(261, 115);
            this.pressureCheck.Name = "pressureCheck";
            this.pressureCheck.Size = new System.Drawing.Size(108, 21);
            this.pressureCheck.TabIndex = 8;
            this.pressureCheck.Text = "1.Давление";
            this.pressureCheck.UseVisualStyleBackColor = true;
            // 
            // temperatureCheck
            // 
            this.temperatureCheck.AutoSize = true;
            this.temperatureCheck.Location = new System.Drawing.Point(261, 142);
            this.temperatureCheck.Name = "temperatureCheck";
            this.temperatureCheck.Size = new System.Drawing.Size(130, 21);
            this.temperatureCheck.TabIndex = 9;
            this.temperatureCheck.Text = "2.Температура";
            this.temperatureCheck.UseVisualStyleBackColor = true;
            // 
            // pulseCheck
            // 
            this.pulseCheck.AutoSize = true;
            this.pulseCheck.Location = new System.Drawing.Point(261, 169);
            this.pulseCheck.Name = "pulseCheck";
            this.pulseCheck.Size = new System.Drawing.Size(81, 21);
            this.pulseCheck.TabIndex = 10;
            this.pulseCheck.Text = "3.Пульс";
            this.pulseCheck.UseVisualStyleBackColor = true;
            // 
            // GotoWindowDG
            // 
            this.GotoWindowDG.Location = new System.Drawing.Point(55, 310);
            this.GotoWindowDG.Name = "GotoWindowDG";
            this.GotoWindowDG.Size = new System.Drawing.Size(75, 23);
            this.GotoWindowDG.TabIndex = 12;
            this.GotoWindowDG.Text = "Начать";
            this.GotoWindowDG.UseVisualStyleBackColor = true;
            this.GotoWindowDG.Click += new System.EventHandler(this.GotoWindowDG_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Активизация датчиков ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(55, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Старт сеанса обследования";
            // 
            // skinTemperatureSensor
            // 
            this.skinTemperatureSensor.AutoSize = true;
            this.skinTemperatureSensor.BackColor = System.Drawing.Color.White;
            this.skinTemperatureSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skinTemperatureSensor.ForeColor = System.Drawing.Color.Black;
            this.skinTemperatureSensor.Location = new System.Drawing.Point(569, 274);
            this.skinTemperatureSensor.Name = "skinTemperatureSensor";
            this.skinTemperatureSensor.Size = new System.Drawing.Size(29, 31);
            this.skinTemperatureSensor.TabIndex = 16;
            this.skinTemperatureSensor.Text = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.patientimage1;
            this.pictureBox1.Location = new System.Drawing.Point(445, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // wetCheck
            // 
            this.wetCheck.AutoSize = true;
            this.wetCheck.Location = new System.Drawing.Point(261, 197);
            this.wetCheck.Name = "wetCheck";
            this.wetCheck.Size = new System.Drawing.Size(113, 21);
            this.wetCheck.TabIndex = 17;
            this.wetCheck.Text = "4.Влажность";
            this.wetCheck.UseVisualStyleBackColor = true;
            // 
            // electroCheck
            // 
            this.electroCheck.AutoSize = true;
            this.electroCheck.Location = new System.Drawing.Point(261, 224);
            this.electroCheck.Name = "electroCheck";
            this.electroCheck.Size = new System.Drawing.Size(190, 21);
            this.electroCheck.TabIndex = 18;
            this.electroCheck.Text = "5.Электр. проводимость";
            this.electroCheck.UseVisualStyleBackColor = true;
            // 
            // BloodPressureSensor
            // 
            this.BloodPressureSensor.AutoSize = true;
            this.BloodPressureSensor.BackColor = System.Drawing.SystemColors.Window;
            this.BloodPressureSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BloodPressureSensor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BloodPressureSensor.Location = new System.Drawing.Point(648, 244);
            this.BloodPressureSensor.Name = "BloodPressureSensor";
            this.BloodPressureSensor.Size = new System.Drawing.Size(29, 31);
            this.BloodPressureSensor.TabIndex = 19;
            this.BloodPressureSensor.Text = "1";
            // 
            // heartRateSensor
            // 
            this.heartRateSensor.AutoSize = true;
            this.heartRateSensor.BackColor = System.Drawing.SystemColors.Window;
            this.heartRateSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heartRateSensor.Location = new System.Drawing.Point(465, 325);
            this.heartRateSensor.Name = "heartRateSensor";
            this.heartRateSensor.Size = new System.Drawing.Size(29, 31);
            this.heartRateSensor.TabIndex = 20;
            this.heartRateSensor.Text = "3";
            // 
            // electricalCoductivitySensor
            // 
            this.electricalCoductivitySensor.AutoSize = true;
            this.electricalCoductivitySensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.electricalCoductivitySensor.Location = new System.Drawing.Point(605, 349);
            this.electricalCoductivitySensor.Name = "electricalCoductivitySensor";
            this.electricalCoductivitySensor.Size = new System.Drawing.Size(29, 31);
            this.electricalCoductivitySensor.TabIndex = 21;
            this.electricalCoductivitySensor.Text = "5";
            // 
            // skinmoistureSensor
            // 
            this.skinmoistureSensor.AutoSize = true;
            this.skinmoistureSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skinmoistureSensor.Location = new System.Drawing.Point(668, 169);
            this.skinmoistureSensor.Name = "skinmoistureSensor";
            this.skinmoistureSensor.Size = new System.Drawing.Size(29, 31);
            this.skinmoistureSensor.TabIndex = 22;
            this.skinmoistureSensor.Text = "4";
            // 
            // RevitalizButton
            // 
            this.RevitalizButton.Location = new System.Drawing.Point(58, 251);
            this.RevitalizButton.Name = "RevitalizButton";
            this.RevitalizButton.Size = new System.Drawing.Size(114, 23);
            this.RevitalizButton.TabIndex = 23;
            this.RevitalizButton.Text = "Активизация";
            this.RevitalizButton.UseVisualStyleBackColor = true;
            this.RevitalizButton.Click += new System.EventHandler(this.RevitalizButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 357);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 153);
            this.textBox1.TabIndex = 24;
            // 
            // WindowDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(888, 565);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RevitalizButton);
            this.Controls.Add(this.skinmoistureSensor);
            this.Controls.Add(this.electricalCoductivitySensor);
            this.Controls.Add(this.heartRateSensor);
            this.Controls.Add(this.BloodPressureSensor);
            this.Controls.Add(this.electroCheck);
            this.Controls.Add(this.wetCheck);
            this.Controls.Add(this.skinTemperatureSensor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GotoWindowDG);
            this.Controls.Add(this.pulseCheck);
            this.Controls.Add(this.temperatureCheck);
            this.Controls.Add(this.pressureCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunCheck);
            this.Controls.Add(this.PowerCheck);
            this.Controls.Add(this.VeloCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "WindowDoctor";
            this.Text = "WindowDoctor";
            this.Load += new System.EventHandler(this.WindowDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox VeloCheck;
        private System.Windows.Forms.CheckBox PowerCheck;
        private System.Windows.Forms.CheckBox RunCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox pressureCheck;
        private System.Windows.Forms.CheckBox temperatureCheck;
        private System.Windows.Forms.CheckBox pulseCheck;

        private System.Windows.Forms.Button GotoWindowDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label skinTemperatureSensor;
        private System.Windows.Forms.CheckBox wetCheck;
        private System.Windows.Forms.CheckBox electroCheck;
        private System.Windows.Forms.Label BloodPressureSensor;
        private System.Windows.Forms.Label heartRateSensor;
        private System.Windows.Forms.Label electricalCoductivitySensor;
        private System.Windows.Forms.Label skinmoistureSensor;
        private System.Windows.Forms.Button RevitalizButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}