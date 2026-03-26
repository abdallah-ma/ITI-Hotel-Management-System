using Hotel.BLL.Managers;
using Hotel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class UpdateReservationFrm : Form
    {
        public UpdateReservationFrm()
        {
            InitializeComponent();
        }


        public Reservation NewReservation;
        public BindingList<Reservation> Reservations;
        BindingSource BindingSource;
        int OldRoomNumber;
        public UpdateReservationFrm(Reservation newReservation , BindingList<Reservation> reservations , int oldRoomNumber)
        {
            InitializeComponent();
            NewReservation = newReservation;
            Reservations = reservations;
            OldRoomNumber = oldRoomNumber;
        }
        private void UpdateReservationFrm_Load(object sender, EventArgs e)
        {
            BindingSource = new BindingSource(NewReservation , "");
            NewFirstNameTxtBox.DataBindings.Add("Text", BindingSource, "Guest.FirstName");
            NewLastNameTxtBox.DataBindings.Add("Text", BindingSource, "Guest.LastName");
            NewPhoneNoTxtBox.DataBindings.Add("Text", BindingSource, "Guest.PhoneNumber");
            NewRoomNoTxtBox.DataBindings.Add("Text", BindingSource, "RoomNumber");
        }

        private void UpdateReservationBtn_Click(object sender, EventArgs e)
        {
            int rowsAffected = ReservationManager.UpdateReservation(NewReservation);

            if (rowsAffected == 0)
            {
                MessageBox.Show("Invalid reservation");
            }
            else
            {
                var index = Reservations.IndexOf(
               Reservations.First(r => r.Id == NewReservation.Id) );

                RoomManager.FreeRoom(OldRoomNumber);

                Reservations[index] = NewReservation;
                this.Close();
            }
        }
    }
}
