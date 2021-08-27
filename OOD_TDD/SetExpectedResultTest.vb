Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class SetExpectedResultTest

    <TestMethod()> Public Sub SetExpectedResult()
        Dim myCalc As New Calculation()
        Dim myExpectedResult As New InputNumber()

        myCalc.ExpectedResult = myExpectedResult
        myCalc.ExpectedResult.Enter("5")


        Assert.IsNotNull(myCalc, "Is Null")
        Assert.AreEqual(5, myCalc.ExpectedResult.Number, "Not valid")
    End Sub

End Class