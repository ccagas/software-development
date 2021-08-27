Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class RetirementTest

    <TestMethod()> Public Sub Retirement()
        Dim valueTest1 As Integer = 7
        Dim valueTest2 As Integer = 8
        Dim valueResult As Integer

        valueResult = valueTest1 * valueTest2

        If valueResult < 55 Then
            Debug.Print("You have a little more work ahead.")
        Else
            Debug.Print("Time to retire.")
        End If
    End Sub

End Class