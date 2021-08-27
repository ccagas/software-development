Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CheckValidCalculationTest

    <TestMethod()> Public Sub CheckValidCalculation()
        Dim myStudent As New Student()
        Dim myCalc As New Calculation()
        Dim myNumber1 As New InputNumber()
        Dim myNumber2 As New InputNumber()
        Dim myExpectedResult As New InputNumber()
        Dim myOperation As New Calculation()
        myOperation.Operation = "+"

        myCalc.Number1 = myNumber1
        myCalc.Number2 = myNumber2
        myCalc.Operation = myOperation.Operation
        myCalc.Number1.Enter("3")
        myCalc.Number2.Enter("2")
        myCalc.ExpectedResult.Enter("5")

        'call check calculation method

        myStudent.CheckCalculation(myCalc.Number1, myCalc.Number2, myCalc.ExpectedResult, myCalc.Operation)

        Assert.AreEqual(myCalc.Calculate, myStudent.Calculations(1), "Invalid Calculation")


    End Sub

End Class