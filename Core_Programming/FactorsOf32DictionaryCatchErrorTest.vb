Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class FactorsOf32DictionaryCatchErrorTest

    <TestMethod()> Public Sub FactorsOf32DictionaryCatchError()
        Dim factor As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
        Dim pair As KeyValuePair(Of Integer, Integer)


        factor.Add(1, 32)
        factor.Add(2, 16)
        factor.Add(4, 8)
        factor.Add(8, 4)
        factor.Add(16, 2)
        factor.Add(32, 1)

        For loopCounter As Integer = 1 To 32

            Try
                For Each pair In factor
                    If pair.Key = loopCounter Then
                        Assert.AreEqual(32, pair.Key * pair.Value, "Not factor of 32")
                    End If
                Next
            Catch
                Debug.Print("Factor of 32 not found")
            End Try

        Next

    End Sub

End Class