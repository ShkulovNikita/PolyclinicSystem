using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
