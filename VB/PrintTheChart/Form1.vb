Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraCharts.Printing

' ...
Namespace PrintTheChart

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private cp As ChartPrinter

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim l As Link = New Link(New PrintingSystem())
            l.Landscape = True
            l.PaperKind = System.Drawing.Printing.PaperKind.A3
            cp = New ChartPrinter(chartControl1)
            cp.Initialize(l.PrintingSystem, l)
            cp.SizeMode = PrintSizeMode.Stretch
            AddHandler l.CreateDetailArea, New CreateAreaEventHandler(AddressOf l_CreateDetailArea)
            l.ShowPreviewDialog()
            cp.Release()
        End Sub

        Private Sub l_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            cp.CreateDetail(e.Graph)
        End Sub
    End Class
End Namespace
