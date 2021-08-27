Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GetStudentNameTest

    <TestMethod()> Public Sub GetStudentName()
        Dim studentName As New StudentCalculationsEntities
        Dim studentCount As Integer = 0

        For Each student As Student In studentName.Students
            Debug.Print("", studentName)
        Next

        studentCount += 1
    End Sub

End Class