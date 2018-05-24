namespace CISModelGenerator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_security_groups = new System.Windows.Forms.Button();
            this.button_folders = new System.Windows.Forms.Button();
            this.button_dashBoard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_company_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.button_minimise = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_security_groups);
            this.panel1.Controls.Add(this.button_folders);
            this.panel1.Controls.Add(this.button_dashBoard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_security_groups
            // 
            this.button_security_groups.FlatAppearance.BorderSize = 0;
            this.button_security_groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_security_groups.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_security_groups.ForeColor = System.Drawing.Color.White;
            this.button_security_groups.Image = ((System.Drawing.Image)(resources.GetObject("button_security_groups.Image")));
            this.button_security_groups.Location = new System.Drawing.Point(-2, 500);
            this.button_security_groups.Name = "button_security_groups";
            this.button_security_groups.Size = new System.Drawing.Size(199, 167);
            this.button_security_groups.TabIndex = 3;
            this.button_security_groups.Text = "Security Groups";
            this.button_security_groups.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_security_groups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_security_groups.UseVisualStyleBackColor = true;
            this.button_security_groups.Click += new System.EventHandler(this.button_security_groups_Click);
            // 
            // button_folders
            // 
            this.button_folders.FlatAppearance.BorderSize = 0;
            this.button_folders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_folders.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_folders.ForeColor = System.Drawing.Color.White;
            this.button_folders.Image = ((System.Drawing.Image)(resources.GetObject("button_folders.Image")));
            this.button_folders.Location = new System.Drawing.Point(0, 327);
            this.button_folders.Name = "button_folders";
            this.button_folders.Size = new System.Drawing.Size(199, 167);
            this.button_folders.TabIndex = 2;
            this.button_folders.Text = "Folders";
            this.button_folders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_folders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_folders.UseVisualStyleBackColor = true;
            this.button_folders.Click += new System.EventHandler(this.button_folders_Click);
            // 
            // button_dashBoard
            // 
            this.button_dashBoard.FlatAppearance.BorderSize = 0;
            this.button_dashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashBoard.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashBoard.ForeColor = System.Drawing.Color.White;
            this.button_dashBoard.Image = ((System.Drawing.Image)(resources.GetObject("button_dashBoard.Image")));
            this.button_dashBoard.Location = new System.Drawing.Point(0, 154);
            this.button_dashBoard.Name = "button_dashBoard";
            this.button_dashBoard.Size = new System.Drawing.Size(199, 167);
            this.button_dashBoard.TabIndex = 1;
            this.button_dashBoard.Text = "Dashboard";
            this.button_dashBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_dashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_dashBoard.UseVisualStyleBackColor = true;
            this.button_dashBoard.Click += new System.EventHandler(this.button_dashBoard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label_company_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 100);
            this.panel3.TabIndex = 0;
            // 
            // label_company_name
            // 
            this.label_company_name.AutoSize = true;
            this.label_company_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_company_name.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company_name.Location = new System.Drawing.Point(0, 0);
            this.label_company_name.Name = "label_company_name";
            this.label_company_name.Size = new System.Drawing.Size(507, 194);
            this.label_company_name.TabIndex = 3;
            this.label_company_name.Text = "tenzing";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(202, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 120);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "CIS Model Generator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_left.Location = new System.Drawing.Point(208, 154);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(6, 167);
            this.panel_left.TabIndex = 3;
            // 
            // button_close
            // 
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(965, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 25);
            this.button_close.TabIndex = 4;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_minimise
            // 
            this.button_minimise.FlatAppearance.BorderSize = 0;
            this.button_minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimise.Image = ((System.Drawing.Image)(resources.GetObject("button_minimise.Image")));
            this.button_minimise.Location = new System.Drawing.Point(930, 4);
            this.button_minimise.Name = "button_minimise";
            this.button_minimise.Size = new System.Drawing.Size(25, 25);
            this.button_minimise.TabIndex = 5;
            this.button_minimise.UseVisualStyleBackColor = true;
            this.button_minimise.Click += new System.EventHandler(this.button_minimise_Click);
            this.button_minimise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_minimise_KeyPress);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(234, 154);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(621, 420);
            this.panel_main.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button_minimise);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_company_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dashBoard;
        private System.Windows.Forms.Button button_security_groups;
        private System.Windows.Forms.Button button_folders;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_minimise;
        private System.Windows.Forms.Panel panel_main;
    }
}

