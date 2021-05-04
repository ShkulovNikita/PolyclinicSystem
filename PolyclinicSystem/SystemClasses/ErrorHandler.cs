using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
