using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ну_как_там_с_деком
{
    public partial class Polish_Form : Form
    {
        public Polish_Form()
        {
            InitializeComponent();
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            RichTextBoxPol.Text = Convert.ToString(Polish.Calculate(TextBoxPol.Text));
        }

    }
}
