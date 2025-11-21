using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.models
{
    using System;

    public class UserBookingHistory
    {
        private int historyId;
        private int userId;
        private int roomId;
        private string checkIn;
        private string checkOut;
        private DateTime dateBooked;
        private bool isCancelled;
        private int bookingId;
        private RoomType roomType;

        // --- Getters and Setters ---

        public int getHistoryId()
        {
            return this.historyId;
        }

        public void setHistoryId(int historyId)
        {
            this.historyId = historyId;
        }

        public int getUserId()
        {
            return this.userId;
        }

        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public int getRoomId()
        {
            return this.roomId;
        }

        public void setRoomId(int roomId)
        {
            this.roomId = roomId;
        }

        public string getCheckIn()
        {
            return this.checkIn;
        }

        public void setCheckIn(string checkIn)
        {
            this.checkIn = checkIn;
        }

        public string getCheckOut()
        {
            return this.checkOut;
        }

        public void setCheckOut(string checkOut)
        {
            this.checkOut = checkOut;
        }

        public DateTime getDateBooked()
        {
            return this.dateBooked;
        }

        public void setDateBooked(DateTime dateBooked)
        {
            this.dateBooked = dateBooked;
        }

        public bool getIsCancelled()
        {
            return this.isCancelled;
        }

        public void setCancelled(bool cancelled)
        {
            this.isCancelled = cancelled;
        }

        public int getBookingId()
        {
            return this.bookingId;
        }

        // Note: setBookingId was not present in your requirements list, 
        // but typically you would add:
        public void setBookingId(int bookingId)
        {
            this.bookingId = bookingId;
        }

        public RoomType getRoomType()
        {
            return this.roomType;
        }

        public void setRoomType(RoomType roomType)
        {
            this.roomType = roomType;
        }
    }
}
