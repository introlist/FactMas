<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1


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
    Public Shared prueba As Integer
    ' Public Shared BtnDisponible As Boolean

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.ListEnlacesFacs = New System.Windows.Forms.ListBox()
        Me.GroupAcciones = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDescarga = New System.Windows.Forms.Button()
        Me.GroupAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'wb
        '
        Me.wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb.Location = New System.Drawing.Point(0, 0)
        Me.wb.MinimumSize = New System.Drawing.Size(400, 400)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(950, 573)
        Me.wb.TabIndex = 0
        Me.wb.Url = New System.Uri("https://portalcfdi.facturaelectronica.sat.gob.mx/", System.UriKind.Absolute)
        '
        'ListEnlacesFacs
        '
        Me.ListEnlacesFacs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListEnlacesFacs.FormattingEnabled = True
        Me.ListEnlacesFacs.Location = New System.Drawing.Point(0, 623)
        Me.ListEnlacesFacs.Name = "ListEnlacesFacs"
        Me.ListEnlacesFacs.Size = New System.Drawing.Size(950, 17)
        Me.ListEnlacesFacs.TabIndex = 1
        Me.ListEnlacesFacs.Visible = False
        '
        'GroupAcciones
        '
        Me.GroupAcciones.Controls.Add(Me.Label1)
        Me.GroupAcciones.Controls.Add(Me.BtnDescarga)
        Me.GroupAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupAcciones.Location = New System.Drawing.Point(0, 573)
        Me.GroupAcciones.Name = "GroupAcciones"
        Me.GroupAcciones.Size = New System.Drawing.Size(950, 50)
        Me.GroupAcciones.TabIndex = 2
        Me.GroupAcciones.TabStop = False
        Me.GroupAcciones.Text = "Acciones"
        Me.GroupAcciones.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Preparado."
        '
        'BtnDescarga
        '
        Me.BtnDescarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDescarga.Location = New System.Drawing.Point(718, 12)
        Me.BtnDescarga.Name = "BtnDescarga"
        Me.BtnDescarga.Size = New System.Drawing.Size(220, 38)
        Me.BtnDescarga.TabIndex = 0
        Me.BtnDescarga.Text = "Descarga Masiva"
        Me.BtnDescarga.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 640)
        Me.Controls.Add(Me.wb)
        Me.Controls.Add(Me.GroupAcciones)
        Me.Controls.Add(Me.ListEnlacesFacs)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupAcciones.ResumeLayout(False)
        Me.GroupAcciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wb As WebBrowser
    Friend WithEvents ListEnlacesFacs As ListBox
    Friend WithEvents GroupAcciones As GroupBox
    Friend WithEvents BtnDescarga As Button
    Friend WithEvents Label1 As Label
End Class
