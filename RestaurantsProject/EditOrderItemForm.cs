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
    public partial class EditOrderItemForm : Form
    {
        public decimal OrderId { get; set; }

        public decimal DishId { get; set; }
        public decimal Quantity { get; set; } = 0;

        public bool Success = false;

        public EditOrderItemForm()
        {
            InitializeComponent();
        }

        private void EditOrderItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantsDataSet.dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.FillByAvailableForOrderId(this.restaurantsDataSet.dishes, OrderId);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DishComboBox.SelectedIndex < 0 || QuantityNumericUpDown.Value < 1)
            {
                MessageBox.Show("Необходимо заполнить все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DishId = (decimal)DishComboBox.SelectedValue;
            Quantity = QuantityNumericUpDown.Value;

            Success = true;

            Close();
        }
    }
}
