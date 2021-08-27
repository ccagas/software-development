Public Class Calculation

    Public Sub New()
    End Sub

    Private _number1 As New InputNumber
    Public Property Number1() As InputNumber
        Get
            Return _number1
        End Get
        Set(value As InputNumber)

        End Set
    End Property

    Private _number2 As New InputNumber
    Public Property Number2() As InputNumber
        Get
            Return _number2
        End Get
        Set(value As InputNumber)
            _number2 = value
        End Set
    End Property

    Private _expectedResult As New InputNumber
    Public Property ExpectedResult() As InputNumber
        Get
            Return _expectedResult
        End Get
        Set(value As InputNumber)
            _expectedResult = value
        End Set
    End Property

    Private _operation As String
    Public Property Operation() As String
        Get
            Return _operation
        End Get
        Set(value As String)
            _operation = value
        End Set
    End Property

    Private _result As Integer

    Public Function Calculate()

        If Operation = "+" Then
            _result = Number1.Number + Number2.Number

            If _result = ExpectedResult.Number Then
                _isCorrect = True
            Else
                _isCorrect = False
            End If

        End If

        Return _result

    End Function

    Private _isCorrect As Boolean
    Public Property IsCorrect() As Boolean
        Get
            Return _isCorrect

        End Get
        Set(value As Boolean)
            _result = value
        End Set
    End Property

End Class

