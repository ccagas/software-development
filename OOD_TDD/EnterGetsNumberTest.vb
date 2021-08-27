Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class EnterGetsNumberTest

    <TestMethod()> Public Sub EnterGetsNumber()
        Dim number As InputNumber
        number = New InputNumber()
        number.Enter("3")



        Assert.AreEqual(3, number.Number, "Invalid input")
        Assert.AreEqual(True, number.Valid, "False")
    End Sub

End Class