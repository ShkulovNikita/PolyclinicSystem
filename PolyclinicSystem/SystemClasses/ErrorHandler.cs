using System;
using System.Windows.Forms;

namespace PolyclinicSystem
{
    static public class ErrorHandler
    {
        static public void ShowError(string error)
        {
            MessageBox.Show(
                error,
                "Произошла ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        static public void ShowError(Exception exception)
        {
            MessageBox.Show(
                exception.ToString(),
                "Произошла ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
