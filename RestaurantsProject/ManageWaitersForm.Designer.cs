namespace RestaurantsProject
{
    partial class ManageWaitersForm
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
            this.waitersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddWaiterButton = new System.Windows.Forms.Button();
            this.DeleteWaiterButton = new System.Windows.Forms.Button();
            this.EditWaiterButton = new System.Windows.Forms.Button();
            this.tablesDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteTableButton = new System.Windows.Forms.Button();
            this.AddTableButton = new System.Windows.Forms.Button();
            this.table_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.restaurant_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiter_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsDataSet = new RestaurantsProject.RestaurantsDataSet();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earned_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earned_pants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waitersTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.waitersTableAdapter();
            this.tableAdapterManager = new RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager();
            this.tablesTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.tablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.waitersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // waitersDataGridView
            // 
            this.waitersDataGridView.AllowUserToAddRows = false;
            this.waitersDataGridView.AllowUserToDeleteRows = false;
            this.waitersDataGridView.AutoGenerateColumns = false;
            this.waitersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.last_name,
            this.first_name,
            this.earned_money,
            this.earned_pants,
            this.id});
            this.waitersDataGridView.DataSource = this.waitersBindingSource;
            this.waitersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.waitersDataGridView.MultiSelect = false;
            this.waitersDataGridView.Name = "waitersDataGridView";
            this.waitersDataGridView.ReadOnly = true;
            this.waitersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.waitersDataGridView.Size = new System.Drawing.Size(650, 336);
            this.waitersDataGridView.TabIndex = 1;
            this.waitersDataGridView.SelectionChanged += new System.EventHandler(this.waitersDataGridView_SelectionChanged);
            // 
            // AddWaiterButton
            // 
            this.AddWaiterButton.Location = new System.Drawing.Point(12, 354);
            this.AddWaiterButton.Name = "AddWaiterButton";
            this.AddWaiterButton.Size = new System.Drawing.Size(212, 23);
            this.AddWaiterButton.TabIndex = 2;
            this.AddWaiterButton.Text = "Добавить официанта";
            this.AddWaiterButton.UseVisualStyleBackColor = true;
            this.AddWaiterButton.Click += new System.EventHandler(this.AddWaiterButton_Click);
            // 
            // DeleteWaiterButton
            // 
            this.DeleteWaiterButton.Enabled = false;
            this.DeleteWaiterButton.Location = new System.Drawing.Point(450, 354);
            this.DeleteWaiterButton.Name = "DeleteWaiterButton";
            this.DeleteWaiterButton.Size = new System.Drawing.Size(212, 23);
            this.DeleteWaiterButton.TabIndex = 3;
            this.DeleteWaiterButton.Text = "Уволить официанта";
            this.DeleteWaiterButton.UseVisualStyleBackColor = true;
            this.DeleteWaiterButton.Click += new System.EventHandler(this.DeleteWaiterButton_Click);
            // 
            // EditWaiterButton
            // 
            this.EditWaiterButton.Enabled = false;
            this.EditWaiterButton.Location = new System.Drawing.Point(230, 354);
            this.EditWaiterButton.Name = "EditWaiterButton";
            this.EditWaiterButton.Size = new System.Drawing.Size(214, 23);
            this.EditWaiterButton.TabIndex = 4;
            this.EditWaiterButton.Text = "Изменить официанта";
            this.EditWaiterButton.UseVisualStyleBackColor = true;
            this.EditWaiterButton.Click += new System.EventHandler(this.EditWaiterButton_Click);
            // 
            // tablesDataGridView
            // 
            this.tablesDataGridView.AllowUserToAddRows = false;
            this.tablesDataGridView.AllowUserToDeleteRows = false;
            this.tablesDataGridView.AutoGenerateColumns = false;
            this.tablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_number,
            this.busy,
            this.restaurant_id,
            this.waiter_id});
            this.tablesDataGridView.DataSource = this.tablesBindingSource;
            this.tablesDataGridView.Location = new System.Drawing.Point(668, 12);
            this.tablesDataGridView.MultiSelect = false;
            this.tablesDataGridView.Name = "tablesDataGridView";
            this.tablesDataGridView.ReadOnly = true;
            this.tablesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablesDataGridView.Size = new System.Drawing.Size(151, 307);
            this.tablesDataGridView.TabIndex = 4;
            this.tablesDataGridView.SelectionChanged += new System.EventHandler(this.tablesDataGridView_SelectionChanged);
            // 
            // DeleteTableButton
            // 
            this.DeleteTableButton.Enabled = false;
            this.DeleteTableButton.Location = new System.Drawing.Point(668, 354);
            this.DeleteTableButton.Name = "DeleteTableButton";
            this.DeleteTableButton.Size = new System.Drawing.Size(151, 23);
            this.DeleteTableButton.TabIndex = 5;
            this.DeleteTableButton.Text = "Удалить столик";
            this.DeleteTableButton.UseVisualStyleBackColor = true;
            this.DeleteTableButton.Click += new System.EventHandler(this.DeleteTableButton_Click);
            // 
            // AddTableButton
            // 
            this.AddTableButton.Enabled = false;
            this.AddTableButton.Location = new System.Drawing.Point(668, 325);
            this.AddTableButton.Name = "AddTableButton";
            this.AddTableButton.Size = new System.Drawing.Size(151, 23);
            this.AddTableButton.TabIndex = 6;
            this.AddTableButton.Text = "Добавить столик";
            this.AddTableButton.UseVisualStyleBackColor = true;
            this.AddTableButton.Click += new System.EventHandler(this.AddTableButton_Click);
            // 
            // table_number
            // 
            this.table_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.table_number.DataPropertyName = "table_number";
            this.table_number.HeaderText = "Номер столика";
            this.table_number.Name = "table_number";
            this.table_number.ReadOnly = true;
            // 
            // busy
            // 
            this.busy.DataPropertyName = "busy";
            this.busy.HeaderText = "busy";
            this.busy.Name = "busy";
            this.busy.ReadOnly = true;
            this.busy.Visible = false;
            // 
            // restaurant_id
            // 
            this.restaurant_id.DataPropertyName = "restaurant_id";
            this.restaurant_id.HeaderText = "restaurant_id";
            this.restaurant_id.Name = "restaurant_id";
            this.restaurant_id.ReadOnly = true;
            this.restaurant_id.Visible = false;
            // 
            // waiter_id
            // 
            this.waiter_id.DataPropertyName = "waiter_id";
            this.waiter_id.HeaderText = "waiter_id";
            this.waiter_id.Name = "waiter_id";
            this.waiter_id.ReadOnly = true;
            this.waiter_id.Visible = false;
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataMember = "tables";
            this.tablesBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // restaurantsDataSet
            // 
            this.restaurantsDataSet.DataSetName = "RestaurantsDataSet";
            this.restaurantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_name.DataPropertyName = "last_name";
            this.last_name.FillWeight = 30F;
            this.last_name.HeaderText = "Фамилия";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.DataPropertyName = "first_name";
            this.first_name.FillWeight = 30F;
            this.first_name.HeaderText = "Имя";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // earned_money
            // 
            this.earned_money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.earned_money.DataPropertyName = "earned_money";
            this.earned_money.FillWeight = 15F;
            this.earned_money.HeaderText = "Заработанные деньги";
            this.earned_money.Name = "earned_money";
            this.earned_money.ReadOnly = true;
            // 
            // earned_pants
            // 
            this.earned_pants.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.earned_pants.DataPropertyName = "earned_pants";
            this.earned_pants.FillWeight = 15F;
            this.earned_pants.HeaderText = "Заработанные \"штаны\"";
            this.earned_pants.Name = "earned_pants";
            this.earned_pants.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // waitersBindingSource
            // 
            this.waitersBindingSource.DataMember = "waiters";
            this.waitersBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // waitersTableAdapter
            // 
            this.waitersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.dishesTableAdapter = null;
            this.tableAdapterManager.order_itemsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.restaurantsTableAdapter = null;
            this.tableAdapterManager.tablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.waitersTableAdapter = this.waitersTableAdapter;
            // 
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // ManageWaitersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 386);
            this.Controls.Add(this.AddTableButton);
            this.Controls.Add(this.DeleteTableButton);
            this.Controls.Add(this.tablesDataGridView);
            this.Controls.Add(this.EditWaiterButton);
            this.Controls.Add(this.DeleteWaiterButton);
            this.Controls.Add(this.AddWaiterButton);
            this.Controls.Add(this.waitersDataGridView);
            this.Name = "ManageWaitersForm";
            this.Text = "Управление официантами и столиками";
            this.Load += new System.EventHandler(this.ManageWaitersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waitersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestaurantsDataSet restaurantsDataSet;
        private System.Windows.Forms.BindingSource waitersBindingSource;
        private RestaurantsDataSetTableAdapters.waitersTableAdapter waitersTableAdapter;
        private RestaurantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView waitersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn earned_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn earned_pants;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button AddWaiterButton;
        private System.Windows.Forms.Button DeleteWaiterButton;
        private System.Windows.Forms.Button EditWaiterButton;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private RestaurantsDataSetTableAdapters.tablesTableAdapter tablesTableAdapter;
        private System.Windows.Forms.DataGridView tablesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_number;
        private System.Windows.Forms.DataGridViewCheckBoxColumn busy;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurant_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiter_id;
        private System.Windows.Forms.Button DeleteTableButton;
        private System.Windows.Forms.Button AddTableButton;
    }
}