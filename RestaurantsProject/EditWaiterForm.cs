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
    public partial class EditWaiterForm : Form
    {
        public string WaiterLastName { get; set; }
        public string WaiterFirstName { get; set; }

        public bool Success = false;

        public EditWaiterForm()
        {
            InitializeComponent();
        }

        private void EditWaiterForm_Load(object sender, EventArgs e)
        {
            LastNameTextBox.Text = WaiterLastName;
            FirstNameTextBox.Text = WaiterFirstName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length == 0 || FirstNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Все поля формы должны быть заполнены!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            WaiterLastName = LastNameTextBox.Text;
            WaiterFirstName = FirstNameTextBox.Text;

            Success = true;

            Close();
        }
    }
}
