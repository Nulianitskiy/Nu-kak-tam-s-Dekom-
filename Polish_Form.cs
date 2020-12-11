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
            Opz opz = null;
            try
            {
                opz = Opz.fromInfix(TextBoxPol.Text);
                RichTextBoxPol.Text = opz.toString();
            }
            catch (Exception ex)
            {
                RichTextBoxPol.Text = "Ошибка: " + ex.Message;
                return;
            }
            try
            {
                RichTextBoxPol.Text += " = " + opz.evaluate().ToString();
            }
            catch (Exception ex)
            {
                RichTextBoxPol.Text = "Ошибка: " + ex.Message;
            }
        }

    }
}
