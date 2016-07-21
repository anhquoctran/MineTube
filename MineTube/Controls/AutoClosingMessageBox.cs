using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MineTube.Controls
{
    public class AutoClosingMessageBox
    {
        #region Field and Properties
        System.Threading.Timer _TimerTimeout;
        private string _Caption;
        const int WM_CLOSE = 0x0010;
        #endregion

        #region Contructor
        public AutoClosingMessageBox(string message, string title, int timeout)
        {
            _Caption = title;
            _TimerTimeout = new System.Threading.Timer(OnTimerElapsed, null, timeout, System.Threading.Timeout.Infinite);
            using (_TimerTimeout)
            {
                MessageBox.Show(message + "\nWill closing after: ", title);
            }
        }
        #endregion

        #region Events and Methods
        /// <summary>
        /// Create messagebox with timeout in miliseconds to do something.
        /// </summary>
        /// <param name="message">Main content of message to displayed.</param>
        /// <param name="title">Title of message</param>
        /// <param name="timeout">Time out to closing or do something</param>
        public static void Show(string message, string title, int timeout)
        {
            new AutoClosingMessageBox(message, title, timeout);
        }

        private void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _Caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _TimerTimeout.Dispose();
        }
              
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        #endregion
    }
}
