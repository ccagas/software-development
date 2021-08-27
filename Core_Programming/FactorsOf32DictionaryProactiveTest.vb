Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class FactorsOf32DictionaryProactiveTest

    <TestMethod()> Public Sub FactorsOf32DictionaryProactive()
        Dim factor As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
        Dim pair As KeyValuePair(Of Integer, Integer)

        factor.Add(1, 32)
        factor.Add(2, 16)
        factor.Add(4, 8)
        factor.Add(8, 4)
        factor.Add(16, 2)
        factor.Add(32, 1)

        Dim loopCounter As Integer = 1

        Do
            For Each pair In factor
                If factor.ContainsKey(loopCounter) Then
                    Assert.AreEqual(32, pair.Key * pair.Value, "Not factor of 32")
                End If
            Next

            loopCounter += 1
        Loop Until loopCounter = 32

    End Sub

End Class