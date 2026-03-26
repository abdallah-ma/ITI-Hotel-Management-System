using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Hotel.BLL.Managers;
using Hotel.DAL.Entities;

namespace Hotel.UI
{
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var guest = new Guest()
            {
                FirstName = FnameTxtBox.Text,
                LastName = LnameTxtBox.Text,
                PhoneNumber = PhoneNoTxtBox.Text
            };

            var reservation = new Reservation()
            {
                Id = 0,
                Guest = guest,
                GuestPhoneNumber = PhoneNoTxtBox.Text
            };


            if(int.TryParse(RoomNoTxtBox.Text.ToString() , out int roomNo))
            {
                reservation.RoomNumber = roomNo;
            }
            else
            {
                MessageBox.Show("Invalid room no");
            }



            int rowsAffected = ReservationManager.AddReservation(reservation);

            if(rowsAffected == 0)
            {
                MessageBox.Show("Invalid reservation");
            }
            else
            {
                RoomManager.MarkAsBooked(roomNo);
                this.Close();
            }
        }
    }
}
