Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class NewValidNumberTest

    <TestMethod()> Public Sub NewValidNumber()
        Dim number As InputNumber
        number = New InputNumber()
        number.Enter("2")

        Assert.AreEqual(2, number.Number, "Not zero")
        Assert.AreEqual(True, number.Valid, "True")
    End Sub

End Class