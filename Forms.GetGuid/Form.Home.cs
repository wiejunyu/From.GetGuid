using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.GetGuid
{
    public partial class form_Home : Form
    {
        public form_Home()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            Guid ID = Guid.NewGuid();
            Clipboard.SetDataObject(ID.ToString());
        }
    }
}
