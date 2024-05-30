Imports System.IO
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging

Public Class FrmComputer
    Inherits Form

    Private computerregister As New ArrayList()
    Private Sub FrmComputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
     
    Private Sub btnAddComputer_Click(sender As Object, e As EventArgs) Handles btnAddComputer.Click
        Try
            Dim computer As New Computer(Convert.ToString(txtNamec.Text), Convert.ToDateTime(dtpcomputer.Text), Convert.ToString(txtComputernum.Text), Convert.ToInt16(txtNoprints.Text))
            computer.Name = txtNamec.Text
            computer.Date = Convert.ToDateTime(dtpcomputer.Text)
            computer.Computernumber = txtComputernum.Text
            computer.Print_number = Convert.ToInt16(txtNoprints.Text)
            computer.Total = Math.Round(computer.Gettotal(computer.Cost, computer.Print_number), 2)
            computerregister.Add(computer)
            lblprinttotal.Text = "Total: " & computer.Total.ToString()
            dgvComputer.DataSource = Nothing
            dgvComputer.DataSource = computerregister
        Catch ex As Exception
            MessageBox.Show("Exception")
            Return
        End Try
    End Sub

    Private Sub btnNewcomputer_Click(sender As Object, e As EventArgs) Handles btnNewcomputer.Click
        txtNamec.Clear()
        txtComputernum.Clear()
        txtNoprints.Clear()
        dtpcomputer.Value = DateTime.Now

    End Sub

    Private Sub btnExporttxtc_Click(sender As Object, e As EventArgs) Handles btnExporttxtc.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "txt files |*.txt"
        dialog.Title = "Save the Text File"
        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filePath As String = dialog.FileName
        Using writer As New StreamWriter(filePath, True)
            For Each computerreg As Computer In computerregister
                writer.WriteLine(String.Join(",", computerreg.Name, computerreg.Date, computerreg.Computernumber, computerreg.Print_number, computerreg.Total))
            Next
        End Using
        MessageBox.Show("Text file exported successfully :D")
    End Sub

    Private Sub btnExportWordc_Click(sender As Object, e As EventArgs) Handles btnExportWordc.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Word Documents|*.docx"
        dialog.Title = "Save the Word File"

        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filePath As String = dialog.FileName

        Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document)
            Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()

            mainPart.Document = New Document()
            Dim body As Body = mainPart.Document.AppendChild(New Body())

            For Each computer As Computer In computerregister
                Dim paragraph As Paragraph = body.AppendChild(New Paragraph())
                Dim run As Run = paragraph.AppendChild(New Run())

                Dim text As Text = run.AppendChild(New Text())
                text.Text = $"Name: {computer.Name}, Date: {computer.Date}, Computer number: {computer.Computernumber}, Number of prints: {computer.Print_number}, Total: {computer.Total} {vbCrLf}"
            Next
        End Using

        MessageBox.Show("Word file exported successfully :D")
    End Sub

    Private Sub btnReadtxt_Click(sender As Object, e As EventArgs) Handles btnReadtxt.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "txt files |*.txt"
        dialog.Title = "Save the Text File"
        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filePath As String = dialog.FileName
        Dim lines As String() = File.ReadAllLines(filePath)

        computerregister.Clear()

        For Each line As String In lines
            Dim columns As String() = line.Split(","c)
            Dim computer As New Computer()
            computer.Name = columns(0).Trim()
            computer.Date = Convert.ToDateTime(columns(1).Trim())
            computer.Computernumber = (columns(2).Trim())
            computer.Print_number = Convert.ToInt16(columns(3).Trim())
            computer.Total = Convert.ToDouble(columns(4).Trim())
            computerregister.Add(computer)
        Next

        dgvComputer.DataSource = Nothing
        dgvComputer.DataSource = computerregister
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        Me.Close()
        Dim frm As New Menu()
        frm.Show()
        Me.Hide()
    End Sub
End Class