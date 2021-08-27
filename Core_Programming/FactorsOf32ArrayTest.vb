Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class FactorsOf32ArrayTest

    <TestMethod()> Public Sub factorsOF32Array()
        Dim factor1(6) As Integer
        Dim factor2(6) As Integer


        factor1 = {1, 2, 4, 8, 16, 32}
        factor2 = {32, 16, 8, 4, 2, 1}

        Dim loopCounter As Integer = 0

        While loopCounter <= 5

            Assert.AreEqual(32, factor1(loopCounter) * factor2(loopCounter), "Not factor of 32")

            loopCounter += 1
        End While


    End Sub

End Class