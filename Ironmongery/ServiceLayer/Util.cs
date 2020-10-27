using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLayer
{
    public class Util
    {
        public void showError(string message, string title)
        {
            MessageBox.Show(message, title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
