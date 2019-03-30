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
        /// Количество человек
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
    /// Начальная страница
    /// </summary>
    public class StartPage
    {
        /// <summary>
        /// Новости Отеля
        /// </summary>
        public string News { get; set; }

        /// <summary>
        /// Авторизация
        /// </summary>
        public List<Autorization> Autorization { get; set; }
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

    /// <summary>
    /// Обратная связь
    /// </summary>
    public class FeedBack
    {
        /// <summary>
        /// Сообщение пользователя
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Письмо от Администратора/Сообщение от Администратора
        /// </summary>
        public string Admin { get; set; }
    }
}
