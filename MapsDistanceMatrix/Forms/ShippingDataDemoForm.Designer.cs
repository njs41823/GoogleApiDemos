namespace MapsDistanceMatrix.Forms
{
    partial class ShippingDataDemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShippingDataDemoForm));
            this.TripsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProcessButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TripsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TripsDataGrid
            // 
            this.TripsDataGrid.AllowUserToAddRows = false;
            this.TripsDataGrid.AllowUserToDeleteRows = false;
            this.TripsDataGrid.AllowUserToResizeRows = false;
            this.TripsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TripsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TripsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripsDataGrid.Location = new System.Drawing.Point(12, 39);
            this.TripsDataGrid.Name = "TripsDataGrid";
            this.TripsDataGrid.ReadOnly = true;
            this.TripsDataGrid.RowHeadersVisible = false;
            this.TripsDataGrid.Size = new System.Drawing.Size(741, 342);
            this.TripsDataGrid.TabIndex = 0;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(13, 8);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ShippingDataDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 393);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.TripsDataGrid);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShippingDataDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shipping Data Demo";
            ((System.ComponentModel.ISupportInitialize)(this.TripsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TripsDataGrid;
        private System.Windows.Forms.Button ProcessButton;
    }
}