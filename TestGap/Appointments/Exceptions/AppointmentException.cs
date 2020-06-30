using System;

namespace Appointments.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class AppointmentException : Exception
    {
        public AppointmentException() { }

        public AppointmentException(string message) : base(message) { }

        public AppointmentException(string message, ushort errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        public ushort ErrorCode { get; set; }
    }
}
