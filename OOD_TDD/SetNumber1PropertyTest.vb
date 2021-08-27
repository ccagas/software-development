Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class SetNumber1PropertyTest

    <TestMethod()> Public Sub SetNumber1Property()
        Dim myCalc As New Calculation()
        Dim number1 As New InputNumber()

        myCalc.Number1 = number1
        myCalc.Number1.Enter("3")


        Assert.IsNotNull(myCalc, "Is Null")
        Assert.AreEqual(3, myCalc.Number1.Number, "Not valid")

    End Sub

End Class