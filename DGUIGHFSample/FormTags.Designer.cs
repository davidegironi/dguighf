#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif

namespace DG.UIGHFSample
{
    partial class FormTags
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
            System.Windows.Forms.Label tags_nameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTags));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_tabTags = new System.Windows.Forms.TabPage();
            this.panel_tabTags_actions = new System.Windows.Forms.Panel();
            this.button_tabTags_new = new System.Windows.Forms.Button();
            this.button_tabTags_edit = new System.Windows.Forms.Button();
            this.button_tabTags_delete = new System.Windows.Forms.Button();
            this.panel_tabTags_updates = new System.Windows.Forms.Panel();
            this.button_tabTags_save = new System.Windows.Forms.Button();
            this.button_tabTags_cancel = new System.Windows.Forms.Button();
            this.panel_tabTags_data = new System.Windows.Forms.Panel();
            this.tags_nameTextBox = new System.Windows.Forms.TextBox();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_list = new System.Windows.Forms.Panel();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.tagsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tags_nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage_tabTags.SuspendLayout();
            this.panel_tabTags_actions.SuspendLayout();
            this.panel_tabTags_updates.SuspendLayout();
            this.panel_tabTags_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            this.panel_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tags_nameLabel
            // 
            tags_nameLabel.AutoSize = true;
            tags_nameLabel.Location = new System.Drawing.Point(5, 9);
            tags_nameLabel.Name = "tags_nameLabel";
            tags_nameLabel.Size = new System.Drawing.Size(59, 13);
            tags_nameLabel.TabIndex = 2;
            tags_nameLabel.Text = "tags name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(324, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 520);
            this.panel1.TabIndex = 0;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_tabTags);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(368, 520);
            this.tabControl_main.TabIndex = 13;
            // 
            // tabPage_tabTags
            // 
            this.tabPage_tabTags.Controls.Add(this.panel_tabTags_actions);
            this.tabPage_tabTags.Controls.Add(this.panel_tabTags_updates);
            this.tabPage_tabTags.Controls.Add(this.panel_tabTags_data);
            this.tabPage_tabTags.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabTags.Name = "tabPage_tabTags";
            this.tabPage_tabTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabTags.Size = new System.Drawing.Size(360, 494);
            this.tabPage_tabTags.TabIndex = 0;
            this.tabPage_tabTags.Text = "Tags";
            this.tabPage_tabTags.UseVisualStyleBackColor = true;
            // 
            // panel_tabTags_actions
            // 
            this.panel_tabTags_actions.Controls.Add(this.button_tabTags_new);
            this.panel_tabTags_actions.Controls.Add(this.button_tabTags_edit);
            this.panel_tabTags_actions.Controls.Add(this.button_tabTags_delete);
            this.panel_tabTags_actions.Location = new System.Drawing.Point(6, 6);
            this.panel_tabTags_actions.Name = "panel_tabTags_actions";
            this.panel_tabTags_actions.Size = new System.Drawing.Size(346, 40);
            this.panel_tabTags_actions.TabIndex = 11;
            // 
            // button_tabTags_new
            // 
            this.button_tabTags_new.Location = new System.Drawing.Point(3, 3);
            this.button_tabTags_new.Name = "button_tabTags_new";
            this.button_tabTags_new.Size = new System.Drawing.Size(75, 23);
            this.button_tabTags_new.TabIndex = 4;
            this.button_tabTags_new.Text = "New";
            this.button_tabTags_new.UseVisualStyleBackColor = true;
            // 
            // button_tabTags_edit
            // 
            this.button_tabTags_edit.Location = new System.Drawing.Point(84, 3);
            this.button_tabTags_edit.Name = "button_tabTags_edit";
            this.button_tabTags_edit.Size = new System.Drawing.Size(75, 23);
            this.button_tabTags_edit.TabIndex = 5;
            this.button_tabTags_edit.Text = "Edit";
            this.button_tabTags_edit.UseVisualStyleBackColor = true;
            // 
            // button_tabTags_delete
            // 
            this.button_tabTags_delete.Location = new System.Drawing.Point(165, 3);
            this.button_tabTags_delete.Name = "button_tabTags_delete";
            this.button_tabTags_delete.Size = new System.Drawing.Size(75, 23);
            this.button_tabTags_delete.TabIndex = 6;
            this.button_tabTags_delete.Text = "Delete";
            this.button_tabTags_delete.UseVisualStyleBackColor = true;
            // 
            // panel_tabTags_updates
            // 
            this.panel_tabTags_updates.Controls.Add(this.button_tabTags_save);
            this.panel_tabTags_updates.Controls.Add(this.button_tabTags_cancel);
            this.panel_tabTags_updates.Location = new System.Drawing.Point(6, 113);
            this.panel_tabTags_updates.Name = "panel_tabTags_updates";
            this.panel_tabTags_updates.Size = new System.Drawing.Size(346, 40);
            this.panel_tabTags_updates.TabIndex = 12;
            // 
            // button_tabTags_save
            // 
            this.button_tabTags_save.Location = new System.Drawing.Point(187, 3);
            this.button_tabTags_save.Name = "button_tabTags_save";
            this.button_tabTags_save.Size = new System.Drawing.Size(75, 23);
            this.button_tabTags_save.TabIndex = 8;
            this.button_tabTags_save.Text = "Save";
            this.button_tabTags_save.UseVisualStyleBackColor = true;
            // 
            // button_tabTags_cancel
            // 
            this.button_tabTags_cancel.Location = new System.Drawing.Point(268, 3);
            this.button_tabTags_cancel.Name = "button_tabTags_cancel";
            this.button_tabTags_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_tabTags_cancel.TabIndex = 9;
            this.button_tabTags_cancel.Text = "Cancel";
            this.button_tabTags_cancel.UseVisualStyleBackColor = true;
            // 
            // panel_tabTags_data
            // 
            this.panel_tabTags_data.Controls.Add(tags_nameLabel);
            this.panel_tabTags_data.Controls.Add(this.tags_nameTextBox);
            this.panel_tabTags_data.Location = new System.Drawing.Point(6, 52);
            this.panel_tabTags_data.Name = "panel_tabTags_data";
            this.panel_tabTags_data.Size = new System.Drawing.Size(346, 55);
            this.panel_tabTags_data.TabIndex = 10;
            // 
            // tags_nameTextBox
            // 
            this.tags_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagsBindingSource, "tags_name", true));
            this.tags_nameTextBox.Location = new System.Drawing.Point(8, 25);
            this.tags_nameTextBox.Name = "tags_nameTextBox";
            this.tags_nameTextBox.Size = new System.Drawing.Size(335, 20);
            this.tags_nameTextBox.TabIndex = 3;
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataSource = typeof(tags);
            // 
            // panel_list
            // 
            this.panel_list.Controls.Add(this.dataGridView_main);
            this.panel_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_list.Location = new System.Drawing.Point(0, 0);
            this.panel_list.Name = "panel_list";
            this.panel_list.Size = new System.Drawing.Size(324, 520);
            this.panel_list.TabIndex = 1;
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_main.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_main.AutoGenerateColumns = false;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagsidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView_main.DataSource = this.vTagsBindingSource;
            this.dataGridView_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_main.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowHeadersVisible = false;
            this.dataGridView_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_main.Size = new System.Drawing.Size(324, 520);
            this.dataGridView_main.TabIndex = 1;
            // 
            // tagsidDataGridViewTextBoxColumn
            // 
            this.tagsidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tagsidDataGridViewTextBoxColumn.DataPropertyName = "tags_id";
            this.tagsidDataGridViewTextBoxColumn.HeaderText = "tags_id";
            this.tagsidDataGridViewTextBoxColumn.Name = "tagsidDataGridViewTextBoxColumn";
            this.tagsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagsidDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vTagsBindingSource
            // 
            this.vTagsBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VTags);
            // 
            // FormTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 520);
            this.Controls.Add(this.panel_list);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTags";
            this.Text = "FormTags";
            this.Load += new System.EventHandler(this.FormTags_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_tabTags.ResumeLayout(false);
            this.panel_tabTags_actions.ResumeLayout(false);
            this.panel_tabTags_updates.ResumeLayout(false);
            this.panel_tabTags_data.ResumeLayout(false);
            this.panel_tabTags_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            this.panel_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTagsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_list;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.BindingSource vTagsBindingSource;
        private System.Windows.Forms.TextBox tags_nameTextBox;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private System.Windows.Forms.Button button_tabTags_delete;
        private System.Windows.Forms.Button button_tabTags_edit;
        private System.Windows.Forms.Button button_tabTags_new;
        private System.Windows.Forms.Panel panel_tabTags_data;
        private System.Windows.Forms.Button button_tabTags_cancel;
        private System.Windows.Forms.Button button_tabTags_save;
        private System.Windows.Forms.Panel panel_tabTags_updates;
        private System.Windows.Forms.Panel panel_tabTags_actions;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_tabTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}