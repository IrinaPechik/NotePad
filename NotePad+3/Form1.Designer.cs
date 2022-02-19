
namespace NotePad_3
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopySelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteSelectTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutSelectTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontOfTheTextFragmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFontOfThePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каждые5МинутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каждые10МинутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каждыйЧасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationColorThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьФорматВыделенногоФрагментаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopySelectedTextToolStripMenuItem,
            this.PasteSelectTextToolStripMenuItem,
            this.CutSelectTextToolStripMenuItem,
            this.SelectAllToolStripMenuItem,
            this.FontOfTheTextFragmentToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // CopySelectedTextToolStripMenuItem
            // 
            this.CopySelectedTextToolStripMenuItem.Name = "CopySelectedTextToolStripMenuItem";
            this.CopySelectedTextToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.CopySelectedTextToolStripMenuItem.Text = "Копировать";
            this.CopySelectedTextToolStripMenuItem.Click += new System.EventHandler(this.CopySelectedTextToolStripMenuItem_Click);
            // 
            // PasteSelectTextToolStripMenuItem
            // 
            this.PasteSelectTextToolStripMenuItem.Name = "PasteSelectTextToolStripMenuItem";
            this.PasteSelectTextToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.PasteSelectTextToolStripMenuItem.Text = "Вставить";
            this.PasteSelectTextToolStripMenuItem.Click += new System.EventHandler(this.PasteSelectTextToolStripMenuItem_Click);
            // 
            // CutSelectTextToolStripMenuItem
            // 
            this.CutSelectTextToolStripMenuItem.Name = "CutSelectTextToolStripMenuItem";
            this.CutSelectTextToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.CutSelectTextToolStripMenuItem.Text = "Вырезать";
            this.CutSelectTextToolStripMenuItem.Click += new System.EventHandler(this.CutSelectTextToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.SelectAllToolStripMenuItem.Text = "Выбрать всё";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // FontOfTheTextFragmentToolStripMenuItem
            // 
            this.FontOfTheTextFragmentToolStripMenuItem.Name = "FontOfTheTextFragmentToolStripMenuItem";
            this.FontOfTheTextFragmentToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.FontOfTheTextFragmentToolStripMenuItem.Text = "Форматировать фрагмент текста";
            this.FontOfTheTextFragmentToolStripMenuItem.Click += new System.EventHandler(this.FontOfTheTextFragmentToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFontOfThePageToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // MainFontOfThePageToolStripMenuItem
            // 
            this.MainFontOfThePageToolStripMenuItem.Name = "MainFontOfThePageToolStripMenuItem";
            this.MainFontOfThePageToolStripMenuItem.Size = new System.Drawing.Size(438, 34);
            this.MainFontOfThePageToolStripMenuItem.Text = "Задать основной шрифт для документа";
            this.MainFontOfThePageToolStripMenuItem.Click += new System.EventHandler(this.MainFontOfThePageToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem,
            this.ApplicationColorThemeToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem
            // 
            this.задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каждые5МинутToolStripMenuItem,
            this.каждые10МинутToolStripMenuItem,
            this.каждыйЧасToolStripMenuItem});
            this.задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem.Name = "задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem";
            this.задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem.Size = new System.Drawing.Size(546, 34);
            this.задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem.Text = "Задать частоту автоматического сохранения файлов";
            // 
            // каждые5МинутToolStripMenuItem
            // 
            this.каждые5МинутToolStripMenuItem.Name = "каждые5МинутToolStripMenuItem";
            this.каждые5МинутToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.каждые5МинутToolStripMenuItem.Text = "Каждые 5 минут";
            this.каждые5МинутToolStripMenuItem.Click += new System.EventHandler(this.SavingEveryFiveMinuteToolStripMenuItem_Click);
            // 
            // каждые10МинутToolStripMenuItem
            // 
            this.каждые10МинутToolStripMenuItem.Name = "каждые10МинутToolStripMenuItem";
            this.каждые10МинутToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.каждые10МинутToolStripMenuItem.Text = "Каждые 10 минут";
            this.каждые10МинутToolStripMenuItem.Click += new System.EventHandler(this.SavingEveryTenMinuteToolStripMenuItem_Click);
            // 
            // каждыйЧасToolStripMenuItem
            // 
            this.каждыйЧасToolStripMenuItem.Name = "каждыйЧасToolStripMenuItem";
            this.каждыйЧасToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.каждыйЧасToolStripMenuItem.Text = "Каждый час";
            this.каждыйЧасToolStripMenuItem.Click += new System.EventHandler(this.SavingEveryHourToolStripMenuItem_Click);
            // 
            // ApplicationColorThemeToolStripMenuItem
            // 
            this.ApplicationColorThemeToolStripMenuItem.Name = "ApplicationColorThemeToolStripMenuItem";
            this.ApplicationColorThemeToolStripMenuItem.Size = new System.Drawing.Size(546, 34);
            this.ApplicationColorThemeToolStripMenuItem.Text = "Выбор цветовой схемы приложения";
            this.ApplicationColorThemeToolStripMenuItem.Click += new System.EventHandler(this.ApplicationColorThemeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 501);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вкладка 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1025, 457);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBoxOneTextChanged);
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContextMenuOfReachTextBoxOneMouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.ForeColor = System.Drawing.Color.Coral;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вкладка 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1025, 457);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBoxTwoTextChanged);
            this.richTextBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContextMenuOfReachTextBoxTwoMouseUp);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1031, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вкладка 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(0, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1031, 463);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.RichTextBoxThreeTextChanged);
            this.richTextBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContextMenuOfReachTextBoxThreeMouseUp);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1031, 463);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Вкладка 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox4.Location = new System.Drawing.Point(0, 0);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(1031, 463);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.RichTextBoxFourTextChanged);
            this.richTextBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContextMenuOfReachTextBoxFourMouseUp);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1031, 463);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Вкладка 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox5.Location = new System.Drawing.Point(0, 0);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(1031, 463);
            this.richTextBox5.TabIndex = 0;
            this.richTextBox5.Text = "";
            this.richTextBox5.TextChanged += new System.EventHandler(this.RichTextBoxFiveTextChanged);
            this.richTextBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContextMenuOfReachTextBoxFiveMouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.задатьФорматВыделенногоФрагментаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(413, 197);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(412, 32);
            this.ToolStripMenuItem.Text = "Выбрать всё";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuSelectAllToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(412, 32);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuCutToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(412, 32);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuCopyToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(412, 32);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuPasteToolStripMenuItem_Click);
            // 
            // задатьФорматВыделенногоФрагментаToolStripMenuItem
            // 
            this.задатьФорматВыделенногоФрагментаToolStripMenuItem.Name = "задатьФорматВыделенногоФрагментаToolStripMenuItem";
            this.задатьФорматВыделенногоФрагментаToolStripMenuItem.Size = new System.Drawing.Size(412, 32);
            this.задатьФорматВыделенногоФрагментаToolStripMenuItem.Text = "Задать формат выделенного фрагмента";
            this.задатьФорматВыделенногоФрагментаToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuFontOfTheTextFragmentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1039, 534);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOneClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOneKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopySelectedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteSelectTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutSelectTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontOfTheTextFragmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainFontOfThePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьЧастотуАвтоматическогоСохраненияФайловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ApplicationColorThemeToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem каждые5МинутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каждые10МинутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каждыйЧасToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьФорматВыделенногоФрагментаToolStripMenuItem;
    }
}

