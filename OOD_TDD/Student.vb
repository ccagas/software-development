Public Class Student

    Private _calculations(9) As Calculation
    Public Property Calculations() As Calculation()
        Get
            Return _calculations
        End Get
        Set(value As Calculation())
            _calculations = value
        End Set
    End Property

    ' code for checking and storing Calculations here
    Public Function CheckCalculation(calcNum1 As InputNumber, calcNum2 As Input, calcExpectedResult As InputNumber, calcOperation As String) As Calculation

        Dim loopCounter As Integer = 0

        For loopCounter = 0 To 9

            CheckCalculation = New Calculation
            calcNum1 = New InputNumber
            calcNum2 = New InputNumber
            calcExpectedResult = New InputNumber
            calcOperation = CheckCalculation.Operation

            CheckCalculation.Calculate()

            If CheckCalculation.IsCorrect = True Then
                _calculations(loopCounter) = CheckCalculation

                loopCounter += 1
            Else
                Return _calculations(loopCounter)
            End If

        Next

        Return _calculations(loopCounter)
    End Function

End Class
