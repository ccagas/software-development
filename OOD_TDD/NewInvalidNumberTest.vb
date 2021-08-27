Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class NewInvalidNumberTest

    <TestMethod()> Public Sub NewInvalidNumber()
        Dim number As InputNumber
        number = New InputNumber()
        number.Enter("u")

        Assert.AreEqual(0, number.Number, "Not zero")
        Assert.AreEqual(False, number.Valid, "True")

    End Sub

End Class