namespace DG.UI.GHF
{
    partial class DGUIGHFFormDataConsistencyViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGUIGHFFormDataConsistencyViewer));
            this.panel_details = new System.Windows.Forms.Panel();
            this.dataGridView_columns = new System.Windows.Forms.DataGridView();
            this.button_details = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_ignore = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_reload = new System.Windows.Forms.Button();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_columns)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.dataGridView_columns);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.Location = new System.Drawing.Point(0, 106);
            this.panel_details.Name = "panel_details";
            this.panel_details.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.panel_details.Size = new System.Drawing.Size(464, 121);
            this.panel_details.TabIndex = 20;
            // 
            // dataGridView_columns
            // 
            this.dataGridView_columns.AllowUserToAddRows = false;
            this.dataGridView_columns.AllowUserToDeleteRows = false;
            this.dataGridView_columns.AllowUserToResizeColumns = false;
            this.dataGridView_columns.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_columns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_columns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_columns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_columns.Location = new System.Drawing.Point(12, 2);
            this.dataGridView_columns.MultiSelect = false;
            this.dataGridView_columns.Name = "dataGridView_columns";
            this.dataGridView_columns.ReadOnly = true;
            this.dataGridView_columns.RowHeadersVisible = false;
            this.dataGridView_columns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_columns.Size = new System.Drawing.Size(440, 117);
            this.dataGridView_columns.TabIndex = 3;
            this.dataGridView_columns.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_columns_CellFormatting);
            // 
            // button_details
            // 
            this.button_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_details.Location = new System.Drawing.Point(352, 6);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(100, 23);
            this.button_details.TabIndex = 3;
            this.button_details.Text = "> Show Details";
            this.button_details.UseVisualStyleBackColor = true;
            this.button_details.Click += new System.EventHandler(this.button_details_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_details);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 35);
            this.panel2.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_info);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(464, 29);
            this.panel5.TabIndex = 19;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(10, 7);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(441, 15);
            this.label_info.TabIndex = 9;
            this.label_info.Text = "Warning: the underlying values for the current record were changed.";
            // 
            // label_text
            // 
            this.label_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_text.Location = new System.Drawing.Point(10, 0);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(444, 42);
            this.label_text.TabIndex = 17;
            this.label_text.Text = resources.GetString("label_text.Text");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label_text);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 29);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel6.Size = new System.Drawing.Size(464, 42);
            this.panel6.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 106);
            this.panel3.TabIndex = 19;
            // 
            // button_edit
            // 
            this.button_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_edit.Location = new System.Drawing.Point(351, 6);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 23);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_ignore
            // 
            this.button_ignore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ignore.Location = new System.Drawing.Point(139, 6);
            this.button_ignore.Name = "button_ignore";
            this.button_ignore.Size = new System.Drawing.Size(100, 23);
            this.button_ignore.TabIndex = 1;
            this.button_ignore.Text = "Ignore and Save";
            this.button_ignore.UseVisualStyleBackColor = true;
            this.button_ignore.Click += new System.EventHandler(this.button_ignore_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_reload);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_ignore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 35);
            this.panel1.TabIndex = 18;
            // 
            // button_reload
            // 
            this.button_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reload.Location = new System.Drawing.Point(245, 6);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(100, 23);
            this.button_reload.TabIndex = 5;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // ABUIGHFFormDataConsistencyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "ABUIGHFFormDataConsistencyViewer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Consistency Comparer";
            this.Load += new System.EventHandler(this.ABUIGHFFormDataConsistencyViewer_Load);
            this.panel_details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_columns)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.Button button_details;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_ignore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.DataGridView dataGridView_columns;
    }
}