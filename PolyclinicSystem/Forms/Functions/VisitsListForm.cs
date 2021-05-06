﻿using System;
using System.Data;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Functions
{
    public partial class VisitsListForm : Form
    {
        public DataTable dt = new DataTable();

        public VisitsListForm()
        {
            InitializeComponent();
        }

        private void VisitsListForm_Load(object sender, EventArgs e)
        {
            try
            {
                //получить список столбцов для текущего типа пользователя
                dt = VisitsHandler.GetDataTable(MainForm.currentUser);
                if ((dt != null) && (dt.Columns.Count > 0))
                {
                    visitsDataGrid.DataSource = dt;

                    //отформатировать столбцы
                    for (int i = 0; i < visitsDataGrid.Columns.Count; i++)
                    {
                        //если столбец не последний - ширина соответствует контенту
                        if (i != visitsDataGrid.Columns.Count - 1)
                            visitsDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        //последний столбец заполняет оставшееся пространство
                        else
                            visitsDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    visitsDataGrid.Columns[0].Visible = false;

                    //добавить данные
                    visitsDataGrid.DataSource = VisitsHandler.FillData(MainForm.currentUser, dt);
                }
                else
                {
                    throw new Exception("Не удалось загрузить таблицу");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError(ex.Message);
                Close();
            }
        }

        //записаться на прием
        private void addVisit_Click(object sender, EventArgs e)
        {
            AddVisitForm addVisitForm = new AddVisitForm();
            addVisitForm.FormClosed += AddVisitForm_FormClosed;
            addVisitForm.Show();
        }

        //отреагировать на закрытие формы записи на прием
        private void AddVisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //обновить таблицу приемов
            visitsDataGrid.DataSource = VisitsHandler.FillData(MainForm.currentUser, dt);
        }

        //выполнение поиска
        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = searchTextBox.Text;
            //выполнить поиск и обновить таблицу
            visitsDataGrid.DataSource = VisitsHandler.Search(MainForm.currentUser, query, dt);
        }

        //просмотреть информацию о выбранном приеме
        private void infoButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                //получение идентификатора приема
                DataGridViewRow row = visitsDataGrid.SelectedRows[0];
                int ID = Convert.ToInt32(row.Cells[0].Value.ToString());

                //получение самого приема
                DoctorVisit visit = DataHandler.GetDoctorVisit(ID);

                //открытие формы с информацией о приеме
                VisitForm visitForm = new VisitForm(visit);
                visitForm.FormClosed += VisitForm_FormClosed;
                visitForm.Show();
            }
            else
                MessagesHandler.ShowMessage("Не выбран прием у врача");
        }

        //обработка закрытия формы информации о приеме
        private void VisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //обновить таблицу приемов
            visitsDataGrid.DataSource = VisitsHandler.FillData(MainForm.currentUser, dt);
        }
    }
}
