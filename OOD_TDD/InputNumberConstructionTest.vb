Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class InputNumberConstructionTest

    <TestMethod()> Public Sub InputNumberConstruction()
        Dim number As InputNumber
        number = New InputNumber()

        Assert.IsNotNull(number, "The value is null")

    End Sub

End Class