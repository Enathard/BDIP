namespace ProccesingImageWFA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.newPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantComboBox = new System.Windows.Forms.ComboBox();
            this.quantButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resizeComboBox = new System.Windows.Forms.ComboBox();
            this.resizeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contransButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fragmentButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.precentTextBox = new System.Windows.Forms.TextBox();
            this.randomReplaceButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьИзображениеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьИзображениеToolStripMenuItem
            // 
            this.открытьИзображениеToolStripMenuItem.Name = "открытьИзображениеToolStripMenuItem";
            this.открытьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.открытьИзображениеToolStripMenuItem.Text = "Открыть изображение";
            this.открытьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.openImage_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Location = new System.Drawing.Point(12, 53);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(279, 274);
            this.originalPictureBox.TabIndex = 1;
            this.originalPictureBox.TabStop = false;
            // 
            // newPictureBox
            // 
            this.newPictureBox.Location = new System.Drawing.Point(358, 53);
            this.newPictureBox.Name = "newPictureBox";
            this.newPictureBox.Size = new System.Drawing.Size(297, 274);
            this.newPictureBox.TabIndex = 1;
            this.newPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходное изображение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(354, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Преобразованное изображение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Уменьшить частоту квантования изображения в";
            // 
            // quantComboBox
            // 
            this.quantComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantComboBox.FormattingEnabled = true;
            this.quantComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.quantComboBox.Location = new System.Drawing.Point(470, 356);
            this.quantComboBox.Name = "quantComboBox";
            this.quantComboBox.Size = new System.Drawing.Size(70, 32);
            this.quantComboBox.TabIndex = 4;
            // 
            // quantButton
            // 
            this.quantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantButton.Location = new System.Drawing.Point(577, 356);
            this.quantButton.Name = "quantButton";
            this.quantButton.Size = new System.Drawing.Size(122, 32);
            this.quantButton.TabIndex = 5;
            this.quantButton.Text = "Выполнить";
            this.quantButton.UseVisualStyleBackColor = true;
            this.quantButton.Click += new System.EventHandler(this.QuantButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Уменьшить разрешение изображения в";
            // 
            // resizeComboBox
            // 
            this.resizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resizeComboBox.FormattingEnabled = true;
            this.resizeComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.resizeComboBox.Location = new System.Drawing.Point(391, 401);
            this.resizeComboBox.Name = "resizeComboBox";
            this.resizeComboBox.Size = new System.Drawing.Size(70, 32);
            this.resizeComboBox.TabIndex = 4;
            // 
            // resizeButton
            // 
            this.resizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resizeButton.Location = new System.Drawing.Point(577, 404);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(122, 32);
            this.resizeButton.TabIndex = 5;
            this.resizeButton.Text = "Выполнить";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Линейное контрастирование изображения от 32 до 196";
            // 
            // contransButton
            // 
            this.contransButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contransButton.Location = new System.Drawing.Point(577, 449);
            this.contransButton.Name = "contransButton";
            this.contransButton.Size = new System.Drawing.Size(122, 32);
            this.contransButton.TabIndex = 5;
            this.contransButton.Text = "Выполнить";
            this.contransButton.UseVisualStyleBackColor = true;
            this.contransButton.Click += new System.EventHandler(this.ContransButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(546, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Вырезать фрагмент изображения и увеличить его в 4 раза";
            // 
            // fragmentButton
            // 
            this.fragmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fragmentButton.Location = new System.Drawing.Point(577, 498);
            this.fragmentButton.Name = "fragmentButton";
            this.fragmentButton.Size = new System.Drawing.Size(122, 32);
            this.fragmentButton.TabIndex = 5;
            this.fragmentButton.Text = "Выполнить";
            this.fragmentButton.UseVisualStyleBackColor = true;
            this.fragmentButton.Click += new System.EventHandler(this.FragmentButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(450, 48);
            this.label7.TabIndex = 3;
            this.label7.Text = "Случайным образом заменить значения яркости\r\nзаданного процента пикселей";
            // 
            // precentTextBox
            // 
            this.precentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.precentTextBox.Location = new System.Drawing.Point(470, 565);
            this.precentTextBox.Name = "precentTextBox";
            this.precentTextBox.Size = new System.Drawing.Size(100, 29);
            this.precentTextBox.TabIndex = 6;
            // 
            // randomReplaceButton
            // 
            this.randomReplaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomReplaceButton.Location = new System.Drawing.Point(577, 564);
            this.randomReplaceButton.Name = "randomReplaceButton";
            this.randomReplaceButton.Size = new System.Drawing.Size(122, 32);
            this.randomReplaceButton.TabIndex = 5;
            this.randomReplaceButton.Text = "Выполнить";
            this.randomReplaceButton.UseVisualStyleBackColor = true;
            this.randomReplaceButton.Click += new System.EventHandler(this.RandomReplaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 621);
            this.Controls.Add(this.precentTextBox);
            this.Controls.Add(this.randomReplaceButton);
            this.Controls.Add(this.fragmentButton);
            this.Controls.Add(this.contransButton);
            this.Controls.Add(this.resizeButton);
            this.Controls.Add(this.quantButton);
            this.Controls.Add(this.resizeComboBox);
            this.Controls.Add(this.quantComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox newPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quantComboBox;
        private System.Windows.Forms.Button quantButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox resizeComboBox;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button contransButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fragmentButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox precentTextBox;
        private System.Windows.Forms.Button randomReplaceButton;
    }
}

