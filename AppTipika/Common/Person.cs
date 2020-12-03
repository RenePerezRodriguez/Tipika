using System;

namespace AppTipika.Common
{
    public class Person
    {
        #region properties
        /// <summary>
        /// Propeerty for indentifier person
        /// </summary>
        public Guid IdPerson { get; set; }
        /// <summary>
        /// Property for identitycard
        /// </summary>
        public string IdentityCard { get; set; }
        /// <summary>
        /// Property for names
        /// </summary>
        public string Names { get; set; }
        /// <summary>
        /// Property for first surmane
        /// </summary>
        public string FirstSurname { get; set; }
        /// <summary>
        ///  Property for second surname
        /// </summary>
        public string SecondSurname { get; set; }
        /// <summary>
        ///  Property for email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        ///  Property for address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        ///  Property for phone
        /// </summary>
        public short Phone { get; set; }

        /// <summary>
        ///  Property for user
        /// </summary>
        public User User { get; set; }

        /// <summary>
        ///  Property for eliminado return 0 or 1
        /// </summary>
        public byte State { get; set; }
        #endregion
    }
}
