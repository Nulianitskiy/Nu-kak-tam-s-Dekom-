using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Ну_как_там_с_деком
{
    public partial class Grafoun_Form : Form
    {
        public Grafoun_Form()
        {
            InitializeComponent();
        }
        GraphPane paneMain;


        private void Grafoun_Form_Load(object sender, EventArgs e)
        {
            paneMain = zMain.GraphPane;
        }

        double func(double x, double a, double y, double b, double z, double c)
        {
            return Math.Pow(x, 2) / Math.Pow(a, 2) + Math.Pow(y, 2) / Math.Pow(b, 2) + Math.Pow(z, 2) / Math.Pow(c, 2);
        }

        private void OXY_Click(object sender, EventArgs e)
        {
            PointPairList listXY = new PointPairList();

            zMain.GraphPane.CurveList.Clear();
            paneMain.XAxis.Title.Text = "Ось X";
            paneMain.YAxis.Title.Text = "Ось Y";

            double A = Double.Parse(tbA.Text);
            double B = Double.Parse(tbB.Text);
            double Answer = Double.Parse(tbAnswer.Text);
            double From = Double.Parse(tbFrom.Text);
            double To = Double.Parse(tbTo.Text);
            double Step = Double.Parse(tbStep.Text);

            for (double x = From; x <= To; x += Step)
                for (double y = From; y <= To; y += Step)
                    if (func(x, A, y, B, 1, 1) - 1 == Answer)
                    {
                        listXY.Add(x, y);
                        break;
                    }

            LineItem Curve = paneMain.AddCurve("FunctionXY", listXY, Color.Blue, SymbolType.None);

            zMain.AxisChange();
            zMain.Invalidate();
        }
    }
}
