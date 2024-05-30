Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO

Namespace LIBRARY_PROJECT
    Friend Class Book
        Inherits Register
        ' Propiedades
        Protected _title As String

        Public Property Title() As String
            Get
                Return _title
            End Get
            Set(value As String)
                _title = value
            End Set
        End Property

        Protected _author As String

        Public Property Author() As String
            Get
                Return _author
            End Get
            Set(value As String)
                _author = value
            End Set
        End Property

        Protected _publisher As String

        Public Property Publisher() As String
            Get
                Return _publisher
            End Get
            Set(value As String)
                _publisher = value
            End Set
        End Property

        Private _enddate As DateTime

        Public Property Enddate() As DateTime
            Get
                Return _enddate
            End Get
            Set(value As DateTime)
                _enddate = value
            End Set
        End Property

        ' Constructor
        Public Sub New()
            MyBase.New()
            _title = ""
            _author = ""
            _publisher = ""
            _enddate = DateTime.Now
        End Sub

        Public Sub New(ByVal name As String, ByVal title As String, ByVal author As String, ByVal publisher As String, ByVal [date] As DateTime, ByVal enddate As DateTime)
            MyBase.New(name, [date])
            _title = title
            _author = author
            _publisher = publisher
            _enddate = enddate
        End Sub

        ' Método sin parámetros de entrada y con retorno de datos 
        Public Overrides Function ToString() As String
            Return "Name: " & Name & "Date: " & [Date] & "End date: " & Enddate & "Title: " & _title & "Author: " & _author & "Publisher: " & _publisher
        End Function
    End Class
End Namespace
