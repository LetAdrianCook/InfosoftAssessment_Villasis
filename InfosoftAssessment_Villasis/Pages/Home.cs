using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfosoftAssessment_Villasis.Pages
{
    public partial class Home : Form
    {

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btndDefaultColor = Color.FromArgb(159, 82, 85);
        Color btndSelectedColor = SystemColors.Control;
        public Home()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new HomeContent(), new ClientPage(), new PreferencesPage(), new BookingPage(), new InventoryPage(), new ProcessPage(), new ReportsPage() };

            navigationControl = new NavigationControl(userControls, homePanel);
            navigationControl.Display(0);

        }
        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            { homeBtn, clientProfileBtn, preferencesBtn, bookingBtn, inventoryBtn, processBtn, reportsBtn};

            navigationButtons = new NavigationButtons(buttons, btndDefaultColor, btndSelectedColor);
            navigationButtons.Highlight(homeBtn);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(homeBtn);
        }

        private void clientProfileBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(clientProfileBtn);
        }

        private void preferencesBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(preferencesBtn);
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(bookingBtn);
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButtons.Highlight(inventoryBtn);
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
            navigationButtons.Highlight(processBtn);
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(6);
            navigationButtons.Highlight(reportsBtn);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out");
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
