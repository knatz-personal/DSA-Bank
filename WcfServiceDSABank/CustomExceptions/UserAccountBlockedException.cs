using System;

namespace WcfServiceDSABank.CustomExceptions
{
    public class UserAccountBlockedException : Exception
    {
        public UserAccountBlockedException()
            : base("This account has been blocked. Contact the administrator to unblock it")
        {
        }

        public UserAccountBlockedException(string message)
            : base(message)
        {
        }

        public UserAccountBlockedException(string message, Exception innException)
            : base(message, innException)
        {
        }
    }
}