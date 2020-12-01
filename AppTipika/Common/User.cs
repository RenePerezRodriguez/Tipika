using System;
using System.Collections.Generic;
using System.Text;

namespace AppTipika.Common
{
    public class User
    {
        #region Properties
        /// <summary>
        /// Propeerty for identifier
        /// </summary>
        public Guid IdUser { get; set; }
        /// <summary>
        /// Propeerty for username
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Propeerty for password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Propeerty for role
        /// </summary>
        public byte Role { get; set; }
        /// <summary>
        /// Propeerty for state
        /// </summary>
        public byte State { get; set; }
        /// <summary>
        /// Propeerty for passwordstate
        /// </summary>
        public byte PasswordState { get; set; }
        #endregion
    }
}
