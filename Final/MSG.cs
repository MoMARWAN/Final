using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    class MSG
    {
        public static void Error(string ms) {
            MessageBox.Show(ms, "حقل مطلوب إجبارياً", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
