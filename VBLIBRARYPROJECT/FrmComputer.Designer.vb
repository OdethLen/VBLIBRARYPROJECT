<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComputer
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
        btnReadtxt = New FontAwesome.Sharp.IconButton()
        lblprinttotal = New Label()
        txtNoprints = New TextBox()
        label4 = New Label()
        txtComputernum = New TextBox()
        btnExporttxtc = New FontAwesome.Sharp.IconButton()
        btnBack2 = New FontAwesome.Sharp.IconButton()
        dgvComputer = New DataGridView()
        btnNewcomputer = New FontAwesome.Sharp.IconButton()
        btnAddComputer = New FontAwesome.Sharp.IconButton()
        txtNamec = New TextBox()
        label3 = New Label()
        label2 = New Label()
        label1 = New Label()
        btnExportWordc = New FontAwesome.Sharp.IconButton()
        groupBox1 = New GroupBox()
        dtpcomputer = New DateTimePicker()
        CType(dgvComputer, ComponentModel.ISupportInitialize).BeginInit()
        groupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnReadtxt
        ' 
        btnReadtxt.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReadtxt.IconChar = FontAwesome.Sharp.IconChar.None
        btnReadtxt.IconColor = Color.Black
        btnReadtxt.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnReadtxt.Location = New Point(94, 575)
        btnReadtxt.Name = "btnReadtxt"
        btnReadtxt.Size = New Size(128, 32)
        btnReadtxt.TabIndex = 16
        btnReadtxt.Text = "READ TXT"
        btnReadtxt.UseVisualStyleBackColor = True
        ' 
        ' lblprinttotal
        ' 
        lblprinttotal.AutoSize = True
        lblprinttotal.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblprinttotal.Location = New Point(295, 139)
        lblprinttotal.Name = "lblprinttotal"
        lblprinttotal.Size = New Size(39, 15)
        lblprinttotal.TabIndex = 10
        lblprinttotal.Text = "Cost"
        ' 
        ' txtNoprints
        ' 
        txtNoprints.Font = New Font("Lucida Sans", 9.75F)
        txtNoprints.Location = New Point(167, 131)
        txtNoprints.Name = "txtNoprints"
        txtNoprints.Size = New Size(84, 23)
        txtNoprints.TabIndex = 9
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(20, 133)
        label4.Name = "label4"
        label4.Size = New Size(132, 17)
        label4.TabIndex = 8
        label4.Text = "Number of prints"
        ' 
        ' txtComputernum
        ' 
        txtComputernum.Font = New Font("Lucida Sans", 9.75F)
        txtComputernum.Location = New Point(167, 93)
        txtComputernum.Name = "txtComputernum"
        txtComputernum.Size = New Size(84, 23)
        txtComputernum.TabIndex = 7
        ' 
        ' btnExporttxtc
        ' 
        btnExporttxtc.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExporttxtc.IconChar = FontAwesome.Sharp.IconChar.None
        btnExporttxtc.IconColor = Color.Black
        btnExporttxtc.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExporttxtc.Location = New Point(100, 299)
        btnExporttxtc.Name = "btnExporttxtc"
        btnExporttxtc.Size = New Size(113, 30)
        btnExporttxtc.TabIndex = 14
        btnExporttxtc.Text = "EXPORT TXT"
        btnExporttxtc.UseVisualStyleBackColor = True
        ' 
        ' btnBack2
        ' 
        btnBack2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        btnBack2.IconColor = Color.CadetBlue
        btnBack2.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnBack2.IconSize = 32
        btnBack2.Location = New Point(47, 52)
        btnBack2.Name = "btnBack2"
        btnBack2.Size = New Size(57, 31)
        btnBack2.TabIndex = 13
        btnBack2.UseVisualStyleBackColor = True
        ' 
        ' dgvComputer
        ' 
        dgvComputer.BackgroundColor = Color.PowderBlue
        dgvComputer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvComputer.Location = New Point(94, 359)
        dgvComputer.Name = "dgvComputer"
        dgvComputer.Size = New Size(608, 193)
        dgvComputer.TabIndex = 12
        ' 
        ' btnNewcomputer
        ' 
        btnNewcomputer.Font = New Font("Lucida Handwriting", 9F)
        btnNewcomputer.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        btnNewcomputer.IconColor = Color.Black
        btnNewcomputer.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnNewcomputer.IconSize = 32
        btnNewcomputer.ImageAlign = ContentAlignment.MiddleLeft
        btnNewcomputer.Location = New Point(317, 77)
        btnNewcomputer.Name = "btnNewcomputer"
        btnNewcomputer.Size = New Size(106, 35)
        btnNewcomputer.TabIndex = 4
        btnNewcomputer.Text = "NEW"
        btnNewcomputer.UseVisualStyleBackColor = True
        ' 
        ' btnAddComputer
        ' 
        btnAddComputer.Font = New Font("Lucida Handwriting", 9F)
        btnAddComputer.IconChar = FontAwesome.Sharp.IconChar.Save
        btnAddComputer.IconColor = Color.Black
        btnAddComputer.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddComputer.IconSize = 32
        btnAddComputer.ImageAlign = ContentAlignment.MiddleLeft
        btnAddComputer.Location = New Point(317, 30)
        btnAddComputer.Name = "btnAddComputer"
        btnAddComputer.Size = New Size(106, 35)
        btnAddComputer.TabIndex = 3
        btnAddComputer.Text = "ADD"
        btnAddComputer.UseVisualStyleBackColor = True
        ' 
        ' txtNamec
        ' 
        txtNamec.Font = New Font("Lucida Sans", 9.75F)
        txtNamec.Location = New Point(86, 30)
        txtNamec.Name = "txtNamec"
        txtNamec.Size = New Size(165, 23)
        txtNamec.TabIndex = 6
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(20, 73)
        label3.Name = "label3"
        label3.Size = New Size(43, 17)
        label3.TabIndex = 4
        label3.Text = "Date"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(20, 101)
        label2.Name = "label2"
        label2.Size = New Size(141, 17)
        label2.TabIndex = 3
        label2.Text = "Computer number"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(20, 38)
        label1.Name = "label1"
        label1.Size = New Size(51, 17)
        label1.TabIndex = 2
        label1.Text = "Name"
        ' 
        ' btnExportWordc
        ' 
        btnExportWordc.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExportWordc.IconChar = FontAwesome.Sharp.IconChar.None
        btnExportWordc.IconColor = Color.Black
        btnExportWordc.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExportWordc.Location = New Point(250, 299)
        btnExportWordc.Name = "btnExportWordc"
        btnExportWordc.Size = New Size(151, 30)
        btnExportWordc.TabIndex = 15
        btnExportWordc.Text = "EXPORT WORD"
        btnExportWordc.UseVisualStyleBackColor = True
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(lblprinttotal)
        groupBox1.Controls.Add(txtNoprints)
        groupBox1.Controls.Add(label4)
        groupBox1.Controls.Add(txtComputernum)
        groupBox1.Controls.Add(btnNewcomputer)
        groupBox1.Controls.Add(btnAddComputer)
        groupBox1.Controls.Add(txtNamec)
        groupBox1.Controls.Add(dtpcomputer)
        groupBox1.Controls.Add(label3)
        groupBox1.Controls.Add(label2)
        groupBox1.Controls.Add(label1)
        groupBox1.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        groupBox1.Location = New Point(150, 90)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Size(483, 182)
        groupBox1.TabIndex = 11
        groupBox1.TabStop = False
        groupBox1.Text = "Register"
        ' 
        ' dtpcomputer
        ' 
        dtpcomputer.Font = New Font("Lucida Sans", 9.75F)
        dtpcomputer.Format = DateTimePickerFormat.Short
        dtpcomputer.Location = New Point(86, 64)
        dtpcomputer.Name = "dtpcomputer"
        dtpcomputer.Size = New Size(165, 23)
        dtpcomputer.TabIndex = 5
        ' 
        ' FrmComputer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(749, 659)
        Controls.Add(btnReadtxt)
        Controls.Add(btnExporttxtc)
        Controls.Add(btnBack2)
        Controls.Add(dgvComputer)
        Controls.Add(btnExportWordc)
        Controls.Add(groupBox1)
        Name = "FrmComputer"
        Text = "FrmComputer"
        CType(dgvComputer, ComponentModel.ISupportInitialize).EndInit()
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents btnReadtxt As FontAwesome.Sharp.IconButton
    Private WithEvents lblprinttotal As Label
    Private WithEvents txtNoprints As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtComputernum As TextBox
    Private WithEvents btnExporttxtc As FontAwesome.Sharp.IconButton
    Private WithEvents btnBack2 As FontAwesome.Sharp.IconButton
    Private WithEvents dgvComputer As DataGridView
    Private WithEvents btnNewcomputer As FontAwesome.Sharp.IconButton
    Private WithEvents btnAddComputer As FontAwesome.Sharp.IconButton
    Private WithEvents txtNamec As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnExportWordc As FontAwesome.Sharp.IconButton
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents dtpcomputer As DateTimePicker
End Class
