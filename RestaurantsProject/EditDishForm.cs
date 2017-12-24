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
    public partial class EditDishForm : Form
    {
        public string DishName { get; set; }
        public decimal DishPrice { get; set; } = 0;

        public bool Success = false;

        public EditDishForm()
        {
            InitializeComponent();
        }

        private void EditDishForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = DishName;
            DishPriceNumericUpDown.Value = DishPrice;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0 ||  DishPriceNumericUpDown.Value < 0)
            {
                MessageBox.Show("Все поля формы должны быть заполнены!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DishName = NameTextBox.Text;
            DishPrice = DishPriceNumericUpDown.Value;

            Success = true;

            Close();
        }
    }
}
