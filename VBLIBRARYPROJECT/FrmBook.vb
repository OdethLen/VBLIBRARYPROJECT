Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Linq
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Controls.Primitives
Imports System.Windows.Forms
Imports System.IO
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Run = DocumentFormat.OpenXml.Wordprocessing.Run
Imports Text = DocumentFormat.OpenXml.Wordprocessing.Text
Imports DocumentFormat.OpenXml.VariantTypes

Namespace LIBRARY_PROJECT
    Partial Public Class FrmBook
        Inherits Form
        Private dataregister As ArrayList = New ArrayList()


        Private components As System.ComponentModel.IContainer
        Private btnBack As System.Windows.Forms.Button
        Private btnAddBook As System.Windows.Forms.Button
        Private btnNewbookr As System.Windows.Forms.Button
        Private btnExporttxt As System.Windows.Forms.Button
        Private btnExportWord As System.Windows.Forms.Button
        Private btnOpentxtFile As System.Windows.Forms.Button
        Private btnExportexcel As System.Windows.Forms.Button
        Private dgvBookregister As System.Windows.Forms.DataGridView
        Private txtName As System.Windows.Forms.TextBox
        Private txtTitle As System.Windows.Forms.TextBox
        Private txtAuthor As System.Windows.Forms.TextBox
        Private txtPublisher As System.Windows.Forms.TextBox
        Private dtpdate As System.Windows.Forms.DateTimePicker
        Private dtpEnddate As System.Windows.Forms.DateTimePicker

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            SuspendLayout()
            InitializeControls()
            ' 
            ' FrmBook
            ' 
            ClientSize = New Size(749, 659)
            Name = "FrmBook"

            ResumeLayout(False)
        End Sub

        Private Sub InitializeControls()
            ' Asignar manejadores de eventos a los botones
            AddHandler btnBack.Click, AddressOf btnBack_Click
            AddHandler btnAddBook.Click, AddressOf btnAddBook_Click
            AddHandler btnNewbookr.Click, AddressOf btnNewbookr_Click
            AddHandler btnExporttxt.Click, AddressOf btnExporttxt_Click
            AddHandler btnExportWord.Click, AddressOf btnExportWord_Click
            AddHandler btnOpentxtFile.Click, AddressOf btnOpentxtFile_Click

        End Sub

        Private Sub FrmBook_Load(sender As Object, e As EventArgs)
        End Sub

        Private Sub btnBack_Click(sender As Object, e As EventArgs)
            Me.Close()
            Dim frm As Menu = New Menu()
            frm.Show()
            Me.Hide()
        End Sub

        Private Sub btnAddBook_Click(sender As Object, e As EventArgs)
            Dim book As Book = New Book()

            If txtName.Text = "" Then
                MessageBox.Show("Field NAME cannot be blank")
            End If

            If txtTitle.Text = "" Then
                MessageBox.Show("Field TITLE cannot be blank")
            End If

            If txtAuthor.Text = "" Then
                MessageBox.Show("Field AUTHOR cannot be blank")
            End If

            If txtPublisher.Text = "" Then
                MessageBox.Show("Field PUBLISHER cannot be blank")
                Return
            End If

            book.Name = txtName.Text
            book.Title = txtTitle.Text
            book.Author = txtAuthor.Text
            book.Publisher = txtPublisher.Text
            book.Date = Convert.ToDateTime(dtpdate.Text)
            book.Enddate = Convert.ToDateTime(dtpEnddate.Text)

            dataregister.Add(book)
            dgvBookregister.DataSource = Nothing
            dgvBookregister.DataSource = dataregister
        End Sub

        Private Sub btnNewbookr_Click(sender As Object, e As EventArgs)
            txtName.Clear()
            txtTitle.Clear()
            txtAuthor.Clear()
            txtPublisher.Clear()
            dtpdate.Value = DateTime.Now
            dtpEnddate.Value = DateTime.Now
        End Sub

        Public Sub SaveTextFile()
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = "txt files |*.txt"
            dialog.Title = "Save the Text File"

            If dialog.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim filePath As String = dialog.FileName

            Using writer As StreamWriter = New StreamWriter(filePath, True)
                For Each bookregister As Book In dataregister
                    writer.WriteLine(String.Join(",", bookregister.Name, bookregister.Title, bookregister.Author, bookregister.Publisher, bookregister.Date, bookregister.Enddate))
                Next
            End Using

            MessageBox.Show("Text file exported successfully :D")
        End Sub

        Public Sub Opentextfile()
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "txt files |*.txt"
            dialog.Title = "Save the Text File"

            If dialog.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim filePath As String = dialog.FileName
            Dim lines As String() = File.ReadAllLines(filePath)

            dataregister.Clear()

            For Each line As String In lines
                Dim columns As String() = line.Split(","c)
                Dim book As Book = New Book()
                book.Name = columns(0).Trim()
                book.Title = columns(1).Trim()
                book.Author = columns(2).Trim()
                book.Publisher = columns(3).Trim()
                book.Date = Convert.ToDateTime(columns(4).Trim())
                book.Enddate = Convert.ToDateTime(columns(5).Trim())
                dataregister.Add(book)
            Next

            dgvBookregister.DataSource = Nothing
            dgvBookregister.DataSource = dataregister
        End Sub

        Private Sub btnExporttxt_Click(sender As Object, e As EventArgs)
            SaveTextFile()
        End Sub

        Private Sub btnExportWord_Click(sender As Object, e As EventArgs)
            Dim dialog As SaveFileDialog = New SaveFileDialog()
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

                For Each book As Book In dataregister
                    Dim paragraph As Paragraph = body.AppendChild(New Paragraph())
                    Dim run As Run = paragraph.AppendChild(New Run())
                    Dim text As Text = run.AppendChild(New Text())
                    text.Text = $"Name: {book.Name}, Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Date: {book.Date}, End Date: {book.Enddate}" & vbCrLf
                Next
            End Using

            MessageBox.Show("Word file exported successfully :D")
        End Sub

        Private Sub btnOpentxtFile_Click(sender As Object, e As EventArgs)
            Opentextfile()
        End Sub




    End Class
End Namespace

