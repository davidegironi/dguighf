#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif

namespace DG.UIGHFSample
{
    partial class FormPosts
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
            System.Windows.Forms.Label posts_titleLabel;
            System.Windows.Forms.Label posts_usernameLabel;
            System.Windows.Forms.Label posts_emailLabel;
            System.Windows.Forms.Label posts_textLabel;
            System.Windows.Forms.Label postsadditionals_noteLabel;
            System.Windows.Forms.Label blogs_idLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_tabPosts = new System.Windows.Forms.TabPage();
            this.panel_tabPosts_data = new System.Windows.Forms.Panel();
            this.blogs_idComboBox = new System.Windows.Forms.ComboBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCBlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posts_textTextBox = new System.Windows.Forms.TextBox();
            this.posts_emailTextBox = new System.Windows.Forms.TextBox();
            this.posts_usernameTextBox = new System.Windows.Forms.TextBox();
            this.posts_titleTextBox = new System.Windows.Forms.TextBox();
            this.panel_tabPosts_updates = new System.Windows.Forms.Panel();
            this.button_tabPosts_cancel = new System.Windows.Forms.Button();
            this.button_tabPosts_save = new System.Windows.Forms.Button();
            this.panel_tabPosts_actions = new System.Windows.Forms.Panel();
            this.button_tabPosts_delete = new System.Windows.Forms.Button();
            this.button_tabPosts_edit = new System.Windows.Forms.Button();
            this.button_tabPosts_new = new System.Windows.Forms.Button();
            this.tabPage_tabPostsextra = new System.Windows.Forms.TabPage();
            this.panel_tabPostsextra_data = new System.Windows.Forms.Panel();
            this.tabControl_tabPostsextra = new System.Windows.Forms.TabControl();
            this.tabPage_tabPostsextra_tabPostsadditionals = new System.Windows.Forms.TabPage();
            this.panel_tabPostsextra_tabPostsadditionals_updates = new System.Windows.Forms.Panel();
            this.button_tabPostsextra_tabPostsadditionals_cancel = new System.Windows.Forms.Button();
            this.button_tabPostsextra_tabPostsadditionals_save = new System.Windows.Forms.Button();
            this.panel_tabPostsextra_tabPostsadditionals_data = new System.Windows.Forms.Panel();
            this.postsadditionals_noteTextBox = new System.Windows.Forms.TextBox();
            this.postsadditionalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_tabPostsextra_tabPostsadditionals_actions = new System.Windows.Forms.Panel();
            this.button_tabPostsextra_tabPostsadditionals_edit = new System.Windows.Forms.Button();
            this.tabPage_tabPostsextra_tabPoststotags = new System.Windows.Forms.TabPage();
            this.panel_tabPostsextra_tabPoststotags_actions = new System.Windows.Forms.Panel();
            this.button_tabPostsextra_tabPoststotags_remove = new System.Windows.Forms.Button();
            this.button_tabPostsextra_tabPoststotags_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tabPostsextra_tabPoststotags_tags = new System.Windows.Forms.ComboBox();
            this.panel_tabPostsextra_tabPosttotags_list = new System.Windows.Forms.Panel();
            this.dataGridView_tabPostsextra_tabPoststotags_list = new System.Windows.Forms.DataGridView();
            this.postsidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPostsToTagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_list = new System.Windows.Forms.Panel();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.postsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_filters = new System.Windows.Forms.Panel();
            this.button_messageboxsample = new System.Windows.Forms.Button();
            this.textBox_filter_title = new System.Windows.Forms.TextBox();
            this.panel_add1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_totals = new System.Windows.Forms.TextBox();
            this.poststotagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            posts_titleLabel = new System.Windows.Forms.Label();
            posts_usernameLabel = new System.Windows.Forms.Label();
            posts_emailLabel = new System.Windows.Forms.Label();
            posts_textLabel = new System.Windows.Forms.Label();
            postsadditionals_noteLabel = new System.Windows.Forms.Label();
            blogs_idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage_tabPosts.SuspendLayout();
            this.panel_tabPosts_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCBlogsBindingSource)).BeginInit();
            this.panel_tabPosts_updates.SuspendLayout();
            this.panel_tabPosts_actions.SuspendLayout();
            this.tabPage_tabPostsextra.SuspendLayout();
            this.panel_tabPostsextra_data.SuspendLayout();
            this.tabControl_tabPostsextra.SuspendLayout();
            this.tabPage_tabPostsextra_tabPostsadditionals.SuspendLayout();
            this.panel_tabPostsextra_tabPostsadditionals_updates.SuspendLayout();
            this.panel_tabPostsextra_tabPostsadditionals_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsadditionalsBindingSource)).BeginInit();
            this.panel_tabPostsextra_tabPostsadditionals_actions.SuspendLayout();
            this.tabPage_tabPostsextra_tabPoststotags.SuspendLayout();
            this.panel_tabPostsextra_tabPoststotags_actions.SuspendLayout();
            this.panel_tabPostsextra_tabPosttotags_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostsextra_tabPoststotags_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPostsToTagsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPostsBindingSource)).BeginInit();
            this.panel_filters.SuspendLayout();
            this.panel_add1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poststotagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // posts_titleLabel
            // 
            posts_titleLabel.AutoSize = true;
            posts_titleLabel.Location = new System.Drawing.Point(5, 9);
            posts_titleLabel.Name = "posts_titleLabel";
            posts_titleLabel.Size = new System.Drawing.Size(54, 13);
            posts_titleLabel.TabIndex = 0;
            posts_titleLabel.Text = "posts title:";
            // 
            // posts_usernameLabel
            // 
            posts_usernameLabel.AutoSize = true;
            posts_usernameLabel.Location = new System.Drawing.Point(5, 48);
            posts_usernameLabel.Name = "posts_usernameLabel";
            posts_usernameLabel.Size = new System.Drawing.Size(84, 13);
            posts_usernameLabel.TabIndex = 2;
            posts_usernameLabel.Text = "posts username:";
            // 
            // posts_emailLabel
            // 
            posts_emailLabel.AutoSize = true;
            posts_emailLabel.Location = new System.Drawing.Point(138, 48);
            posts_emailLabel.Name = "posts_emailLabel";
            posts_emailLabel.Size = new System.Drawing.Size(62, 13);
            posts_emailLabel.TabIndex = 4;
            posts_emailLabel.Text = "posts email:";
            // 
            // posts_textLabel
            // 
            posts_textLabel.AutoSize = true;
            posts_textLabel.Location = new System.Drawing.Point(5, 87);
            posts_textLabel.Name = "posts_textLabel";
            posts_textLabel.Size = new System.Drawing.Size(55, 13);
            posts_textLabel.TabIndex = 6;
            posts_textLabel.Text = "posts text:";
            // 
            // postsadditionals_noteLabel
            // 
            postsadditionals_noteLabel.AutoSize = true;
            postsadditionals_noteLabel.Location = new System.Drawing.Point(5, 9);
            postsadditionals_noteLabel.Name = "postsadditionals_noteLabel";
            postsadditionals_noteLabel.Size = new System.Drawing.Size(109, 13);
            postsadditionals_noteLabel.TabIndex = 0;
            postsadditionals_noteLabel.Text = "postsadditionals note:";
            // 
            // blogs_idLabel
            // 
            blogs_idLabel.AutoSize = true;
            blogs_idLabel.Location = new System.Drawing.Point(137, 9);
            blogs_idLabel.Name = "blogs_idLabel";
            blogs_idLabel.Size = new System.Drawing.Size(46, 13);
            blogs_idLabel.TabIndex = 8;
            blogs_idLabel.Text = "blogs id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(312, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 368);
            this.panel1.TabIndex = 0;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_tabPosts);
            this.tabControl_main.Controls.Add(this.tabPage_tabPostsextra);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(372, 368);
            this.tabControl_main.TabIndex = 0;
            // 
            // tabPage_tabPosts
            // 
            this.tabPage_tabPosts.AutoScroll = true;
            this.tabPage_tabPosts.Controls.Add(this.panel_tabPosts_data);
            this.tabPage_tabPosts.Controls.Add(this.panel_tabPosts_updates);
            this.tabPage_tabPosts.Controls.Add(this.panel_tabPosts_actions);
            this.tabPage_tabPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPosts.Name = "tabPage_tabPosts";
            this.tabPage_tabPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPosts.Size = new System.Drawing.Size(364, 342);
            this.tabPage_tabPosts.TabIndex = 0;
            this.tabPage_tabPosts.Text = "Post";
            this.tabPage_tabPosts.UseVisualStyleBackColor = true;
            // 
            // panel_tabPosts_data
            // 
            this.panel_tabPosts_data.Controls.Add(blogs_idLabel);
            this.panel_tabPosts_data.Controls.Add(this.blogs_idComboBox);
            this.panel_tabPosts_data.Controls.Add(posts_textLabel);
            this.panel_tabPosts_data.Controls.Add(this.posts_textTextBox);
            this.panel_tabPosts_data.Controls.Add(posts_emailLabel);
            this.panel_tabPosts_data.Controls.Add(this.posts_emailTextBox);
            this.panel_tabPosts_data.Controls.Add(posts_usernameLabel);
            this.panel_tabPosts_data.Controls.Add(this.posts_usernameTextBox);
            this.panel_tabPosts_data.Controls.Add(posts_titleLabel);
            this.panel_tabPosts_data.Controls.Add(this.posts_titleTextBox);
            this.panel_tabPosts_data.Location = new System.Drawing.Point(7, 52);
            this.panel_tabPosts_data.Name = "panel_tabPosts_data";
            this.panel_tabPosts_data.Size = new System.Drawing.Size(350, 197);
            this.panel_tabPosts_data.TabIndex = 2;
            // 
            // blogs_idComboBox
            // 
            this.blogs_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postsBindingSource, "blogs_id", true));
            this.blogs_idComboBox.DataSource = this.vCBlogsBindingSource;
            this.blogs_idComboBox.DisplayMember = "title";
            this.blogs_idComboBox.FormattingEnabled = true;
            this.blogs_idComboBox.Location = new System.Drawing.Point(140, 24);
            this.blogs_idComboBox.Name = "blogs_idComboBox";
            this.blogs_idComboBox.Size = new System.Drawing.Size(121, 21);
            this.blogs_idComboBox.TabIndex = 9;
            this.blogs_idComboBox.ValueMember = "blogs_id";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataSource = typeof(posts);
            // 
            // vCBlogsBindingSource
            // 
            this.vCBlogsBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VCBlogs);
            // 
            // posts_textTextBox
            // 
            this.posts_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_text", true));
            this.posts_textTextBox.Location = new System.Drawing.Point(8, 103);
            this.posts_textTextBox.Multiline = true;
            this.posts_textTextBox.Name = "posts_textTextBox";
            this.posts_textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.posts_textTextBox.Size = new System.Drawing.Size(337, 80);
            this.posts_textTextBox.TabIndex = 7;
            // 
            // posts_emailTextBox
            // 
            this.posts_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_email", true));
            this.posts_emailTextBox.Location = new System.Drawing.Point(141, 64);
            this.posts_emailTextBox.Name = "posts_emailTextBox";
            this.posts_emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.posts_emailTextBox.TabIndex = 5;
            // 
            // posts_usernameTextBox
            // 
            this.posts_usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_username", true));
            this.posts_usernameTextBox.Location = new System.Drawing.Point(8, 64);
            this.posts_usernameTextBox.Name = "posts_usernameTextBox";
            this.posts_usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.posts_usernameTextBox.TabIndex = 3;
            // 
            // posts_titleTextBox
            // 
            this.posts_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_title", true));
            this.posts_titleTextBox.Location = new System.Drawing.Point(8, 25);
            this.posts_titleTextBox.Name = "posts_titleTextBox";
            this.posts_titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.posts_titleTextBox.TabIndex = 1;
            // 
            // panel_tabPosts_updates
            // 
            this.panel_tabPosts_updates.Controls.Add(this.button_tabPosts_cancel);
            this.panel_tabPosts_updates.Controls.Add(this.button_tabPosts_save);
            this.panel_tabPosts_updates.Location = new System.Drawing.Point(7, 255);
            this.panel_tabPosts_updates.Name = "panel_tabPosts_updates";
            this.panel_tabPosts_updates.Size = new System.Drawing.Size(350, 40);
            this.panel_tabPosts_updates.TabIndex = 1;
            // 
            // button_tabPosts_cancel
            // 
            this.button_tabPosts_cancel.Location = new System.Drawing.Point(270, 3);
            this.button_tabPosts_cancel.Name = "button_tabPosts_cancel";
            this.button_tabPosts_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_tabPosts_cancel.TabIndex = 3;
            this.button_tabPosts_cancel.Text = "Cancel";
            this.button_tabPosts_cancel.UseVisualStyleBackColor = true;
            // 
            // button_tabPosts_save
            // 
            this.button_tabPosts_save.Location = new System.Drawing.Point(189, 3);
            this.button_tabPosts_save.Name = "button_tabPosts_save";
            this.button_tabPosts_save.Size = new System.Drawing.Size(75, 23);
            this.button_tabPosts_save.TabIndex = 2;
            this.button_tabPosts_save.Text = "Save";
            this.button_tabPosts_save.UseVisualStyleBackColor = true;
            this.button_tabPosts_save.Click += new System.EventHandler(this.button_tabPosts_save_Click);
            // 
            // panel_tabPosts_actions
            // 
            this.panel_tabPosts_actions.Controls.Add(this.button_tabPosts_delete);
            this.panel_tabPosts_actions.Controls.Add(this.button_tabPosts_edit);
            this.panel_tabPosts_actions.Controls.Add(this.button_tabPosts_new);
            this.panel_tabPosts_actions.Location = new System.Drawing.Point(6, 6);
            this.panel_tabPosts_actions.Name = "panel_tabPosts_actions";
            this.panel_tabPosts_actions.Size = new System.Drawing.Size(350, 40);
            this.panel_tabPosts_actions.TabIndex = 0;
            // 
            // button_tabPosts_delete
            // 
            this.button_tabPosts_delete.Location = new System.Drawing.Point(165, 3);
            this.button_tabPosts_delete.Name = "button_tabPosts_delete";
            this.button_tabPosts_delete.Size = new System.Drawing.Size(75, 23);
            this.button_tabPosts_delete.TabIndex = 5;
            this.button_tabPosts_delete.Text = "Delete";
            this.button_tabPosts_delete.UseVisualStyleBackColor = true;
            // 
            // button_tabPosts_edit
            // 
            this.button_tabPosts_edit.Location = new System.Drawing.Point(84, 3);
            this.button_tabPosts_edit.Name = "button_tabPosts_edit";
            this.button_tabPosts_edit.Size = new System.Drawing.Size(75, 23);
            this.button_tabPosts_edit.TabIndex = 4;
            this.button_tabPosts_edit.Text = "Edit";
            this.button_tabPosts_edit.UseVisualStyleBackColor = true;
            // 
            // button_tabPosts_new
            // 
            this.button_tabPosts_new.Location = new System.Drawing.Point(3, 3);
            this.button_tabPosts_new.Name = "button_tabPosts_new";
            this.button_tabPosts_new.Size = new System.Drawing.Size(75, 23);
            this.button_tabPosts_new.TabIndex = 3;
            this.button_tabPosts_new.Text = "New";
            this.button_tabPosts_new.UseVisualStyleBackColor = true;
            // 
            // tabPage_tabPostsextra
            // 
            this.tabPage_tabPostsextra.Controls.Add(this.panel_tabPostsextra_data);
            this.tabPage_tabPostsextra.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostsextra.Name = "tabPage_tabPostsextra";
            this.tabPage_tabPostsextra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostsextra.Size = new System.Drawing.Size(364, 342);
            this.tabPage_tabPostsextra.TabIndex = 1;
            this.tabPage_tabPostsextra.Text = "Extra";
            this.tabPage_tabPostsextra.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostsextra_data
            // 
            this.panel_tabPostsextra_data.Controls.Add(this.tabControl_tabPostsextra);
            this.panel_tabPostsextra_data.Location = new System.Drawing.Point(6, 6);
            this.panel_tabPostsextra_data.Name = "panel_tabPostsextra_data";
            this.panel_tabPostsextra_data.Size = new System.Drawing.Size(355, 333);
            this.panel_tabPostsextra_data.TabIndex = 1;
            // 
            // tabControl_tabPostsextra
            // 
            this.tabControl_tabPostsextra.Controls.Add(this.tabPage_tabPostsextra_tabPostsadditionals);
            this.tabControl_tabPostsextra.Controls.Add(this.tabPage_tabPostsextra_tabPoststotags);
            this.tabControl_tabPostsextra.Location = new System.Drawing.Point(3, 8);
            this.tabControl_tabPostsextra.Name = "tabControl_tabPostsextra";
            this.tabControl_tabPostsextra.SelectedIndex = 0;
            this.tabControl_tabPostsextra.Size = new System.Drawing.Size(350, 220);
            this.tabControl_tabPostsextra.TabIndex = 0;
            // 
            // tabPage_tabPostsextra_tabPostsadditionals
            // 
            this.tabPage_tabPostsextra_tabPostsadditionals.Controls.Add(this.panel_tabPostsextra_tabPostsadditionals_updates);
            this.tabPage_tabPostsextra_tabPostsadditionals.Controls.Add(this.panel_tabPostsextra_tabPostsadditionals_data);
            this.tabPage_tabPostsextra_tabPostsadditionals.Controls.Add(this.panel_tabPostsextra_tabPostsadditionals_actions);
            this.tabPage_tabPostsextra_tabPostsadditionals.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostsextra_tabPostsadditionals.Name = "tabPage_tabPostsextra_tabPostsadditionals";
            this.tabPage_tabPostsextra_tabPostsadditionals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostsextra_tabPostsadditionals.Size = new System.Drawing.Size(342, 194);
            this.tabPage_tabPostsextra_tabPostsadditionals.TabIndex = 0;
            this.tabPage_tabPostsextra_tabPostsadditionals.Text = "Additional Info";
            this.tabPage_tabPostsextra_tabPostsadditionals.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostsextra_tabPostsadditionals_updates
            // 
            this.panel_tabPostsextra_tabPostsadditionals_updates.Controls.Add(this.button_tabPostsextra_tabPostsadditionals_cancel);
            this.panel_tabPostsextra_tabPostsadditionals_updates.Controls.Add(this.button_tabPostsextra_tabPostsadditionals_save);
            this.panel_tabPostsextra_tabPostsadditionals_updates.Location = new System.Drawing.Point(5, 148);
            this.panel_tabPostsextra_tabPostsadditionals_updates.Name = "panel_tabPostsextra_tabPostsadditionals_updates";
            this.panel_tabPostsextra_tabPostsadditionals_updates.Size = new System.Drawing.Size(331, 40);
            this.panel_tabPostsextra_tabPostsadditionals_updates.TabIndex = 3;
            // 
            // button_tabPostsextra_tabPostsadditionals_cancel
            // 
            this.button_tabPostsextra_tabPostsadditionals_cancel.Location = new System.Drawing.Point(253, 3);
            this.button_tabPostsextra_tabPostsadditionals_cancel.Name = "button_tabPostsextra_tabPostsadditionals_cancel";
            this.button_tabPostsextra_tabPostsadditionals_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostsextra_tabPostsadditionals_cancel.TabIndex = 5;
            this.button_tabPostsextra_tabPostsadditionals_cancel.Text = "Cancel";
            this.button_tabPostsextra_tabPostsadditionals_cancel.UseVisualStyleBackColor = true;
            // 
            // button_tabPostsextra_tabPostsadditionals_save
            // 
            this.button_tabPostsextra_tabPostsadditionals_save.Location = new System.Drawing.Point(172, 3);
            this.button_tabPostsextra_tabPostsadditionals_save.Name = "button_tabPostsextra_tabPostsadditionals_save";
            this.button_tabPostsextra_tabPostsadditionals_save.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostsextra_tabPostsadditionals_save.TabIndex = 4;
            this.button_tabPostsextra_tabPostsadditionals_save.Text = "Save";
            this.button_tabPostsextra_tabPostsadditionals_save.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostsextra_tabPostsadditionals_data
            // 
            this.panel_tabPostsextra_tabPostsadditionals_data.Controls.Add(postsadditionals_noteLabel);
            this.panel_tabPostsextra_tabPostsadditionals_data.Controls.Add(this.postsadditionals_noteTextBox);
            this.panel_tabPostsextra_tabPostsadditionals_data.Location = new System.Drawing.Point(5, 52);
            this.panel_tabPostsextra_tabPostsadditionals_data.Name = "panel_tabPostsextra_tabPostsadditionals_data";
            this.panel_tabPostsextra_tabPostsadditionals_data.Size = new System.Drawing.Size(331, 90);
            this.panel_tabPostsextra_tabPostsadditionals_data.TabIndex = 2;
            // 
            // postsadditionals_noteTextBox
            // 
            this.postsadditionals_noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsadditionalsBindingSource, "postsadditionals_note", true));
            this.postsadditionals_noteTextBox.Location = new System.Drawing.Point(8, 25);
            this.postsadditionals_noteTextBox.Multiline = true;
            this.postsadditionals_noteTextBox.Name = "postsadditionals_noteTextBox";
            this.postsadditionals_noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.postsadditionals_noteTextBox.Size = new System.Drawing.Size(320, 60);
            this.postsadditionals_noteTextBox.TabIndex = 1;
            // 
            // postsadditionalsBindingSource
            // 
            this.postsadditionalsBindingSource.DataSource = typeof(postsadditionals);
            // 
            // panel_tabPostsextra_tabPostsadditionals_actions
            // 
            this.panel_tabPostsextra_tabPostsadditionals_actions.Controls.Add(this.button_tabPostsextra_tabPostsadditionals_edit);
            this.panel_tabPostsextra_tabPostsadditionals_actions.Location = new System.Drawing.Point(4, 6);
            this.panel_tabPostsextra_tabPostsadditionals_actions.Name = "panel_tabPostsextra_tabPostsadditionals_actions";
            this.panel_tabPostsextra_tabPostsadditionals_actions.Size = new System.Drawing.Size(332, 40);
            this.panel_tabPostsextra_tabPostsadditionals_actions.TabIndex = 1;
            // 
            // button_tabPostsextra_tabPostsadditionals_edit
            // 
            this.button_tabPostsextra_tabPostsadditionals_edit.Location = new System.Drawing.Point(3, 3);
            this.button_tabPostsextra_tabPostsadditionals_edit.Name = "button_tabPostsextra_tabPostsadditionals_edit";
            this.button_tabPostsextra_tabPostsadditionals_edit.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostsextra_tabPostsadditionals_edit.TabIndex = 7;
            this.button_tabPostsextra_tabPostsadditionals_edit.Text = "Edit";
            this.button_tabPostsextra_tabPostsadditionals_edit.UseVisualStyleBackColor = true;
            // 
            // tabPage_tabPostsextra_tabPoststotags
            // 
            this.tabPage_tabPostsextra_tabPoststotags.AutoScroll = true;
            this.tabPage_tabPostsextra_tabPoststotags.Controls.Add(this.panel_tabPostsextra_tabPoststotags_actions);
            this.tabPage_tabPostsextra_tabPoststotags.Controls.Add(this.panel_tabPostsextra_tabPosttotags_list);
            this.tabPage_tabPostsextra_tabPoststotags.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostsextra_tabPoststotags.Name = "tabPage_tabPostsextra_tabPoststotags";
            this.tabPage_tabPostsextra_tabPoststotags.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostsextra_tabPoststotags.Size = new System.Drawing.Size(342, 194);
            this.tabPage_tabPostsextra_tabPoststotags.TabIndex = 1;
            this.tabPage_tabPostsextra_tabPoststotags.Text = "Post To Tags";
            this.tabPage_tabPostsextra_tabPoststotags.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostsextra_tabPoststotags_actions
            // 
            this.panel_tabPostsextra_tabPoststotags_actions.Controls.Add(this.button_tabPostsextra_tabPoststotags_remove);
            this.panel_tabPostsextra_tabPoststotags_actions.Controls.Add(this.button_tabPostsextra_tabPoststotags_add);
            this.panel_tabPostsextra_tabPoststotags_actions.Controls.Add(this.label1);
            this.panel_tabPostsextra_tabPoststotags_actions.Controls.Add(this.comboBox_tabPostsextra_tabPoststotags_tags);
            this.panel_tabPostsextra_tabPoststotags_actions.Location = new System.Drawing.Point(8, 124);
            this.panel_tabPostsextra_tabPoststotags_actions.Name = "panel_tabPostsextra_tabPoststotags_actions";
            this.panel_tabPostsextra_tabPoststotags_actions.Size = new System.Drawing.Size(328, 40);
            this.panel_tabPostsextra_tabPoststotags_actions.TabIndex = 2;
            // 
            // button_tabPostsextra_tabPoststotags_remove
            // 
            this.button_tabPostsextra_tabPoststotags_remove.Location = new System.Drawing.Point(250, 3);
            this.button_tabPostsextra_tabPoststotags_remove.Name = "button_tabPostsextra_tabPoststotags_remove";
            this.button_tabPostsextra_tabPoststotags_remove.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostsextra_tabPoststotags_remove.TabIndex = 8;
            this.button_tabPostsextra_tabPoststotags_remove.Text = "Remove";
            this.button_tabPostsextra_tabPoststotags_remove.UseVisualStyleBackColor = true;
            // 
            // button_tabPostsextra_tabPoststotags_add
            // 
            this.button_tabPostsextra_tabPoststotags_add.Location = new System.Drawing.Point(169, 4);
            this.button_tabPostsextra_tabPoststotags_add.Name = "button_tabPostsextra_tabPoststotags_add";
            this.button_tabPostsextra_tabPoststotags_add.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostsextra_tabPoststotags_add.TabIndex = 7;
            this.button_tabPostsextra_tabPoststotags_add.Text = "Add";
            this.button_tabPostsextra_tabPoststotags_add.UseVisualStyleBackColor = true;
            this.button_tabPostsextra_tabPoststotags_add.Click += new System.EventHandler(this.button_tabPostsextra_tabPoststotags_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag";
            // 
            // comboBox_tabPostsextra_tabPoststotags_tags
            // 
            this.comboBox_tabPostsextra_tabPoststotags_tags.FormattingEnabled = true;
            this.comboBox_tabPostsextra_tabPoststotags_tags.Location = new System.Drawing.Point(37, 6);
            this.comboBox_tabPostsextra_tabPoststotags_tags.Name = "comboBox_tabPostsextra_tabPoststotags_tags";
            this.comboBox_tabPostsextra_tabPoststotags_tags.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tabPostsextra_tabPoststotags_tags.TabIndex = 0;
            // 
            // panel_tabPostsextra_tabPosttotags_list
            // 
            this.panel_tabPostsextra_tabPosttotags_list.Controls.Add(this.dataGridView_tabPostsextra_tabPoststotags_list);
            this.panel_tabPostsextra_tabPosttotags_list.Location = new System.Drawing.Point(8, 6);
            this.panel_tabPostsextra_tabPosttotags_list.Name = "panel_tabPostsextra_tabPosttotags_list";
            this.panel_tabPostsextra_tabPosttotags_list.Size = new System.Drawing.Size(328, 112);
            this.panel_tabPostsextra_tabPosttotags_list.TabIndex = 1;
            // 
            // dataGridView_tabPostsextra_tabPoststotags_list
            // 
            this.dataGridView_tabPostsextra_tabPoststotags_list.AllowUserToAddRows = false;
            this.dataGridView_tabPostsextra_tabPoststotags_list.AllowUserToDeleteRows = false;
            this.dataGridView_tabPostsextra_tabPoststotags_list.AllowUserToResizeColumns = false;
            this.dataGridView_tabPostsextra_tabPoststotags_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_tabPostsextra_tabPoststotags_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_tabPostsextra_tabPoststotags_list.AutoGenerateColumns = false;
            this.dataGridView_tabPostsextra_tabPoststotags_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tabPostsextra_tabPoststotags_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postsidDataGridViewTextBoxColumn1,
            this.tagsidDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView_tabPostsextra_tabPoststotags_list.DataSource = this.vPostsToTagsBindingSource;
            this.dataGridView_tabPostsextra_tabPoststotags_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tabPostsextra_tabPoststotags_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_tabPostsextra_tabPoststotags_list.MultiSelect = false;
            this.dataGridView_tabPostsextra_tabPoststotags_list.Name = "dataGridView_tabPostsextra_tabPoststotags_list";
            this.dataGridView_tabPostsextra_tabPoststotags_list.ReadOnly = true;
            this.dataGridView_tabPostsextra_tabPoststotags_list.RowHeadersVisible = false;
            this.dataGridView_tabPostsextra_tabPoststotags_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tabPostsextra_tabPoststotags_list.Size = new System.Drawing.Size(328, 112);
            this.dataGridView_tabPostsextra_tabPoststotags_list.TabIndex = 4;
            // 
            // postsidDataGridViewTextBoxColumn1
            // 
            this.postsidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.postsidDataGridViewTextBoxColumn1.DataPropertyName = "posts_id";
            this.postsidDataGridViewTextBoxColumn1.HeaderText = "posts_id";
            this.postsidDataGridViewTextBoxColumn1.Name = "postsidDataGridViewTextBoxColumn1";
            this.postsidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.postsidDataGridViewTextBoxColumn1.Width = 70;
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
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postDataGridViewTextBoxColumn.DataPropertyName = "post";
            this.postDataGridViewTextBoxColumn.HeaderText = "post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vPostsToTagsBindingSource
            // 
            this.vPostsToTagsBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VPostsToTags);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_list);
            this.panel2.Controls.Add(this.panel_filters);
            this.panel2.Controls.Add(this.panel_add1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 368);
            this.panel2.TabIndex = 1;
            // 
            // panel_list
            // 
            this.panel_list.Controls.Add(this.dataGridView_list);
            this.panel_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_list.Location = new System.Drawing.Point(0, 54);
            this.panel_list.Name = "panel_list";
            this.panel_list.Size = new System.Drawing.Size(312, 270);
            this.panel_list.TabIndex = 1;
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.AllowUserToAddRows = false;
            this.dataGridView_list.AllowUserToDeleteRows = false;
            this.dataGridView_list.AllowUserToResizeColumns = false;
            this.dataGridView_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_list.AutoGenerateColumns = false;
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postsidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.dataGridView_list.DataSource = this.vPostsBindingSource;
            this.dataGridView_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_list.MultiSelect = false;
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.ReadOnly = true;
            this.dataGridView_list.RowHeadersVisible = false;
            this.dataGridView_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_list.Size = new System.Drawing.Size(312, 270);
            this.dataGridView_list.TabIndex = 3;
            // 
            // postsidDataGridViewTextBoxColumn
            // 
            this.postsidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.postsidDataGridViewTextBoxColumn.DataPropertyName = "posts_id";
            this.postsidDataGridViewTextBoxColumn.HeaderText = "posts_id";
            this.postsidDataGridViewTextBoxColumn.Name = "postsidDataGridViewTextBoxColumn";
            this.postsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.postsidDataGridViewTextBoxColumn.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vPostsBindingSource
            // 
            this.vPostsBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VPosts);
            this.vPostsBindingSource.CurrentChanged += new System.EventHandler(this.vPostsBindingSource_CurrentChanged);
            // 
            // panel_filters
            // 
            this.panel_filters.Controls.Add(this.button_messageboxsample);
            this.panel_filters.Controls.Add(this.textBox_filter_title);
            this.panel_filters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filters.Location = new System.Drawing.Point(0, 0);
            this.panel_filters.Name = "panel_filters";
            this.panel_filters.Size = new System.Drawing.Size(312, 54);
            this.panel_filters.TabIndex = 0;
            // 
            // button_messageboxsample
            // 
            this.button_messageboxsample.Location = new System.Drawing.Point(12, 3);
            this.button_messageboxsample.Name = "button_messageboxsample";
            this.button_messageboxsample.Size = new System.Drawing.Size(120, 23);
            this.button_messageboxsample.TabIndex = 1;
            this.button_messageboxsample.Text = "MessageBox Sample";
            this.button_messageboxsample.UseVisualStyleBackColor = true;
            this.button_messageboxsample.Click += new System.EventHandler(this.button_messageboxsample_Click);
            // 
            // textBox_filter_title
            // 
            this.textBox_filter_title.Location = new System.Drawing.Point(70, 28);
            this.textBox_filter_title.Name = "textBox_filter_title";
            this.textBox_filter_title.Size = new System.Drawing.Size(100, 20);
            this.textBox_filter_title.TabIndex = 0;
            this.textBox_filter_title.TextChanged += new System.EventHandler(this.textBox_filter_title_TextChanged);
            // 
            // panel_add1
            // 
            this.panel_add1.Controls.Add(this.label2);
            this.panel_add1.Controls.Add(this.textBox_totals);
            this.panel_add1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_add1.Location = new System.Drawing.Point(0, 324);
            this.panel_add1.Name = "panel_add1";
            this.panel_add1.Size = new System.Drawing.Size(312, 44);
            this.panel_add1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "total";
            // 
            // textBox_totals
            // 
            this.textBox_totals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_totals.Location = new System.Drawing.Point(206, 6);
            this.textBox_totals.Name = "textBox_totals";
            this.textBox_totals.Size = new System.Drawing.Size(100, 20);
            this.textBox_totals.TabIndex = 1;
            // 
            // poststotagsBindingSource
            // 
            this.poststotagsBindingSource.DataSource = typeof(poststotags);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(684, 368);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            this.Load += new System.EventHandler(this.FormPosts_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_tabPosts.ResumeLayout(false);
            this.panel_tabPosts_data.ResumeLayout(false);
            this.panel_tabPosts_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCBlogsBindingSource)).EndInit();
            this.panel_tabPosts_updates.ResumeLayout(false);
            this.panel_tabPosts_actions.ResumeLayout(false);
            this.tabPage_tabPostsextra.ResumeLayout(false);
            this.panel_tabPostsextra_data.ResumeLayout(false);
            this.tabControl_tabPostsextra.ResumeLayout(false);
            this.tabPage_tabPostsextra_tabPostsadditionals.ResumeLayout(false);
            this.panel_tabPostsextra_tabPostsadditionals_updates.ResumeLayout(false);
            this.panel_tabPostsextra_tabPostsadditionals_data.ResumeLayout(false);
            this.panel_tabPostsextra_tabPostsadditionals_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsadditionalsBindingSource)).EndInit();
            this.panel_tabPostsextra_tabPostsadditionals_actions.ResumeLayout(false);
            this.tabPage_tabPostsextra_tabPoststotags.ResumeLayout(false);
            this.panel_tabPostsextra_tabPoststotags_actions.ResumeLayout(false);
            this.panel_tabPostsextra_tabPoststotags_actions.PerformLayout();
            this.panel_tabPostsextra_tabPosttotags_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostsextra_tabPoststotags_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPostsToTagsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPostsBindingSource)).EndInit();
            this.panel_filters.ResumeLayout(false);
            this.panel_filters.PerformLayout();
            this.panel_add1.ResumeLayout(false);
            this.panel_add1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poststotagsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_tabPosts;
        private System.Windows.Forms.TabPage tabPage_tabPostsextra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_list;
        private System.Windows.Forms.Panel panel_filters;
        private System.Windows.Forms.Panel panel_tabPosts_updates;
        private System.Windows.Forms.Panel panel_tabPosts_actions;
        private System.Windows.Forms.TabControl tabControl_tabPostsextra;
        private System.Windows.Forms.TabPage tabPage_tabPostsextra_tabPostsadditionals;
        private System.Windows.Forms.Panel panel_tabPostsextra_tabPostsadditionals_updates;
        private System.Windows.Forms.Panel panel_tabPostsextra_tabPostsadditionals_data;
        private System.Windows.Forms.Panel panel_tabPostsextra_tabPostsadditionals_actions;
        private System.Windows.Forms.TabPage tabPage_tabPostsextra_tabPoststotags;
        private System.Windows.Forms.Panel panel_tabPostsextra_tabPosttotags_list;
        private System.Windows.Forms.Panel panel_tabPostsextra_tabPoststotags_actions;
        private System.Windows.Forms.DataGridView dataGridView_list;
        private System.Windows.Forms.Button button_tabPosts_delete;
        private System.Windows.Forms.Button button_tabPosts_edit;
        private System.Windows.Forms.Button button_tabPosts_new;
        private System.Windows.Forms.Button button_tabPosts_cancel;
        private System.Windows.Forms.Button button_tabPosts_save;
        private System.Windows.Forms.Panel panel_tabPosts_data;
        private System.Windows.Forms.TextBox posts_textTextBox;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.TextBox posts_emailTextBox;
        private System.Windows.Forms.TextBox posts_usernameTextBox;
        private System.Windows.Forms.TextBox posts_titleTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn postsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vPostsBindingSource;
        private System.Windows.Forms.TextBox textBox_filter_title;
        private System.Windows.Forms.Button button_tabPostsextra_tabPostsadditionals_cancel;
        private System.Windows.Forms.Button button_tabPostsextra_tabPostsadditionals_save;
        private System.Windows.Forms.Button button_tabPostsextra_tabPostsadditionals_edit;
        private System.Windows.Forms.TextBox postsadditionals_noteTextBox;
        private System.Windows.Forms.BindingSource postsadditionalsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_tabPostsextra_tabPoststotags_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn postsidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vPostsToTagsBindingSource;
        private System.Windows.Forms.Button button_tabPostsextra_tabPoststotags_remove;
        private System.Windows.Forms.Button button_tabPostsextra_tabPoststotags_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tabPostsextra_tabPoststotags_tags;
        private System.Windows.Forms.Panel panel_tabPostsextra_data;
        private System.Windows.Forms.ComboBox blogs_idComboBox;
        private System.Windows.Forms.BindingSource vCBlogsBindingSource;
        private System.Windows.Forms.BindingSource poststotagsBindingSource;
        private System.Windows.Forms.Panel panel_add1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_totals;
        private System.Windows.Forms.Button button_messageboxsample;
    }
}