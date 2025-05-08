using BT5_ThieuKhaiNhi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BT5_ThieuKhaiNhi
{
    public partial class Form1 : Form
    { private SampleData data ;
        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Email", 200);
            data = new SampleData();
            ShowData();
            treeView1.AfterSelect += treeView1_AfterSelect;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }
        private void ShowData()
        {
            // Xóa tất cả các node hiện tại
            treeView1.Nodes.Clear();

            // Duyệt qua từng khoa
            for (int i = 0; i < data.Departments.Count; i++)
            {
                Department khoa = data.Departments[i];

                // Tạo node cho khoa
                TreeNode nodeKhoa = new TreeNode(khoa.Name);

                // Duyệt qua từng lớp trong khoa
                for (int j = 0; j < khoa.Classes.Count; j++)
                {
                    Clazz lop = khoa.Classes[j];

                    // Tạo node cho lớp
                    TreeNode nodeLop = new TreeNode("Class " + lop.ClassId);

                    // Lưu thông tin lớp vào Tag của node
                    nodeLop.Tag = lop;

                    // Thêm node lớp vào node khoa
                    nodeKhoa.Nodes.Add(nodeLop);
                }

                // Thêm node khoa vào TreeView
                treeView1.Nodes.Add(nodeKhoa);
            }

            // Mở rộng tất cả các node
            treeView1.ExpandAll();
        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Lấy node được chọn
            TreeNode selectedNode = e.Node;

            // Kiểm tra xem node có chứa thông tin lớp không
            if (selectedNode.Tag != null && selectedNode.Tag is Clazz)
            {
                // Lấy thông tin lớp từ Tag
                Clazz lop = (Clazz)selectedNode.Tag;

                // Hiển thị danh sách sinh viên của lớp
                ShowListStudent(lop);
            }
            else
            {
                // Nếu không phải node lớp, xóa danh sách sinh viên
                listView1.Items.Clear();
            }
        }
        private void ShowListStudent(Clazz lop)
        {
            // Xóa tất cả các item hiện tại
            listView1.Items.Clear();

            // Duyệt qua từng sinh viên trong lớp
            for (int i = 0; i < lop.Students.Count; i++)
            {
                Student sv = lop.Students[i];

                // Tạo item cho sinh viên
                ListViewItem item = new ListViewItem(sv.Id.ToString());

                // Thêm các thông tin khác
                item.SubItems.Add(sv.Name);
                item.SubItems.Add(sv.Email);

                // Lưu thông tin sinh viên vào Tag của item
                item.Tag = sv;

                // Thêm item vào ListView
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có item nào được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy item được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Lấy thông tin sinh viên từ Tag
                Student sv = (Student)selectedItem.Tag;

                // Hiển thị thông tin sinh viên lên TextBox
                txtID.Text = sv.Id.ToString();
                txtName.Text = sv.Name;
            }
        }
    }
}
