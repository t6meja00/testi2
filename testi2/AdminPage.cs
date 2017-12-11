using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi2
{
    public partial class Form1
    {
        private void buttonClearDatabase_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure?", "Confirm", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                Database.Execute("truncate table weather");
            }
        }
    }
}
