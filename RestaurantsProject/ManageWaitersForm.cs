using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantsProject
{
    public partial class ManageWaitersForm : Form
    {
        public decimal RestaurantId { get; set; }

        public ManageWaitersForm()
        {
            InitializeComponent();
        }

        private void waitersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.waitersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantsDataSet);

        }

        private void ManageWaitersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantsDataSet.tables". При необходимости она может быть перемещена или удалена.
            tablesTableAdapter.ClearBeforeFill = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantsDataSet.waiters". При необходимости она может быть перемещена или удалена.
            this.waitersTableAdapter.FillByRestaurantId(this.restaurantsDataSet.waiters, RestaurantId);
            waitersDataGridView.ClearSelection();
            tablesDataGridView.ClearSelection();
        }

        private void waitersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            AddTableButton.Enabled = EditWaiterButton.Enabled = 
                DeleteWaiterButton.Enabled = waitersDataGridView.SelectedRows.Count > 0;

            if (waitersDataGridView.SelectedRows.Count > 0)
            {
                var selectedWaiter = waitersDataGridView.SelectedRows[0];
                var selectedWaiterId = (decimal)selectedWaiter.Cells["id"].Value;

                tablesTableAdapter.FillByRestaurantIdAndWaiterId(restaurantsDataSet.tables, RestaurantId, selectedWaiterId);
            }
            else
            {
                tablesTableAdapter.FillByRestaurantIdAndWaiterId(restaurantsDataSet.tables, -1, -1);
            }
        }

        private void AddWaiterButton_Click(object sender, EventArgs e)
        {
            EditWaiterForm createForm = new EditWaiterForm();
            createForm.ShowDialog();

            if (createForm.Success)
            {
                var newWaiter = restaurantsDataSet.waiters.NewwaitersRow();
                newWaiter.last_name = createForm.WaiterLastName;
                newWaiter.first_name = createForm.WaiterFirstName;
                newWaiter.restaurant_id = RestaurantId;
                newWaiter.earned_money = 0;
                newWaiter.earned_pants = 0;

                restaurantsDataSet.waiters.Rows.Add(newWaiter);
                waitersTableAdapter.Update(restaurantsDataSet.waiters);
            }
        }

        private void EditWaiterButton_Click(object sender, EventArgs e)
        {
            var selectedRow = waitersDataGridView.SelectedRows[0];

            EditWaiterForm editForm = new EditWaiterForm
            {
                WaiterLastName = (string)selectedRow.Cells["last_name"].Value,
                WaiterFirstName = (string)selectedRow.Cells["first_name"].Value
            };
            editForm.ShowDialog();

            if (editForm.Success)
            {
                var waiterRow = restaurantsDataSet.waiters.FindByid((decimal)selectedRow.Cells["id"].Value);
                waiterRow.last_name = editForm.WaiterLastName;
                waiterRow.first_name = editForm.WaiterFirstName;

                waitersTableAdapter.Update(restaurantsDataSet.waiters);
            }
        }

        private void DeleteWaiterButton_Click(object sender, EventArgs e)
        {
            var selectedRow = waitersDataGridView.SelectedRows[0];

            var confirmation = MessageBox.Show("Вы уверены, что хотите уволить официанта: " +
                (string)selectedRow.Cells["last_name"].Value + " " + (string)selectedRow.Cells["first_name"].Value +
                "?", "Увольнение официанта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                var waiterRow = restaurantsDataSet.waiters.FindByid((decimal)selectedRow.Cells["id"].Value);
                waiterRow.Delete();

                waitersTableAdapter.Update(restaurantsDataSet.waiters);
            }
        }

        private void tablesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DeleteTableButton.Enabled = tablesDataGridView.SelectedRows.Count > 0;
        }

        private void AddTableButton_Click(object sender, EventArgs e)
        {
            EditTableForm createForm = new EditTableForm();
            createForm.ShowDialog();

            var selectedWaiter = waitersDataGridView.SelectedRows[0];
            var selectedWaiterId = (decimal)selectedWaiter.Cells["id"].Value;

            if (createForm.Success)
            {
                var newTable = restaurantsDataSet.tables.NewtablesRow();
                newTable.table_number = createForm.TableNumber;
                newTable.restaurant_id = RestaurantId;
                newTable.waiter_id = selectedWaiterId;
                newTable.busy = false;

                try
                {
                    restaurantsDataSet.tables.Rows.Add(newTable);
                    tablesTableAdapter.Update(restaurantsDataSet.tables);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Столик с номером " + createForm.TableNumber + " уже существует в этом ресторане!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        restaurantsDataSet.tables.Rows.Remove(newTable);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при обработке запроса.\nПовторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            var selectedRow = tablesDataGridView.SelectedRows[0];

            var confirmation = MessageBox.Show("Вы уверены, что хотите удалить столик " +
                (decimal)selectedRow.Cells["table_number"].Value + "?", "Удаление столика", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                var tableRow = restaurantsDataSet.tables.FindBytable_numberrestaurant_id((decimal)selectedRow.Cells["table_number"].Value, (decimal)selectedRow.Cells["restaurant_id"].Value);
                tableRow.Delete();

                tablesTableAdapter.Update(restaurantsDataSet.tables);
            }
        }
    }
}
