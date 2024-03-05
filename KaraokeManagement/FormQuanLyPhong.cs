using KaraokeManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManagement
{
    public partial class FormQuanLyPhong : Form
    {
        public FormQuanLyPhong()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            var db = new KaraDB();
            var RoomList = db.Rooms.OrderBy(room => room.RoomNumber).ToList();
            roomBindingSource.DataSource = RoomList;
        }

        private void FormQuanLyPhong_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRoom = roomBindingSource.Current;
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
                return;
            row = tblRoom.Rows[e.RowIndex];
            Room sp = (Room)row.DataBoundItem;
            txtId.Text = sp.RoomID.ToString();
            txtRoomNum.Text = sp.RoomNumber;
            cbbRoomType.SelectedItem = sp.RoomType;
            cbbRoomRate.SelectedItem = Convert.ToUInt32(sp.Rate).ToString();
            cbbIsOccpied.SelectedItem = sp.IsOccupied ? "Có" : "Không";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new KaraDB();
                db.Database.EnsureCreated();
                Room newRoom = new Room()
                {
                    RoomNumber = txtRoomNum.Text,
                    RoomType = cbbRoomType?.SelectedItem.ToString(),
                    Rate = Convert.ToInt32(cbbRoomRate.SelectedItem),
                    IsOccupied = cbbIsOccpied.SelectedItem.ToString().Equals("Có") ? true : false,
                };
                var check = db.Rooms.Where(r => r.RoomNumber == newRoom.RoomNumber).FirstOrDefault();
                if (check != null)
                {
                    MessageBox.Show("Số phòng đã tồn tại!", "Thông báo");
                    return;
                }
                db.Rooms.Add(newRoom);
                db.SaveChanges();
                LoadData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Room editedRoom = new Room()
                {
                    RoomID = Convert.ToInt32(txtId.Text),
                    RoomNumber = txtRoomNum.Text,
                    RoomType = cbbRoomType?.SelectedItem.ToString(),
                    Rate = Convert.ToInt32(cbbRoomRate.SelectedItem),
                    IsOccupied = cbbIsOccpied.SelectedItem.ToString().Equals("Có") ? true : false,
                };
                var db = new KaraDB();
                db.Database.EnsureCreated();
                var obj = db.Rooms.Find(editedRoom.RoomID);
                if (obj != null)
                {
                    obj.RoomNumber = editedRoom.RoomNumber;
                    obj.RoomType = editedRoom.RoomType;
                    obj.Rate = editedRoom.Rate;
                    obj.IsOccupied = editedRoom.IsOccupied;
                    db.SaveChanges();
                    LoadData();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var db = new KaraDB();
            var obj = db.Rooms.Find(Convert.ToInt32(txtId.Text));
            if (obj != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    db.Rooms.Remove(obj);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }
    }
}
