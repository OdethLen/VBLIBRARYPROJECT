<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBook
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnExportexcel = New FontAwesome.Sharp.IconButton()
        dtpEnddate = New DateTimePicker()
        btnAddBook = New FontAwesome.Sharp.IconButton()
        label6 = New Label()
        btnNewbookr = New FontAwesome.Sharp.IconButton()
        dtpdate = New DateTimePicker()
        txtPublisher = New TextBox()
        txtAuthor = New TextBox()
        txtTitle = New TextBox()
        txtName = New TextBox()
        btnExporttxt = New FontAwesome.Sharp.IconButton()
        btnBack = New FontAwesome.Sharp.IconButton()
        btnOpentxtFile = New FontAwesome.Sharp.IconButton()
        dgvBookregister = New DataGridView()
        label5 = New Label()
        label4 = New Label()
        label3 = New Label()
        label2 = New Label()
        btnExportWord = New FontAwesome.Sharp.IconButton()
        label1 = New Label()
        groupBox1 = New GroupBox()
        CType(dgvBookregister, ComponentModel.ISupportInitialize).BeginInit()
        groupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExportexcel
        ' 
        btnExportexcel.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExportexcel.IconChar = FontAwesome.Sharp.IconChar.None
        btnExportexcel.IconColor = Color.Black
        btnExportexcel.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExportexcel.Location = New Point(381, 323)
        btnExportexcel.Name = "btnExportexcel"
        btnExportexcel.Size = New Size(126, 30)
        btnExportexcel.TabIndex = 15
        btnExportexcel.Text = "EXPORT EXCEL"
        btnExportexcel.UseVisualStyleBackColor = True
        ' 
        ' dtpEnddate
        ' 
        dtpEnddate.Font = New Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpEnddate.Format = DateTimePickerFormat.Short
        dtpEnddate.Location = New Point(287, 168)
        dtpEnddate.Name = "dtpEnddate"
        dtpEnddate.Size = New Size(117, 23)
        dtpEnddate.TabIndex = 12
        ' 
        ' btnAddBook
        ' 
        btnAddBook.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddBook.IconChar = FontAwesome.Sharp.IconChar.None
        btnAddBook.IconColor = Color.Black
        btnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddBook.Location = New Point(394, 44)
        btnAddBook.Name = "btnAddBook"
        btnAddBook.Size = New Size(104, 30)
        btnAddBook.TabIndex = 5
        btnAddBook.Text = "ADD"
        btnAddBook.UseVisualStyleBackColor = True
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(207, 174)
        label6.Name = "label6"
        label6.Size = New Size(74, 17)
        label6.TabIndex = 11
        label6.Text = "End date"
        ' 
        ' btnNewbookr
        ' 
        btnNewbookr.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNewbookr.IconChar = FontAwesome.Sharp.IconChar.None
        btnNewbookr.IconColor = Color.Black
        btnNewbookr.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnNewbookr.IconSize = 32
        btnNewbookr.ImageAlign = ContentAlignment.MiddleLeft
        btnNewbookr.Location = New Point(394, 80)
        btnNewbookr.Name = "btnNewbookr"
        btnNewbookr.Size = New Size(106, 30)
        btnNewbookr.TabIndex = 2
        btnNewbookr.Text = "NEW"
        btnNewbookr.UseVisualStyleBackColor = True
        ' 
        ' dtpdate
        ' 
        dtpdate.Font = New Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpdate.Format = DateTimePickerFormat.Short
        dtpdate.Location = New Point(65, 172)
        dtpdate.Name = "dtpdate"
        dtpdate.Size = New Size(115, 23)
        dtpdate.TabIndex = 10
        ' 
        ' txtPublisher
        ' 
        txtPublisher.Font = New Font("Lucida Sans", 9.75F)
        txtPublisher.Location = New Point(118, 133)
        txtPublisher.Name = "txtPublisher"
        txtPublisher.Size = New Size(231, 23)
        txtPublisher.TabIndex = 9
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Lucida Sans", 9.75F)
        txtAuthor.Location = New Point(118, 100)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(231, 23)
        txtAuthor.TabIndex = 8
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Lucida Sans", 9.75F)
        txtTitle.Location = New Point(118, 66)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(231, 23)
        txtTitle.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Lucida Sans", 9.75F)
        txtName.Location = New Point(86, 31)
        txtName.Name = "txtName"
        txtName.Size = New Size(171, 23)
        txtName.TabIndex = 6
        ' 
        ' btnExporttxt
        ' 
        btnExporttxt.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExporttxt.IconChar = FontAwesome.Sharp.IconChar.None
        btnExporttxt.IconColor = Color.Black
        btnExporttxt.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExporttxt.Location = New Point(94, 323)
        btnExporttxt.Name = "btnExporttxt"
        btnExporttxt.Size = New Size(113, 30)
        btnExporttxt.TabIndex = 13
        btnExporttxt.Text = "EXPORT TXT"
        btnExporttxt.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        btnBack.IconColor = Color.RosyBrown
        btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnBack.IconSize = 32
        btnBack.Location = New Point(42, 41)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(57, 31)
        btnBack.TabIndex = 12
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnOpentxtFile
        ' 
        btnOpentxtFile.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOpentxtFile.IconChar = FontAwesome.Sharp.IconChar.None
        btnOpentxtFile.IconColor = Color.Black
        btnOpentxtFile.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnOpentxtFile.Location = New Point(94, 588)
        btnOpentxtFile.Name = "btnOpentxtFile"
        btnOpentxtFile.Size = New Size(122, 30)
        btnOpentxtFile.TabIndex = 11
        btnOpentxtFile.Text = "READ TXT"
        btnOpentxtFile.UseVisualStyleBackColor = True
        ' 
        ' dgvBookregister
        ' 
        dgvBookregister.BackgroundColor = Color.Pink
        dgvBookregister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookregister.Location = New Point(94, 377)
        dgvBookregister.Name = "dgvBookregister"
        dgvBookregister.Size = New Size(613, 193)
        dgvBookregister.TabIndex = 10
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(16, 177)
        label5.Name = "label5"
        label5.Size = New Size(43, 17)
        label5.TabIndex = 5
        label5.Text = "Date"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(34, 135)
        label4.Name = "label4"
        label4.Size = New Size(78, 17)
        label4.TabIndex = 4
        label4.Text = "Publisher"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(34, 103)
        label3.Name = "label3"
        label3.Size = New Size(60, 17)
        label3.TabIndex = 3
        label3.Text = "Author"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(34, 69)
        label2.Name = "label2"
        label2.Size = New Size(42, 17)
        label2.TabIndex = 2
        label2.Text = "Title"
        ' 
        ' btnExportWord
        ' 
        btnExportWord.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExportWord.IconChar = FontAwesome.Sharp.IconChar.None
        btnExportWord.IconColor = Color.Black
        btnExportWord.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExportWord.Location = New Point(231, 323)
        btnExportWord.Name = "btnExportWord"
        btnExportWord.Size = New Size(121, 30)
        btnExportWord.TabIndex = 14
        btnExportWord.Text = "EXPORT WORD"
        btnExportWord.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(16, 33)
        label1.Name = "label1"
        label1.Size = New Size(51, 17)
        label1.TabIndex = 1
        label1.Text = "Name"
        ' 
        ' groupBox1
        ' 
        groupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        groupBox1.Controls.Add(dtpEnddate)
        groupBox1.Controls.Add(btnAddBook)
        groupBox1.Controls.Add(label6)
        groupBox1.Controls.Add(btnNewbookr)
        groupBox1.Controls.Add(dtpdate)
        groupBox1.Controls.Add(txtPublisher)
        groupBox1.Controls.Add(txtAuthor)
        groupBox1.Controls.Add(txtTitle)
        groupBox1.Controls.Add(txtName)
        groupBox1.Controls.Add(label5)
        groupBox1.Controls.Add(label4)
        groupBox1.Controls.Add(label3)
        groupBox1.Controls.Add(label2)
        groupBox1.Controls.Add(label1)
        groupBox1.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        groupBox1.Location = New Point(131, 76)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Size(523, 226)
        groupBox1.TabIndex = 9
        groupBox1.TabStop = False
        groupBox1.Text = "Register"
        ' 
        ' FrmBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(749, 659)
        Controls.Add(btnExportexcel)
        Controls.Add(btnExporttxt)
        Controls.Add(btnBack)
        Controls.Add(btnOpentxtFile)
        Controls.Add(dgvBookregister)
        Controls.Add(btnExportWord)
        Controls.Add(groupBox1)
        Name = "FrmBook"
        Text = "FrmBook"
        CType(dgvBookregister, ComponentModel.ISupportInitialize).EndInit()
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents btnExportexcel As FontAwesome.Sharp.IconButton
    Private WithEvents dtpEnddate As DateTimePicker
    Private WithEvents btnAddBook As FontAwesome.Sharp.IconButton
    Private WithEvents label6 As Label
    Private WithEvents btnNewbookr As FontAwesome.Sharp.IconButton
    Private WithEvents dtpdate As DateTimePicker
    Private WithEvents txtPublisher As TextBox
    Private WithEvents txtAuthor As TextBox
    Private WithEvents txtTitle As TextBox
    Private WithEvents txtName As TextBox
    Private WithEvents btnExporttxt As FontAwesome.Sharp.IconButton
    Private WithEvents btnBack As FontAwesome.Sharp.IconButton
    Private WithEvents btnOpentxtFile As FontAwesome.Sharp.IconButton
    Private WithEvents dgvBookregister As DataGridView
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents btnExportWord As FontAwesome.Sharp.IconButton
    Private WithEvents label1 As Label
    Private WithEvents groupBox1 As GroupBox
End Class
