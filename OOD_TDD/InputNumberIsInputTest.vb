Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class InputNumberIsInputTest

    <TestMethod()> Public Sub InputNumberIsInputTest()
        Dim number As Input
        number = New InputNumber()

        Assert.IsNotNull(number, "Null")

    End Sub

End Class