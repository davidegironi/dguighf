namespace DG.UI.GHF
{
    partial class DGUIGHFFormStackTracer
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
            this.button_continue = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.textBox_stacktrace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label_errormessage = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_details = new System.Windows.Forms.Button();
            this.panel_details = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_continue
            // 
            this.button_continue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_continue.Location = new System.Drawing.Point(298, 6);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(75, 23);
            this.button_continue.TabIndex = 2;
            this.button_continue.Text = "Continue";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(379, 6);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Quit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // textBox_stacktrace
            // 
            this.textBox_stacktrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_stacktrace.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stacktrace.Location = new System.Drawing.Point(12, 2);
            this.textBox_stacktrace.Multiline = true;
            this.textBox_stacktrace.Name = "textBox_stacktrace";
            this.textBox_stacktrace.ReadOnly = true;
            this.textBox_stacktrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_stacktrace.Size = new System.Drawing.Size(440, 134);
            this.textBox_stacktrace.TabIndex = 7;
            this.textBox_stacktrace.TabStop = false;
            this.textBox_stacktrace.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "We are Sorry. An unexpected error has occurred.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_continue);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 35);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 124);
            this.panel3.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label_info);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(100, 29);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel6.Size = new System.Drawing.Size(364, 60);
            this.panel6.TabIndex = 20;
            // 
            // label_info
            // 
            this.label_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info.Location = new System.Drawing.Point(10, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(344, 60);
            this.label_info.TabIndex = 17;
            this.label_info.Text = "If you click Continue the application will ignore this error.\r\nIf you click Quit " +
    "the application will be shutdown immediately.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(100, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 29);
            this.panel5.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 89);
            this.panel4.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 35);
            this.panel2.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label_errormessage);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(123, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel8.Size = new System.Drawing.Size(341, 35);
            this.panel8.TabIndex = 5;
            // 
            // label_errormessage
            // 
            this.label_errormessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_errormessage.Location = new System.Drawing.Point(10, 0);
            this.label_errormessage.Name = "label_errormessage";
            this.label_errormessage.Size = new System.Drawing.Size(321, 35);
            this.label_errormessage.TabIndex = 0;
            this.label_errormessage.Text = "Error: Unknown.";
            this.label_errormessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button_details);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(123, 35);
            this.panel7.TabIndex = 4;
            // 
            // button_details
            // 
            this.button_details.Location = new System.Drawing.Point(12, 6);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(100, 23);
            this.button_details.TabIndex = 3;
            this.button_details.Text = "> Show Details";
            this.button_details.UseVisualStyleBackColor = true;
            this.button_details.Click += new System.EventHandler(this.button_details_Click);
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.textBox_stacktrace);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.Location = new System.Drawing.Point(0, 124);
            this.panel_details.Name = "panel_details";
            this.panel_details.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.panel_details.Size = new System.Drawing.Size(464, 138);
            this.panel_details.TabIndex = 17;
            // 
            // DGUIGHFFormStackTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 297);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 335);
            this.Name = "DGUIGHFFormStackTracer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stack Tracer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DGUIGHFFormStackTracer_FormClosing);
            this.Load += new System.EventHandler(this.DGUIGHFFormStackTracer_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textBox_stacktrace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.Button button_details;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label_errormessage;
        private System.Windows.Forms.Panel panel7;

    }
}