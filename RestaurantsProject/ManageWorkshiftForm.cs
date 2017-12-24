using RestaurantsProject.DataClasses;
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
    public partial class ManageWorkshiftForm : Form
    {
        public Restaurant MyRestaurant { get; set; }

        public ManageWorkshiftForm()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantsDataSet);
        }

        private void ManageWorkshiftForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantsDataSet.customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.FillByRestaurantId(this.restaurantsDataSet.customers, MyRestaurant.Id);
            this.tablesTableAdapter.FillByRestaurantId(this.restaurantsDataSet.tables, MyRestaurant.Id);
            customersDataGridView.ClearSelection();

            for (int i = 0; i < customersDataGridView.Rows.Count; i++)
            {
                // Вручную запускаем валидацию (для заполнения вычислимого поля)
                customersDataGridView_RowValidated(null, new DataGridViewCellEventArgs(-1, i));
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            EditCustomerForm createForm = new EditCustomerForm();
            createForm.ShowDialog();

            if (createForm.Success)
            {
                var newCustomer = restaurantsDataSet.customers.NewcustomersRow();
                newCustomer.money = createForm.Money;
                newCustomer.state = 0;
                newCustomer.table_restaurant_id = MyRestaurant.Id;

                restaurantsDataSet.customers.Rows.Add(newCustomer);
                customersTableAdapter.Update(restaurantsDataSet.customers);
            }
        }

        private void customersDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var customerRow = customersDataGridView.Rows[e.RowIndex];
                var state = (decimal)customerRow.Cells["state"].Value;

                string stateDescription = "???";
                switch (state)
                {
                    case 0:
                        stateDescription = "Ожидает столик";
                        break;
                    case 1:
                        stateDescription = "Выбирает блюда";
                        break;
                    case 2:
                        stateDescription = "Обедает";
                        break;
                    case 3:
                        stateDescription = "Покинул ресторан";
                        break;
                }

                customerRow.Cells["state_desc"].Value = stateDescription;
            }
        }

        private void customersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DeleteCustomerButton.Enabled = AssignTableButton.Enabled =
                AddOrderButton.Enabled = CollectPaymentButton.Enabled = false;

            if (customersDataGridView.SelectedRows.Count > 0)
            {
                DeleteCustomerButton.Enabled = true;

                var state = (decimal)customersDataGridView.SelectedRows[0].Cells["state"].Value;

                switch (state)
                {
                    case 0:
                        AssignTableButton.Enabled = true;
                        break;
                    case 1:
                        AddOrderButton.Enabled = true;
                        break;
                    case 2:
                        CollectPaymentButton.Enabled = true;
                        break;
                }
            }
        }

        private void customersDataGridView_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < customersDataGridView.Rows.Count; i++)
            {
                // Вручную запускаем валидацию (для заполнения вычислимого поля)
                customersDataGridView_RowValidated(null, new DataGridViewCellEventArgs(-1, i));
            }
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            var selectedRow = customersDataGridView.SelectedRows[0];
            var customerId = (decimal)selectedRow.Cells["id"].Value;

            var confirmation = MessageBox.Show("Вы уверены, что выгнать клиента " +
                customerId + "?", "Выгнать клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                var customerRow = restaurantsDataSet.customers.FindByid(customerId);
                if (customerRow["table_number"].ToString() != "")
                {
                    // Этим клиентом уже занят столик, нужно его освободить
                    var tableRow = restaurantsDataSet.tables.FindBytable_numberrestaurant_id(customerRow.table_number, MyRestaurant.Id);
                    tableRow.busy = false;
                    tablesTableAdapter.Update(restaurantsDataSet.tables);
                }
                customerRow.Delete();
                customersTableAdapter.Update(restaurantsDataSet.customers);
            }
        }

        private void customersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            customersDataGridView_RowValidated(null, new DataGridViewCellEventArgs(-1, e.RowIndex));
        }

        private void AssignTableButton_Click(object sender, EventArgs e)
        {
            var selectedRow = customersDataGridView.SelectedRows[0];

            TableSelectionForm tableSelectionForm = new TableSelectionForm
            {
                RestaurantId = MyRestaurant.Id
            };
            tableSelectionForm.ShowDialog();

            if (tableSelectionForm.Success)
            {
                var customerRow = restaurantsDataSet.customers.FindByid((decimal)selectedRow.Cells["id"].Value);
                customerRow.table_number = tableSelectionForm.TableNumber;
                customerRow.state = 1;

                var tableRow = restaurantsDataSet.tables.FindBytable_numberrestaurant_id(tableSelectionForm.TableNumber, MyRestaurant.Id);
                tableRow.busy = true;
                tablesTableAdapter.Update(restaurantsDataSet.tables);

                customersTableAdapter.Update(restaurantsDataSet.customers);

                updateUI();
            }
        }

        private void updateUI()
        {
            customersDataGridView_RowValidated(null, new DataGridViewCellEventArgs(-1, customersDataGridView.SelectedRows[0].Index));
            customersDataGridView_SelectionChanged(null, null);
        }
    }
}
