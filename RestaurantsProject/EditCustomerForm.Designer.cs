﻿namespace RestaurantsProject
{
    partial class EditCustomerForm
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
            this.MoneyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма денег:";
            // 
            // MoneyNumericUpDown
            // 
            this.MoneyNumericUpDown.DecimalPlaces = 2;
            this.MoneyNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.MoneyNumericUpDown.Location = new System.Drawing.Point(93, 14);
            this.MoneyNumericUpDown.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.MoneyNumericUpDown.Name = "MoneyNumericUpDown";
            this.MoneyNumericUpDown.Size = new System.Drawing.Size(190, 20);
            this.MoneyNumericUpDown.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 46);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(272, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 81);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MoneyNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "EditCustomerForm";
            this.Text = "Новый клиент...";
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MoneyNumericUpDown;
        private System.Windows.Forms.Button SaveButton;
    }
}