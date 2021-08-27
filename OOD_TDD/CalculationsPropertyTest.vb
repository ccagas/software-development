Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationsPropertyTest

    <TestMethod()> Public Sub CalculationsProperty()
        Dim myStudent As New Student()

        Assert.IsNotNull(myStudent, "Is Null")
        Assert.AreEqual(10, myStudent.Calculations.Count, "Array list is {0}", myStudent.Calculations.Count)

    End Sub

End Class