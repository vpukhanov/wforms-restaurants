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
    public partial class EditTableForm : Form
    {
        public decimal TableNumber { get; set; } = 0;

        public bool Success = false;

        public EditTableForm()
        {
            InitializeComponent();
        }

        private void EditTableForm_Load(object sender, EventArgs e)
        {
            NumberNumericUpDown.Value = TableNumber;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NumberNumericUpDown.Value < 0)
            {
                MessageBox.Show("Все поля формы должны быть заполнены!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TableNumber = NumberNumericUpDown.Value;

            Success = true;

            Close();
        }
    }
}
