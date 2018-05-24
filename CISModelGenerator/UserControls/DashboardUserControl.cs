using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISModelGenerator
{
    public partial class DashboardUserControl : UserControl
    {
        private static DashboardUserControl _instance;
        public static DashboardUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashboardUserControl();

                return _instance;
            }
        }

        public DashboardUserControl()
        {
            InitializeComponent();
        }
    }
}
