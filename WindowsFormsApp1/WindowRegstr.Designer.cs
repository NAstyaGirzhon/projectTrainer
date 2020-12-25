namespace WindowsFormsApp1
{
    partial class WindowRegstr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGgge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ViewReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация пациентов";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблица данных о пациенте";
            // 
            // namesTextBox
            // 
            this.namesTextBox.Location = new System.Drawing.Point(62, 81);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(100, 22);
            this.namesTextBox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(62, 141);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ФИО";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(63, 121);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(62, 17);
            this.age.TabIndex = 6;
            this.age.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пол";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(62, 207);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 22);
            this.genderTextBox.TabIndex = 8;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(59, 274);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(144, 29);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Зарегистрировать";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.AGgge,
            this.Gend});
            this.dataGridView1.Location = new System.Drawing.Point(285, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "Имя";
            this.FIO.Name = "FIO";
            // 
            // AGgge
            // 
            this.AGgge.HeaderText = "Возраст";
            this.AGgge.Name = "AGgge";
            // 
            // Gend
            // 
            this.Gend.HeaderText = "Пол";
            this.Gend.Name = "Gend";
            // 
            // ViewReportButton
            // 
            this.ViewReportButton.Location = new System.Drawing.Point(59, 334);
            this.ViewReportButton.Name = "ViewReportButton";
            this.ViewReportButton.Size = new System.Drawing.Size(103, 30);
            this.ViewReportButton.TabIndex = 11;
            this.ViewReportButton.Text = "Результаты";
            this.ViewReportButton.UseVisualStyleBackColor = true;
            this.ViewReportButton.Click += new System.EventHandler(this.ViewReportButton_Click);
            // 
            // WindowRegstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewReportButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.namesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WindowRegstr";
            this.Load += new System.EventHandler(this.WindowRegstr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ViewReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGgge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gend;
    }
}