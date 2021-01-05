using System;
using System.Windows.Forms;

namespace Ну_как_там_с_деком
{
    public partial class AutoLogic_Form : Form
    {
        public AutoLogic_Form()
        {
            InitializeComponent();
        }
        AutoLogic AL;
        private void TermCheck_Click(object sender, EventArgs e)
        {
            try
            {
                AL = new AutoLogic(richTextBox.Text);
                labelTerm.ForeColor = System.Drawing.Color.Green;
                labelTerm.Text = "✓";
            }
            catch (Exception)
            {
                labelTerm.ForeColor = System.Drawing.Color.Red;
                labelTerm.Text = "X";
            }
        }

        private void WordCheck_Click(object sender, EventArgs e)
        {
            if (AL.CheckWord(textBox.Text))
            {
                labelWord.ForeColor = System.Drawing.Color.Green;
                labelWord.Text = "✓";
            }
            else
            {
                labelWord.ForeColor = System.Drawing.Color.Red;
                labelWord.Text = "X";
            }
        }
    }
}
