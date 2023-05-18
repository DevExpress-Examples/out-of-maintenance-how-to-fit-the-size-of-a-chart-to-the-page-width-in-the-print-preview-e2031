Namespace PrintTheChart

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {(CObj((1)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {(CObj((9)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {(CObj((2)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {(CObj((12)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("E", New Object() {(CObj((5)))})
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.button1 = New System.Windows.Forms.Button()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(0, 64)
            Me.chartControl1.Name = "chartControl1"
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Label = pointSeriesLabel1
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
            series1.View = lineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.Size = New System.Drawing.Size(284, 200)
            Me.chartControl1.TabIndex = 0
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(82, 12)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(130, 46)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Print the Chart"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 264)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace
