Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Xml
Imports System.Runtime.Remoting

Public Class Form1

    Dim isFirstRun As Boolean = My.Settings.isFirstRun
    Dim Directorio As String = My.Settings.directorio

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (isFirstRun) Then
            FirstRun()
        End If
        Me.Text = "Descarga Masiva XML CFDi - OneSmart Soluciones"
    End Sub


    Const INTERNET_COOKIE_HTTPONLY As Integer = &H2000

    Public Shared Function GetGlobalCookies(ByVal uri As String) As String
        'Dim datasize As UInteger = CInt(strCache)
        Dim datasize As UInteger = 8192
        Dim cookieData As New StringBuilder(CInt(datasize))
        If InternetGetCookieEx(uri, Nothing, cookieData, datasize, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero) AndAlso cookieData.Length > 0 Then
            'Return cookieData.ToString().Replace(";"c, ","c)
            Return cookieData.ToString()
        Else
            Return Nothing
        End If
    End Function

    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True, PreserveSig:=True)>
    Private Shared Function InternetGetCookieEx(ByVal pchURL As String, ByVal pchCookieName _
                                                As String, ByVal pchCookieData As StringBuilder,
                                                ByRef pcchCookieData As UInteger, ByVal dwFlags As Integer,
                                                ByVal lpReserved As IntPtr) As Boolean
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupAcciones.Enter

    End Sub
    Dim FormPB As New Form2

    Private Sub BtnDescarga_Click_1(sender As Object, e As EventArgs) Handles BtnDescarga.Click
        Dim htmlDocument As HtmlDocument = wb.Document
        Directorio = My.Settings.directorio
        Try
            Dim htmlElementCollection As HtmlElementCollection = htmlDocument.Images
            'Con estas dos variables, localizas la cadena de cada comprobante, se almacenara temporalmente.
            Dim cadIni, cadFin As Integer

            For Each htmlElement As HtmlElement In htmlElementCollection
                Dim imgUrl As String = htmlElement.GetAttribute("id")
                If imgUrl = "BtnDescarga" Then
                    imgUrl = Replace(htmlElement.OuterHtml, Chr(34), "")
                    cadIni = InStr(imgUrl, "?Datos=")
                    cadFin = InStr(imgUrl, "=','Recuperacion')")
                    imgUrl = imgUrl.Substring(cadIni, cadFin - cadIni)
                    imgUrl = "https://portalcfdi.facturaelectronica.sat.gob.mx/RecuperaCfdi.aspx?" & imgUrl
                    ListEnlacesFacs.Items.Add(imgUrl)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim URI As String
        Dim fecha As String
        Dim wc As New WebClient


        'Empezamos con la descarga
        wc.Headers.Add(HttpRequestHeader.Cookie, GetGlobalCookies(wb.Document.Url.ToString))

        If (ListEnlacesFacs.Items.Count > 500) Then
            MessageBox.Show("La consulta realizada solo muestra las primeras 500 facturas, 
se recomienda hacer los periodos de búsqueda más cortos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Verificamos el directorio de salida
        ElseIf (ListEnlacesFacs.Items.Count > 0) Then
            Label1.Text = "Descarga en proceso. Espere por favor"
            Dim isCarpetaValida As Boolean = False
            While (Not isCarpetaValida)
                If (Not System.IO.Directory.Exists(Directorio)) Then
                    Try
                        System.IO.Directory.CreateDirectory(Directorio)
                    Catch ex As DirectoryNotFoundException
                        MessageBox.Show("No se puede acceder a la carpeta seleccionada, elija una otra para poder continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SeleccionarCarpeta()
                    End Try
                Else
                    isCarpetaValida = True

                End If

            End While
            'Creamos un nuevo folder por cada busqueda realizada
            fecha = DateTime.Now.ToString("yyyyMM-dd-HH mm ss")
            If (Not System.IO.Directory.Exists(Directorio & "\" & fecha & "\")) Then
                System.IO.Directory.CreateDirectory(Directorio & "\" & fecha & "\")
            End If
            BackgroundWorker1.WorkerReportsProgress = True
            BackgroundWorker1.RunWorkerAsync()
            FormPB.ShowDialog()
            'recorro el listBox y voy descargando uno por uno
            For i = 0 To ListEnlacesFacs.Items.Count - 1
                FormPB.SetLabel1Text("Progreso: " & i + 1 & "/" & ListEnlacesFacs.Items.Count & " Facturas")

                reportProgress(i, ListEnlacesFacs.Items.Count)
                URI = ListEnlacesFacs.Items.Item(i).ToString.Trim
                Debug.Print(Directorio & "\" & fecha & "\CFDi-N" & (i + 1) & ".xml")
                wc.DownloadFile(URI, Directorio & "\" & fecha & "\CFDi-N" & (i + 1) & ".xml")
            Next
            MessageBox.Show("Se descargaron correctamente: " & ListEnlacesFacs.Items.Count & " elementos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information
                           )
            'limpiamos nuestra lista por si queremos ingresar otra busqueda
        Else
            MessageBox.Show("La búsqueda no muestra elementos para descargar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
        ListEnlacesFacs.Items.Clear()
        Label1.Text = "Preparado."

        GroupAcciones.Visible = False
    End Sub
    Dim pagesNum As Integer = 0
    Dim passwordLogin As Boolean = False
    Private Sub wb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        'En primera instancia nos manda al login con RFC y contraseña
        If pagesNum < 2 Then

            If (Not passwordLogin) Then
                Dim linkFound As Boolean = False
                Dim passwordLoginLink As HtmlElement = Nothing
                For Each passwordLoginLink In wb.Document.Links
                    If passwordLoginLink.InnerText IsNot Nothing _
                    AndAlso passwordLoginLink.InnerText.ToString.Trim = "Contraseña" Then
                        linkFound = True
                        Exit For
                    End If
                Next

                If (linkFound) Then
                    passwordLoginLink.Focus()
                    SendKeys.Send("{ENTER}")
                    passwordLogin = True
                End If
            End If
        End If

        'Verificamos a que hacemos clic
        Dim htmlDocument As HtmlDocument = wb.Document
        GroupAcciones.Visible = False
        AddHandler htmlDocument.Body.MouseDown, New HtmlElementEventHandler(AddressOf wb_MouseDown)

    End Sub

    Private Sub wb_MouseDown(ByVal sender As Object, ByVal e As HtmlElementEventArgs)
        'En caso de hacer clic en el boton de Buscar CFDI Mostraremos el grupo de acciones.
        Select Case (e.MouseButtonsPressed)

            Case MouseButtons.Left
                Dim element As HtmlElement
                element = wb.Document.GetElementFromPoint(e.ClientMousePosition)
                If (element IsNot Nothing AndAlso "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase)) Then
                    If ("Buscar CFDI".Equals(element.GetAttribute("value"), StringComparison.OrdinalIgnoreCase)) Then
                        GroupAcciones.Visible = True
                    End If

                End If
                Exit Select
        End Select
    End Sub

    Private Sub FirstRun()
        SeleccionarCarpeta()
        MostrarAyudaInicial()
        My.Settings.isFirstRun = False
        My.Settings.Save()
    End Sub

    Private Sub CarpetaDeGuardadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarpetaDeGuardadoToolStripMenuItem.Click
        SeleccionarCarpeta()
    End Sub

    Private Sub SeleccionarCarpeta()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "%userprofile%\documents"
        dialog.Description = "Seleccione la carpeta para guardar los archivos"
        If dialog.ShowDialog() = DialogResult.OK Then
            Directorio = dialog.SelectedPath & "\OneSmart-DMF"
        End If
        My.Settings.directorio = Directorio
        My.Settings.Save()
    End Sub

    Private Sub MostrarAyudaInicial()
        'TODO
    End Sub

    Private Sub AyudaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaInicialToolStripMenuItem.Click
        MostrarAyudaInicial()
    End Sub

    Private Sub BtnCarpeta_Click(sender As Object, e As EventArgs) Handles BtnCarpeta.Click
        SeleccionarCarpeta()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object,
 ByVal e As System.ComponentModel.ProgressChangedEventArgs) _
 Handles BackgroundWorker1.ProgressChanged

        FormPB.ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object,
 ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
 Handles BackgroundWorker1.RunWorkerCompleted

        FormPB.Close()

    End Sub

    Private Sub reportProgress(i As Integer, total As Integer)
        Dim progress As Integer = Math.Floor(i / total * 100)
        BackgroundWorker1.ReportProgress(progress)

    End Sub

End Class
