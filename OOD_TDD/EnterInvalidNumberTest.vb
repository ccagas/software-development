Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class EnterInvalidNumberTest

    <TestMethod()> Public Sub EnterInvalidNumber()
        Dim number As InputNumber
        number = New InputNumber()
        number.Enter("x")

        Assert.AreEqual(0, number.Number, "Valid")
        Assert.AreEqual(False, number.Valid, "True")
    End Sub

End Class