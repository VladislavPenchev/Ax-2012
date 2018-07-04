using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace UserAccess.Forms.Common
{
    public class DisableFunctionalityOfExitBtn
    {
        private const int SC_CLOSE = 0xF060;           //close button's code in windows api
        private const int MF_GRAYED = 0x1;             //disabled button status (enabled = false)
        private const int MF_ENABLED = 0x00000000;     //enabled button status
        private const int MF_DISABLED = 0x00000002;    //disabled button status

        [DllImport("user32.dll")] //Importing user32.dll for calling required function
        private static extern IntPtr GetSystemMenu(IntPtr HWNDValue, bool Revert);

        /// HWND: An IntPtr typed handler of the related form
        /// It is used from the Win API "user32.dll"

        [DllImport("user32.dll")] //Importing user32.dll for calling required function again
        private static extern int EnableMenuItem(IntPtr tMenu, int targetItem, int targetStatus);

        public static void EnableCloseButton(System.IntPtr Handle) //A standard void function to invoke EnableMenuItem()
        {
            EnableMenuItem(GetSystemMenu(Handle, false), SC_CLOSE, MF_ENABLED);
        }

        public static void DisableCloseButton(System.IntPtr Handle) //A standard void function to invoke EnableMenuItem()
        {
            EnableMenuItem(GetSystemMenu(Handle, false), SC_CLOSE, MF_GRAYED);
        }       


    }
}
