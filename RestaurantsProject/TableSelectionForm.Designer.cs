namespace RestaurantsProject
{
    partial class TableSelectionForm
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
            this.TableNumberComboBox = new System.Windows.Forms.ComboBox();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsDataSet = new RestaurantsProject.RestaurantsDataSet();
            this.tablesTableAdapter = new RestaurantsProject.RestaurantsDataSetTableAdapters.tablesTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Столик:";
            // 
            // TableNumberComboBox
            // 
            this.TableNumberComboBox.DataSource = this.tablesBindingSource;
            this.TableNumberComboBox.DisplayMember = "table_number";
            this.TableNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableNumberComboBox.FormattingEnabled = true;
            this.TableNumberComboBox.Location = new System.Drawing.Point(64, 20);
            this.TableNumberComboBox.Name = "TableNumberComboBox";
            this.TableNumberComboBox.Size = new System.Drawing.Size(208, 21);
            this.TableNumberComboBox.TabIndex = 1;
            this.TableNumberComboBox.ValueMember = "table_number";
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
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(15, 57);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(257, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TableSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 93);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TableNumberComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TableSelectionForm";
            this.Text = "Выбрать столик...";
            this.Load += new System.EventHandler(this.TableSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TableNumberComboBox;
        private RestaurantsDataSet restaurantsDataSet;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private RestaurantsDataSetTableAdapters.tablesTableAdapter tablesTableAdapter;
        private System.Windows.Forms.Button SaveButton;
    }
}