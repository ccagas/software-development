Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationConstructionTest

    <TestMethod()> Public Sub CalculationConstruction()
        Dim calc As Calculation
        calc = New Calculation()

        Assert.IsNotNull(calc, "Is Null")
    End Sub

End Class