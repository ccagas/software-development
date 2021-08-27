Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class YourNameTest

    <TestMethod()> Public Sub YourName()
        Dim myFullNameTest As String

        myFullNameTest = "Candie Cagas"

        If myFullNameTest = "Candie Cagas" Then
            Assert.AreEqual("Candie Cagas", myFullNameTest, "Is my full name")
        Else
            Debug.Print("Is not my full name")
        End If

    End Sub

End Class