using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Форматы для сохранения файлов.
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|Reach Text Format(*.rtf)|*.rtf";
            // Следим за изменением вкладок.
            richTextBox1.TextChanged += RichTextBoxOneTextChanged;
            richTextBox2.TextChanged += RichTextBoxTwoTextChanged;
            richTextBox3.TextChanged += RichTextBoxThreeTextChanged;
            richTextBox4.TextChanged += RichTextBoxFourTextChanged;
            richTextBox5.TextChanged += RichTextBoxFiveTextChanged;
        }
        // Номер выбранной вкладки.
        int numberOfcurrentTab;
        // Показывает, было ли изменено содержимое первой вкладки.
        bool textChangedFirst;
        // Показывает, было ли изменено содержимое второй вкладки.
        bool textChangedSecond;
        // Показывает, было ли изменено содержимое третьей вкладки.
        bool textChangedThird;
        // Показывает, было ли изменено содержимое четвёртой вкладки.
        bool textChangedFourth;
        // Показывает, было ли изменено содержимое пятой вкладки.
        bool textChangedFifth;
        /// <summary>
        /// Показывает, была ли создана вторая форма.
        /// </summary>
        public int wasCreatedSecondForm = 0;
        /// <summary>
        /// Считает количество новых созданных форм.
        /// </summary>
        public int countOfNewForms = 1;
        // Хранит пути к файлам.
        string[] path = new string[5];
        // RichTextBox, не привязанный к определённой вкладке.
        RichTextBox richTextBox;
        // RichTextBox для вставки.
        RichTextBox richTextBoxToPaste;
        /// <summary>
        /// Выбирает нужную вкладку для работы с ней.
        /// </summary>
        public void NewRichTextBox()
        {
            try
            {
                RichTextBox[] currentRichTextBox = new RichTextBox[5];
                currentRichTextBox[0] = richTextBox1;
                currentRichTextBox[1] = richTextBox2;
                currentRichTextBox[2] = richTextBox3;
                currentRichTextBox[3] = richTextBox4;
                currentRichTextBox[4] = richTextBox5;
                var currentTab = tabControl1.SelectedTab;
                numberOfcurrentTab = int.Parse(currentTab.Text[8].ToString());
                richTextBox = currentRichTextBox[numberOfcurrentTab - 1];
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.", "Ошибка");
            }
        }
        /// <summary>
        /// Открывает новый файл.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog1.FileName;
            try
            {
                string fileText = File.ReadAllText(fileName);
                string file = Path.GetExtension(fileName);
                NewRichTextBox();
                if (file == ".txt")
                {
                    richTextBox.Text = fileText;
                    path[numberOfcurrentTab-1] = fileName;
                }
                else
                {
                    richTextBox.Rtf = fileText;
                    path[numberOfcurrentTab-1] = fileName;
                }
                MessageBox.Show("Файл был успешно открыт.");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Указан недопустимый путь!");
            }
            catch (SecurityException)
            {
                MessageBox.Show("У вас нет прав для совершения данного действия!");
            }
            catch (IOException ex)
            {
                MessageBox.Show("При открытии файла произошла ошибка.", ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка", ex.Message);
            }
        }
        /// <summary>
        /// Сохраняет файл по выбранному пользователем пути.
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии.</param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveFileDialog1.FileName;
            NewRichTextBox();
            try
            {
                string file = Path.GetExtension(fileName);
                if (file == ".txt")
                {
                    File.WriteAllText(fileName, richTextBox.Text);
                    path[numberOfcurrentTab-1] = fileName;
                }
                else
                {
                    File.WriteAllText(fileName, richTextBox.Rtf);
                    path[numberOfcurrentTab-1] = fileName;
                }
                MessageBox.Show("Файл был успешно сохранён!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Указан недопустимый путь!");
            }
            catch (SecurityException)
            {
                MessageBox.Show("У вас нет прав для совершения данного действия!");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка");
            }
        }
        /// <summary>
        /// Копирует выбранный фрагмент текста.
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии.</param>
        private void CopySelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                if (richTextBox.TextLength > 0)
                {
                    richTextBox.Copy();
                    richTextBoxToPaste = richTextBox;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Вставляет текст из буфера обмена.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void PasteSelectTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                if (richTextBoxToPaste != null)
                {
                    if (richTextBoxToPaste.TextLength > 0)
                    {
                        richTextBox.Paste();
                    }
                }
                else
                {
                    MessageBox.Show("Вы ничего не скопировали!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }           
        }
        /// <summary>
        /// Вырезать выделенный текст.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void CutSelectTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                if (richTextBox.TextLength > 0)
                {
                    richTextBox.Cut();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Задать основной стиль шрифта вкладки.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void MainFontOfThePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                fontDialog1.ShowDialog();
                richTextBox.Font = fontDialog1.Font;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }         
        }
        /// <summary>
        /// Задать стиль шрифта для выделенного фрагмента.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void FontOfTheTextFragmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                fontDialog1.ShowDialog();
                richTextBox.SelectionFont = fontDialog1.Font;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Выбор цветовой схемы приложения.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        public void ApplicationColorThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                MessageBox.Show("Выберите цвет фона рабочей области.");
                if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    richTextBox.BackColor = colorDialog1.Color;
                }
                MessageBox.Show("Выберите цвет основного меню.");
                if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                    menuStrip1.BackColor = colorDialog1.Color;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Выбрать весь текст во вкладке.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                // Ставим курсор в начало, чтобы если курсор еще не стоит,
                // он стоял по умолчанию и пользователю
                // не пришлось совершать лишние действия.
                richTextBox.Select(0, 0);
                richTextBox.Focus();
                richTextBox.ScrollToCaret();
                if (richTextBox.TextLength > 0)
                {
                    richTextBox.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Контекстное меню для вкладки 1 при нажатии правой кнопки мыши.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuOfReachTextBoxOneMouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    richTextBox1.ContextMenuStrip = contextMenuStrip1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Контекстное меню для вкладки 2 при нажатии правой кнопки мыши.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuOfReachTextBoxTwoMouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    richTextBox2.ContextMenuStrip = contextMenuStrip1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Контекстное меню для вкладки 3 при нажатии правой кнопки мыши.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuOfReachTextBoxThreeMouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    richTextBox3.ContextMenuStrip = contextMenuStrip1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Контекстное меню для вкладки 4 при нажатии правой кнопки мыши.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuOfReachTextBoxFourMouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    richTextBox4.ContextMenuStrip = contextMenuStrip1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Контекстное меню для вкладки 5 при нажатии правой кнопки мыши.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuOfReachTextBoxFiveMouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    richTextBox5.ContextMenuStrip = contextMenuStrip1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Сохранение изменений в вкладках при закрытии приложения.
        /// </summary>
        /// <param name="wasFileChanged">Показывет был ли файл во вкладке изменён.</param>
        /// <param name="richTextBox">Страница для сохранения её текста.</param>
        /// <param name="numberOfThePage">Текущая страница, в которой работет пользователь.</param>
        private void SaveChanges(bool wasFileChanged, RichTextBox richTextBox, int numberOfThePage)
        {
            try
            {
                if (wasFileChanged)
                {
                    var shouldSaveChanges = MessageBox.Show($"Сохранить внесённые изменения в вкладке " +
                        $"{numberOfThePage}?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (shouldSaveChanges == DialogResult.Yes)
                    {
                        if (path[numberOfThePage - 1] != null)
                        {
                            var extension = Path.GetExtension(path[numberOfThePage - 1]);
                            if (extension == ".txt")
                                richTextBox.SaveFile(path[numberOfThePage - 1], RichTextBoxStreamType.PlainText);
                            if (extension == ".rtf")
                                richTextBox.SaveFile(path[numberOfThePage - 1]);
                        }
                        else
                        {
                            if (wasCreatedSecondForm == 1)
                            {
                                richTextBox.SaveFile($"FileByNotepad#{numberOfThePage} form{countOfNewForms}.rtf");
                            }
                            else
                                richTextBox.SaveFile($"FileByNotepad#{numberOfThePage} form1.rtf");
                        }
                        MessageBox.Show("Изменения были сохранены");
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Во время сохранения файлf произошла ошибка.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Недопустимый путь файла");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Произошла ошибка отображения сообщения.");
            }
            catch (Exception)
            {
                MessageBox.Show("Прозошла непредвиденная ошибка.");
            }            
        }
        /// <summary>
        /// Сохранение данных при закрытии формы.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void FormOneClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var shouldClosingForm = MessageBox.Show("Вы действительно хотите закрыть приложение?", 
                    "Закрытие приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (shouldClosingForm == DialogResult.Yes)
                {
                    SaveChanges(textChangedFirst, richTextBox1, 1);
                    SaveChanges(textChangedSecond, richTextBox2, 2);
                    SaveChanges(textChangedThird, richTextBox3, 3);
                    SaveChanges(textChangedFourth, richTextBox4, 4);
                    SaveChanges(textChangedFifth, richTextBox5, 5);
                }
                if (shouldClosingForm == DialogResult.No)
                {
                    // Закрываем приложение.
                    e.Cancel = true;
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Произошла ошибка отображения сообщения.");
            }
            catch (Exception)
            {
                MessageBox.Show("Прозошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Показывает, были ли внесены изменения во вкладку 1.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void RichTextBoxOneTextChanged(object sender, EventArgs e)
        {
            textChangedFirst = true;
        }
        /// <summary>
        /// Показывает, были ли внесены изменения во вкладку 2.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void RichTextBoxTwoTextChanged(object sender, EventArgs e)
        {
            textChangedSecond = true;
        }
        /// <summary>
        /// Показывает, были ли внесены изменения во вкладку 3.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void RichTextBoxThreeTextChanged(object sender, EventArgs e)
        {
            textChangedThird = true;
        }
        /// <summary>
        /// Показывает, были ли внесены изменения во вкладку 4.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void RichTextBoxFourTextChanged(object sender, EventArgs e)
        {
            textChangedFourth = true;
        }
        /// <summary>
        /// Показывает, были ли внесены изменения во вкладку 5.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void RichTextBoxFiveTextChanged(object sender, EventArgs e)
        {
            textChangedFifth = true;
        }
        /// <summary>
        /// Сохраняет файл, без выбора пути.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                if (path[numberOfcurrentTab - 1] != null)
                {
                    var extension = Path.GetExtension(path[numberOfcurrentTab - 1]);
                    if (extension == ".txt")
                        richTextBox.SaveFile(path[numberOfcurrentTab - 1], RichTextBoxStreamType.PlainText);
                    if (extension == ".rtf")
                        richTextBox.SaveFile(path[numberOfcurrentTab - 1]);
                }
                else
                {
                    if (wasCreatedSecondForm == 1)
                    {
                        MessageBox.Show(numberOfcurrentTab.ToString());
                        richTextBox.SaveFile($"FileByNotepad#{numberOfcurrentTab} form{countOfNewForms}.rtf");
                        wasCreatedSecondForm = 0;
                    }
                    else
                        richTextBox.SaveFile($"FileByNotepad#{numberOfcurrentTab} form1.rtf");
                }
                if (numberOfcurrentTab == 1)
                    textChangedFirst = false;
                if (numberOfcurrentTab == 2)
                    textChangedSecond = false;
                if (numberOfcurrentTab == 3)
                    textChangedThird = false;
                if (numberOfcurrentTab == 4)
                    textChangedFourth = false;
                if (numberOfcurrentTab == 5)
                    textChangedFifth = false;
                MessageBox.Show("Изменения были сохранены");
            }
            catch (IOException)
            {
                MessageBox.Show("Во время сохранения файла произошла ошибка.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Недопустимый путь файла");
            }
            catch (Exception)
            {
                MessageBox.Show("Прозошла непредвиденная ошибка.");
            }
        }
        // Флаг для отсчёта пяти минут.
        int saveEveryFiveMinutes = 0;
        // Флаг для отсчёта десяти минут.
        int saveEveryTenMinutes = 0;
        // Флаг для отсчёта часа.
        int saveEveryHour = 0;
        /// <summary>
        /// Реализует возможность сохранять файлы в приложении каждые 5 минут.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void SavingEveryFiveMinuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveEveryTenMinutes = 0;
                saveEveryHour = 0;
                saveEveryFiveMinutes = 1;
                timer1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Прозошла непредвиденная ошибка.");
            }
        }
        // Тик таймера.
        int tick = 0;
        /// <summary>
        /// Сохраняет файлы, спустя заданное пользователем количество времени.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void TimerTick(object sender, EventArgs e)
        {
            try
            {
                tick++;
                if ((tick == 5) && (saveEveryFiveMinutes == 1))
                {
                    SaveChanges(richTextBox1, 1);
                    textChangedFirst = false;
                    SaveChanges(richTextBox2, 2);
                    textChangedSecond = false;
                    SaveChanges(richTextBox3, 3);
                    textChangedThird = false;
                    SaveChanges(richTextBox4, 4);
                    textChangedFourth = false;
                    SaveChanges(richTextBox5, 5);
                    textChangedFifth = false;
                    tick = 0;
                }
                if ((tick == 10) && (saveEveryTenMinutes == 1))
                {
                    SaveChanges(richTextBox1, 1);
                    textChangedFirst = false;
                    SaveChanges(richTextBox2, 2);
                    textChangedSecond = false;
                    SaveChanges(richTextBox3, 3);
                    textChangedThird = false;
                    SaveChanges(richTextBox4, 4);
                    textChangedFourth = false;
                    SaveChanges(richTextBox5, 5);
                    textChangedFifth = false;
                    tick = 0;
                }
                if ((tick == 60) && (saveEveryHour == 1))
                {
                    SaveChanges(richTextBox1, 1);
                    textChangedFirst = false;
                    SaveChanges(richTextBox2, 2);
                    textChangedSecond = false;
                    SaveChanges(richTextBox3, 3);
                    textChangedThird = false;
                    SaveChanges(richTextBox4, 4);
                    textChangedFourth = false;
                    SaveChanges(richTextBox5, 5);
                    textChangedFifth = false;
                    tick = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Реализует возможность сохранять файлы в приложении каждые 10 минут.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavingEveryTenMinuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveEveryFiveMinutes = 0;
                saveEveryHour = 0;
                saveEveryTenMinutes = 1;
                timer1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Прозошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Сохранение файлов.
        /// </summary>
        /// <param name="richTextBox">Страница для сохранения её текста.</param>
        /// <param name="numberOfThePage">Номер страницы.</param>
        private void SaveChanges(RichTextBox richTextBox, int numberOfThePage)
        {
            try
            {
                if (path[numberOfThePage - 1] != null)
                {
                    var extension = Path.GetExtension(path[numberOfThePage - 1]);
                    if (extension == ".txt")
                        richTextBox.SaveFile(path[numberOfThePage - 1], RichTextBoxStreamType.PlainText);
                    if (extension == ".rtf")
                        richTextBox.SaveFile(path[numberOfThePage - 1]);
                }
                else
                {
                    if (wasCreatedSecondForm == 1)
                    {
                        richTextBox.SaveFile($"FileByNotepad#{numberOfThePage} form{countOfNewForms}.rtf");
                    }
                    else
                        richTextBox.SaveFile($"FileByNotepad#{numberOfThePage} form1.rtf");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Во время сохранения файлa произошла ошибка.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Недопустимый путь файла");
            }
            catch (Exception)
            {
                MessageBox.Show("Прозошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Реализует возможность сохранять файлы в приложении каждый час.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void SavingEveryHourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveEveryFiveMinutes = 0;
                saveEveryTenMinutes = 0;
                saveEveryHour = 1;
                timer1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Прозошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Реализация горячих клавишь.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void FormOneKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Создание нового окна
                if (e.KeyValue == (char)Keys.F2)
                {
                    NewWindow SecondForm = new NewWindow();
                    SecondForm.Show();
                }
                // Переход между вкладками.
                if (e.KeyValue == (char)Keys.F3)
                {
                    NewRichTextBox();
                    if (tabControl1.SelectedIndex == 4)
                    {
                        numberOfcurrentTab = 0;
                    }
                    tabControl1.SelectedIndex = numberOfcurrentTab;
                }
                // Сохранение текущего документа.
                if (e.KeyValue == (char)Keys.F4)
                {
                    NewRichTextBox();
                    SaveChanges(richTextBox, numberOfcurrentTab);
                    if (numberOfcurrentTab == 1)
                        textChangedFirst = false;
                    if (numberOfcurrentTab == 2)
                        textChangedSecond = false;
                    if (numberOfcurrentTab == 3)
                        textChangedThird = false;
                    if (numberOfcurrentTab == 4)
                        textChangedFourth = false;
                    if (numberOfcurrentTab == 5)
                        textChangedFifth = false;
                    MessageBox.Show("Файл был сохранён");
                }
                // Сохранение всех вкладок.
                if (e.KeyValue == (char)Keys.F5)
                {
                    SaveChanges(richTextBox1, 1);
                    textChangedFirst = false;
                    SaveChanges(richTextBox2, 2);
                    textChangedSecond = false;
                    SaveChanges(richTextBox3, 3);
                    textChangedThird = false;
                    SaveChanges(richTextBox4, 4);
                    textChangedFourth = false;
                    SaveChanges(richTextBox5, 5);
                    textChangedFifth = false;
                    MessageBox.Show("Файлы были сохранены.");
                }
                // Закрытие формы.
                if (e.KeyValue == (char)Keys.Escape)
                {
                    Close();
                }
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Не удается получить доступ к закрытому потоку.");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Произошла ошибка при вызове нового окна.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }            
        }
        /// <summary>
        /// Выбрать весь текст во вкладке с помощью контекстного меню.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                // Ставим курсор в начало, чтобы если курсор еще не стоит,
                // он стоял по умолчанию и пользователю
                // не пришлось совершать лишние действия.
                richTextBox.Select(0, 0);
                richTextBox.Focus();
                richTextBox.ScrollToCaret();
                if (richTextBox.TextLength > 0)
                {
                    richTextBox.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Вырезать выделенный текст с помощью контекстного меню.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                if (richTextBox.TextLength > 0)
                {
                    richTextBox.Cut();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Копирует выбранный фрагмент текста с помощью контекстного меню.
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                if (richTextBox.TextLength > 0)
                {
                    richTextBox.Copy();
                    richTextBoxToPaste = richTextBox;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Вставляет текст с помощью контекстного меню .
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                if (richTextBoxToPaste != null)
                {
                    if (richTextBoxToPaste.TextLength > 0)
                    {
                        richTextBox.Paste();
                    }
                }
                else
                {
                    MessageBox.Show("Вы ничего не скопировали!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
        /// <summary>
        /// Задать стиль шрифта для выделенного фрагмента.
        /// </summary>
        /// <param name="sender">Издатель.</param>
        /// <param name="e">Информация о событии.</param>
        private void ContextMenuFontOfTheTextFragmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox();
                fontDialog1.ShowDialog();
                richTextBox.SelectionFont = fontDialog1.Font;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }
    }
}