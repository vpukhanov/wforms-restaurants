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
    public partial class EditRestaurantForm : Form
    {
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }

        public bool Success = false;

        public EditRestaurantForm()
        {
            InitializeComponent();
        }

        private void EditRestaurantForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = RestaurantName;
            AddressTextBox.Text = RestaurantAddress;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0 || AddressTextBox.Text.Length == 0)
            {
                MessageBox.Show("Все поля формы должны быть заполнены!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RestaurantName = NameTextBox.Text;
            RestaurantAddress = AddressTextBox.Text;

            Success = true;
            Close();
        }
    }
}
