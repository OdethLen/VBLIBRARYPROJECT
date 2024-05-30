Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace LIBRARY_PROJECT
    Friend Class Register
        Protected _name As String

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Protected _date As DateTime

        Public Property [Date]() As DateTime
            Get
                Return _date
            End Get
            Set(value As DateTime)
                _date = value
            End Set
        End Property

        ' Constructor
        Public Sub New()
            _name = ""
            _date = DateTime.Now
        End Sub

        Public Sub New(ByVal name As String, ByVal [date] As DateTime)
            _name = name
            _date = [date]
        End Sub

        ' Method
        Public Overrides Function ToString() As String
            Return "Name: " & _name & "Date: " & _date
        End Function
    End Class
End Namespace

