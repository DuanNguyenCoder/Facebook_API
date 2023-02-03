using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACEBOOKI_API_TH3
{
    public partial class Form1 : Form
    {
        public string access_token = "EAAaeqgR9D70BAIAdzEde37ElAHlL6Ds9pNxaLZCHjb8ZAZCZBPNpeE3eTOMPRECJOMOyBfEfqbGZAKY2gEpliEQJ5lxR4PEaZBUWHX0Au56kdbc7ZC8RVT4qgWiOpanbWq8XTDq7c8Rke1qDVDCGHUgNR4mzrIEY7V6Nvk8pG0a7wZDZD";
        public string page_access_token;
        public Form1()
        {
            InitializeComponent();
                get_user_page();
        }
        void get_user_page()
        {
            webBrowser1.Navigate("https://www.facebook.com/login.php/");
            ListViewItem item;
            string[] arr = new string[3];
            FacebookClient fb = new FacebookClient(access_token);
            dynamic getdata_status = fb.Get("me/accounts");
            int count = (int)getdata_status.data.Count;
            for (int i = 0; i < count; i++)
            {
                arr[0] = getdata_status.data[i].name;
                arr[1] = getdata_status.data[i].id;
                arr[2] = getdata_status.data[i].access_token;
                item = new ListViewItem(arr);
                lv_page_user.Items.Add(item);
            }
        }

        private void lv_page_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_page_user.Rows.Clear();
            if (lv_page_user.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lv_page_user.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                try
                {
                    get_Post_page(lv_page_user.SelectedItems[0].SubItems[2].Text, dataGridView_page_user, "me/feed?fields=message,full_picture,created_time,id");
                    page_access_token = lv_page_user.SelectedItems[0].SubItems[2].Text;
                        }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           
        }
        private void get_Post_page(string access_token, DataGridView dtgv, string parameter)
        {
            dtgv.Rows.Clear();
            FacebookClient fb = new FacebookClient(access_token);
            dynamic getdata_group = fb.Get(parameter);
            int count = (int)getdata_group.data.Count;
            for (int i = 0; i < count; i++)
            {
                dtgv.Rows.Add();
                dtgv.Rows[i].Cells[0].Value = getdata_group.data[i].message;
               
                    dtgv.Rows[i].Cells[1].Value = getdata_group.data[i].created_time;
            
                dtgv.Rows[i].Cells[2].Value = getdata_group.data[i].id;
               

            }
        }

        private void dataGridView_page_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_content_post.Text = dataGridView_page_user.CurrentRow.Cells[0].Value.ToString();
            lb_count_like.Text = Count_like().ToString();
            lb_count_comment.Text = Count_Comment().ToString();
            lb_postName.Text = dataGridView_page_user.CurrentRow.Cells[0].Value.ToString();


        }
        private int Count_like()
        {
            try
            {
            string id_post = dataGridView_page_user.CurrentRow.Cells[2].Value.ToString();   
            FacebookClient fb = new FacebookClient(page_access_token);
            dynamic getdata_page = fb.Get(id_post+ "?fields=likes.summary(true)");
            int count = (int)getdata_page.likes.summary.total_count;
            return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private int Count_Comment()
        {
            try
            {
            string id_post = dataGridView_page_user.CurrentRow.Cells[2].Value.ToString();
            FacebookClient fb = new FacebookClient(page_access_token);
            dynamic getdata_page = fb.Get(id_post + "?fields=comments.summary(true)");
            int count = (int)getdata_page.comments.summary.total_count;
            return count;

            }
            catch (Exception)
            {

                return 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txt_content_comment_status.Text != "")
            {
            try
            {
                string id_post = dataGridView_page_user.CurrentRow.Cells[2].Value.ToString();
                FacebookClient fb = new FacebookClient(page_access_token);
                dynamic getdata_page = fb.Post(id_post + "/comments?fields=message",new
                {
                    message = txt_content_comment_status.Text,

                });
                    MessageBox.Show("success");

                }
            catch (Exception)
            {
               throw;
            }

            }
            else
            {
                MessageBox.Show("vui long khong de trong");
            }
        }
    }
}
