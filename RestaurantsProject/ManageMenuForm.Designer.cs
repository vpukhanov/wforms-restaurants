namespace RestaurantsProject
{
    partial class ManageMenuForm
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
            this.restaurantsDataSet = new RestaurantsProject.RestaurantsDataSet();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.dishesTableAdapter();
            this.tableAdapterManager = new RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager();
            this.dishesDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurant_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDishButton = new System.Windows.Forms.Button();
            this.EditDishButton = new System.Windows.Forms.Button();
            this.DeleteDishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantsDataSet
            // 
            this.restaurantsDataSet.DataSetName = "RestaurantsDataSet";
            this.restaurantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "dishes";
            this.dishesBindingSource.DataSource = this.restaurantsDataSet;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.dishesTableAdapter = this.dishesTableAdapter;
            this.tableAdapterManager.order_itemsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.restaurantsTableAdapter = null;
            this.tableAdapterManager.tablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantsProject.RestaurantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.waitersTableAdapter = null;
            // 
            // dishesDataGridView
            // 
            this.dishesDataGridView.AllowUserToAddRows = false;
            this.dishesDataGridView.AllowUserToDeleteRows = false;
            this.dishesDataGridView.AutoGenerateColumns = false;
            this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.id,
            this.restaurant_id});
            this.dishesDataGridView.DataSource = this.dishesBindingSource;
            this.dishesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.dishesDataGridView.MultiSelect = false;
            this.dishesDataGridView.Name = "dishesDataGridView";
            this.dishesDataGridView.ReadOnly = true;
            this.dishesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dishesDataGridView.Size = new System.Drawing.Size(418, 321);
            this.dishesDataGridView.TabIndex = 1;
            this.dishesDataGridView.SelectionChanged += new System.EventHandler(this.dishesDataGridView_SelectionChanged);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 70F;
            this.name.HeaderText = "Блюдо";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 30F;
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // restaurant_id
            // 
            this.restaurant_id.DataPropertyName = "restaurant_id";
            this.restaurant_id.HeaderText = "restaurant_id";
            this.restaurant_id.Name = "restaurant_id";
            this.restaurant_id.ReadOnly = true;
            this.restaurant_id.Visible = false;
            // 
            // AddDishButton
            // 
            this.AddDishButton.Location = new System.Drawing.Point(12, 340);
            this.AddDishButton.Name = "AddDishButton";
            this.AddDishButton.Size = new System.Drawing.Size(418, 23);
            this.AddDishButton.TabIndex = 2;
            this.AddDishButton.Text = "Добавить блюдо";
            this.AddDishButton.UseVisualStyleBackColor = true;
            this.AddDishButton.Click += new System.EventHandler(this.AddDishButton_Click);
            // 
            // EditDishButton
            // 
            this.EditDishButton.Enabled = false;
            this.EditDishButton.Location = new System.Drawing.Point(12, 370);
            this.EditDishButton.Name = "EditDishButton";
            this.EditDishButton.Size = new System.Drawing.Size(418, 23);
            this.EditDishButton.TabIndex = 3;
            this.EditDishButton.Text = "Изменить блюдо";
            this.EditDishButton.UseVisualStyleBackColor = true;
            this.EditDishButton.Click += new System.EventHandler(this.EditDishButton_Click);
            // 
            // DeleteDishButton
            // 
            this.DeleteDishButton.Enabled = false;
            this.DeleteDishButton.Location = new System.Drawing.Point(12, 400);
            this.DeleteDishButton.Name = "DeleteDishButton";
            this.DeleteDishButton.Size = new System.Drawing.Size(418, 23);
            this.DeleteDishButton.TabIndex = 4;
            this.DeleteDishButton.Text = "Удалить блюдо";
            this.DeleteDishButton.UseVisualStyleBackColor = true;
            this.DeleteDishButton.Click += new System.EventHandler(this.DeleteDishButton_Click);
            // 
            // ManageMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 433);
            this.Controls.Add(this.DeleteDishButton);
            this.Controls.Add(this.EditDishButton);
            this.Controls.Add(this.AddDishButton);
            this.Controls.Add(this.dishesDataGridView);
            this.Name = "ManageMenuForm";
            this.Text = "Управление меню";
            this.Load += new System.EventHandler(this.ManageMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestaurantsDataSet restaurantsDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestaurantsDataSetTableAdapters.dishesTableAdapter dishesTableAdapter;
        private RestaurantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dishesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurant_id;
        private System.Windows.Forms.Button AddDishButton;
        private System.Windows.Forms.Button EditDishButton;
        private System.Windows.Forms.Button DeleteDishButton;
    }
}