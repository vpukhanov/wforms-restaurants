namespace RestaurantsProject
{
    partial class EditOrderItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DishComboBox = new System.Windows.Forms.ComboBox();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsDataSet = new RestaurantsProject.RestaurantsDataSet();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dishesTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.dishesTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Блюдо:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество:";
            // 
            // DishComboBox
            // 
            this.DishComboBox.DataSource = this.dishesBindingSource;
            this.DishComboBox.DisplayMember = "name";
            this.DishComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DishComboBox.FormattingEnabled = true;
            this.DishComboBox.Location = new System.Drawing.Point(87, 20);
            this.DishComboBox.Name = "DishComboBox";
            this.DishComboBox.Size = new System.Drawing.Size(215, 21);
            this.DishComboBox.TabIndex = 2;
            this.DishComboBox.ValueMember = "id";
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "dishes";
            this.dishesBindingSource.DataSource = this.restaurantsDataSetBindingSource;
            // 
            // restaurantsDataSetBindingSource
            // 
            this.restaurantsDataSetBindingSource.DataSource = this.restaurantsDataSet;
            this.restaurantsDataSetBindingSource.Position = 0;
            // 
            // restaurantsDataSet
            // 
            this.restaurantsDataSet.DataSetName = "RestaurantsDataSet";
            this.restaurantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(87, 51);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.QuantityNumericUpDown.TabIndex = 3;
            this.QuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(15, 77);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(287, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditOrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 108);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.DishComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditOrderItemForm";
            this.Text = "Позиция заказа...";
            this.Load += new System.EventHandler(this.EditOrderItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DishComboBox;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.BindingSource restaurantsDataSetBindingSource;
        private RestaurantsDataSet restaurantsDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestaurantsDataSetTableAdapters.dishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.Button SaveButton;
    }
}