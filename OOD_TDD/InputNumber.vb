Public Class InputNumber
    Inherits Input
    Public Sub New()
    End Sub

    Private myIntNum As Integer
    Public Sub Parsed()
        myIntNum = _isNumber
    End Sub

    Private _isNumber As Integer
    Public ReadOnly Property Number() As Integer
        Get
            Return _isNumber
        End Get
    End Property

    Protected Overrides Sub Validate(myNumber As String)
        Dim result As Integer

        Dim success As Boolean = Integer.TryParse(myNumber, result)
        If success Then
            _valid = success
            _isNumber = result
        End If

    End Sub

End Class
