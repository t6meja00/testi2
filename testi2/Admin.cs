using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testi2
{
    public partial class Form1
    {
        private void ButtonEmpty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Database.Execute("truncate table weather");
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            Database.Execute("DELETE FROM weather WHERE humidity > 80");
            Database.Execute("DELETE FROM weather WHERE temperature > 80 OR temperature < -20");
        }
        private void SelectedButton_Click(object sender, EventArgs e)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            Database.Execute("Delete FROM weather WHERE time LIKE '%"+date+"%'");
            Console.WriteLine(date);
        }
    }
}
