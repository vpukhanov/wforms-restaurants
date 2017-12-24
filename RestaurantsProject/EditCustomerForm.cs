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
    public partial class EditCustomerForm : Form
    {
        public decimal Money { get; set; }

        public bool Success = false;

        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MoneyNumericUpDown.Value < 0)
            {
                MessageBox.Show("Укажите корректное значение суммы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Money = MoneyNumericUpDown.Value;

            Success = true;

            Close();
        }
    }
}
