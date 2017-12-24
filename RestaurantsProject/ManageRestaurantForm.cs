using RestaurantsProject.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantsProject
{
    public partial class ManageRestaurantForm : Form
    {
        public Restaurant MyRestaurant { get; set; }

        public ManageRestaurantForm()
        {
            InitializeComponent();
        }

        private void ManageRestaurantForm_Load(object sender, EventArgs e)
        {
            Text = "Управление рестораном \"" + MyRestaurant.Name + "\"";
            RestaurantNameLabel.Text = MyRestaurant.Name;
        }

        private void ManageMenuButton_Click(object sender, EventArgs e)
        {
            ManageMenuForm manageMenuForm = new ManageMenuForm
            {
                RestaurantId = MyRestaurant.Id
            };
            manageMenuForm.ShowDialog();
        }

        private void ManageWaitersButton_Click(object sender, EventArgs e)
        {
            ManageWaitersForm manageWaitersForm = new ManageWaitersForm
            {
                RestaurantId = MyRestaurant.Id
            };
            manageWaitersForm.ShowDialog();
        }

        private void StartWorkButton_Click(object sender, EventArgs e)
        {
            ManageWorkshiftForm workshiftForm = new ManageWorkshiftForm
            {
                MyRestaurant = MyRestaurant
            };
            workshiftForm.FormClosing += WorkshiftForm_FormClosing;
            workshiftForm.Show();

            Hide();
        }

        private void WorkshiftForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Show();
        }
    }
}
