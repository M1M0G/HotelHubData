using System;
using System.Collections.Generic;

namespace HotelHubData
{
    /// <summary>
    /// Бронирование номера
    /// </summary>
    public class Booking
    {

        /// <summary>
        /// Выбор номера
        /// </summary>
        public List<Rooms> GetRooms { get; set; }

        /// <summary>
        /// Отмена бронирования
        /// </summary>
        public string CancelBooking { get; set; }

    }

    /// <summary>
    /// Номера 
    /// </summary>
    public class Rooms
    {
        /// <summary>
        /// Дата заезда и выезда 
        /// </summary>
        public DateTime Residency { get; set; }
        
        /// <summary>
        /// Номера с подходящим количеством человек
        /// </summary>
        public int NumberOfPersons { get; set; }

        /// <summary>
        /// Компановка спальных мест  
        /// </summary>
        public int NumberOfBeds { get; set; }

        /// <summary>
        /// Фотография номера
        /// </summary>
        public byte[] Photo { get; set; }
    }

    /// <summary>
    /// Авторизация
    /// </summary>
    public class Autorization
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Mail { get; set; }
    }
}
