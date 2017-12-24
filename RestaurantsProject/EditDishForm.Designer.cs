namespace RestaurantsProject
{
    partial class EditDishForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DishPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DishPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(80, 13);
            this.NameTextBox.MaxLength = 256;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(260, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена:";
            // 
            // DishPriceNumericUpDown
            // 
            this.DishPriceNumericUpDown.DecimalPlaces = 2;
            this.DishPriceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.DishPriceNumericUpDown.Location = new System.Drawing.Point(80, 48);
            this.DishPriceNumericUpDown.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.DishPriceNumericUpDown.Name = "DishPriceNumericUpDown";
            this.DishPriceNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.DishPriceNumericUpDown.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 83);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(328, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 119);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DishPriceNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditDishForm";
            this.Text = "Блюдо...";
            this.Load += new System.EventHandler(this.EditDishForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DishPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DishPriceNumericUpDown;
        private System.Windows.Forms.Button SaveButton;
    }
}