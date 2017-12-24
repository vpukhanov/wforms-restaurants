namespace RestaurantsProject
{
    partial class RestaurantsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.restaurantsDataSet = new RestaurantsProject.RestaurantsDataSet();
            this.restaurantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.restaurantsTableAdapter();
            this.tableAdapterManager = new RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager();
            this.restaurantsDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteRestaurantButton = new System.Windows.Forms.Button();
            this.EditRestaurantButton = new System.Windows.Forms.Button();
            this.AddRestaurantButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManageRestaurantButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantsDataSet
            // 
            this.restaurantsDataSet.DataSetName = "RestaurantsDataSet";
            this.restaurantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantsBindingSource
            // 
            this.restaurantsBindingSource.DataMember = "restaurants";
            this.restaurantsBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // restaurantsTableAdapter
            // 
            this.restaurantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.dishesTableAdapter = null;
            this.tableAdapterManager.order_itemsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.restaurantsTableAdapter = this.restaurantsTableAdapter;
            this.tableAdapterManager.tablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.waitersTableAdapter = null;
            // 
            // restaurantsDataGridView
            // 
            this.restaurantsDataGridView.AllowUserToAddRows = false;
            this.restaurantsDataGridView.AllowUserToDeleteRows = false;
            this.restaurantsDataGridView.AutoGenerateColumns = false;
            this.restaurantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.id});
            this.restaurantsDataGridView.DataSource = this.restaurantsBindingSource;
            this.restaurantsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.restaurantsDataGridView.MultiSelect = false;
            this.restaurantsDataGridView.Name = "restaurantsDataGridView";
            this.restaurantsDataGridView.ReadOnly = true;
            this.restaurantsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.restaurantsDataGridView.Size = new System.Drawing.Size(433, 364);
            this.restaurantsDataGridView.TabIndex = 1;
            this.restaurantsDataGridView.SelectionChanged += new System.EventHandler(this.restaurantsDataGridView_SelectionChanged);
            // 
            // DeleteRestaurantButton
            // 
            this.DeleteRestaurantButton.Enabled = false;
            this.DeleteRestaurantButton.Location = new System.Drawing.Point(12, 440);
            this.DeleteRestaurantButton.Name = "DeleteRestaurantButton";
            this.DeleteRestaurantButton.Size = new System.Drawing.Size(433, 23);
            this.DeleteRestaurantButton.TabIndex = 7;
            this.DeleteRestaurantButton.Text = "Удалить ресторан";
            this.DeleteRestaurantButton.UseVisualStyleBackColor = true;
            this.DeleteRestaurantButton.Click += new System.EventHandler(this.DeleteRestaurantButton_Click);
            // 
            // EditRestaurantButton
            // 
            this.EditRestaurantButton.Enabled = false;
            this.EditRestaurantButton.Location = new System.Drawing.Point(12, 411);
            this.EditRestaurantButton.Name = "EditRestaurantButton";
            this.EditRestaurantButton.Size = new System.Drawing.Size(433, 23);
            this.EditRestaurantButton.TabIndex = 6;
            this.EditRestaurantButton.Text = "Изменить ресторан";
            this.EditRestaurantButton.UseVisualStyleBackColor = true;
            this.EditRestaurantButton.Click += new System.EventHandler(this.EditRestaurantButton_Click);
            // 
            // AddRestaurantButton
            // 
            this.AddRestaurantButton.Location = new System.Drawing.Point(12, 382);
            this.AddRestaurantButton.Name = "AddRestaurantButton";
            this.AddRestaurantButton.Size = new System.Drawing.Size(433, 23);
            this.AddRestaurantButton.TabIndex = 5;
            this.AddRestaurantButton.Text = "Добавить ресторан";
            this.AddRestaurantButton.UseVisualStyleBackColor = true;
            this.AddRestaurantButton.Click += new System.EventHandler(this.AddRestaurantButton_Click);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 40F;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.FillWeight = 60F;
            this.address.HeaderText = "Юридический адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ManageRestaurantButton
            // 
            this.ManageRestaurantButton.Enabled = false;
            this.ManageRestaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManageRestaurantButton.Location = new System.Drawing.Point(12, 483);
            this.ManageRestaurantButton.Name = "ManageRestaurantButton";
            this.ManageRestaurantButton.Size = new System.Drawing.Size(433, 37);
            this.ManageRestaurantButton.TabIndex = 8;
            this.ManageRestaurantButton.Text = "Управлять рестораном";
            this.ManageRestaurantButton.UseVisualStyleBackColor = true;
            this.ManageRestaurantButton.Click += new System.EventHandler(this.ManageRestaurantButton_Click);
            // 
            // RestaurantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 532);
            this.Controls.Add(this.ManageRestaurantButton);
            this.Controls.Add(this.DeleteRestaurantButton);
            this.Controls.Add(this.EditRestaurantButton);
            this.Controls.Add(this.AddRestaurantButton);
            this.Controls.Add(this.restaurantsDataGridView);
            this.Name = "RestaurantsForm";
            this.Text = "Список ресторанов";
            this.Load += new System.EventHandler(this.RestaurantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestaurantsDataSet restaurantsDataSet;
        private System.Windows.Forms.BindingSource restaurantsBindingSource;
        private RestaurantsDataSetTableAdapters.restaurantsTableAdapter restaurantsTableAdapter;
        private RestaurantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView restaurantsDataGridView;
        private System.Windows.Forms.Button DeleteRestaurantButton;
        private System.Windows.Forms.Button EditRestaurantButton;
        private System.Windows.Forms.Button AddRestaurantButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button ManageRestaurantButton;
    }
}

