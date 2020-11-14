using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Может_через_список_попробовать;

namespace Ну_как_там_с_деком
{
    public partial class Choser : Form
    {
        public Choser()
        {
            InitializeComponent();
        }

        private void Open_Polish_Click(object sender, EventArgs e)
        {
            Polish_Form newForm = new Polish_Form();
            newForm.Owner = this;
            newForm.Show();
        }

        private void Open_Deque_Click(object sender, EventArgs e)
        {
            Deque_Form newForm = new Deque_Form();
            newForm.Owner = this;
            newForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Zuma_Click(object sender, EventArgs e)
        {
            Sortir_Form newForm = new Sortir_Form();
            newForm.Owner = this;
            newForm.Show();
        }
    }
}
