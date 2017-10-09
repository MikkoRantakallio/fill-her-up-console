namespace FillHerUp
{
    partial class FillingForm
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
            this.fillingTime = new System.Windows.Forms.DateTimePicker();
            this.fillingLicense = new System.Windows.Forms.TextBox();
            this.fillingPrice = new System.Windows.Forms.TextBox();
            this.fillingAmount = new System.Windows.Forms.TextBox();
            this.fillingMileage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fillingTime
            // 
            this.fillingTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillingTime.CustomFormat = "dd.MM.yyyy";
            this.fillingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fillingTime.Location = new System.Drawing.Point(129, 112);
            this.fillingTime.Name = "fillingTime";
            this.fillingTime.Size = new System.Drawing.Size(122, 23);
            this.fillingTime.TabIndex = 0;
            this.fillingTime.Value = new System.DateTime(2017, 10, 9, 0, 0, 0, 0);
            // 
            // fillingLicense
            // 
            this.fillingLicense.Enabled = false;
            this.fillingLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillingLicense.Location = new System.Drawing.Point(129, 86);
            this.fillingLicense.Name = "fillingLicense";
            this.fillingLicense.Size = new System.Drawing.Size(122, 23);
            this.fillingLicense.TabIndex = 1;
            // 
            // fillingPrice
            // 
            this.fillingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillingPrice.Location = new System.Drawing.Point(129, 139);
            this.fillingPrice.Name = "fillingPrice";
            this.fillingPrice.Size = new System.Drawing.Size(122, 23);
            this.fillingPrice.TabIndex = 2;
            // 
            // fillingAmount
            // 
            this.fillingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillingAmount.Location = new System.Drawing.Point(129, 166);
            this.fillingAmount.Name = "fillingAmount";
            this.fillingAmount.Size = new System.Drawing.Size(122, 23);
            this.fillingAmount.TabIndex = 3;
            // 
            // fillingMileage
            // 
            this.fillingMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillingMileage.Location = new System.Drawing.Point(129, 193);
            this.fillingMileage.Name = "fillingMileage";
            this.fillingMileage.Size = new System.Drawing.Size(122, 23);
            this.fillingMileage.TabIndex = 4;
            // 
            // FillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 516);
            this.Controls.Add(this.fillingMileage);
            this.Controls.Add(this.fillingAmount);
            this.Controls.Add(this.fillingPrice);
            this.Controls.Add(this.fillingLicense);
            this.Controls.Add(this.fillingTime);
            this.Name = "FillingForm";
            this.Text = "FillingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fillingTime;
        private System.Windows.Forms.TextBox fillingLicense;
        private System.Windows.Forms.TextBox fillingPrice;
        private System.Windows.Forms.TextBox fillingAmount;
        private System.Windows.Forms.TextBox fillingMileage;
    }
}