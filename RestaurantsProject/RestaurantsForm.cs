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
    public partial class RestaurantsForm : Form
    {
        public RestaurantsForm()
        {
            InitializeComponent();
        }

        private void restaurantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restaurantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantsDataSet);

        }

        private void RestaurantsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantsDataSet.restaurants". При необходимости она может быть перемещена или удалена.
            this.restaurantsTableAdapter.Fill(this.restaurantsDataSet.restaurants);
            restaurantsDataGridView.ClearSelection();
        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            EditRestaurantForm createForm = new EditRestaurantForm();
            createForm.ShowDialog();

            if (createForm.Success)
            {
                var newRestaurant = restaurantsDataSet.restaurants.NewrestaurantsRow();
                newRestaurant.name = createForm.RestaurantName;
                newRestaurant.address = createForm.RestaurantAddress;

                restaurantsDataSet.restaurants.Rows.Add(newRestaurant);
                restaurantsTableAdapter.Update(restaurantsDataSet.restaurants);
            }
        }

        private void restaurantsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ManageRestaurantButton.Enabled = DeleteRestaurantButton.Enabled = 
                EditRestaurantButton.Enabled = restaurantsDataGridView.SelectedRows.Count > 0;
        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            var selectedRow = restaurantsDataGridView.SelectedRows[0];

            EditRestaurantForm editForm = new EditRestaurantForm
            {
                RestaurantName = (string)selectedRow.Cells["name"].Value,
                RestaurantAddress = (string)selectedRow.Cells["address"].Value
            };
            editForm.ShowDialog();

            if (editForm.Success)
            {
                var restaurantRow = restaurantsDataSet.restaurants.FindByid((decimal)selectedRow.Cells["id"].Value);
                restaurantRow.name = editForm.RestaurantName;
                restaurantRow.address = editForm.RestaurantAddress;

                restaurantsTableAdapter.Update(restaurantsDataSet.restaurants);
            }
        }

        private void DeleteRestaurantButton_Click(object sender, EventArgs e)
        {
            var selectedRow = restaurantsDataGridView.SelectedRows[0];

            var confirmation = MessageBox.Show("Вы уверены, что хотите удалить ресторан \"" +
                (string)selectedRow.Cells["name"].Value + "\"?", "Удаление ресторана", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                var restaurantRow = restaurantsDataSet.restaurants.FindByid((decimal)selectedRow.Cells["id"].Value);
                restaurantRow.Delete();
                restaurantsTableAdapter.Update(restaurantsDataSet.restaurants);
            }
        }

        private void ManageRestaurantButton_Click(object sender, EventArgs e)
        {
            var selectedRow = restaurantsDataGridView.SelectedRows[0];

            ManageRestaurantForm manageForm = new ManageRestaurantForm();
            manageForm.MyRestaurant = new DataClasses.Restaurant
            {
                Id = (decimal)selectedRow.Cells["id"].Value,
                Name = (string)selectedRow.Cells["name"].Value,
                Address = (string)selectedRow.Cells["address"].Value
            };
            manageForm.FormClosing += ManageForm_FormClosing;
            manageForm.Show();

            Hide();
        }

        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Show();
        }
    }
}
