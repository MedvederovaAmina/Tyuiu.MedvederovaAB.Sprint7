﻿namespace Tyuiu.MedvederovaAB.Sprint7.Project.V13
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            panelChart_MAB = new Panel();
            groupBoxChart_MAB = new GroupBox();
            chartStatistic_MAB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelOperation_MAB = new Panel();
            groupBoxOperation_MAB = new GroupBox();
            buttonTask_MAB = new Button();
            buttonInfo_MAB = new Button();
            buttonSaveFile_MAB = new Button();
            buttonOpenFile_MAB = new Button();
            buttonStatistic_MAB = new Button();
            textBoxResStatistic_MAB = new TextBox();
            labelResStatistic_MAB = new Label();
            labelOperation_MAB = new Label();
            labelNumOfColumn_MAB = new Label();
            textBoxOperation_MAB = new TextBox();
            textBoxNumOfColumn_MAB = new TextBox();
            labelStatistic_MAB = new Label();
            buttonSortPopulation_MAB = new Button();
            buttonSortSquare_MAB = new Button();
            labelSort_MAB = new Label();
            buttonSearchInfo_MAB = new Button();
            textBoxSearch_MAB = new TextBox();
            labelSearchInfo_MAB = new Label();
            panelInputData_MAB = new Panel();
            groupBoxInPutData_MAB = new GroupBox();
            dataGridViewInPutData_MAB = new DataGridView();
            ColumnCountryIn_MAB = new DataGridViewTextBoxColumn();
            ColumnStolIn_MAB = new DataGridViewTextBoxColumn();
            ColumnPopulIn_MAB = new DataGridViewTextBoxColumn();
            ColumnSquareIn_MAB = new DataGridViewTextBoxColumn();
            ColumnEconomy_MAB = new DataGridViewTextBoxColumn();
            ColumnPrPopulIn_MAB = new DataGridViewTextBoxColumn();
            panelOutputData_MAB = new Panel();
            groupBoxOutPutData_MAB = new GroupBox();
            dataGridViewOutPutData_MAB = new DataGridView();
            ColumnCountryOut_MAB = new DataGridViewTextBoxColumn();
            ColumnStolOut_MAB = new DataGridViewTextBoxColumn();
            ColumnPopulationOut_MAB = new DataGridViewTextBoxColumn();
            ColumnSquareOut_MAB = new DataGridViewTextBoxColumn();
            ColumnEconomyOut_MAB = new DataGridViewTextBoxColumn();
            ColumnPrOut_MAB = new DataGridViewTextBoxColumn();
            toolTipInfo_MAB = new ToolTip(components);
            openFileDialogLibrary_MAB = new OpenFileDialog();
            saveFileDialogLibrary_MAB = new SaveFileDialog();
            panelChart_MAB.SuspendLayout();
            groupBoxChart_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatistic_MAB).BeginInit();
            panelOperation_MAB.SuspendLayout();
            groupBoxOperation_MAB.SuspendLayout();
            panelInputData_MAB.SuspendLayout();
            groupBoxInPutData_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutData_MAB).BeginInit();
            panelOutputData_MAB.SuspendLayout();
            groupBoxOutPutData_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutData_MAB).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(528, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 162);
            panel1.TabIndex = 0;
            // 
            // panelChart_MAB
            // 
            panelChart_MAB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChart_MAB.Controls.Add(groupBoxChart_MAB);
            panelChart_MAB.Location = new Point(528, 1);
            panelChart_MAB.Name = "panelChart_MAB";
            panelChart_MAB.Size = new Size(539, 287);
            panelChart_MAB.TabIndex = 1;
            // 
            // groupBoxChart_MAB
            // 
            groupBoxChart_MAB.Controls.Add(chartStatistic_MAB);
            groupBoxChart_MAB.Dock = DockStyle.Fill;
            groupBoxChart_MAB.Location = new Point(0, 0);
            groupBoxChart_MAB.Name = "groupBoxChart_MAB";
            groupBoxChart_MAB.Size = new Size(539, 287);
            groupBoxChart_MAB.TabIndex = 0;
            groupBoxChart_MAB.TabStop = false;
            groupBoxChart_MAB.Text = "График";
            // 
            // chartStatistic_MAB
            // 
            chartArea1.Name = "ChartArea1";
            chartStatistic_MAB.ChartAreas.Add(chartArea1);
            chartStatistic_MAB.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartStatistic_MAB.Legends.Add(legend1);
            chartStatistic_MAB.Location = new Point(3, 23);
            chartStatistic_MAB.Name = "chartStatistic_MAB";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStatistic_MAB.Series.Add(series1);
            chartStatistic_MAB.Size = new Size(533, 261);
            chartStatistic_MAB.TabIndex = 0;
            chartStatistic_MAB.Text = "chart1";
            // 
            // panelOperation_MAB
            // 
            panelOperation_MAB.Controls.Add(groupBoxOperation_MAB);
            panelOperation_MAB.Controls.Add(panel1);
            panelOperation_MAB.Location = new Point(0, 1);
            panelOperation_MAB.Name = "panelOperation_MAB";
            panelOperation_MAB.Size = new Size(522, 287);
            panelOperation_MAB.TabIndex = 2;
            // 
            // groupBoxOperation_MAB
            // 
            groupBoxOperation_MAB.Controls.Add(buttonTask_MAB);
            groupBoxOperation_MAB.Controls.Add(buttonInfo_MAB);
            groupBoxOperation_MAB.Controls.Add(buttonSaveFile_MAB);
            groupBoxOperation_MAB.Controls.Add(buttonOpenFile_MAB);
            groupBoxOperation_MAB.Controls.Add(buttonStatistic_MAB);
            groupBoxOperation_MAB.Controls.Add(textBoxResStatistic_MAB);
            groupBoxOperation_MAB.Controls.Add(labelResStatistic_MAB);
            groupBoxOperation_MAB.Controls.Add(labelOperation_MAB);
            groupBoxOperation_MAB.Controls.Add(labelNumOfColumn_MAB);
            groupBoxOperation_MAB.Controls.Add(textBoxOperation_MAB);
            groupBoxOperation_MAB.Controls.Add(textBoxNumOfColumn_MAB);
            groupBoxOperation_MAB.Controls.Add(labelStatistic_MAB);
            groupBoxOperation_MAB.Controls.Add(buttonSortPopulation_MAB);
            groupBoxOperation_MAB.Controls.Add(buttonSortSquare_MAB);
            groupBoxOperation_MAB.Controls.Add(labelSort_MAB);
            groupBoxOperation_MAB.Controls.Add(buttonSearchInfo_MAB);
            groupBoxOperation_MAB.Controls.Add(textBoxSearch_MAB);
            groupBoxOperation_MAB.Controls.Add(labelSearchInfo_MAB);
            groupBoxOperation_MAB.Dock = DockStyle.Fill;
            groupBoxOperation_MAB.Location = new Point(0, 0);
            groupBoxOperation_MAB.Name = "groupBoxOperation_MAB";
            groupBoxOperation_MAB.Size = new Size(522, 287);
            groupBoxOperation_MAB.TabIndex = 1;
            groupBoxOperation_MAB.TabStop = false;
            groupBoxOperation_MAB.Text = "Операции";
            // 
            // buttonTask_MAB
            // 
            buttonTask_MAB.FlatStyle = FlatStyle.Flat;
            buttonTask_MAB.Image = Properties.Resources.application_form_edit;
            buttonTask_MAB.Location = new Point(432, 225);
            buttonTask_MAB.Name = "buttonTask_MAB";
            buttonTask_MAB.Size = new Size(77, 52);
            buttonTask_MAB.TabIndex = 17;
            toolTipInfo_MAB.SetToolTip(buttonTask_MAB, "Описание технического задания");
            buttonTask_MAB.UseVisualStyleBackColor = true;
            buttonTask_MAB.Click += buttonTask_MAB_Click;
            // 
            // buttonInfo_MAB
            // 
            buttonInfo_MAB.FlatStyle = FlatStyle.Flat;
            buttonInfo_MAB.Image = Properties.Resources.application_form_magnify;
            buttonInfo_MAB.Location = new Point(349, 225);
            buttonInfo_MAB.Name = "buttonInfo_MAB";
            buttonInfo_MAB.Size = new Size(77, 52);
            buttonInfo_MAB.TabIndex = 16;
            toolTipInfo_MAB.SetToolTip(buttonInfo_MAB, "Сведение о программе");
            buttonInfo_MAB.UseVisualStyleBackColor = true;
            buttonInfo_MAB.Click += buttonInfo_MAB_Click;
            // 
            // buttonSaveFile_MAB
            // 
            buttonSaveFile_MAB.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_MAB.Image = Properties.Resources.book_key;
            buttonSaveFile_MAB.Location = new Point(89, 225);
            buttonSaveFile_MAB.Name = "buttonSaveFile_MAB";
            buttonSaveFile_MAB.Size = new Size(77, 52);
            buttonSaveFile_MAB.TabIndex = 15;
            toolTipInfo_MAB.SetToolTip(buttonSaveFile_MAB, "Сохранить файл");
            buttonSaveFile_MAB.UseVisualStyleBackColor = true;
            buttonSaveFile_MAB.Click += buttonSaveFile_MAB_Click;
            // 
            // buttonOpenFile_MAB
            // 
            buttonOpenFile_MAB.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_MAB.Image = Properties.Resources.book_open;
            buttonOpenFile_MAB.Location = new Point(6, 225);
            buttonOpenFile_MAB.Name = "buttonOpenFile_MAB";
            buttonOpenFile_MAB.Size = new Size(77, 52);
            buttonOpenFile_MAB.TabIndex = 14;
            toolTipInfo_MAB.SetToolTip(buttonOpenFile_MAB, "Выберите файл для открытия");
            buttonOpenFile_MAB.UseVisualStyleBackColor = true;
            buttonOpenFile_MAB.Click += buttonOpenFile_MAB_Click;
            // 
            // buttonStatistic_MAB
            // 
            buttonStatistic_MAB.Location = new Point(148, 188);
            buttonStatistic_MAB.Name = "buttonStatistic_MAB";
            buttonStatistic_MAB.Size = new Size(101, 27);
            buttonStatistic_MAB.TabIndex = 13;
            buttonStatistic_MAB.Text = "Применить";
            toolTipInfo_MAB.SetToolTip(buttonStatistic_MAB, resources.GetString("buttonStatistic_MAB.ToolTip"));
            buttonStatistic_MAB.UseVisualStyleBackColor = true;
            buttonStatistic_MAB.Click += buttonStatistic_MAB_Click;
            // 
            // textBoxResStatistic_MAB
            // 
            textBoxResStatistic_MAB.Location = new Point(6, 188);
            textBoxResStatistic_MAB.Name = "textBoxResStatistic_MAB";
            textBoxResStatistic_MAB.ReadOnly = true;
            textBoxResStatistic_MAB.Size = new Size(136, 27);
            textBoxResStatistic_MAB.TabIndex = 12;
            // 
            // labelResStatistic_MAB
            // 
            labelResStatistic_MAB.AutoSize = true;
            labelResStatistic_MAB.Location = new Point(6, 165);
            labelResStatistic_MAB.Name = "labelResStatistic_MAB";
            labelResStatistic_MAB.Size = new Size(78, 20);
            labelResStatistic_MAB.TabIndex = 11;
            labelResStatistic_MAB.Text = "Результат:";
            labelResStatistic_MAB.Click += labelResStatistic_MAB_Click;
            // 
            // labelOperation_MAB
            // 
            labelOperation_MAB.AutoSize = true;
            labelOperation_MAB.Location = new Point(265, 112);
            labelOperation_MAB.Name = "labelOperation_MAB";
            labelOperation_MAB.Size = new Size(74, 20);
            labelOperation_MAB.TabIndex = 10;
            labelOperation_MAB.Text = "Команда:";
            // 
            // labelNumOfColumn_MAB
            // 
            labelNumOfColumn_MAB.AutoSize = true;
            labelNumOfColumn_MAB.Location = new Point(61, 113);
            labelNumOfColumn_MAB.Name = "labelNumOfColumn_MAB";
            labelNumOfColumn_MAB.Size = new Size(120, 20);
            labelNumOfColumn_MAB.TabIndex = 9;
            labelNumOfColumn_MAB.Text = "Номер столбца:";
            // 
            // textBoxOperation_MAB
            // 
            textBoxOperation_MAB.Location = new Point(265, 135);
            textBoxOperation_MAB.Name = "textBoxOperation_MAB";
            textBoxOperation_MAB.Size = new Size(105, 27);
            textBoxOperation_MAB.TabIndex = 8;
            // 
            // textBoxNumOfColumn_MAB
            // 
            textBoxNumOfColumn_MAB.Location = new Point(61, 135);
            textBoxNumOfColumn_MAB.Name = "textBoxNumOfColumn_MAB";
            textBoxNumOfColumn_MAB.Size = new Size(105, 27);
            textBoxNumOfColumn_MAB.TabIndex = 7;
            // 
            // labelStatistic_MAB
            // 
            labelStatistic_MAB.AutoSize = true;
            labelStatistic_MAB.Location = new Point(12, 93);
            labelStatistic_MAB.Name = "labelStatistic_MAB";
            labelStatistic_MAB.Size = new Size(87, 20);
            labelStatistic_MAB.TabIndex = 6;
            labelStatistic_MAB.Text = "Статистика:";
            // 
            // buttonSortPopulation_MAB
            // 
            buttonSortPopulation_MAB.Location = new Point(394, 42);
            buttonSortPopulation_MAB.Name = "buttonSortPopulation_MAB";
            buttonSortPopulation_MAB.Size = new Size(125, 31);
            buttonSortPopulation_MAB.TabIndex = 5;
            buttonSortPopulation_MAB.Text = "По населению";
            buttonSortPopulation_MAB.UseVisualStyleBackColor = true;
            buttonSortPopulation_MAB.Click += buttonSortPopulation_MAB_Click;
            // 
            // buttonSortSquare_MAB
            // 
            buttonSortSquare_MAB.Location = new Point(265, 43);
            buttonSortSquare_MAB.Name = "buttonSortSquare_MAB";
            buttonSortSquare_MAB.Size = new Size(123, 30);
            buttonSortSquare_MAB.TabIndex = 4;
            buttonSortSquare_MAB.Text = "По площади";
            buttonSortSquare_MAB.UseVisualStyleBackColor = true;
            buttonSortSquare_MAB.Click += buttonSortSquare_MAB_Click;
            // 
            // labelSort_MAB
            // 
            labelSort_MAB.AutoSize = true;
            labelSort_MAB.Location = new Point(265, 20);
            labelSort_MAB.Name = "labelSort_MAB";
            labelSort_MAB.Size = new Size(95, 20);
            labelSort_MAB.TabIndex = 3;
            labelSort_MAB.Text = "Сортировка:";
            // 
            // buttonSearchInfo_MAB
            // 
            buttonSearchInfo_MAB.Location = new Point(152, 45);
            buttonSearchInfo_MAB.Name = "buttonSearchInfo_MAB";
            buttonSearchInfo_MAB.Size = new Size(103, 28);
            buttonSearchInfo_MAB.TabIndex = 2;
            buttonSearchInfo_MAB.Text = "Найти";
            toolTipInfo_MAB.SetToolTip(buttonSearchInfo_MAB, "Находит объект по названию");
            buttonSearchInfo_MAB.UseVisualStyleBackColor = true;
            buttonSearchInfo_MAB.Click += buttonSearchInfo_MAB_Click;
            // 
            // textBoxSearch_MAB
            // 
            textBoxSearch_MAB.Location = new Point(12, 46);
            textBoxSearch_MAB.Name = "textBoxSearch_MAB";
            textBoxSearch_MAB.Size = new Size(136, 27);
            textBoxSearch_MAB.TabIndex = 1;
            // 
            // labelSearchInfo_MAB
            // 
            labelSearchInfo_MAB.AutoSize = true;
            labelSearchInfo_MAB.Location = new Point(12, 23);
            labelSearchInfo_MAB.Name = "labelSearchInfo_MAB";
            labelSearchInfo_MAB.Size = new Size(55, 20);
            labelSearchInfo_MAB.TabIndex = 0;
            labelSearchInfo_MAB.Text = "Поиск:";
            // 
            // panelInputData_MAB
            // 
            panelInputData_MAB.Controls.Add(groupBoxInPutData_MAB);
            panelInputData_MAB.Location = new Point(0, 284);
            panelInputData_MAB.Name = "panelInputData_MAB";
            panelInputData_MAB.Size = new Size(522, 271);
            panelInputData_MAB.TabIndex = 3;
            // 
            // groupBoxInPutData_MAB
            // 
            groupBoxInPutData_MAB.Controls.Add(dataGridViewInPutData_MAB);
            groupBoxInPutData_MAB.Dock = DockStyle.Fill;
            groupBoxInPutData_MAB.Location = new Point(0, 0);
            groupBoxInPutData_MAB.Name = "groupBoxInPutData_MAB";
            groupBoxInPutData_MAB.Size = new Size(522, 271);
            groupBoxInPutData_MAB.TabIndex = 0;
            groupBoxInPutData_MAB.TabStop = false;
            groupBoxInPutData_MAB.Text = "Ввод данных";
            // 
            // dataGridViewInPutData_MAB
            // 
            dataGridViewInPutData_MAB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPutData_MAB.Columns.AddRange(new DataGridViewColumn[] { ColumnCountryIn_MAB, ColumnStolIn_MAB, ColumnPopulIn_MAB, ColumnSquareIn_MAB, ColumnEconomy_MAB, ColumnPrPopulIn_MAB });
            dataGridViewInPutData_MAB.Dock = DockStyle.Fill;
            dataGridViewInPutData_MAB.Location = new Point(3, 23);
            dataGridViewInPutData_MAB.Name = "dataGridViewInPutData_MAB";
            dataGridViewInPutData_MAB.RowHeadersVisible = false;
            dataGridViewInPutData_MAB.RowHeadersWidth = 51;
            dataGridViewInPutData_MAB.Size = new Size(516, 245);
            dataGridViewInPutData_MAB.TabIndex = 0;
            // 
            // ColumnCountryIn_MAB
            // 
            ColumnCountryIn_MAB.HeaderText = "Страна";
            ColumnCountryIn_MAB.MinimumWidth = 6;
            ColumnCountryIn_MAB.Name = "ColumnCountryIn_MAB";
            ColumnCountryIn_MAB.Resizable = DataGridViewTriState.False;
            ColumnCountryIn_MAB.Width = 125;
            // 
            // ColumnStolIn_MAB
            // 
            ColumnStolIn_MAB.HeaderText = "Столица";
            ColumnStolIn_MAB.MinimumWidth = 6;
            ColumnStolIn_MAB.Name = "ColumnStolIn_MAB";
            ColumnStolIn_MAB.Resizable = DataGridViewTriState.False;
            ColumnStolIn_MAB.Width = 125;
            // 
            // ColumnPopulIn_MAB
            // 
            ColumnPopulIn_MAB.HeaderText = "Население";
            ColumnPopulIn_MAB.MinimumWidth = 6;
            ColumnPopulIn_MAB.Name = "ColumnPopulIn_MAB";
            ColumnPopulIn_MAB.Resizable = DataGridViewTriState.False;
            ColumnPopulIn_MAB.Width = 125;
            // 
            // ColumnSquareIn_MAB
            // 
            ColumnSquareIn_MAB.HeaderText = "Площадь";
            ColumnSquareIn_MAB.MinimumWidth = 6;
            ColumnSquareIn_MAB.Name = "ColumnSquareIn_MAB";
            ColumnSquareIn_MAB.Resizable = DataGridViewTriState.False;
            ColumnSquareIn_MAB.Width = 125;
            // 
            // ColumnEconomy_MAB
            // 
            ColumnEconomy_MAB.HeaderText = "Экономически развита";
            ColumnEconomy_MAB.MinimumWidth = 6;
            ColumnEconomy_MAB.Name = "ColumnEconomy_MAB";
            ColumnEconomy_MAB.Resizable = DataGridViewTriState.False;
            ColumnEconomy_MAB.Width = 125;
            // 
            // ColumnPrPopulIn_MAB
            // 
            ColumnPrPopulIn_MAB.HeaderText = "Преобладающее население";
            ColumnPrPopulIn_MAB.MinimumWidth = 6;
            ColumnPrPopulIn_MAB.Name = "ColumnPrPopulIn_MAB";
            ColumnPrPopulIn_MAB.Resizable = DataGridViewTriState.False;
            ColumnPrPopulIn_MAB.Width = 125;
            // 
            // panelOutputData_MAB
            // 
            panelOutputData_MAB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOutputData_MAB.Controls.Add(groupBoxOutPutData_MAB);
            panelOutputData_MAB.Location = new Point(528, 284);
            panelOutputData_MAB.Name = "panelOutputData_MAB";
            panelOutputData_MAB.Size = new Size(539, 271);
            panelOutputData_MAB.TabIndex = 4;
            // 
            // groupBoxOutPutData_MAB
            // 
            groupBoxOutPutData_MAB.Controls.Add(dataGridViewOutPutData_MAB);
            groupBoxOutPutData_MAB.Dock = DockStyle.Fill;
            groupBoxOutPutData_MAB.Location = new Point(0, 0);
            groupBoxOutPutData_MAB.Name = "groupBoxOutPutData_MAB";
            groupBoxOutPutData_MAB.Size = new Size(539, 271);
            groupBoxOutPutData_MAB.TabIndex = 0;
            groupBoxOutPutData_MAB.TabStop = false;
            groupBoxOutPutData_MAB.Text = "Вывод данных";
            // 
            // dataGridViewOutPutData_MAB
            // 
            dataGridViewOutPutData_MAB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPutData_MAB.Columns.AddRange(new DataGridViewColumn[] { ColumnCountryOut_MAB, ColumnStolOut_MAB, ColumnPopulationOut_MAB, ColumnSquareOut_MAB, ColumnEconomyOut_MAB, ColumnPrOut_MAB });
            dataGridViewOutPutData_MAB.Dock = DockStyle.Fill;
            dataGridViewOutPutData_MAB.Location = new Point(3, 23);
            dataGridViewOutPutData_MAB.Name = "dataGridViewOutPutData_MAB";
            dataGridViewOutPutData_MAB.RowHeadersVisible = false;
            dataGridViewOutPutData_MAB.RowHeadersWidth = 51;
            dataGridViewOutPutData_MAB.Size = new Size(533, 245);
            dataGridViewOutPutData_MAB.TabIndex = 0;
            // 
            // ColumnCountryOut_MAB
            // 
            ColumnCountryOut_MAB.HeaderText = "Страна";
            ColumnCountryOut_MAB.MinimumWidth = 6;
            ColumnCountryOut_MAB.Name = "ColumnCountryOut_MAB";
            ColumnCountryOut_MAB.Width = 125;
            // 
            // ColumnStolOut_MAB
            // 
            ColumnStolOut_MAB.HeaderText = "Столица";
            ColumnStolOut_MAB.MinimumWidth = 6;
            ColumnStolOut_MAB.Name = "ColumnStolOut_MAB";
            ColumnStolOut_MAB.Width = 125;
            // 
            // ColumnPopulationOut_MAB
            // 
            ColumnPopulationOut_MAB.HeaderText = "Население";
            ColumnPopulationOut_MAB.MinimumWidth = 6;
            ColumnPopulationOut_MAB.Name = "ColumnPopulationOut_MAB";
            ColumnPopulationOut_MAB.Width = 125;
            // 
            // ColumnSquareOut_MAB
            // 
            ColumnSquareOut_MAB.HeaderText = "Площадь";
            ColumnSquareOut_MAB.MinimumWidth = 6;
            ColumnSquareOut_MAB.Name = "ColumnSquareOut_MAB";
            ColumnSquareOut_MAB.Width = 125;
            // 
            // ColumnEconomyOut_MAB
            // 
            ColumnEconomyOut_MAB.HeaderText = "Экономически развита";
            ColumnEconomyOut_MAB.MinimumWidth = 6;
            ColumnEconomyOut_MAB.Name = "ColumnEconomyOut_MAB";
            ColumnEconomyOut_MAB.Width = 125;
            // 
            // ColumnPrOut_MAB
            // 
            ColumnPrOut_MAB.HeaderText = "Преобладающее население";
            ColumnPrOut_MAB.MinimumWidth = 6;
            ColumnPrOut_MAB.Name = "ColumnPrOut_MAB";
            ColumnPrOut_MAB.Width = 125;
            // 
            // toolTipInfo_MAB
            // 
            toolTipInfo_MAB.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogLibrary_MAB
            // 
            openFileDialogLibrary_MAB.FileName = "openFileDialog";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 554);
            Controls.Add(panelOutputData_MAB);
            Controls.Add(panelInputData_MAB);
            Controls.Add(panelOperation_MAB);
            Controls.Add(panelChart_MAB);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(1090, 605);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "География";
            panelChart_MAB.ResumeLayout(false);
            groupBoxChart_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStatistic_MAB).EndInit();
            panelOperation_MAB.ResumeLayout(false);
            groupBoxOperation_MAB.ResumeLayout(false);
            groupBoxOperation_MAB.PerformLayout();
            panelInputData_MAB.ResumeLayout(false);
            groupBoxInPutData_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutData_MAB).EndInit();
            panelOutputData_MAB.ResumeLayout(false);
            groupBoxOutPutData_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutData_MAB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelChart_MAB;
        private Panel panelOperation_MAB;
        private Panel panelInputData_MAB;
        private Panel panelOutputData_MAB;
        private GroupBox groupBoxChart_MAB;
        private GroupBox groupBoxOperation_MAB;
        private GroupBox groupBoxInPutData_MAB;
        private GroupBox groupBoxOutPutData_MAB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic_MAB;
        private DataGridView dataGridViewInPutData_MAB;
        private DataGridView dataGridViewOutPutData_MAB;
        private DataGridViewTextBoxColumn ColumnCountryIn_MAB;
        private DataGridViewTextBoxColumn ColumnStolIn_MAB;
        private DataGridViewTextBoxColumn ColumnPopulIn_MAB;
        private DataGridViewTextBoxColumn ColumnSquareIn_MAB;
        private DataGridViewTextBoxColumn ColumnEconomy_MAB;
        private DataGridViewTextBoxColumn ColumnPrPopulIn_MAB;
        private DataGridViewTextBoxColumn ColumnCountryOut_MAB;
        private DataGridViewTextBoxColumn ColumnStolOut_MAB;
        private DataGridViewTextBoxColumn ColumnPopulationOut_MAB;
        private DataGridViewTextBoxColumn ColumnSquareOut_MAB;
        private DataGridViewTextBoxColumn ColumnEconomyOut_MAB;
        private DataGridViewTextBoxColumn ColumnPrOut_MAB;
        private Button buttonSearchInfo_MAB;
        private TextBox textBoxSearch_MAB;
        private Label labelSearchInfo_MAB;
        private Label labelSort_MAB;
        private ToolTip toolTipInfo_MAB;
        private Button buttonSortPopulation_MAB;
        private Button buttonSortSquare_MAB;
        private Label labelOperation_MAB;
        private Label labelNumOfColumn_MAB;
        private TextBox textBoxOperation_MAB;
        private TextBox textBoxNumOfColumn_MAB;
        private Label labelStatistic_MAB;
        private TextBox textBoxResStatistic_MAB;
        private Label labelResStatistic_MAB;
        private Button buttonStatistic_MAB;
        private Button buttonTask_MAB;
        private Button buttonInfo_MAB;
        private Button buttonSaveFile_MAB;
        private Button buttonOpenFile_MAB;
        private OpenFileDialog openFileDialogLibrary_MAB;
        private SaveFileDialog saveFileDialogLibrary_MAB;
    }
}
