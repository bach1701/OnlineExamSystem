using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.Presentation.UITest.UITestManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class TestManagment : UserControl
    {
        public TestManagment()
        {
            InitializeComponent();
        }

        private void BtnAddNewTest_Click(object sender, EventArgs e)
        {
            AddNewTest NewTestForm = new AddNewTest();
            Globals.MainForm.AddNewPanelToQueue(NewTestForm);
        }
    }
}
