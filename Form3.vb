Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CheckBox1.Checked = My.Settings.crearSubcarpeta
        CheckBox1.Visible = False
        CheckBox2.Checked = My.Settings.agruparXML
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'My.Settings.crearSubcarpeta = CheckBox1.Checked
        My.Settings.agruparXML = CheckBox2.Checked
        My.Settings.Save()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class