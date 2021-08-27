Imports Object_Oriented_Programming_Assignment
Module Module1

    Sub Main()
        Dim currentStudent As Student
        Dim firstNum As InputNumber
        Dim secondNum As InputNumber
        Dim expectedResult As InputNumber
        Dim calculation As Calculation
        Dim result As String

        Console.WriteLine("Assignment: Console Number Adder" + vbNewLine)
        currentStudent = New Student

        Do

            Console.WriteLine("Enter First Number:")
            firstNum = New InputNumber
            firstNum.Enter(Console.ReadLine)

            Console.WriteLine("Enter Second Number:")
            secondNum = New InputNumber
            secondNum.Enter(Console.ReadLine)

            Console.WriteLine("Enter Expected Result:")
            expectedResult = New InputNumber
            expectedResult.Enter(Console.ReadLine)

            Console.WriteLine("Enter Operation:")
            calculation = New Calculation
            calculation.Operation = (Console.ReadLine)

            calculation.Number1 = firstNum
            calculation.Number2 = secondNum
            calculation.ExpectedResult = expectedResult

            currentStudent.CheckCalculation(calculation)
            result = CType(calculation.IsCorrect, String)

            Console.Write("Your answer is " + result + vbNewLine)
            Console.WriteLine("Enter again? Y/N:")

            If Console.ReadLine.ToUpper = "N" Then
                Exit Do
            End If

        Loop

    End Sub

End Module
