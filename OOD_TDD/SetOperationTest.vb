Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class SetOperationTest

    <TestMethod()> Public Sub SetOperation()
        Dim myCalc As New Calculation()
        Dim myOperation As String = "+"

        myCalc.Operation = myOperation

        Assert.IsNotNull(myCalc, "Is Null")
        Assert.AreEqual("+", myCalc.Operation, "Not valid")
    End Sub

End Class