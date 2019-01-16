<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vanzari
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cboZone = New System.Windows.Forms.ComboBox()
        Me.JudeteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VanzariMasini2DataSet = New ProiectSIAD.VanzariMasini2DataSet()
        Me.cboTipAuto = New System.Windows.Forms.ComboBox()
        Me.MasiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.JudeteTableAdapter = New ProiectSIAD.VanzariMasini2DataSetTableAdapters.judeteTableAdapter()
        Me.MasiniTableAdapter = New ProiectSIAD.VanzariMasini2DataSetTableAdapters.masiniTableAdapter()
        Me.chVanzari = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.VanzariMasini2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.JudeteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VanzariMasini2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chVanzari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VanzariMasini2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(713, 415)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Înapoi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cboZone
        '
        Me.cboZone.DataSource = Me.JudeteBindingSource
        Me.cboZone.DisplayMember = "judet"
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(440, 11)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(348, 21)
        Me.cboZone.TabIndex = 1
        '
        'JudeteBindingSource
        '
        Me.JudeteBindingSource.DataMember = "judete"
        Me.JudeteBindingSource.DataSource = Me.VanzariMasini2DataSet
        '
        'VanzariMasini2DataSet
        '
        Me.VanzariMasini2DataSet.DataSetName = "VanzariMasini2DataSet"
        Me.VanzariMasini2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboTipAuto
        '
        Me.cboTipAuto.DataSource = Me.MasiniBindingSource
        Me.cboTipAuto.DisplayMember = "model"
        Me.cboTipAuto.FormattingEnabled = True
        Me.cboTipAuto.Location = New System.Drawing.Point(440, 47)
        Me.cboTipAuto.Name = "cboTipAuto"
        Me.cboTipAuto.Size = New System.Drawing.Size(348, 21)
        Me.cboTipAuto.TabIndex = 2
        '
        'MasiniBindingSource
        '
        Me.MasiniBindingSource.DataMember = "masini"
        Me.MasiniBindingSource.DataSource = Me.VanzariMasini2DataSet
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(12, 12)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 3
        '
        'dtp2
        '
        Me.dtp2.Location = New System.Drawing.Point(12, 48)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(200, 20)
        Me.dtp2.TabIndex = 4
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 74)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(373, 335)
        Me.grid.TabIndex = 5
        '
        'JudeteTableAdapter
        '
        Me.JudeteTableAdapter.ClearBeforeFill = True
        '
        'MasiniTableAdapter
        '
        Me.MasiniTableAdapter.ClearBeforeFill = True
        '
        'chVanzari
        '
        ChartArea1.Name = "ChartArea1"
        Me.chVanzari.ChartAreas.Add(ChartArea1)
        Me.chVanzari.DataSource = Me.VanzariMasini2DataSetBindingSource
        Legend1.Name = "Legend1"
        Me.chVanzari.Legends.Add(Legend1)
        Me.chVanzari.Location = New System.Drawing.Point(391, 74)
        Me.chVanzari.Name = "chVanzari"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Număr mașini"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.chVanzari.Series.Add(Series1)
        Me.chVanzari.Size = New System.Drawing.Size(397, 335)
        Me.chVanzari.TabIndex = 6
        Me.chVanzari.Text = "Volum masini"
        '
        'VanzariMasini2DataSetBindingSource
        '
        Me.VanzariMasini2DataSetBindingSource.DataSource = Me.VanzariMasini2DataSet
        Me.VanzariMasini2DataSetBindingSource.Position = 0
        '
        'Vanzari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chVanzari)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.cboTipAuto)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Vanzari"
        Me.Text = "Vanzari"
        CType(Me.JudeteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VanzariMasini2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chVanzari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VanzariMasini2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents cboZone As ComboBox
    Friend WithEvents cboTipAuto As ComboBox
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents grid As DataGridView
    Friend WithEvents VanzariMasini2DataSet As VanzariMasini2DataSet
    Friend WithEvents JudeteBindingSource As BindingSource
    Friend WithEvents JudeteTableAdapter As VanzariMasini2DataSetTableAdapters.judeteTableAdapter
    Friend WithEvents MasiniBindingSource As BindingSource
    Friend WithEvents MasiniTableAdapter As VanzariMasini2DataSetTableAdapters.masiniTableAdapter
    Friend WithEvents chVanzari As DataVisualization.Charting.Chart
    Friend WithEvents VanzariMasini2DataSetBindingSource As BindingSource
End Class
