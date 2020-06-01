namespace Program
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьконтрастностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветовойБалансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повыситьРезкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.друкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.открытьToolStripMenuItem.Text = "Відкрити...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Зберегти як...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.яркостьконтрастностьToolStripMenuItem,
            this.цветовойБалансToolStripMenuItem,
            this.повыситьРезкостьToolStripMenuItem,
            this.размытьToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem2.Text = "ФІльтри";
            // 
            // яркостьконтрастностьToolStripMenuItem
            // 
            this.яркостьконтрастностьToolStripMenuItem.Name = "яркостьконтрастностьToolStripMenuItem";
            this.яркостьконтрастностьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.яркостьконтрастностьToolStripMenuItem.Text = "Ясравість/контрастність";
            this.яркостьконтрастностьToolStripMenuItem.Click += new System.EventHandler(this.яркостьконтрастностьToolStripMenuItem_Click);
            // 
            // цветовойБалансToolStripMenuItem
            // 
            this.цветовойБалансToolStripMenuItem.Name = "цветовойБалансToolStripMenuItem";
            this.цветовойБалансToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.цветовойБалансToolStripMenuItem.Text = "Баланс кольорів";
            this.цветовойБалансToolStripMenuItem.Click += new System.EventHandler(this.цветовойБалансToolStripMenuItem_Click);
            // 
            // повыситьРезкостьToolStripMenuItem
            // 
            this.повыситьРезкостьToolStripMenuItem.Name = "повыситьРезкостьToolStripMenuItem";
            this.повыситьРезкостьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.повыситьРезкостьToolStripMenuItem.Text = "Підвищити різкість";
            this.повыситьРезкостьToolStripMenuItem.Click += new System.EventHandler(this.повыситьРезкостьToolStripMenuItem_Click);
            // 
            // размытьToolStripMenuItem
            // 
            this.размытьToolStripMenuItem.Name = "размытьToolStripMenuItem";
            this.размытьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.размытьToolStripMenuItem.Text = "Розмити";
            this.размытьToolStripMenuItem.Click += new System.EventHandler(this.размытьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.друкToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // друкToolStripMenuItem
            // 
            this.друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            this.друкToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.друкToolStripMenuItem.Text = "Друк";
            this.друкToolStripMenuItem.Click += new System.EventHandler(this.друкToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Нахил зображення";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Креслити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(983, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Повернути праворуч";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(863, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Повернути ліворуч";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Enabled = false;
            this.btnRotate.Location = new System.Drawing.Point(758, 3);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 11;
            this.btnRotate.Text = "Нахилити";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(682, 5);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(46, 20);
            this.txtAngle.TabIndex = 10;
            this.txtAngle.Text = "30";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(825, 471);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 129);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = " В ході обслідування аномалій виявлено не було. Пацієнт Сашнєв Г. О. не має патал" +
    "огій в області грудної клітини. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1073, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Опис знімку";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1155, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Стиснути";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1283, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Розширити";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(825, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 408);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(32, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 573);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(32, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Гістограма";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(825, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Гістограма";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 612);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Редактор зображень";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem яркостьконтрастностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветовойБалансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повыситьРезкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem друкToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

