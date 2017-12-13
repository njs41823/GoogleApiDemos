namespace MapsDistanceMatrix.Views
{
    partial class ResponseView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponseView));
            this.ResponseDataGrid = new System.Windows.Forms.DataGridView();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationInTraffic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseDataGridPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ResponseDataGrid)).BeginInit();
            this.ResponseDataGridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResponseDataGrid
            // 
            this.ResponseDataGrid.AllowUserToAddRows = false;
            this.ResponseDataGrid.AllowUserToDeleteRows = false;
            this.ResponseDataGrid.AllowUserToResizeRows = false;
            this.ResponseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResponseDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ResponseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResponseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origin,
            this.Destination,
            this.Distance,
            this.Duration,
            this.DurationInTraffic,
            this.Fare,
            this.Status});
            this.ResponseDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ResponseDataGrid.MultiSelect = false;
            this.ResponseDataGrid.Name = "ResponseDataGrid";
            this.ResponseDataGrid.ReadOnly = true;
            this.ResponseDataGrid.RowHeadersVisible = false;
            this.ResponseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResponseDataGrid.Size = new System.Drawing.Size(896, 290);
            this.ResponseDataGrid.TabIndex = 0;
            // 
            // Origin
            // 
            this.Origin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Origin.DataPropertyName = "Origin";
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            this.Origin.Width = 61;
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 89;
            // 
            // Distance
            // 
            this.Distance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Distance.DataPropertyName = "Distance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Distance.DefaultCellStyle = dataGridViewCellStyle2;
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Width = 76;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 74;
            // 
            // DurationInTraffic
            // 
            this.DurationInTraffic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DurationInTraffic.DataPropertyName = "DurationInTraffic";
            this.DurationInTraffic.HeaderText = "Duration in Traffic";
            this.DurationInTraffic.Name = "DurationInTraffic";
            this.DurationInTraffic.ReadOnly = true;
            this.DurationInTraffic.Width = 123;
            // 
            // Fare
            // 
            this.Fare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fare.DataPropertyName = "Fare";
            this.Fare.HeaderText = "Fare";
            this.Fare.Name = "Fare";
            this.Fare.ReadOnly = true;
            this.Fare.Width = 54;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ResponseDataGridPanel
            // 
            this.ResponseDataGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseDataGridPanel.Controls.Add(this.ResponseDataGrid);
            this.ResponseDataGridPanel.Location = new System.Drawing.Point(12, 12);
            this.ResponseDataGridPanel.Name = "ResponseDataGridPanel";
            this.ResponseDataGridPanel.Size = new System.Drawing.Size(896, 290);
            this.ResponseDataGridPanel.TabIndex = 1;
            // 
            // ResponseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 314);
            this.Controls.Add(this.ResponseDataGridPanel);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResponseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Response View";
            ((System.ComponentModel.ISupportInitialize)(this.ResponseDataGrid)).EndInit();
            this.ResponseDataGridPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResponseDataGrid;
        private System.Windows.Forms.Panel ResponseDataGridPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationInTraffic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}