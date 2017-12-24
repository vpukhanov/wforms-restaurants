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
    public partial class ManageMenuForm : Form
    {
        public decimal RestaurantId { get; set; }

        public ManageMenuForm()
        {
            InitializeComponent();
        }

        private void dishesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dishesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantsDataSet);

        }

        private void ManageMenuForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantsDataSet.dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.FillByRestaurantId(this.restaurantsDataSet.dishes, RestaurantId);
            dishesDataGridView.ClearSelection();
        }

        private void dishesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            EditDishButton.Enabled = DeleteDishButton.Enabled = dishesDataGridView.SelectedRows.Count > 0;
        }

        private void AddDishButton_Click(object sender, EventArgs e)
        {
            EditDishForm createForm = new EditDishForm();
            createForm.ShowDialog();

            if (createForm.Success)
            {
                var newDish = restaurantsDataSet.dishes.NewdishesRow();
                newDish.name = createForm.DishName;
                newDish.price = createForm.DishPrice;
                newDish.restaurant_id = RestaurantId;

                restaurantsDataSet.dishes.Rows.Add(newDish);
                dishesTableAdapter.Update(restaurantsDataSet.dishes);
            }
        }

        private void EditDishButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dishesDataGridView.SelectedRows[0];

            EditDishForm editForm = new EditDishForm
            {
                DishName = (string)selectedRow.Cells["name"].Value,
                DishPrice = (decimal)selectedRow.Cells["price"].Value
            };
            editForm.ShowDialog();

            if (editForm.Success)
            {
                var dishRow = restaurantsDataSet.dishes.FindByid((decimal)selectedRow.Cells["id"].Value);
                dishRow.name = editForm.DishName;
                dishRow.price = editForm.DishPrice;

                dishesTableAdapter.Update(restaurantsDataSet.dishes);
            }
        }

        private void DeleteDishButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dishesDataGridView.SelectedRows[0];

            var confirmation = MessageBox.Show("Вы уверены, что хотите удалить блюдо \"" +
                (string)selectedRow.Cells["name"].Value + "\"?", "Удаление блюда", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                var dishRow = restaurantsDataSet.dishes.FindByid((decimal)selectedRow.Cells["id"].Value);
                dishRow.Delete();
                dishesTableAdapter.Update(restaurantsDataSet.dishes);
            }
        }
    }
}
