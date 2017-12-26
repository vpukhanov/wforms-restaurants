namespace RestaurantsProject
{
    partial class EditOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.restaurantsDataSet = new RestaurantsProject.RestaurantsDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager();
            this.order_itemsTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.order_itemsTableAdapter();
            this.order_itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dish_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dish_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemswithdishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddDishButton = new System.Windows.Forms.Button();
            this.DeleteDishButton = new System.Windows.Forms.Button();
            this.order_items_with_dishTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.order_items_with_dishTableAdapter();
            this.TotalCostValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemswithdishBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantsDataSet
            // 
            this.restaurantsDataSet.DataSetName = "RestaurantsDataSet";
            this.restaurantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.dishesTableAdapter = null;
            this.tableAdapterManager.order_itemsTableAdapter = this.order_itemsTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.restaurantsTableAdapter = null;
            this.tableAdapterManager.tablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.waitersTableAdapter = null;
            // 
            // order_itemsTableAdapter
            // 
            this.order_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // order_itemsBindingSource
            // 
            this.order_itemsBindingSource.DataMember = "order_items";
            this.order_itemsBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // order_itemsDataGridView
            // 
            this.order_itemsDataGridView.AllowUserToAddRows = false;
            this.order_itemsDataGridView.AllowUserToDeleteRows = false;
            this.order_itemsDataGridView.AutoGenerateColumns = false;
            this.order_itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dish_name,
            this.quantity,
            this.cost,
            this.order_id,
            this.dish_id});
            this.order_itemsDataGridView.DataSource = this.orderitemswithdishBindingSource;
            this.order_itemsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.order_itemsDataGridView.MultiSelect = false;
            this.order_itemsDataGridView.Name = "order_itemsDataGridView";
            this.order_itemsDataGridView.ReadOnly = true;
            this.order_itemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.order_itemsDataGridView.Size = new System.Drawing.Size(420, 391);
            this.order_itemsDataGridView.TabIndex = 0;
            this.order_itemsDataGridView.SelectionChanged += new System.EventHandler(this.order_itemsDataGridView_SelectionChanged);
            // 
            // dish_name
            // 
            this.dish_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dish_name.DataPropertyName = "dish_name";
            this.dish_name.FillWeight = 50F;
            this.dish_name.HeaderText = "Блюдо";
            this.dish_name.Name = "dish_name";
            this.dish_name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 20F;
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost.DataPropertyName = "cost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.cost.DefaultCellStyle = dataGridViewCellStyle1;
            this.cost.FillWeight = 30F;
            this.cost.HeaderText = "Стоимость";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "order_id";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Visible = false;
            // 
            // dish_id
            // 
            this.dish_id.DataPropertyName = "dish_id";
            this.dish_id.HeaderText = "dish_id";
            this.dish_id.Name = "dish_id";
            this.dish_id.ReadOnly = true;
            this.dish_id.Visible = false;
            // 
            // orderitemswithdishBindingSource
            // 
            this.orderitemswithdishBindingSource.DataMember = "order_items_with_dish";
            this.orderitemswithdishBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // AddDishButton
            // 
            this.AddDishButton.Location = new System.Drawing.Point(12, 473);
            this.AddDishButton.Name = "AddDishButton";
            this.AddDishButton.Size = new System.Drawing.Size(207, 23);
            this.AddDishButton.TabIndex = 1;
            this.AddDishButton.Text = "Добавить блюдо";
            this.AddDishButton.UseVisualStyleBackColor = true;
            this.AddDishButton.Click += new System.EventHandler(this.AddDishButton_Click);
            // 
            // DeleteDishButton
            // 
            this.DeleteDishButton.Enabled = false;
            this.DeleteDishButton.Location = new System.Drawing.Point(225, 473);
            this.DeleteDishButton.Name = "DeleteDishButton";
            this.DeleteDishButton.Size = new System.Drawing.Size(207, 23);
            this.DeleteDishButton.TabIndex = 2;
            this.DeleteDishButton.Text = "Удалить блюдо";
            this.DeleteDishButton.UseVisualStyleBackColor = true;
            this.DeleteDishButton.Click += new System.EventHandler(this.DeleteDishButton_Click);
            // 
            // order_items_with_dishTableAdapter
            // 
            this.order_items_with_dishTableAdapter.ClearBeforeFill = true;
            // 
            // TotalCostValue
            // 
            this.TotalCostValue.AutoSize = true;
            this.TotalCostValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalCostValue.Location = new System.Drawing.Point(12, 428);
            this.TotalCostValue.Name = "TotalCostValue";
            this.TotalCostValue.Size = new System.Drawing.Size(108, 25);
            this.TotalCostValue.TabIndex = 3;
            this.TotalCostValue.Text = "Итог: 0 ₽";
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 508);
            this.Controls.Add(this.TotalCostValue);
            this.Controls.Add(this.DeleteDishButton);
            this.Controls.Add(this.AddDishButton);
            this.Controls.Add(this.order_itemsDataGridView);
            this.Name = "EditOrderForm";
            this.Text = "Заказ...";
            this.Load += new System.EventHandler(this.EditOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemswithdishBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantsDataSet restaurantsDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RestaurantsDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private RestaurantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RestaurantsDataSetTableAdapters.order_itemsTableAdapter order_itemsTableAdapter;
        private System.Windows.Forms.BindingSource order_itemsBindingSource;
        private System.Windows.Forms.DataGridView order_itemsDataGridView;
        private System.Windows.Forms.Button AddDishButton;
        private System.Windows.Forms.Button DeleteDishButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dish_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dish_id;
        private System.Windows.Forms.BindingSource orderitemswithdishBindingSource;
        private RestaurantsDataSetTableAdapters.order_items_with_dishTableAdapter order_items_with_dishTableAdapter;
        private System.Windows.Forms.Label TotalCostValue;
    }
}