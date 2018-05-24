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
    public partial class foldersControl : UserControl
    {
        //Singleton 
        private static foldersControl _instance;
        public static foldersControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new foldersControl();

                return _instance;
            }
        }

        public foldersControl()
        {
            InitializeComponent();
        }

        private void foldersControl_Load(object sender, EventArgs e)
        {

        }
    }
}
