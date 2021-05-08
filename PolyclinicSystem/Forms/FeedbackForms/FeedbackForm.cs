using System;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.FeedbackForms
{
    public partial class FeedbackForm : Form
    {
        private Feedback Feedback;

        public FeedbackForm(Feedback feedback)
        {
            InitializeComponent();
            Feedback = feedback;
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            try
            {
                ratingLabel.Text = "Оценка: " + Feedback.Rating.ToString();
                infoTextBox.Text = Feedback.Text;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось загрузить информацию об отзыве");
                Close();
            }
        }
    }
}
