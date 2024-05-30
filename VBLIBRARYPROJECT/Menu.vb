Public Class Menu

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim form As New FrmBook
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btnComputer_Click(sender As Object, e As EventArgs) Handles btnComputer.Click
        Dim form As New FrmComputer
        form.Show()
        Me.Hide()
    End Sub

End Class

