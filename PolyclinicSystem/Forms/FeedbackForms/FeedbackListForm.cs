using System;
using System.Data;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.FeedbackForms
{
    public partial class FeedbackListForm : Form
    {
        private DataTable dt = new DataTable();

        private Doctor Doctor;

        public FeedbackListForm(Doctor doctor)
        {
            InitializeComponent();
            Doctor = doctor;
        }

        private void FeedbackListForm_Load(object sender, EventArgs e)
        {
            try
            {
                dt = FeedbackHandler.GetDataTable();
                if ((dt != null) && (dt.Columns.Count > 0))
                {
                    //применить столбцы
                    feedbackDataGrid.DataSource = dt;
                    //отформатировать столбцы
                    feedbackDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    feedbackDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    feedbackDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    feedbackDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //скрыть ID
                    feedbackDataGrid.Columns[0].Visible = false;
                    //загрузить данные
                    feedbackDataGrid.DataSource = FeedbackHandler.FillData(Doctor, dt);
                }
                else
                    throw new Exception("Не удалось загрузить таблицу");
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError(ex.Message);
                Close();
            }
        }

        //отображение формы с информацией о враче
        private void ShowFeedbackForm(DataGridViewRow row)
        {
            if (row.Cells[0].Value != null)
            {
                int ID = Convert.ToInt32(row.Cells[0].Value.ToString());

                //получение отзыва
                Feedback feedback = DataHandler.GetFeedback(ID);

                //отображение формы
                FeedbackForm feedbackForm = new FeedbackForm(feedback);
                feedbackForm.Show();
            }
            else
                MessagesHandler.ShowMessage("Не выбран отзыв");
        }

        private void showFeedbackButton_Click(object sender, EventArgs e)
        {
            if (feedbackDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = feedbackDataGrid.SelectedRows[0];
                ShowFeedbackForm(row);
            }
            else if (feedbackDataGrid.SelectedCells.Count > 0)
            {
                DataGridViewRow row = feedbackDataGrid.SelectedCells[0].OwningRow;
                ShowFeedbackForm(row);
            }
            else
                MessagesHandler.ShowMessage("Не выбран отзыв");
        }
    }
}
