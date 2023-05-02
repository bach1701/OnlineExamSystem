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
    public partial class MainPage : Form
    {
        private UserInformation userInfoDock;
        private TestManagment testDock;
        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CreateDockForm()
        {
            userInfoDock = new UserInformation();
            userInfoDock.Dock = DockStyle.Fill;

            testDock = new TestManagment();
            testDock.Dock = DockStyle.Fill;
        }
        private void BringUpFrontDock(object sender)
        {
            PanelContent.Controls.Clear();
            PanelContent.Controls.Add((Control)sender);
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

            CreateDockForm();

            BringUpFrontDock(userInfoDock);
            //PanelContent.Controls["UserInformation"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BringUpFrontDock(userInfoDock);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BringUpFrontDock(testDock);
        }
    }
}
