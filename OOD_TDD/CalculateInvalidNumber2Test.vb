Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculateInvalidNumber2Test

    <TestMethod()> Public Sub CalculateInvalidNumber2()
        Dim myCalc As New Calculation()
        Dim myNumber1 As New InputNumber()
        Dim myNumber2 As New InputNumber()
        Dim myExpectedResult As New InputNumber()
        Dim myOperation As New Calculation()
        myOperation.Operation = "+"

        myCalc.Number1 = myNumber1
        myCalc.Number2 = myNumber2
        myCalc.Operation = myOperation.Operation
        myCalc.Number1.Enter("3")
        myCalc.Number2.Enter("x")
        myCalc.ExpectedResult.Enter("5")

        myCalc.Calculate()

        Assert.AreEqual(False, myCalc.IsCorrect, "Not valid")
    End Sub

End Class