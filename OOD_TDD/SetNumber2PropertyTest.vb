Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class SetNumber2PropertyTest

    <TestMethod()> Public Sub SetNumber2Property()
        Dim myCalc As New Calculation()
        Dim number2 As New InputNumber()

        myCalc.Number2 = number2
        myCalc.Number2.Enter("2")


        Assert.IsNotNull(myCalc, "Is Null")
        Assert.AreEqual(2, myCalc.Number2.Number, "Not valid")
    End Sub

End Class