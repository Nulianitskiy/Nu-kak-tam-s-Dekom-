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
    public partial class Grafouni_Form : Form
    {
        public Grafouni_Form()
        {
            InitializeComponent();
        }
        GraphPane paneXY;
        GraphPane paneYZ;
        GraphPane paneXZ;

        private void Grafouni_Form_Load(object sender, EventArgs e)
        {
            paneXY = zOXY.GraphPane;
            paneYZ = zOYZ.GraphPane;
            paneXZ = zOXZ.GraphPane;
            InitializeComponent();
        }

        double func(double x)
        {
            return Math.Pow(x, 2);
        }

        private void Creation_Click(object sender, EventArgs e)
        {

            zOXY.GraphPane.CurveList.Clear();
            zOYZ.GraphPane.CurveList.Clear();
            zOXZ.GraphPane.CurveList.Clear();
            PointPairList listXY = new PointPairList();
            PointPairList listYZ = new PointPairList();
            PointPairList listXZ = new PointPairList();
            double xmin = -10;
            double xmax = 10;

            for (double x = xmin; x <= xmax; x += 0.1)
            {
                listXY.Add(x, func(x));
                listYZ.Add(func(x), x);
                listXZ.Add(x, x);
            }
            LineItem Curve1 = paneXY.AddCurve("FunctionXY", listXY, Color.Blue, SymbolType.None);
            LineItem Curve2 = paneYZ.AddCurve("FunctionYZ", listYZ, Color.Blue, SymbolType.None);
            LineItem Curve3 = paneXZ.AddCurve("FunctionXZ", listXZ, Color.Blue, SymbolType.None);


            // !!! Установим заливку для кривой
            Curve1.Line.Fill = new ZedGraph.Fill(Color.Blue);
            Curve2.Line.Fill = new ZedGraph.Fill(Color.Blue);
            Curve3.Line.Fill = new ZedGraph.Fill(Color.Blue);

            zOXY.AxisChange();
            zOXY.Invalidate();

            zOYZ.AxisChange();
            zOYZ.Invalidate();

            zOXZ.AxisChange();
            zOXZ.Invalidate();

        }
    }
}
