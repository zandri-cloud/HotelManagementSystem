using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.models
{
    // Enum definition required for the code to compile
    public enum RoomType
    {
        Standard,
        Deluxe,
        Suite
    }

    public class Room
    {
        private string _name;
        private User _user;
        private int _price;
        private string _bedType;
        private string _capacity;
        private bool _isPurchased;
        private string _checkIn;
        private string _checkOut;
        private DateTime _bookingDate;
        private RoomType _roomType;
        private int _roomId;

        // --- Constructors ---

        // Constructor 1: Full details (excluding ID, based on your prompt signature)
        public Room(string name, int price, string bedType, string capacity, bool isPurchased,
                    User user, string checkIn, string checkOut, DateTime bookingDate, RoomType roomType)
        {
            this._name = name;
            this._price = price;
            this._bedType = bedType;
            this._capacity = capacity;
            this._isPurchased = isPurchased;
            this._user = user;
            this._checkIn = checkIn;
            this._checkOut = checkOut;
            this._bookingDate = bookingDate;
            this._roomType = roomType;
        }

        // Constructor 2: Partial details
        public Room(string name, int price, string bedType, string capacity, RoomType roomType)
        {
            this._name = name;
            this._price = price;
            this._bedType = bedType;
            this._capacity = capacity;
            this._roomType = roomType;
        }

        // --- Getters and Setters ---

        public string getName()
        {
            return this._name;
        }

        public void setName(string name)
        {
            this._name = name;
        }

        public RoomType getRoomType()
        {
            return this._roomType;
        }

        public void setRoomType(RoomType roomType)
        {
            this._roomType = roomType;
        }

        public int getPrice()
        {
            return this._price;
        }

        public void setPrice(int price)
        {
            this._price = price;
        }

        public string getBedType()
        {
            return this._bedType;
        }

        public void setBedType(string bedType)
        {
            this._bedType = bedType;
        }

        public string getCapacity()
        {
            return this._capacity;
        }

        public void setCapacity(string capacity)
        {
            this._capacity = capacity;
        }

        public bool getIsPurchased()
        {
            return this._isPurchased;
        }

        public void setIsPurchased(bool isPurchased)
        {
            this._isPurchased = isPurchased;
        }

        public string getCheckIn()
        {
            return this._checkIn;
        }

        public void setCheckIn(string checkIn)
        {
            this._checkIn = checkIn;
        }

        public string getCheckOut()
        {
            return this._checkOut;
        }

        public void setCheckOut(string checkOut)
        {
            this._checkOut = checkOut;
        }

        public DateTime getBookingDate()
        {
            return this._bookingDate;
        }

        public void setBookingDate(DateTime bookingDate)
        {
            this._bookingDate = bookingDate;
        }

        public User getUser()
        {
            return this._user;
        }

        public void setUser(User user)
        {
            this._user = user;
        }

        public int getRoomID()
        {
            return this._roomId;
        }

        // Prompt specified parameter name 'index'
        public void setRoomId(int index)
        {
            this._roomId = index;
        }

        // --- Logic Methods ---

        // Usually returns the purchased status or checks if a user is assigned
        public bool isBooked()
        {
            return this._isPurchased;
        }
    }

    public class StandardRoom : Room
    {
        // Matches the prompt's signature passing all data to base
        public StandardRoom(string name, int price, string bedType, string capacity, bool isPurchased,
            User user, string checkIn, string checkOut, DateTime bookingDate, RoomType roomType)
            : base(name, price, bedType, capacity, isPurchased, user, checkIn, checkOut, bookingDate, roomType)
        {
        }
    }

    public class DeluxeRoom : Room
    {
        // Full Constructor: hardcodes RoomType.Deluxe and sets isPurchased to true since User exists
        public DeluxeRoom(string name, int price, string bedType, string capacity,
            User user, string checkIn, string checkOut, DateTime bookingDate)
            : base(name, price, bedType, capacity, true, user, checkIn, checkOut, bookingDate, RoomType.Deluxe)
        {
        }

        // Partial Constructor
        public DeluxeRoom(string name, int price, string bedType, string capacity)
            : base(name, price, bedType, capacity, RoomType.Deluxe)
        {
        }
    }

    public class LuxuryRoom : Room
    {
        // Full Constructor: hardcodes RoomType.Suite (assuming Suite = Luxury)
        public LuxuryRoom(string name, int price, string bedType, string capacity,
            User user, string checkIn, string checkOut, DateTime bookingDate)
            : base(name, price, bedType, capacity, true, user, checkIn, checkOut, bookingDate, RoomType.Suite)
        {
        }

        // Partial Constructor
        public LuxuryRoom(string name, int price, string bedType, string capacity)
            : base(name, price, bedType, capacity, RoomType.Suite)
        {
        }
    }

}
