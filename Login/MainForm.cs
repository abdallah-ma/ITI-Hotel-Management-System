using Hotel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hotel.BLL.Managers;
using Hotel.UI;

namespace Login
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        BindingList<Reservation> Reservations;
        BindingSource BindingSource;

        
        private void AddReservationBtn_Click(object sender, EventArgs e)
        {

            var AddReservationFrm = new AddReservation();
            AddReservationFrm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Reservations = ReservationManager.GetAllReservation();

            BindingSource = new BindingSource(Reservations, "");

            IdLabel.DataBindings.Add("Text", BindingSource, "Id");
            FirstNameLabel.DataBindings.Add("Text", BindingSource, "Guest.FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
            LastNameLabel.DataBindings.Add("Text", BindingSource, "Guest.LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            PhoneNoLabel.DataBindings.Add("Text", BindingSource, "Guest.PhoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);

            RoomNoLabel.DataBindings.Add("Text", BindingSource, "RoomNumber", true, DataSourceUpdateMode.OnPropertyChanged);

            listBox1.DataSource = Reservations;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Id";

        }

        private void RemoveReservation_Click(object sender, EventArgs e)
        {
            int.TryParse(IdLabel.Text, out int reservationId);

            if (MessageBox.Show("", "Are you sure you want to remove this reservation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ReservationManager.RemoveReservation(reservationId);
            }
        }

        private void UpdateReservationBtn_Click(object sender, EventArgs e)
        {

            int oldRoomNumber;

            int.TryParse(RoomNoLabel.Text, out oldRoomNumber);
            

            var UpdateReservationFrm = new UpdateReservationFrm((Reservation)listBox1.SelectedItem , Reservations , oldRoomNumber);

            UpdateReservationFrm.Show();
        }
    }
}
