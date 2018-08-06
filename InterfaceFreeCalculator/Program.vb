Imports System

'Jacob Leffew
'Aug 5, 2018
'This simple program functions as a calculator without an interface.  The user enters the first number, the operation,
'and the second number.  The result is displayed and the user is asked whether they want to continue or exit.

Module Program
    Sub Main(args As String())

        Dim finished = False    'Flag used to decide whether or not to quit program
        While (finished = False)
            'Initialize variables
            Dim num1, num2 As Integer, tmp, op As String
            'Request and store first number, loop if input validation fails
            Do
                Console.WriteLine(vbCrLf + "Enter first number: ")
                tmp = Console.ReadLine()
            Loop While Integer.TryParse(tmp, num1) = False
            'Request and store operation, loop if input validation fails
            Do
                Console.WriteLine(vbCrLf + "Enter operation ( Choose from + - * or / ): ")
                op = Console.ReadLine()
            Loop Until (op = "+") Or (op = "-") Or (op = "*") Or (op = "/")
            'Request and store second number, loop if input validation fails
            Do
                Console.WriteLine(vbCrLf + "Enter second number: ")
                tmp = Console.ReadLine()
            Loop While Integer.TryParse(tmp, num2) = False

            Dim result As Double = 0   'Initialize result variable
            'Select Case statement to perform calculation based on operation
            Select Case op
                Case "+"
                    result = num1 + num2
                    Console.WriteLine(num1.ToString + " " + op + " " + num2.ToString + " = " + result.ToString)
                Case "-"
                    result = num1 - num2
                    Console.WriteLine(num1.ToString + " " + op + " " + num2.ToString + " = " + result.ToString)
                Case "*"
                    result = num1 * num2
                    Console.WriteLine(num1.ToString + " " + op + " " + num2.ToString + " = " + result.ToString)
                Case "/"
                    If num2 <> 0 Then   'Test for division by zero
                        result = num1 / num2
                        Console.WriteLine(num1.ToString + " " + op + " " + num2.ToString + " = " + result.ToString)
                    Else Console.WriteLine("Division by zero error" + vbCrLf)
                    End If
            End Select

            'Request whether user wants to continue or quit
            Console.WriteLine("Press any key to continue or q to quit")
            Dim testFinished = Console.ReadKey(True).Key
            If (testFinished = ConsoleKey.Q) Then
                finished = True
            End If

            Console.WriteLine("--------------------------------------")
        End While
    End Sub
End Module
