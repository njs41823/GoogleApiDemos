namespace MapsDistanceMatrix.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.ApiDemoButton = new System.Windows.Forms.Button();
            this.ShippingDataDemoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApiDemoButton
            // 
            this.ApiDemoButton.Location = new System.Drawing.Point(12, 13);
            this.ApiDemoButton.Name = "ApiDemoButton";
            this.ApiDemoButton.Size = new System.Drawing.Size(244, 26);
            this.ApiDemoButton.TabIndex = 0;
            this.ApiDemoButton.Text = "API Demo";
            this.ApiDemoButton.UseVisualStyleBackColor = true;
            this.ApiDemoButton.Click += new System.EventHandler(this.ApiDemoButton_Click);
            // 
            // ShippingDataDemoButton
            // 
            this.ShippingDataDemoButton.Location = new System.Drawing.Point(12, 45);
            this.ShippingDataDemoButton.Name = "ShippingDataDemoButton";
            this.ShippingDataDemoButton.Size = new System.Drawing.Size(244, 26);
            this.ShippingDataDemoButton.TabIndex = 1;
            this.ShippingDataDemoButton.Text = "Shipping Data Demo";
            this.ShippingDataDemoButton.UseVisualStyleBackColor = true;
            this.ShippingDataDemoButton.Click += new System.EventHandler(this.ShippingDataDemoButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 84);
            this.Controls.Add(this.ShippingDataDemoButton);
            this.Controls.Add(this.ApiDemoButton);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApiDemoButton;
        private System.Windows.Forms.Button ShippingDataDemoButton;
    }
}