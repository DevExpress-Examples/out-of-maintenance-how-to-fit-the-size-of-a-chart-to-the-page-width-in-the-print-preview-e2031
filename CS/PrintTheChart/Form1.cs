using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraCharts.Printing;
// ...

namespace PrintTheChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        ChartPrinter cp;

        private void button1_Click(object sender, EventArgs e) {
            Link l = new Link(new PrintingSystem());
       
            
            l.Landscape = true;
            l.PaperKind = System.Drawing.Printing.PaperKind.A3;
            cp = new ChartPrinter(this.chartControl1);
            cp.Initialize(l.PrintingSystem, l);
            cp.SizeMode = PrintSizeMode.Stretch;
            l.CreateDetailArea += new CreateAreaEventHandler(l_CreateDetailArea);
            l.ShowPreviewDialog();
            cp.Release();
        }

        void l_CreateDetailArea(object sender, CreateAreaEventArgs e) {
            cp.CreateDetail(e.Graph);
        }

    }
}