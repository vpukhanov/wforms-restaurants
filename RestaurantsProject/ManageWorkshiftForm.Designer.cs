namespace RestaurantsProject
{
    partial class ManageWorkshiftForm
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
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsDataSet = new RestaurantsProject.RestaurantsDataSet();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.AssignTableButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.CollectPaymentButton = new System.Windows.Forms.Button();
            this.customersTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager();
            this.tablesTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.tablesTableAdapter();
            this.ordersTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.ordersTableAdapter();
            this.waitersTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.waitersTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_restaurant_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.money,
            this.state_desc,
            this.table_number,
            this.table_restaurant_id,
            this.state});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(192, 12);
            this.customersDataGridView.MultiSelect = false;
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDataGridView.Size = new System.Drawing.Size(497, 341);
            this.customersDataGridView.TabIndex = 1;
            this.customersDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.customersDataGridView_RowsAdded);
            this.customersDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_RowValidated);
            this.customersDataGridView.SelectionChanged += new System.EventHandler(this.customersDataGridView_SelectionChanged);
            this.customersDataGridView.Sorted += new System.EventHandler(this.customersDataGridView_Sorted);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // restaurantsDataSet
            // 
            this.restaurantsDataSet.DataSetName = "RestaurantsDataSet";
            this.restaurantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(12, 12);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(174, 23);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Новый клиент";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Enabled = false;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(12, 41);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(174, 23);
            this.DeleteCustomerButton.TabIndex = 3;
            this.DeleteCustomerButton.Text = "Удалить клиента";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // AssignTableButton
            // 
            this.AssignTableButton.Enabled = false;
            this.AssignTableButton.Location = new System.Drawing.Point(12, 100);
            this.AssignTableButton.Name = "AssignTableButton";
            this.AssignTableButton.Size = new System.Drawing.Size(174, 23);
            this.AssignTableButton.TabIndex = 4;
            this.AssignTableButton.Text = "Посадить за столик";
            this.AssignTableButton.UseVisualStyleBackColor = true;
            this.AssignTableButton.Click += new System.EventHandler(this.AssignTableButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Enabled = false;
            this.AddOrderButton.Location = new System.Drawing.Point(12, 129);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(174, 23);
            this.AddOrderButton.TabIndex = 5;
            this.AddOrderButton.Text = "Записать заказ клиента";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // CollectPaymentButton
            // 
            this.CollectPaymentButton.Enabled = false;
            this.CollectPaymentButton.Location = new System.Drawing.Point(12, 158);
            this.CollectPaymentButton.Name = "CollectPaymentButton";
            this.CollectPaymentButton.Size = new System.Drawing.Size(174, 23);
            this.CollectPaymentButton.TabIndex = 6;
            this.CollectPaymentButton.Text = "Получить оплату";
            this.CollectPaymentButton.UseVisualStyleBackColor = true;
            this.CollectPaymentButton.Click += new System.EventHandler(this.CollectPaymentButton_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.dishesTableAdapter = null;
            this.tableAdapterManager.order_itemsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.restaurantsTableAdapter = null;
            this.tableAdapterManager.tablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.waitersTableAdapter = null;
            // 
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // waitersTableAdapter
            // 
            this.waitersTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 10F;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // money
            // 
            this.money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.money.DataPropertyName = "money";
            dataGridViewCellStyle1.Format = "C2";
            this.money.DefaultCellStyle = dataGridViewCellStyle1;
            this.money.FillWeight = 20F;
            this.money.HeaderText = "Сумма денег";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // state_desc
            // 
            this.state_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.state_desc.FillWeight = 50F;
            this.state_desc.HeaderText = "Состояние";
            this.state_desc.Name = "state_desc";
            this.state_desc.ReadOnly = true;
            // 
            // table_number
            // 
            this.table_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.table_number.DataPropertyName = "table_number";
            this.table_number.FillWeight = 20F;
            this.table_number.HeaderText = "Номер столика";
            this.table_number.Name = "table_number";
            this.table_number.ReadOnly = true;
            // 
            // table_restaurant_id
            // 
            this.table_restaurant_id.DataPropertyName = "table_restaurant_id";
            this.table_restaurant_id.HeaderText = "table_restaurant_id";
            this.table_restaurant_id.Name = "table_restaurant_id";
            this.table_restaurant_id.ReadOnly = true;
            this.table_restaurant_id.Visible = false;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.state.DataPropertyName = "state";
            this.state.FillWeight = 50F;
            this.state.HeaderText = "Состояние (скрытое)";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Visible = false;
            // 
            // ManageWorkshiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 369);
            this.Controls.Add(this.CollectPaymentButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.AssignTableButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.customersDataGridView);
            this.Name = "ManageWorkshiftForm";
            this.Text = "Рабочая смена";
            this.Load += new System.EventHandler(this.ManageWorkshiftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestaurantsDataSet restaurantsDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private RestaurantsDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private RestaurantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button AssignTableButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button CollectPaymentButton;
        private RestaurantsDataSetTableAdapters.tablesTableAdapter tablesTableAdapter;
        private RestaurantsDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private RestaurantsDataSetTableAdapters.waitersTableAdapter waitersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_restaurant_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}