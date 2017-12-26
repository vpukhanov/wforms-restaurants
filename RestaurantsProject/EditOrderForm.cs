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
    public partial class EditOrderForm : Form
    {
        public decimal CustomerId { get; set; }
        public decimal RestaurantId { get; set; }

        public decimal OrderId { get; set; }
        public decimal TotalCost { get; set; } = 0;

        public EditOrderForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantsDataSet);

        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.restaurantsDataSet.orders);

            var newOrder = restaurantsDataSet.orders.NewordersRow();
            newOrder.customer_id = CustomerId;
            newOrder.restaurant_id = RestaurantId;
            restaurantsDataSet.orders.Rows.Add(newOrder);
            ordersTableAdapter.Update(restaurantsDataSet.orders);

            OrderId = newOrder.id;

            order_items_with_dishTableAdapter.FillByOrderId(restaurantsDataSet.order_items_with_dish, OrderId);
            order_itemsDataGridView.ClearSelection();

            updateTotalCost();
        }

        private void AddDishButton_Click(object sender, EventArgs e)
        {
            EditOrderItemForm createForm = new EditOrderItemForm
            {
                OrderId = OrderId
            };
            createForm.ShowDialog();

            if (createForm.Success)
            {
                var newOrderItem = restaurantsDataSet.order_items.Neworder_itemsRow();
                newOrderItem.order_id = OrderId;
                newOrderItem.dish_id = createForm.DishId;
                newOrderItem.quantity = createForm.Quantity;

                restaurantsDataSet.order_items.Rows.Add(newOrderItem);
                order_itemsTableAdapter.Update(restaurantsDataSet.order_items);
                order_items_with_dishTableAdapter.FillByOrderId(restaurantsDataSet.order_items_with_dish, OrderId);

                updateTotalCost();
            }
        }

        private void order_itemsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DeleteDishButton.Enabled = order_itemsDataGridView.SelectedRows.Count > 0;
        }

        private void DeleteDishButton_Click(object sender, EventArgs e)
        {
            var selectedRow = order_itemsDataGridView.SelectedRows[0];

            var confirmation = MessageBox.Show("Вы уверены, что хотите удалить позицию " +
                (string)selectedRow.Cells["dish_name"].Value + "?", "Удалить позицию", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                var orderItemRow = restaurantsDataSet.order_items.FindByorder_iddish_id(
                    (decimal)selectedRow.Cells["order_id"].Value,
                    (decimal)selectedRow.Cells["dish_id"].Value
                );
                orderItemRow.Delete();

                order_itemsTableAdapter.Update(restaurantsDataSet.order_items);
                order_items_with_dishTableAdapter.FillByOrderId(restaurantsDataSet.order_items_with_dish, OrderId);

                updateTotalCost();
            }
        }

        private void updateTotalCost()
        {
            decimal? total = order_items_with_dishTableAdapter.GetTotalByOrderId(OrderId);
            TotalCost = total.HasValue ? total.Value : 0;

            TotalCostValue.Text = "Итог: " + TotalCost.ToString("C2");
        }
    }
}
