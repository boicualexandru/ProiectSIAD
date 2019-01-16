<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Raport
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ClientiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VanzariMasini2DataSet = New ProiectSIAD.VanzariMasini2DataSet()
        Me.dgvc = New System.Windows.Forms.DataGridView()
        Me.ClientiTableAdapter = New ProiectSIAD.VanzariMasini2DataSetTableAdapters.clientiTableAdapter()
        Me.chRaport = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VanzariMasini2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chRaport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"stareCivila", "sex", "studii", "ocupatie"})
        Me.ComboBox1.Location = New System.Drawing.Point(13, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(337, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(13, 41)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(337, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.Visible = False
        '
        'ClientiBindingSource
        '
        Me.ClientiBindingSource.DataMember = "clienti"
        Me.ClientiBindingSource.DataSource = Me.VanzariMasini2DataSet
        '
        'VanzariMasini2DataSet
        '
        Me.VanzariMasini2DataSet.DataSetName = "VanzariMasini2DataSet"
        Me.VanzariMasini2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvc
        '
        Me.dgvc.AllowUserToAddRows = False
        Me.dgvc.AllowUserToDeleteRows = False
        Me.dgvc.AllowUserToOrderColumns = True
        Me.dgvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvc.Location = New System.Drawing.Point(13, 69)
        Me.dgvc.Name = "dgvc"
        Me.dgvc.ReadOnly = True
        Me.dgvc.Size = New System.Drawing.Size(337, 340)
        Me.dgvc.TabIndex = 3
        '
        'ClientiTableAdapter
        '
        Me.ClientiTableAdapter.ClearBeforeFill = True
        '
        'chRaport
        '
        ChartArea5.Name = "ChartArea1"
        Me.chRaport.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chRaport.Legends.Add(Legend5)
        Me.chRaport.Location = New System.Drawing.Point(357, 70)
        Me.chRaport.Name = "chRaport"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.chRaport.Series.Add(Series5)
        Me.chRaport.Size = New System.Drawing.Size(431, 339)
        Me.chRaport.TabIndex = 5
        Me.chRaport.Text = "Chart1"
        '
        'Raport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chRaport)
        Me.Controls.Add(Me.dgvc)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Raport"
        Me.Text = "Raport"
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VanzariMasini2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chRaport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents dgvc As DataGridView
    Friend WithEvents VanzariMasini2DataSet As VanzariMasini2DataSet
    Friend WithEvents ClientiBindingSource As BindingSource
    Friend WithEvents ClientiTableAdapter As VanzariMasini2DataSetTableAdapters.clientiTableAdapter
    Friend WithEvents chRaport As DataVisualization.Charting.Chart
End Class
