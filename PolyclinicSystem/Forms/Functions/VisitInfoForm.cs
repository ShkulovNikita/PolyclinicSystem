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
    public partial class VisitInfoForm : Form
    {
        private string Type;
        private string Content;

        public VisitInfoForm(string type, string content)
        {
            InitializeComponent();
            Type = type;
            Content = content;

            Text = "Информация о приеме (" + type.ToLower() + ")";
        }

        private void VisitInfoForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = Type;
            infoTextBox.Text = Content;
        }
    }
}
