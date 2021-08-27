Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class StudentConstructionTest

    <TestMethod()> Public Sub StudentConstruction()
        Dim myStudent As New Student()

        Assert.IsNotNull(myStudent, "Is Null")

    End Sub

End Class