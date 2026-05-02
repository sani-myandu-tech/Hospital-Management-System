// Session.cs — single shared session store for the whole application.
// All forms read from and write to this one class.
// Having it here removes the duplicate Session declarations in Login.cs,
// Appointment.cs, and Doctor.cs that caused naming conflicts.

namespace Assignment212
{
    public static class Session
    {
        public static int    UserID   = -1;
        public static string Username = string.Empty;
        public static string Position = string.Empty; // "Admin" or "Doctor"
        public static string DoctorName = string.Empty;
        public static int    DoctorID = -1;
        public static int    PatientID = -1;

        /// <summary>Clears all session data on logout.</summary>
        public static void Clear()
        {
            UserID     = -1;
            Username   = string.Empty;
            Position   = string.Empty;
            DoctorName = string.Empty;
            DoctorID   = -1;
            PatientID  = -1;
        }
    }
}
