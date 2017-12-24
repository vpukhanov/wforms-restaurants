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
    public partial class TableSelectionForm : Form
    {
        public decimal RestaurantId { get; set; }
        public decimal TableNumber { get; set; }

        public bool Success = false;

        public TableSelectionForm()
        {
            InitializeComponent();
        }

        private void TableSelectionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantsDataSet.tables". При необходимости она может быть перемещена или удалена.
            this.tablesTableAdapter.FillNonBusyByRestaurantId(this.restaurantsDataSet.tables, RestaurantId);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TableNumberComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать столик", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TableNumber = (decimal)TableNumberComboBox.SelectedValue;

            Success = true;

            Close();
        }
    }
}
