Public MustInherit Class Input
    Public Sub New()
    End Sub

    Protected _valid As Boolean
    ReadOnly Property Valid() As Boolean
        Get
            Return _valid
        End Get
    End Property

    Private myTextNumber As String
    Public Sub Enter(myNumber As String)
        myTextNumber = myNumber

        Validate(myNumber)
    End Sub

    Protected MustOverride Sub Validate(myNumber As String)

End Class
