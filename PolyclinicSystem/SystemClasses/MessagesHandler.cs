using System.Windows.Forms;

namespace PolyclinicSystem
{
    class MessagesHandler
    {
        static public void ShowMessage(string message)
        {
            MessageBox.Show(
                message,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
