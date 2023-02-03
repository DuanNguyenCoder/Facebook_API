namespace FACEBOOKI_API_TH3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView_page_user = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lv_page_user = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_content_comment_status = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_postName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_content_post = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_count_comment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_count_like = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_page_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(24, 105);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(332, 537);
            this.webBrowser1.TabIndex = 0;
            // 
            // dataGridView_page_user
            // 
            this.dataGridView_page_user.AllowUserToAddRows = false;
            this.dataGridView_page_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_page_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.id});
            this.dataGridView_page_user.Location = new System.Drawing.Point(373, 105);
            this.dataGridView_page_user.Name = "dataGridView_page_user";
            this.dataGridView_page_user.Size = new System.Drawing.Size(429, 203);
            this.dataGridView_page_user.TabIndex = 20;
            this.dataGridView_page_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_page_user_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "content";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "create_time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 10;
            // 
            // lv_page_user
            // 
            this.lv_page_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_page_user.FullRowSelect = true;
            this.lv_page_user.GridLines = true;
            this.lv_page_user.HideSelection = false;
            this.lv_page_user.Location = new System.Drawing.Point(817, 105);
            this.lv_page_user.Name = "lv_page_user";
            this.lv_page_user.Size = new System.Drawing.Size(263, 203);
            this.lv_page_user.TabIndex = 19;
            this.lv_page_user.UseCompatibleStateImageBehavior = false;
            this.lv_page_user.View = System.Windows.Forms.View.Details;
            this.lv_page_user.SelectedIndexChanged += new System.EventHandler(this.lv_page_user_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "page_name";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "page_id";
            this.columnHeader4.Width = 180;
            // 
            // txt_content_comment_status
            // 
            this.txt_content_comment_status.Location = new System.Drawing.Point(31, 188);
            this.txt_content_comment_status.Multiline = true;
            this.txt_content_comment_status.Name = "txt_content_comment_status";
            this.txt_content_comment_status.Size = new System.Drawing.Size(327, 39);
            this.txt_content_comment_status.TabIndex = 21;
            this.txt_content_comment_status.Text = "write something....";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button9.Location = new System.Drawing.Point(271, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 34);
            this.button9.TabIndex = 22;
            this.button9.Text = "post";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_postName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_content_comment_status);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Location = new System.Drawing.Point(373, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 311);
            this.panel1.TabIndex = 23;
            // 
            // lb_postName
            // 
            this.lb_postName.AutoSize = true;
            this.lb_postName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_postName.ForeColor = System.Drawing.Color.Red;
            this.lb_postName.Location = new System.Drawing.Point(227, 148);
            this.lb_postName.Name = "lb_postName";
            this.lb_postName.Size = new System.Drawing.Size(82, 20);
            this.lb_postName.TabIndex = 29;
            this.lb_postName.Text = "post_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(36, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "*Tạo comment vào bài viết ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(246)))));
            this.panel4.Controls.Add(this.tb_content_post);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(9, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 106);
            this.panel4.TabIndex = 27;
            // 
            // tb_content_post
            // 
            this.tb_content_post.Location = new System.Drawing.Point(30, 26);
            this.tb_content_post.Multiline = true;
            this.tb_content_post.Name = "tb_content_post";
            this.tb_content_post.ReadOnly = true;
            this.tb_content_post.Size = new System.Drawing.Size(292, 76);
            this.tb_content_post.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Content";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Controls.Add(this.lb_count_comment);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(378, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 106);
            this.panel3.TabIndex = 24;
            // 
            // lb_count_comment
            // 
            this.lb_count_comment.AutoSize = true;
            this.lb_count_comment.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_count_comment.ForeColor = System.Drawing.Color.White;
            this.lb_count_comment.Location = new System.Drawing.Point(62, 54);
            this.lb_count_comment.Name = "lb_count_comment";
            this.lb_count_comment.Size = new System.Drawing.Size(33, 37);
            this.lb_count_comment.TabIndex = 1;
            this.lb_count_comment.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Comment Count";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.lb_count_like);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(555, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 106);
            this.panel2.TabIndex = 23;
            // 
            // lb_count_like
            // 
            this.lb_count_like.AutoSize = true;
            this.lb_count_like.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_count_like.ForeColor = System.Drawing.Color.White;
            this.lb_count_like.Location = new System.Drawing.Point(62, 54);
            this.lb_count_like.Name = "lb_count_like";
            this.lb_count_like.Size = new System.Drawing.Size(33, 37);
            this.lb_count_like.TabIndex = 1;
            this.lb_count_like.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIKE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1106, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_page_user);
            this.Controls.Add(this.lv_page_user);
            this.Controls.Add(this.webBrowser1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "facebookAPI_TH3_Daun";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_page_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView_page_user;
        private System.Windows.Forms.ListView lv_page_user;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txt_content_comment_status;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_content_post;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_count_comment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_count_like;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_postName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

