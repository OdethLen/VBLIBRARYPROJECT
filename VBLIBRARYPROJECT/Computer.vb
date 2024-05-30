Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Numerics
Imports System.Text
Imports System.Threading.Tasks

Namespace LIBRARY_PROJECT
    Friend Class Computer
        Inherits Register
        ' Propiedades
        Protected _computerNumber As String

        Public Property ComputerNumber() As String
            Get
                Return _computerNumber
            End Get
            Set(value As String)
                _computerNumber = value
            End Set
        End Property

        ' Propiedad de solo lectura
        Protected _cost As Double = 0.26

        Public ReadOnly Property Cost() As Double
            Get
                Return _cost
            End Get
        End Property

        Private _printNumber As Integer

        Public Property PrintNumber() As Integer
            Get
                Return _printNumber
            End Get
            Set(value As Integer)
                _printNumber = value
            End Set
        End Property

        Private _total As Double

        Public Property Total() As Double
            Get
                Return _total
            End Get
            Set(value As Double)
                _total = value
            End Set
        End Property

        ' Constructor
        Public Sub New()
            MyBase.New()
            _computerNumber = ""
            _cost = 0.26
            _total = 0
        End Sub

        Public Sub New(ByVal name As String, ByVal [date] As DateTime, ByVal computerNumber As String, ByVal printNumber As Integer)
            MyBase.New(name, [date])
            _computerNumber = computerNumber
            _printNumber = printNumber
        End Sub

        Public Overrides Function ToString() As String
            Return "Name: " & Name & "Date: " & [Date] & "Computer number: " & _computerNumber
        End Function

        ' Método con parámetros y retorno de datos
        Public Function GetTotal(cost As Double, printNumber As Integer) As Double
            Dim total As Double = cost * printNumber
            Return total
        End Function
    End Class
End Namespace
