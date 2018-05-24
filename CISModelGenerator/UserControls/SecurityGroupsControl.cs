using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISModelGenerator.UserControls
{
    public partial class SecurityGroupsControl : UserControl
    {

        //Singleton 
        private static SecurityGroupsControl _instance;
        public static SecurityGroupsControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SecurityGroupsControl();

                return _instance;
            }
        }

        public SecurityGroupsControl()
        {
            InitializeComponent();
        }
    }
}
