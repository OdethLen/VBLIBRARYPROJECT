<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Label1 = New Label()
        label2 = New Label()
        btnComputer = New FontAwesome.Sharp.IconButton()
        btnBook = New FontAwesome.Sharp.IconButton()
        Label3 = New Label()
        pictureBox1 = New PictureBox()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(247, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label2.ForeColor = SystemColors.ActiveCaptionText
        label2.Location = New Point(250, 194)
        label2.Name = "label2"
        label2.Size = New Size(90, 21)
        label2.TabIndex = 8
        label2.Text = "Register"
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnComputer
        ' 
        btnComputer.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnComputer.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt
        btnComputer.IconColor = Color.Black
        btnComputer.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnComputer.IconSize = 40
        btnComputer.ImageAlign = ContentAlignment.MiddleLeft
        btnComputer.Location = New Point(199, 288)
        btnComputer.Name = "btnComputer"
        btnComputer.Size = New Size(186, 49)
        btnComputer.TabIndex = 7
        btnComputer.Text = "Computer"
        btnComputer.UseVisualStyleBackColor = True
        ' 
        ' btnBook
        ' 
        btnBook.Font = New Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBook.ForeColor = Color.Black
        btnBook.IconChar = FontAwesome.Sharp.IconChar.BookBookmark
        btnBook.IconColor = SystemColors.ActiveCaptionText
        btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnBook.IconSize = 40
        btnBook.ImageAlign = ContentAlignment.MiddleLeft
        btnBook.Location = New Point(199, 230)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(186, 52)
        btnBook.TabIndex = 6
        btnBook.Text = "Book"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua Titling MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(160, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(269, 23)
        Label3.TabIndex = 5
        Label3.Text = "G A R D E N  L I B R A R Y"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Image = My.Resources.Resources.d54e12c8b53f8c9cf86d8527fa193f1c
        pictureBox1.Location = New Point(216, 29)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(157, 139)
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox1.TabIndex = 9
        pictureBox1.TabStop = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(588, 347)
        Controls.Add(pictureBox1)
        Controls.Add(label2)
        Controls.Add(btnComputer)
        Controls.Add(btnBook)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Menu"
        Text = "Menu"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents btnComputer As FontAwesome.Sharp.IconButton
    Private WithEvents btnBook As FontAwesome.Sharp.IconButton
    Private WithEvents Label3 As Label
    Private WithEvents pictureBox1 As PictureBox

End Class
