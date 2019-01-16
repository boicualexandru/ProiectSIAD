<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_start))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GraficEvolutiePretToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstimareaPretuluiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraficEvolutiePretToolStripMenuItem, Me.EstimareaPretuluiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(858, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GraficEvolutiePretToolStripMenuItem
        '
        Me.GraficEvolutiePretToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraficEvolutiePretToolStripMenuItem.Name = "GraficEvolutiePretToolStripMenuItem"
        Me.GraficEvolutiePretToolStripMenuItem.Size = New System.Drawing.Size(135, 21)
        Me.GraficEvolutiePretToolStripMenuItem.Text = "Grafic Evolutie Pret"
        '
        'EstimareaPretuluiToolStripMenuItem
        '
        Me.EstimareaPretuluiToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstimareaPretuluiToolStripMenuItem.Name = "EstimareaPretuluiToolStripMenuItem"
        Me.EstimareaPretuluiToolStripMenuItem.Size = New System.Drawing.Size(130, 21)
        Me.EstimareaPretuluiToolStripMenuItem.Text = "Estimarea Pretului"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(134, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 66)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Grafic Evolutie Pret"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(436, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 66)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Estimarea Pretului"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form_start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(858, 563)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_start"
        Me.Text = "Meniu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GraficEvolutiePretToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstimareaPretuluiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
