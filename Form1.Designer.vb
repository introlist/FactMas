﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.ListEnlacesFacs = New System.Windows.Forms.ListBox()
        Me.GroupAcciones = New System.Windows.Forms.GroupBox()
        Me.BtnCarpeta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDescarga = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarpetaDeGuardadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ParámetrosDeGuardadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupAcciones.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wb
        '
        Me.wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb.Location = New System.Drawing.Point(0, 24)
        Me.wb.MinimumSize = New System.Drawing.Size(400, 400)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(950, 549)
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
        Me.GroupAcciones.Controls.Add(Me.BtnCarpeta)
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
        'BtnCarpeta
        '
        Me.BtnCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCarpeta.Location = New System.Drawing.Point(492, 12)
        Me.BtnCarpeta.Name = "BtnCarpeta"
        Me.BtnCarpeta.Size = New System.Drawing.Size(220, 38)
        Me.BtnCarpeta.TabIndex = 2
        Me.BtnCarpeta.Text = "Cambiar Carpeta Destino"
        Me.BtnCarpeta.UseVisualStyleBackColor = True
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(950, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarpetaDeGuardadoToolStripMenuItem, Me.ParámetrosDeGuardadoToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'CarpetaDeGuardadoToolStripMenuItem
        '
        Me.CarpetaDeGuardadoToolStripMenuItem.Name = "CarpetaDeGuardadoToolStripMenuItem"
        Me.CarpetaDeGuardadoToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CarpetaDeGuardadoToolStripMenuItem.Text = "Ubicación de descarga"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.AyudaInicialToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        Me.AyudaToolStripMenuItem.Visible = False
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'AyudaInicialToolStripMenuItem
        '
        Me.AyudaInicialToolStripMenuItem.Name = "AyudaInicialToolStripMenuItem"
        Me.AyudaInicialToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AyudaInicialToolStripMenuItem.Text = "Ayuda inicial"
        '
        'BackgroundWorker1
        '
        '
        'ParámetrosDeGuardadoToolStripMenuItem
        '
        Me.ParámetrosDeGuardadoToolStripMenuItem.Name = "ParámetrosDeGuardadoToolStripMenuItem"
        Me.ParámetrosDeGuardadoToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ParámetrosDeGuardadoToolStripMenuItem.Text = "Parámetros de descarga"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 640)
        Me.Controls.Add(Me.wb)
        Me.Controls.Add(Me.GroupAcciones)
        Me.Controls.Add(Me.ListEnlacesFacs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OneSmart Descarga XML SAT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupAcciones.ResumeLayout(False)
        Me.GroupAcciones.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wb As WebBrowser
    Friend WithEvents ListEnlacesFacs As ListBox
    Friend WithEvents GroupAcciones As GroupBox
    Friend WithEvents BtnDescarga As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarpetaDeGuardadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaInicialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnCarpeta As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ParámetrosDeGuardadoToolStripMenuItem As ToolStripMenuItem
End Class
