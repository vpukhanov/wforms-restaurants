namespace RestaurantsProject
{
    partial class ManageRestaurantForm
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
            this.RestaurantNameLabel = new System.Windows.Forms.Label();
            this.ManageMenuButton = new System.Windows.Forms.Button();
            this.ManageWaitersButton = new System.Windows.Forms.Button();
            this.StartWorkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RestaurantNameLabel
            // 
            this.RestaurantNameLabel.AutoSize = true;
            this.RestaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestaurantNameLabel.Location = new System.Drawing.Point(12, 9);
            this.RestaurantNameLabel.Name = "RestaurantNameLabel";
            this.RestaurantNameLabel.Size = new System.Drawing.Size(279, 25);
            this.RestaurantNameLabel.TabIndex = 0;
            this.RestaurantNameLabel.Text = "НАЗВАНИЕ РЕСТОРАНА";
            // 
            // ManageMenuButton
            // 
            this.ManageMenuButton.Location = new System.Drawing.Point(12, 55);
            this.ManageMenuButton.Name = "ManageMenuButton";
            this.ManageMenuButton.Size = new System.Drawing.Size(342, 23);
            this.ManageMenuButton.TabIndex = 1;
            this.ManageMenuButton.Text = "Управление меню";
            this.ManageMenuButton.UseVisualStyleBackColor = true;
            this.ManageMenuButton.Click += new System.EventHandler(this.ManageMenuButton_Click);
            // 
            // ManageWaitersButton
            // 
            this.ManageWaitersButton.Location = new System.Drawing.Point(12, 84);
            this.ManageWaitersButton.Name = "ManageWaitersButton";
            this.ManageWaitersButton.Size = new System.Drawing.Size(342, 23);
            this.ManageWaitersButton.TabIndex = 2;
            this.ManageWaitersButton.Text = "Управление официантами и столиками";
            this.ManageWaitersButton.UseVisualStyleBackColor = true;
            this.ManageWaitersButton.Click += new System.EventHandler(this.ManageWaitersButton_Click);
            // 
            // StartWorkButton
            // 
            this.StartWorkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartWorkButton.Location = new System.Drawing.Point(12, 134);
            this.StartWorkButton.Name = "StartWorkButton";
            this.StartWorkButton.Size = new System.Drawing.Size(342, 46);
            this.StartWorkButton.TabIndex = 4;
            this.StartWorkButton.Text = "Открыть смену";
            this.StartWorkButton.UseVisualStyleBackColor = true;
            this.StartWorkButton.Click += new System.EventHandler(this.StartWorkButton_Click);
            // 
            // ManageRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 190);
            this.Controls.Add(this.StartWorkButton);
            this.Controls.Add(this.ManageWaitersButton);
            this.Controls.Add(this.ManageMenuButton);
            this.Controls.Add(this.RestaurantNameLabel);
            this.Name = "ManageRestaurantForm";
            this.Text = "Управление рестораном";
            this.Load += new System.EventHandler(this.ManageRestaurantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantNameLabel;
        private System.Windows.Forms.Button ManageMenuButton;
        private System.Windows.Forms.Button ManageWaitersButton;
        private System.Windows.Forms.Button StartWorkButton;
    }
}