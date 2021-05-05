using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolyclinicSystem.Forms.Functions;

namespace PolyclinicSystem.Forms
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void visitsButton_Click(object sender, EventArgs e)
        {
            VisitsListForm visitsForm = new VisitsListForm();
            visitsForm.Show();
        }
    }
}
