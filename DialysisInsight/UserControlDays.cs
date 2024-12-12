using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialysisInsight
{
    public partial class UserControlDays : UserControl
    {
        string? date;
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
        }
    }
}
