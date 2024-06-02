namespace Translator
{
    partial class FirstForm
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
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.ChosePath = new System.Windows.Forms.Button();
            this.RUN = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(20, 37);
            this.FileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.ReadOnly = true;
            this.FileLocation.Size = new System.Drawing.Size(463, 22);
            this.FileLocation.TabIndex = 0;
            this.FileLocation.Text = "Выберите путь к файлу *.pas ->";
            // 
            // ChosePath
            // 
            this.ChosePath.Location = new System.Drawing.Point(492, 34);
            this.ChosePath.Margin = new System.Windows.Forms.Padding(4);
            this.ChosePath.Name = "ChosePath";
            this.ChosePath.Size = new System.Drawing.Size(100, 28);
            this.ChosePath.TabIndex = 1;
            this.ChosePath.Text = "Обзор";
            this.ChosePath.UseVisualStyleBackColor = true;
            this.ChosePath.Click += new System.EventHandler(this.ChosePath_Click);
            // 
            // RUN
            // 
            this.RUN.Location = new System.Drawing.Point(357, 69);
            this.RUN.Margin = new System.Windows.Forms.Padding(4);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(235, 28);
            this.RUN.TabIndex = 2;
            this.RUN.Text = "Провести трансляцию";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "pas";
            this.openFileDialog.FileName = "*.pas";
            this.openFileDialog.Filter = "Код на языке Pascal (.pas)|*.pas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь к файлу для трансляции";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 201);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(315, 367);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(20, 169);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Файл открыт";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(380, 201);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(533, 367);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.Location = new System.Drawing.Point(380, 169);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(533, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Класс лексемы     Значение  Тип      Ключи      № строки  № позиции\r\n\r\n";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 583);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RUN);
            this.Controls.Add(this.ChosePath);
            this.Controls.Add(this.FileLocation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirstForm";
            this.Text = "Транслятор Pascal -> C#";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.Shown += new System.EventHandler(this.FirstForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.Button ChosePath;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

