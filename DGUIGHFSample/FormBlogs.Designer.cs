#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif

namespace DG.UIGHFSample
{
    partial class FormBlogs
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
            System.Windows.Forms.Label blogs_titleLabel;
            System.Windows.Forms.Label blogs_descriptionLabel;
            System.Windows.Forms.Label posts_titleLabel;
            System.Windows.Forms.Label posts_usernameLabel;
            System.Windows.Forms.Label posts_textLabel;
            System.Windows.Forms.Label posts_emailLabel;
            System.Windows.Forms.Label blogs_dateLabel;
            System.Windows.Forms.Label comments_usernameLabel;
            System.Windows.Forms.Label comments_emailLabel;
            System.Windows.Forms.Label comments_textLabel;
            System.Windows.Forms.Label commentsuseful_pointsLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlogs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_tabBlogs = new System.Windows.Forms.TabPage();
            this.panel_tabBlogs_updates = new System.Windows.Forms.Panel();
            this.button_tabBlogs_cancel = new System.Windows.Forms.Button();
            this.button_tabBlogs_save = new System.Windows.Forms.Button();
            this.panel_tabBlogs_data = new System.Windows.Forms.Panel();
            this.blogs_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogs_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.blogs_titleTextBox = new System.Windows.Forms.TextBox();
            this.panel_tabBlogs_actions = new System.Windows.Forms.Panel();
            this.button_tabBlogs_delete = new System.Windows.Forms.Button();
            this.button_tabBlogs_edit = new System.Windows.Forms.Button();
            this.button_tabBlogs_new = new System.Windows.Forms.Button();
            this.tabPage_tabPostslist = new System.Windows.Forms.TabPage();
            this.panel_tabPostslist_data = new System.Windows.Forms.Panel();
            this.tabControl_tabPostslist = new System.Windows.Forms.TabControl();
            this.tabPage_tabPostslist_tabPosts = new System.Windows.Forms.TabPage();
            this.panel_tabPostslist_tabPosts_actions = new System.Windows.Forms.Panel();
            this.button_tabPostslist_tabPosts_delete = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabPosts_edit = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabPosts_new = new System.Windows.Forms.Button();
            this.panel_tabPostslist_tabPosts_data = new System.Windows.Forms.Panel();
            this.posts_emailTextBox = new System.Windows.Forms.TextBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posts_textTextBox = new System.Windows.Forms.TextBox();
            this.posts_usernameTextBox = new System.Windows.Forms.TextBox();
            this.posts_titleTextBox = new System.Windows.Forms.TextBox();
            this.panel_tabPostslist_tabPosts_updates = new System.Windows.Forms.Panel();
            this.button_tabPostslist_tabPosts_cancel = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabPosts_save = new System.Windows.Forms.Button();
            this.tabPage_tabPostslist_tabCommentslist = new System.Windows.Forms.TabPage();
            this.panel_tabPostslist_tabCommentslist_data = new System.Windows.Forms.Panel();
            this.tabControl_tabPostslist_tabCommentslist = new System.Windows.Forms.TabControl();
            this.tabPage_tabPostslist_tabCommentslist_tabComments = new System.Windows.Forms.TabPage();
            this.panel_tabPostslist_tabCommentslist_tabComments_updates = new System.Windows.Forms.Panel();
            this.button_tabPostslist_tabCommentslist_tabComments_cancel = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabCommentslist_tabComments_save = new System.Windows.Forms.Button();
            this.panel_tabPostslist_tabCommentslist_tabComments_data = new System.Windows.Forms.Panel();
            this.comments_textTextBox = new System.Windows.Forms.TextBox();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comments_emailTextBox = new System.Windows.Forms.TextBox();
            this.comments_usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel_tabPostslist_tabCommentslist_tabComments_actions = new System.Windows.Forms.Panel();
            this.button_tabPostslist_tabCommentslist_tabComments_delete = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabCommentslist_tabComments_edit = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabCommentslist_tabComments_new = new System.Windows.Forms.Button();
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful = new System.Windows.Forms.TabPage();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates = new System.Windows.Forms.Panel();
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save = new System.Windows.Forms.Button();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data = new System.Windows.Forms.Panel();
            this.commentsuseful_pointsTextBox = new System.Windows.Forms.TextBox();
            this.commentsusefulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions = new System.Windows.Forms.Panel();
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit = new System.Windows.Forms.Button();
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new = new System.Windows.Forms.Button();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list = new System.Windows.Forms.Panel();
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list = new System.Windows.Forms.DataGridView();
            this.commentsusefulidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCommentsUsefulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_tabPostslist_tabCommentslist_list = new System.Windows.Forms.Panel();
            this.dataGridView_tabPostslist_tabCommentslist_list = new System.Windows.Forms.DataGridView();
            this.commentsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_tabPostslist_list = new System.Windows.Forms.Panel();
            this.dataGridView_tabPostslist_list = new System.Windows.Forms.DataGridView();
            this.postsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_list = new System.Windows.Forms.Panel();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.blogsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_filters = new System.Windows.Forms.Panel();
            this.button_reloadview = new System.Windows.Forms.Button();
            blogs_titleLabel = new System.Windows.Forms.Label();
            blogs_descriptionLabel = new System.Windows.Forms.Label();
            posts_titleLabel = new System.Windows.Forms.Label();
            posts_usernameLabel = new System.Windows.Forms.Label();
            posts_textLabel = new System.Windows.Forms.Label();
            posts_emailLabel = new System.Windows.Forms.Label();
            blogs_dateLabel = new System.Windows.Forms.Label();
            comments_usernameLabel = new System.Windows.Forms.Label();
            comments_emailLabel = new System.Windows.Forms.Label();
            comments_textLabel = new System.Windows.Forms.Label();
            commentsuseful_pointsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage_tabBlogs.SuspendLayout();
            this.panel_tabBlogs_updates.SuspendLayout();
            this.panel_tabBlogs_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            this.panel_tabBlogs_actions.SuspendLayout();
            this.tabPage_tabPostslist.SuspendLayout();
            this.panel_tabPostslist_data.SuspendLayout();
            this.tabControl_tabPostslist.SuspendLayout();
            this.tabPage_tabPostslist_tabPosts.SuspendLayout();
            this.panel_tabPostslist_tabPosts_actions.SuspendLayout();
            this.panel_tabPostslist_tabPosts_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.panel_tabPostslist_tabPosts_updates.SuspendLayout();
            this.tabPage_tabPostslist_tabCommentslist.SuspendLayout();
            this.panel_tabPostslist_tabCommentslist_data.SuspendLayout();
            this.tabControl_tabPostslist_tabCommentslist.SuspendLayout();
            this.tabPage_tabPostslist_tabCommentslist_tabComments.SuspendLayout();
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.SuspendLayout();
            this.panel_tabPostslist_tabCommentslist_tabComments_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.SuspendLayout();
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.SuspendLayout();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.SuspendLayout();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsusefulBindingSource)).BeginInit();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.SuspendLayout();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCommentsUsefulBindingSource)).BeginInit();
            this.panel_tabPostslist_tabCommentslist_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostslist_tabCommentslist_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCommentsBindingSource)).BeginInit();
            this.panel_tabPostslist_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostslist_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPostsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBlogsBindingSource)).BeginInit();
            this.panel_filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // blogs_titleLabel
            // 
            blogs_titleLabel.AutoSize = true;
            blogs_titleLabel.Location = new System.Drawing.Point(5, 9);
            blogs_titleLabel.Name = "blogs_titleLabel";
            blogs_titleLabel.Size = new System.Drawing.Size(54, 13);
            blogs_titleLabel.TabIndex = 2;
            blogs_titleLabel.Text = "blogs title:";
            // 
            // blogs_descriptionLabel
            // 
            blogs_descriptionLabel.AutoSize = true;
            blogs_descriptionLabel.Location = new System.Drawing.Point(5, 47);
            blogs_descriptionLabel.Name = "blogs_descriptionLabel";
            blogs_descriptionLabel.Size = new System.Drawing.Size(89, 13);
            blogs_descriptionLabel.TabIndex = 4;
            blogs_descriptionLabel.Text = "blogs description:";
            // 
            // posts_titleLabel
            // 
            posts_titleLabel.AutoSize = true;
            posts_titleLabel.Location = new System.Drawing.Point(5, 9);
            posts_titleLabel.Name = "posts_titleLabel";
            posts_titleLabel.Size = new System.Drawing.Size(54, 13);
            posts_titleLabel.TabIndex = 2;
            posts_titleLabel.Text = "posts title:";
            // 
            // posts_usernameLabel
            // 
            posts_usernameLabel.AutoSize = true;
            posts_usernameLabel.Location = new System.Drawing.Point(5, 48);
            posts_usernameLabel.Name = "posts_usernameLabel";
            posts_usernameLabel.Size = new System.Drawing.Size(84, 13);
            posts_usernameLabel.TabIndex = 4;
            posts_usernameLabel.Text = "posts username:";
            // 
            // posts_textLabel
            // 
            posts_textLabel.AutoSize = true;
            posts_textLabel.Location = new System.Drawing.Point(11, 87);
            posts_textLabel.Name = "posts_textLabel";
            posts_textLabel.Size = new System.Drawing.Size(55, 13);
            posts_textLabel.TabIndex = 6;
            posts_textLabel.Text = "posts text:";
            // 
            // posts_emailLabel
            // 
            posts_emailLabel.AutoSize = true;
            posts_emailLabel.Location = new System.Drawing.Point(114, 48);
            posts_emailLabel.Name = "posts_emailLabel";
            posts_emailLabel.Size = new System.Drawing.Size(62, 13);
            posts_emailLabel.TabIndex = 8;
            posts_emailLabel.Text = "posts email:";
            // 
            // blogs_dateLabel
            // 
            blogs_dateLabel.AutoSize = true;
            blogs_dateLabel.Location = new System.Drawing.Point(5, 116);
            blogs_dateLabel.Name = "blogs_dateLabel";
            blogs_dateLabel.Size = new System.Drawing.Size(59, 13);
            blogs_dateLabel.TabIndex = 5;
            blogs_dateLabel.Text = "blogs date:";
            // 
            // comments_usernameLabel
            // 
            comments_usernameLabel.AutoSize = true;
            comments_usernameLabel.Location = new System.Drawing.Point(5, 9);
            comments_usernameLabel.Name = "comments_usernameLabel";
            comments_usernameLabel.Size = new System.Drawing.Size(107, 13);
            comments_usernameLabel.TabIndex = 2;
            comments_usernameLabel.Text = "comments username:";
            // 
            // comments_emailLabel
            // 
            comments_emailLabel.AutoSize = true;
            comments_emailLabel.Location = new System.Drawing.Point(135, 9);
            comments_emailLabel.Name = "comments_emailLabel";
            comments_emailLabel.Size = new System.Drawing.Size(85, 13);
            comments_emailLabel.TabIndex = 3;
            comments_emailLabel.Text = "comments email:";
            // 
            // comments_textLabel
            // 
            comments_textLabel.AutoSize = true;
            comments_textLabel.Location = new System.Drawing.Point(5, 48);
            comments_textLabel.Name = "comments_textLabel";
            comments_textLabel.Size = new System.Drawing.Size(78, 13);
            comments_textLabel.TabIndex = 4;
            comments_textLabel.Text = "comments text:";
            // 
            // commentsuseful_pointsLabel
            // 
            commentsuseful_pointsLabel.AutoSize = true;
            commentsuseful_pointsLabel.Location = new System.Drawing.Point(5, 9);
            commentsuseful_pointsLabel.Name = "commentsuseful_pointsLabel";
            commentsuseful_pointsLabel.Size = new System.Drawing.Size(117, 13);
            commentsuseful_pointsLabel.TabIndex = 0;
            commentsuseful_pointsLabel.Text = "commentsuseful points:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(371, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 627);
            this.panel1.TabIndex = 0;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_tabBlogs);
            this.tabControl_main.Controls.Add(this.tabPage_tabPostslist);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(404, 627);
            this.tabControl_main.TabIndex = 1;
            // 
            // tabPage_tabBlogs
            // 
            this.tabPage_tabBlogs.AutoScroll = true;
            this.tabPage_tabBlogs.Controls.Add(this.panel_tabBlogs_updates);
            this.tabPage_tabBlogs.Controls.Add(this.panel_tabBlogs_data);
            this.tabPage_tabBlogs.Controls.Add(this.panel_tabBlogs_actions);
            this.tabPage_tabBlogs.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabBlogs.Name = "tabPage_tabBlogs";
            this.tabPage_tabBlogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabBlogs.Size = new System.Drawing.Size(396, 601);
            this.tabPage_tabBlogs.TabIndex = 0;
            this.tabPage_tabBlogs.Text = "Blog";
            this.tabPage_tabBlogs.UseVisualStyleBackColor = true;
            // 
            // panel_tabBlogs_updates
            // 
            this.panel_tabBlogs_updates.Controls.Add(this.button_tabBlogs_cancel);
            this.panel_tabBlogs_updates.Controls.Add(this.button_tabBlogs_save);
            this.panel_tabBlogs_updates.Location = new System.Drawing.Point(6, 228);
            this.panel_tabBlogs_updates.Name = "panel_tabBlogs_updates";
            this.panel_tabBlogs_updates.Size = new System.Drawing.Size(382, 40);
            this.panel_tabBlogs_updates.TabIndex = 2;
            // 
            // button_tabBlogs_cancel
            // 
            this.button_tabBlogs_cancel.Location = new System.Drawing.Point(304, 3);
            this.button_tabBlogs_cancel.Name = "button_tabBlogs_cancel";
            this.button_tabBlogs_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_tabBlogs_cancel.TabIndex = 1;
            this.button_tabBlogs_cancel.Text = "Cancel";
            this.button_tabBlogs_cancel.UseVisualStyleBackColor = true;
            // 
            // button_tabBlogs_save
            // 
            this.button_tabBlogs_save.Location = new System.Drawing.Point(223, 3);
            this.button_tabBlogs_save.Name = "button_tabBlogs_save";
            this.button_tabBlogs_save.Size = new System.Drawing.Size(75, 23);
            this.button_tabBlogs_save.TabIndex = 0;
            this.button_tabBlogs_save.Text = "Save";
            this.button_tabBlogs_save.UseVisualStyleBackColor = true;
            // 
            // panel_tabBlogs_data
            // 
            this.panel_tabBlogs_data.Controls.Add(blogs_dateLabel);
            this.panel_tabBlogs_data.Controls.Add(this.blogs_dateDateTimePicker);
            this.panel_tabBlogs_data.Controls.Add(blogs_descriptionLabel);
            this.panel_tabBlogs_data.Controls.Add(this.blogs_descriptionTextBox);
            this.panel_tabBlogs_data.Controls.Add(blogs_titleLabel);
            this.panel_tabBlogs_data.Controls.Add(this.blogs_titleTextBox);
            this.panel_tabBlogs_data.Location = new System.Drawing.Point(6, 52);
            this.panel_tabBlogs_data.Name = "panel_tabBlogs_data";
            this.panel_tabBlogs_data.Size = new System.Drawing.Size(382, 170);
            this.panel_tabBlogs_data.TabIndex = 1;
            // 
            // blogs_dateDateTimePicker
            // 
            this.blogs_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.blogsBindingSource, "blogs_date", true));
            this.blogs_dateDateTimePicker.Location = new System.Drawing.Point(8, 132);
            this.blogs_dateDateTimePicker.Name = "blogs_dateDateTimePicker";
            this.blogs_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.blogs_dateDateTimePicker.TabIndex = 6;
            // 
            // blogsBindingSource
            // 
            this.blogsBindingSource.DataSource = typeof(blogs);
            // 
            // blogs_descriptionTextBox
            // 
            this.blogs_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blogsBindingSource, "blogs_description", true));
            this.blogs_descriptionTextBox.Location = new System.Drawing.Point(8, 63);
            this.blogs_descriptionTextBox.Multiline = true;
            this.blogs_descriptionTextBox.Name = "blogs_descriptionTextBox";
            this.blogs_descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.blogs_descriptionTextBox.Size = new System.Drawing.Size(371, 50);
            this.blogs_descriptionTextBox.TabIndex = 5;
            // 
            // blogs_titleTextBox
            // 
            this.blogs_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blogsBindingSource, "blogs_title", true));
            this.blogs_titleTextBox.Location = new System.Drawing.Point(8, 24);
            this.blogs_titleTextBox.Name = "blogs_titleTextBox";
            this.blogs_titleTextBox.Size = new System.Drawing.Size(371, 20);
            this.blogs_titleTextBox.TabIndex = 3;
            // 
            // panel_tabBlogs_actions
            // 
            this.panel_tabBlogs_actions.Controls.Add(this.button_tabBlogs_delete);
            this.panel_tabBlogs_actions.Controls.Add(this.button_tabBlogs_edit);
            this.panel_tabBlogs_actions.Controls.Add(this.button_tabBlogs_new);
            this.panel_tabBlogs_actions.Location = new System.Drawing.Point(6, 6);
            this.panel_tabBlogs_actions.Name = "panel_tabBlogs_actions";
            this.panel_tabBlogs_actions.Size = new System.Drawing.Size(382, 40);
            this.panel_tabBlogs_actions.TabIndex = 0;
            // 
            // button_tabBlogs_delete
            // 
            this.button_tabBlogs_delete.Location = new System.Drawing.Point(165, 3);
            this.button_tabBlogs_delete.Name = "button_tabBlogs_delete";
            this.button_tabBlogs_delete.Size = new System.Drawing.Size(75, 23);
            this.button_tabBlogs_delete.TabIndex = 2;
            this.button_tabBlogs_delete.Text = "Delete";
            this.button_tabBlogs_delete.UseVisualStyleBackColor = true;
            // 
            // button_tabBlogs_edit
            // 
            this.button_tabBlogs_edit.Location = new System.Drawing.Point(84, 3);
            this.button_tabBlogs_edit.Name = "button_tabBlogs_edit";
            this.button_tabBlogs_edit.Size = new System.Drawing.Size(75, 23);
            this.button_tabBlogs_edit.TabIndex = 1;
            this.button_tabBlogs_edit.Text = "Edit";
            this.button_tabBlogs_edit.UseVisualStyleBackColor = true;
            // 
            // button_tabBlogs_new
            // 
            this.button_tabBlogs_new.Location = new System.Drawing.Point(3, 3);
            this.button_tabBlogs_new.Name = "button_tabBlogs_new";
            this.button_tabBlogs_new.Size = new System.Drawing.Size(75, 23);
            this.button_tabBlogs_new.TabIndex = 0;
            this.button_tabBlogs_new.Text = "New";
            this.button_tabBlogs_new.UseVisualStyleBackColor = true;
            this.button_tabBlogs_new.Click += new System.EventHandler(this.button_tabBlogs_new_Click);
            // 
            // tabPage_tabPostslist
            // 
            this.tabPage_tabPostslist.AutoScroll = true;
            this.tabPage_tabPostslist.Controls.Add(this.panel_tabPostslist_data);
            this.tabPage_tabPostslist.Controls.Add(this.panel_tabPostslist_list);
            this.tabPage_tabPostslist.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostslist.Name = "tabPage_tabPostslist";
            this.tabPage_tabPostslist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostslist.Size = new System.Drawing.Size(396, 601);
            this.tabPage_tabPostslist.TabIndex = 1;
            this.tabPage_tabPostslist.Text = "Posts";
            this.tabPage_tabPostslist.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostslist_data
            // 
            this.panel_tabPostslist_data.Controls.Add(this.tabControl_tabPostslist);
            this.panel_tabPostslist_data.Location = new System.Drawing.Point(6, 92);
            this.panel_tabPostslist_data.Name = "panel_tabPostslist_data";
            this.panel_tabPostslist_data.Size = new System.Drawing.Size(382, 412);
            this.panel_tabPostslist_data.TabIndex = 6;
            // 
            // tabControl_tabPostslist
            // 
            this.tabControl_tabPostslist.Controls.Add(this.tabPage_tabPostslist_tabPosts);
            this.tabControl_tabPostslist.Controls.Add(this.tabPage_tabPostslist_tabCommentslist);
            this.tabControl_tabPostslist.Location = new System.Drawing.Point(3, 3);
            this.tabControl_tabPostslist.Name = "tabControl_tabPostslist";
            this.tabControl_tabPostslist.SelectedIndex = 0;
            this.tabControl_tabPostslist.Size = new System.Drawing.Size(376, 394);
            this.tabControl_tabPostslist.TabIndex = 5;
            // 
            // tabPage_tabPostslist_tabPosts
            // 
            this.tabPage_tabPostslist_tabPosts.Controls.Add(this.panel_tabPostslist_tabPosts_actions);
            this.tabPage_tabPostslist_tabPosts.Controls.Add(this.panel_tabPostslist_tabPosts_data);
            this.tabPage_tabPostslist_tabPosts.Controls.Add(this.panel_tabPostslist_tabPosts_updates);
            this.tabPage_tabPostslist_tabPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostslist_tabPosts.Name = "tabPage_tabPostslist_tabPosts";
            this.tabPage_tabPostslist_tabPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostslist_tabPosts.Size = new System.Drawing.Size(368, 368);
            this.tabPage_tabPostslist_tabPosts.TabIndex = 0;
            this.tabPage_tabPostslist_tabPosts.Text = "Info";
            this.tabPage_tabPostslist_tabPosts.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostslist_tabPosts_actions
            // 
            this.panel_tabPostslist_tabPosts_actions.Controls.Add(this.button_tabPostslist_tabPosts_delete);
            this.panel_tabPostslist_tabPosts_actions.Controls.Add(this.button_tabPostslist_tabPosts_edit);
            this.panel_tabPostslist_tabPosts_actions.Controls.Add(this.button_tabPostslist_tabPosts_new);
            this.panel_tabPostslist_tabPosts_actions.Location = new System.Drawing.Point(3, 6);
            this.panel_tabPostslist_tabPosts_actions.Name = "panel_tabPostslist_tabPosts_actions";
            this.panel_tabPostslist_tabPosts_actions.Size = new System.Drawing.Size(359, 40);
            this.panel_tabPostslist_tabPosts_actions.TabIndex = 1;
            // 
            // button_tabPostslist_tabPosts_delete
            // 
            this.button_tabPostslist_tabPosts_delete.Location = new System.Drawing.Point(165, 3);
            this.button_tabPostslist_tabPosts_delete.Name = "button_tabPostslist_tabPosts_delete";
            this.button_tabPostslist_tabPosts_delete.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabPosts_delete.TabIndex = 5;
            this.button_tabPostslist_tabPosts_delete.Text = "Delete";
            this.button_tabPostslist_tabPosts_delete.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabPosts_edit
            // 
            this.button_tabPostslist_tabPosts_edit.Location = new System.Drawing.Point(84, 3);
            this.button_tabPostslist_tabPosts_edit.Name = "button_tabPostslist_tabPosts_edit";
            this.button_tabPostslist_tabPosts_edit.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabPosts_edit.TabIndex = 4;
            this.button_tabPostslist_tabPosts_edit.Text = "Edit";
            this.button_tabPostslist_tabPosts_edit.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabPosts_new
            // 
            this.button_tabPostslist_tabPosts_new.Location = new System.Drawing.Point(3, 3);
            this.button_tabPostslist_tabPosts_new.Name = "button_tabPostslist_tabPosts_new";
            this.button_tabPostslist_tabPosts_new.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabPosts_new.TabIndex = 3;
            this.button_tabPostslist_tabPosts_new.Text = "New";
            this.button_tabPostslist_tabPosts_new.UseVisualStyleBackColor = true;
            this.button_tabPostslist_tabPosts_new.Click += new System.EventHandler(this.button_tabPostslist_tabPosts_new_Click);
            // 
            // panel_tabPostslist_tabPosts_data
            // 
            this.panel_tabPostslist_tabPosts_data.Controls.Add(posts_emailLabel);
            this.panel_tabPostslist_tabPosts_data.Controls.Add(this.posts_emailTextBox);
            this.panel_tabPostslist_tabPosts_data.Controls.Add(posts_textLabel);
            this.panel_tabPostslist_tabPosts_data.Controls.Add(this.posts_textTextBox);
            this.panel_tabPostslist_tabPosts_data.Controls.Add(posts_usernameLabel);
            this.panel_tabPostslist_tabPosts_data.Controls.Add(this.posts_usernameTextBox);
            this.panel_tabPostslist_tabPosts_data.Controls.Add(posts_titleLabel);
            this.panel_tabPostslist_tabPosts_data.Controls.Add(this.posts_titleTextBox);
            this.panel_tabPostslist_tabPosts_data.Location = new System.Drawing.Point(3, 49);
            this.panel_tabPostslist_tabPosts_data.Name = "panel_tabPostslist_tabPosts_data";
            this.panel_tabPostslist_tabPosts_data.Size = new System.Drawing.Size(359, 160);
            this.panel_tabPostslist_tabPosts_data.TabIndex = 2;
            // 
            // posts_emailTextBox
            // 
            this.posts_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_email", true));
            this.posts_emailTextBox.Location = new System.Drawing.Point(117, 64);
            this.posts_emailTextBox.Name = "posts_emailTextBox";
            this.posts_emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.posts_emailTextBox.TabIndex = 9;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataSource = typeof(posts);
            // 
            // posts_textTextBox
            // 
            this.posts_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_text", true));
            this.posts_textTextBox.Location = new System.Drawing.Point(8, 103);
            this.posts_textTextBox.Multiline = true;
            this.posts_textTextBox.Name = "posts_textTextBox";
            this.posts_textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.posts_textTextBox.Size = new System.Drawing.Size(348, 50);
            this.posts_textTextBox.TabIndex = 7;
            // 
            // posts_usernameTextBox
            // 
            this.posts_usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_username", true));
            this.posts_usernameTextBox.Location = new System.Drawing.Point(8, 64);
            this.posts_usernameTextBox.Name = "posts_usernameTextBox";
            this.posts_usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.posts_usernameTextBox.TabIndex = 5;
            // 
            // posts_titleTextBox
            // 
            this.posts_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "posts_title", true));
            this.posts_titleTextBox.Location = new System.Drawing.Point(8, 25);
            this.posts_titleTextBox.Name = "posts_titleTextBox";
            this.posts_titleTextBox.Size = new System.Drawing.Size(348, 20);
            this.posts_titleTextBox.TabIndex = 3;
            // 
            // panel_tabPostslist_tabPosts_updates
            // 
            this.panel_tabPostslist_tabPosts_updates.Controls.Add(this.button_tabPostslist_tabPosts_cancel);
            this.panel_tabPostslist_tabPosts_updates.Controls.Add(this.button_tabPostslist_tabPosts_save);
            this.panel_tabPostslist_tabPosts_updates.Location = new System.Drawing.Point(3, 215);
            this.panel_tabPostslist_tabPosts_updates.Name = "panel_tabPostslist_tabPosts_updates";
            this.panel_tabPostslist_tabPosts_updates.Size = new System.Drawing.Size(359, 40);
            this.panel_tabPostslist_tabPosts_updates.TabIndex = 3;
            // 
            // button_tabPostslist_tabPosts_cancel
            // 
            this.button_tabPostslist_tabPosts_cancel.Location = new System.Drawing.Point(281, 3);
            this.button_tabPostslist_tabPosts_cancel.Name = "button_tabPostslist_tabPosts_cancel";
            this.button_tabPostslist_tabPosts_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabPosts_cancel.TabIndex = 6;
            this.button_tabPostslist_tabPosts_cancel.Text = "Cancel";
            this.button_tabPostslist_tabPosts_cancel.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabPosts_save
            // 
            this.button_tabPostslist_tabPosts_save.Location = new System.Drawing.Point(200, 3);
            this.button_tabPostslist_tabPosts_save.Name = "button_tabPostslist_tabPosts_save";
            this.button_tabPostslist_tabPosts_save.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabPosts_save.TabIndex = 5;
            this.button_tabPostslist_tabPosts_save.Text = "Save";
            this.button_tabPostslist_tabPosts_save.UseVisualStyleBackColor = true;
            // 
            // tabPage_tabPostslist_tabCommentslist
            // 
            this.tabPage_tabPostslist_tabCommentslist.Controls.Add(this.panel_tabPostslist_tabCommentslist_data);
            this.tabPage_tabPostslist_tabCommentslist.Controls.Add(this.panel_tabPostslist_tabCommentslist_list);
            this.tabPage_tabPostslist_tabCommentslist.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostslist_tabCommentslist.Name = "tabPage_tabPostslist_tabCommentslist";
            this.tabPage_tabPostslist_tabCommentslist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostslist_tabCommentslist.Size = new System.Drawing.Size(368, 368);
            this.tabPage_tabPostslist_tabCommentslist.TabIndex = 1;
            this.tabPage_tabPostslist_tabCommentslist.Text = "Comments";
            this.tabPage_tabPostslist_tabCommentslist.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostslist_tabCommentslist_data
            // 
            this.panel_tabPostslist_tabCommentslist_data.Controls.Add(this.tabControl_tabPostslist_tabCommentslist);
            this.panel_tabPostslist_tabCommentslist_data.Location = new System.Drawing.Point(6, 92);
            this.panel_tabPostslist_tabCommentslist_data.Name = "panel_tabPostslist_tabCommentslist_data";
            this.panel_tabPostslist_tabCommentslist_data.Size = new System.Drawing.Size(356, 270);
            this.panel_tabPostslist_tabCommentslist_data.TabIndex = 1;
            // 
            // tabControl_tabPostslist_tabCommentslist
            // 
            this.tabControl_tabPostslist_tabCommentslist.Controls.Add(this.tabPage_tabPostslist_tabCommentslist_tabComments);
            this.tabControl_tabPostslist_tabCommentslist.Controls.Add(this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful);
            this.tabControl_tabPostslist_tabCommentslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_tabPostslist_tabCommentslist.Location = new System.Drawing.Point(0, 0);
            this.tabControl_tabPostslist_tabCommentslist.Name = "tabControl_tabPostslist_tabCommentslist";
            this.tabControl_tabPostslist_tabCommentslist.SelectedIndex = 0;
            this.tabControl_tabPostslist_tabCommentslist.Size = new System.Drawing.Size(356, 270);
            this.tabControl_tabPostslist_tabCommentslist.TabIndex = 0;
            // 
            // tabPage_tabPostslist_tabCommentslist_tabComments
            // 
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Controls.Add(this.panel_tabPostslist_tabCommentslist_tabComments_updates);
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Controls.Add(this.panel_tabPostslist_tabCommentslist_tabComments_data);
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Controls.Add(this.panel_tabPostslist_tabCommentslist_tabComments_actions);
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Name = "tabPage_tabPostslist_tabCommentslist_tabComments";
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Size = new System.Drawing.Size(348, 244);
            this.tabPage_tabPostslist_tabCommentslist_tabComments.TabIndex = 0;
            this.tabPage_tabPostslist_tabCommentslist_tabComments.Text = "Comment";
            this.tabPage_tabPostslist_tabCommentslist_tabComments.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostslist_tabCommentslist_tabComments_updates
            // 
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.Controls.Add(this.button_tabPostslist_tabCommentslist_tabComments_cancel);
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.Controls.Add(this.button_tabPostslist_tabCommentslist_tabComments_save);
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.Location = new System.Drawing.Point(6, 179);
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.Name = "panel_tabPostslist_tabCommentslist_tabComments_updates";
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.Size = new System.Drawing.Size(336, 40);
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.TabIndex = 2;
            // 
            // button_tabPostslist_tabCommentslist_tabComments_cancel
            // 
            this.button_tabPostslist_tabCommentslist_tabComments_cancel.Location = new System.Drawing.Point(258, 3);
            this.button_tabPostslist_tabCommentslist_tabComments_cancel.Name = "button_tabPostslist_tabCommentslist_tabComments_cancel";
            this.button_tabPostslist_tabCommentslist_tabComments_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabComments_cancel.TabIndex = 8;
            this.button_tabPostslist_tabCommentslist_tabComments_cancel.Text = "Cancel";
            this.button_tabPostslist_tabCommentslist_tabComments_cancel.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabCommentslist_tabComments_save
            // 
            this.button_tabPostslist_tabCommentslist_tabComments_save.Location = new System.Drawing.Point(177, 3);
            this.button_tabPostslist_tabCommentslist_tabComments_save.Name = "button_tabPostslist_tabCommentslist_tabComments_save";
            this.button_tabPostslist_tabCommentslist_tabComments_save.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabComments_save.TabIndex = 7;
            this.button_tabPostslist_tabCommentslist_tabComments_save.Text = "Save";
            this.button_tabPostslist_tabCommentslist_tabComments_save.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostslist_tabCommentslist_tabComments_data
            // 
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Controls.Add(comments_textLabel);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Controls.Add(this.comments_textTextBox);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Controls.Add(comments_emailLabel);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Controls.Add(this.comments_emailTextBox);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Controls.Add(comments_usernameLabel);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Controls.Add(this.comments_usernameTextBox);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Location = new System.Drawing.Point(6, 52);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Name = "panel_tabPostslist_tabCommentslist_tabComments_data";
            this.panel_tabPostslist_tabCommentslist_tabComments_data.Size = new System.Drawing.Size(336, 121);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.TabIndex = 1;
            // 
            // comments_textTextBox
            // 
            this.comments_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "comments_text", true));
            this.comments_textTextBox.Location = new System.Drawing.Point(8, 64);
            this.comments_textTextBox.Multiline = true;
            this.comments_textTextBox.Name = "comments_textTextBox";
            this.comments_textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.comments_textTextBox.Size = new System.Drawing.Size(325, 50);
            this.comments_textTextBox.TabIndex = 5;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataSource = typeof(comments);
            // 
            // comments_emailTextBox
            // 
            this.comments_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "comments_email", true));
            this.comments_emailTextBox.Location = new System.Drawing.Point(138, 25);
            this.comments_emailTextBox.Name = "comments_emailTextBox";
            this.comments_emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.comments_emailTextBox.TabIndex = 4;
            // 
            // comments_usernameTextBox
            // 
            this.comments_usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "comments_username", true));
            this.comments_usernameTextBox.Location = new System.Drawing.Point(8, 25);
            this.comments_usernameTextBox.Name = "comments_usernameTextBox";
            this.comments_usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.comments_usernameTextBox.TabIndex = 3;
            // 
            // panel_tabPostslist_tabCommentslist_tabComments_actions
            // 
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.Controls.Add(this.button_tabPostslist_tabCommentslist_tabComments_delete);
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.Controls.Add(this.button_tabPostslist_tabCommentslist_tabComments_edit);
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.Controls.Add(this.button_tabPostslist_tabCommentslist_tabComments_new);
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.Location = new System.Drawing.Point(6, 6);
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.Name = "panel_tabPostslist_tabCommentslist_tabComments_actions";
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.Size = new System.Drawing.Size(336, 40);
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.TabIndex = 0;
            // 
            // button_tabPostslist_tabCommentslist_tabComments_delete
            // 
            this.button_tabPostslist_tabCommentslist_tabComments_delete.Location = new System.Drawing.Point(165, 3);
            this.button_tabPostslist_tabCommentslist_tabComments_delete.Name = "button_tabPostslist_tabCommentslist_tabComments_delete";
            this.button_tabPostslist_tabCommentslist_tabComments_delete.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabComments_delete.TabIndex = 8;
            this.button_tabPostslist_tabCommentslist_tabComments_delete.Text = "Delete";
            this.button_tabPostslist_tabCommentslist_tabComments_delete.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabCommentslist_tabComments_edit
            // 
            this.button_tabPostslist_tabCommentslist_tabComments_edit.Location = new System.Drawing.Point(84, 3);
            this.button_tabPostslist_tabCommentslist_tabComments_edit.Name = "button_tabPostslist_tabCommentslist_tabComments_edit";
            this.button_tabPostslist_tabCommentslist_tabComments_edit.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabComments_edit.TabIndex = 7;
            this.button_tabPostslist_tabCommentslist_tabComments_edit.Text = "Edit";
            this.button_tabPostslist_tabCommentslist_tabComments_edit.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabCommentslist_tabComments_new
            // 
            this.button_tabPostslist_tabCommentslist_tabComments_new.Location = new System.Drawing.Point(3, 3);
            this.button_tabPostslist_tabCommentslist_tabComments_new.Name = "button_tabPostslist_tabCommentslist_tabComments_new";
            this.button_tabPostslist_tabCommentslist_tabComments_new.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabComments_new.TabIndex = 6;
            this.button_tabPostslist_tabCommentslist_tabComments_new.Text = "New";
            this.button_tabPostslist_tabCommentslist_tabComments_new.UseVisualStyleBackColor = true;
            this.button_tabPostslist_tabCommentslist_tabComments_new.Click += new System.EventHandler(this.button_tabPostslist_tabCommentslist_tabComments_new_Click);
            // 
            // tabPage_tabPostslist_tabCommentslist_tabCommentsuseful
            // 
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Controls.Add(this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Controls.Add(this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Controls.Add(this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Controls.Add(this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Name = "tabPage_tabPostslist_tabCommentslist_tabCommentsuseful";
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Size = new System.Drawing.Size(348, 244);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.TabIndex = 1;
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.Text = "Comment Useful";
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates
            // 
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.Controls.Add(this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.Controls.Add(this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.Location = new System.Drawing.Point(6, 201);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.Name = "panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates";
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.Size = new System.Drawing.Size(336, 40);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.TabIndex = 3;
            // 
            // button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel
            // 
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel.Location = new System.Drawing.Point(258, 3);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel.Name = "button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel.TabIndex = 10;
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel.Text = "Cancel";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabCommentslist_tabCommentsuseful_save
            // 
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save.Location = new System.Drawing.Point(177, 3);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save.Name = "button_tabPostslist_tabCommentslist_tabCommentsuseful_save";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save.TabIndex = 9;
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save.Text = "Save";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_save.UseVisualStyleBackColor = true;
            // 
            // panel_tabPostslist_tabCommentslist_tabCommentsuseful_data
            // 
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.Controls.Add(commentsuseful_pointsLabel);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.Controls.Add(this.commentsuseful_pointsTextBox);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.Location = new System.Drawing.Point(6, 138);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.Name = "panel_tabPostslist_tabCommentslist_tabCommentsuseful_data";
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.Size = new System.Drawing.Size(336, 57);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.TabIndex = 2;
            // 
            // commentsuseful_pointsTextBox
            // 
            this.commentsuseful_pointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsusefulBindingSource, "commentsuseful_points", true));
            this.commentsuseful_pointsTextBox.Location = new System.Drawing.Point(8, 25);
            this.commentsuseful_pointsTextBox.Name = "commentsuseful_pointsTextBox";
            this.commentsuseful_pointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.commentsuseful_pointsTextBox.TabIndex = 1;
            // 
            // commentsusefulBindingSource
            // 
            this.commentsusefulBindingSource.DataSource = typeof(commentsuseful);
            this.commentsusefulBindingSource.CurrentChanged += new System.EventHandler(this.commentsusefulBindingSource_CurrentChanged);
            // 
            // panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions
            // 
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.Controls.Add(this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.Controls.Add(this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.Controls.Add(this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.Location = new System.Drawing.Point(6, 92);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.Name = "panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions";
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.Size = new System.Drawing.Size(336, 40);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.TabIndex = 1;
            // 
            // button_tabPostslist_tabCommentslist_tabCommentsuseful_delete
            // 
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete.Location = new System.Drawing.Point(165, 3);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete.Name = "button_tabPostslist_tabCommentslist_tabCommentsuseful_delete";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete.TabIndex = 11;
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete.Text = "Delete";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_delete.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabCommentslist_tabCommentsuseful_edit
            // 
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit.Location = new System.Drawing.Point(84, 3);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit.Name = "button_tabPostslist_tabCommentslist_tabCommentsuseful_edit";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit.TabIndex = 10;
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit.Text = "Edit";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_edit.UseVisualStyleBackColor = true;
            // 
            // button_tabPostslist_tabCommentslist_tabCommentsuseful_new
            // 
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new.Location = new System.Drawing.Point(3, 3);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new.Name = "button_tabPostslist_tabCommentslist_tabCommentsuseful_new";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new.Size = new System.Drawing.Size(75, 23);
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new.TabIndex = 9;
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new.Text = "New";
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new.UseVisualStyleBackColor = true;
            this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new.Click += new System.EventHandler(this.button_tabPostslist_tabCommentslist_tabCommentsuseful_new_Click);
            // 
            // panel_tabPostslist_tabCommentslist_tabCommentsuseful_list
            // 
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list.Controls.Add(this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list.Location = new System.Drawing.Point(6, 6);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list.Name = "panel_tabPostslist_tabCommentslist_tabCommentsuseful_list";
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list.Size = new System.Drawing.Size(336, 80);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list.TabIndex = 0;
            // 
            // dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list
            // 
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.AllowUserToAddRows = false;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.AllowUserToDeleteRows = false;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.AllowUserToResizeColumns = false;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.AutoGenerateColumns = false;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentsusefulidDataGridViewTextBoxColumn,
            this.commentsidDataGridViewTextBoxColumn1,
            this.pointsDataGridViewTextBoxColumn});
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.DataSource = this.vCommentsUsefulBindingSource;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.MultiSelect = false;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.Name = "dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list";
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.ReadOnly = true;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.RowHeadersVisible = false;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.Size = new System.Drawing.Size(336, 80);
            this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.TabIndex = 5;
            // 
            // commentsusefulidDataGridViewTextBoxColumn
            // 
            this.commentsusefulidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentsusefulidDataGridViewTextBoxColumn.DataPropertyName = "commentsuseful_id";
            this.commentsusefulidDataGridViewTextBoxColumn.HeaderText = "commentsuseful_id";
            this.commentsusefulidDataGridViewTextBoxColumn.Name = "commentsusefulidDataGridViewTextBoxColumn";
            this.commentsusefulidDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsusefulidDataGridViewTextBoxColumn.Width = 70;
            // 
            // commentsidDataGridViewTextBoxColumn1
            // 
            this.commentsidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentsidDataGridViewTextBoxColumn1.DataPropertyName = "comments_id";
            this.commentsidDataGridViewTextBoxColumn1.HeaderText = "comments_id";
            this.commentsidDataGridViewTextBoxColumn1.Name = "commentsidDataGridViewTextBoxColumn1";
            this.commentsidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.commentsidDataGridViewTextBoxColumn1.Width = 70;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vCommentsUsefulBindingSource
            // 
            this.vCommentsUsefulBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VCommentsUseful);
            this.vCommentsUsefulBindingSource.CurrentChanged += new System.EventHandler(this.vCommentsUsefulBindingSource_CurrentChanged);
            // 
            // panel_tabPostslist_tabCommentslist_list
            // 
            this.panel_tabPostslist_tabCommentslist_list.Controls.Add(this.dataGridView_tabPostslist_tabCommentslist_list);
            this.panel_tabPostslist_tabCommentslist_list.Location = new System.Drawing.Point(6, 6);
            this.panel_tabPostslist_tabCommentslist_list.Name = "panel_tabPostslist_tabCommentslist_list";
            this.panel_tabPostslist_tabCommentslist_list.Size = new System.Drawing.Size(356, 80);
            this.panel_tabPostslist_tabCommentslist_list.TabIndex = 0;
            // 
            // dataGridView_tabPostslist_tabCommentslist_list
            // 
            this.dataGridView_tabPostslist_tabCommentslist_list.AllowUserToAddRows = false;
            this.dataGridView_tabPostslist_tabCommentslist_list.AllowUserToDeleteRows = false;
            this.dataGridView_tabPostslist_tabCommentslist_list.AllowUserToResizeColumns = false;
            this.dataGridView_tabPostslist_tabCommentslist_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_tabPostslist_tabCommentslist_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_tabPostslist_tabCommentslist_list.AutoGenerateColumns = false;
            this.dataGridView_tabPostslist_tabCommentslist_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tabPostslist_tabCommentslist_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentsidDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn});
            this.dataGridView_tabPostslist_tabCommentslist_list.DataSource = this.vCommentsBindingSource;
            this.dataGridView_tabPostslist_tabCommentslist_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tabPostslist_tabCommentslist_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_tabPostslist_tabCommentslist_list.MultiSelect = false;
            this.dataGridView_tabPostslist_tabCommentslist_list.Name = "dataGridView_tabPostslist_tabCommentslist_list";
            this.dataGridView_tabPostslist_tabCommentslist_list.ReadOnly = true;
            this.dataGridView_tabPostslist_tabCommentslist_list.RowHeadersVisible = false;
            this.dataGridView_tabPostslist_tabCommentslist_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tabPostslist_tabCommentslist_list.Size = new System.Drawing.Size(356, 80);
            this.dataGridView_tabPostslist_tabCommentslist_list.TabIndex = 4;
            // 
            // commentsidDataGridViewTextBoxColumn
            // 
            this.commentsidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentsidDataGridViewTextBoxColumn.DataPropertyName = "comments_id";
            this.commentsidDataGridViewTextBoxColumn.HeaderText = "comments_id";
            this.commentsidDataGridViewTextBoxColumn.Name = "commentsidDataGridViewTextBoxColumn";
            this.commentsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsidDataGridViewTextBoxColumn.Width = 70;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.HeaderText = "text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vCommentsBindingSource
            // 
            this.vCommentsBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VComments);
            // 
            // panel_tabPostslist_list
            // 
            this.panel_tabPostslist_list.Controls.Add(this.dataGridView_tabPostslist_list);
            this.panel_tabPostslist_list.Location = new System.Drawing.Point(6, 6);
            this.panel_tabPostslist_list.Name = "panel_tabPostslist_list";
            this.panel_tabPostslist_list.Size = new System.Drawing.Size(382, 80);
            this.panel_tabPostslist_list.TabIndex = 0;
            // 
            // dataGridView_tabPostslist_list
            // 
            this.dataGridView_tabPostslist_list.AllowUserToAddRows = false;
            this.dataGridView_tabPostslist_list.AllowUserToDeleteRows = false;
            this.dataGridView_tabPostslist_list.AllowUserToResizeColumns = false;
            this.dataGridView_tabPostslist_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_tabPostslist_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_tabPostslist_list.AutoGenerateColumns = false;
            this.dataGridView_tabPostslist_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tabPostslist_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postsidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1});
            this.dataGridView_tabPostslist_list.DataSource = this.vPostsBindingSource;
            this.dataGridView_tabPostslist_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tabPostslist_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_tabPostslist_list.MultiSelect = false;
            this.dataGridView_tabPostslist_list.Name = "dataGridView_tabPostslist_list";
            this.dataGridView_tabPostslist_list.ReadOnly = true;
            this.dataGridView_tabPostslist_list.RowHeadersVisible = false;
            this.dataGridView_tabPostslist_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tabPostslist_list.Size = new System.Drawing.Size(382, 80);
            this.dataGridView_tabPostslist_list.TabIndex = 3;
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
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vPostsBindingSource
            // 
            this.vPostsBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VPosts);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_list);
            this.panel2.Controls.Add(this.panel_filters);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 627);
            this.panel2.TabIndex = 1;
            // 
            // panel_list
            // 
            this.panel_list.Controls.Add(this.dataGridView_list);
            this.panel_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_list.Location = new System.Drawing.Point(0, 56);
            this.panel_list.Name = "panel_list";
            this.panel_list.Size = new System.Drawing.Size(371, 571);
            this.panel_list.TabIndex = 1;
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.AllowUserToAddRows = false;
            this.dataGridView_list.AllowUserToDeleteRows = false;
            this.dataGridView_list.AllowUserToResizeColumns = false;
            this.dataGridView_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_list.AutoGenerateColumns = false;
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blogsidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView_list.DataSource = this.vBlogsBindingSource;
            this.dataGridView_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_list.MultiSelect = false;
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.ReadOnly = true;
            this.dataGridView_list.RowHeadersVisible = false;
            this.dataGridView_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_list.Size = new System.Drawing.Size(371, 571);
            this.dataGridView_list.TabIndex = 2;
            // 
            // blogsidDataGridViewTextBoxColumn
            // 
            this.blogsidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.blogsidDataGridViewTextBoxColumn.DataPropertyName = "blogs_id";
            this.blogsidDataGridViewTextBoxColumn.HeaderText = "blogs_id";
            this.blogsidDataGridViewTextBoxColumn.Name = "blogsidDataGridViewTextBoxColumn";
            this.blogsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.blogsidDataGridViewTextBoxColumn.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vBlogsBindingSource
            // 
            this.vBlogsBindingSource.DataSource = typeof(DG.UIGHFSample.Objects.View.VBlogs);
            // 
            // panel_filters
            // 
            this.panel_filters.Controls.Add(this.button_reloadview);
            this.panel_filters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filters.Location = new System.Drawing.Point(0, 0);
            this.panel_filters.Name = "panel_filters";
            this.panel_filters.Size = new System.Drawing.Size(371, 56);
            this.panel_filters.TabIndex = 0;
            // 
            // button_reloadview
            // 
            this.button_reloadview.Location = new System.Drawing.Point(3, 12);
            this.button_reloadview.Name = "button_reloadview";
            this.button_reloadview.Size = new System.Drawing.Size(75, 23);
            this.button_reloadview.TabIndex = 3;
            this.button_reloadview.Text = "Reload";
            this.button_reloadview.UseVisualStyleBackColor = true;
            this.button_reloadview.Click += new System.EventHandler(this.button_reloadview_Click);
            // 
            // FormBlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(775, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBlogs";
            this.Text = "FormBlogs";
            this.Load += new System.EventHandler(this.FormBlogs_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_tabBlogs.ResumeLayout(false);
            this.panel_tabBlogs_updates.ResumeLayout(false);
            this.panel_tabBlogs_data.ResumeLayout(false);
            this.panel_tabBlogs_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            this.panel_tabBlogs_actions.ResumeLayout(false);
            this.tabPage_tabPostslist.ResumeLayout(false);
            this.panel_tabPostslist_data.ResumeLayout(false);
            this.tabControl_tabPostslist.ResumeLayout(false);
            this.tabPage_tabPostslist_tabPosts.ResumeLayout(false);
            this.panel_tabPostslist_tabPosts_actions.ResumeLayout(false);
            this.panel_tabPostslist_tabPosts_data.ResumeLayout(false);
            this.panel_tabPostslist_tabPosts_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.panel_tabPostslist_tabPosts_updates.ResumeLayout(false);
            this.tabPage_tabPostslist_tabCommentslist.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_data.ResumeLayout(false);
            this.tabControl_tabPostslist_tabCommentslist.ResumeLayout(false);
            this.tabPage_tabPostslist_tabCommentslist_tabComments.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_tabComments_updates.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_tabComments_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.panel_tabPostslist_tabCommentslist_tabComments_actions.ResumeLayout(false);
            this.tabPage_tabPostslist_tabCommentslist_tabCommentsuseful.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsusefulBindingSource)).EndInit();
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions.ResumeLayout(false);
            this.panel_tabPostslist_tabCommentslist_tabCommentsuseful_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCommentsUsefulBindingSource)).EndInit();
            this.panel_tabPostslist_tabCommentslist_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostslist_tabCommentslist_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCommentsBindingSource)).EndInit();
            this.panel_tabPostslist_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabPostslist_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPostsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBlogsBindingSource)).EndInit();
            this.panel_filters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_tabBlogs;
        private System.Windows.Forms.Panel panel_tabBlogs_updates;
        private System.Windows.Forms.Panel panel_tabBlogs_data;
        private System.Windows.Forms.Panel panel_tabBlogs_actions;
        private System.Windows.Forms.TabPage tabPage_tabPostslist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_list;
        private System.Windows.Forms.Panel panel_filters;
        private System.Windows.Forms.DataGridView dataGridView_list;
        private System.Windows.Forms.BindingSource vBlogsBindingSource;
        private System.Windows.Forms.Button button_tabBlogs_cancel;
        private System.Windows.Forms.Button button_tabBlogs_save;
        private System.Windows.Forms.TextBox blogs_descriptionTextBox;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private System.Windows.Forms.TextBox blogs_titleTextBox;
        private System.Windows.Forms.Button button_tabBlogs_delete;
        private System.Windows.Forms.Button button_tabBlogs_edit;
        private System.Windows.Forms.Button button_tabBlogs_new;
        private System.Windows.Forms.Panel panel_tabPostslist_tabPosts_updates;
        private System.Windows.Forms.Panel panel_tabPostslist_tabPosts_data;
        private System.Windows.Forms.TextBox posts_textTextBox;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.TextBox posts_usernameTextBox;
        private System.Windows.Forms.TextBox posts_titleTextBox;
        private System.Windows.Forms.Panel panel_tabPostslist_tabPosts_actions;
        private System.Windows.Forms.Button button_tabPostslist_tabPosts_delete;
        private System.Windows.Forms.Button button_tabPostslist_tabPosts_edit;
        private System.Windows.Forms.Button button_tabPostslist_tabPosts_new;
        private System.Windows.Forms.Panel panel_tabPostslist_list;
        private System.Windows.Forms.DataGridView dataGridView_tabPostslist_list;
        private System.Windows.Forms.Button button_tabPostslist_tabPosts_cancel;
        private System.Windows.Forms.Button button_tabPostslist_tabPosts_save;
        private System.Windows.Forms.BindingSource vPostsBindingSource;
        private System.Windows.Forms.TextBox posts_emailTextBox;
        private System.Windows.Forms.DateTimePicker blogs_dateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn postsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_reloadview;
        private System.Windows.Forms.TabControl tabControl_tabPostslist;
        private System.Windows.Forms.TabPage tabPage_tabPostslist_tabPosts;
        private System.Windows.Forms.TabPage tabPage_tabPostslist_tabCommentslist;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_data;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_list;
        private System.Windows.Forms.DataGridView dataGridView_tabPostslist_tabCommentslist_list;
        private System.Windows.Forms.Panel panel_tabPostslist_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vCommentsBindingSource;
        private System.Windows.Forms.TabControl tabControl_tabPostslist_tabCommentslist;
        private System.Windows.Forms.TabPage tabPage_tabPostslist_tabCommentslist_tabComments;
        private System.Windows.Forms.TabPage tabPage_tabPostslist_tabCommentslist_tabCommentsuseful;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_tabComments_actions;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabComments_delete;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabComments_edit;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabComments_new;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_tabComments_updates;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabComments_cancel;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabComments_save;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_tabComments_data;
        private System.Windows.Forms.TextBox comments_textTextBox;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.TextBox comments_emailTextBox;
        private System.Windows.Forms.TextBox comments_usernameTextBox;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_tabCommentsuseful_data;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabCommentsuseful_delete;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabCommentsuseful_edit;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabCommentsuseful_new;
        private System.Windows.Forms.Panel panel_tabPostslist_tabCommentslist_tabCommentsuseful_list;
        private System.Windows.Forms.DataGridView dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list;
        private System.Windows.Forms.BindingSource vCommentsUsefulBindingSource;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel;
        private System.Windows.Forms.Button button_tabPostslist_tabCommentslist_tabCommentsuseful_save;
        private System.Windows.Forms.TextBox commentsuseful_pointsTextBox;
        private System.Windows.Forms.BindingSource commentsusefulBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsusefulidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
    }
}