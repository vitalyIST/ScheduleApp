namespace ScheduleApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView weekGrid;
        private System.Windows.Forms.Button btnAddEvent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.weekGrid = new System.Windows.Forms.DataGridView();
            this.btnAddEvent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weekGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // weekGrid
            // 
            this.weekGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weekGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayColumn,
            this.eventsColumn});
            this.weekGrid.Location = new System.Drawing.Point(12, 12);
            this.weekGrid.Name = "weekGrid";
            this.weekGrid.RowHeadersVisible = false;
            this.weekGrid.Size = new System.Drawing.Size(760, 400);
            this.weekGrid.TabIndex = 0;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(12, 418);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Добавить событие";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.weekGrid);
            this.Name = "MainForm";
            this.Text = "Планировщик событий";
            ((System.ComponentModel.ISupportInitialize)(this.weekGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn
        {
            Name = "dayColumn",
            HeaderText = "День недели",
            Width = 200 // Устанавливаем ширину столбца
        };

        private System.Windows.Forms.DataGridViewTextBoxColumn eventsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn
        {
            Name = "eventsColumn",
            HeaderText = "События",
            Width = 600 // Устанавливаем ширину столбца
        };
    }
}
