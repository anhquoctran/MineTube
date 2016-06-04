using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MediaPlayer4Net
{
    public class player
    {
        private string _ffExe;

        public string ffExe
        {
            get
            {
                return _ffExe;
            }
            set
            {
                _ffExe = value;
            }
        }
    }
}
