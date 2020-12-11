using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Ну_как_там_с_деком
{
    public partial class Grafouni_Form : Form
    {
        public Grafouni_Form()
        {
            InitializeComponent();
        }
        GraphPane paneMain;

        private void Grafouni_Form_Load(object sender, EventArgs e)
        {
            paneMain = zMain.GraphPane;
            InitializeComponent();
        }

        double func(double x, double a, double y, double b , double z, double c)
        {
            return Math.Pow(x, 2) / Math.Pow(a, 2) + Math.Pow(y, 2) / Math.Pow(b, 2) + Math.Pow(z, 2) / Math.Pow(c, 2);
        }

        private void Creation_Click(object sender, EventArgs e)
        {

            zMain.GraphPane.CurveList.Clear();
            PointPairList listXY = new PointPairList();
            PointPairList listYZ = new PointPairList();
            PointPairList listXZ = new PointPairList();
            double Left = Convert.ToDouble(tbLeft.Text);
            double Right = Convert.ToDouble(tbRight.Text);
            double Step = Convert.ToDouble(tbStep.Text);

            for (double x = Left; x <= Right; x += Step)
            {
                
            }
            LineItem Curve1 = paneMain.AddCurve("FunctionXY", listXY, Color.Blue, SymbolType.None);


            zMain.AxisChange();
            zMain.Invalidate();
        }

        private void OXY_Click(object sender, EventArgs e)
        {
            zMain.GraphPane.CurveList.Clear();
            paneMain.XAxis.Title.Text = "Ось X";
            paneMain.YAxis.Title.Text = "Ось Y";
        }

        private void OYZ_Click(object sender, EventArgs e)
        {
            zMain.GraphPane.CurveList.Clear();
            paneMain.XAxis.Title.Text = "Ось Y";
            paneMain.YAxis.Title.Text = "Ось Z";
        }

        private void OXZ_Click(object sender, EventArgs e)
        {
            zMain.GraphPane.CurveList.Clear();
            paneMain.XAxis.Title.Text = "Ось X";
            paneMain.YAxis.Title.Text = "Ось Z";
        }
    }
}
