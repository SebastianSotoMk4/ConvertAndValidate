'Sebastian Soto
'RCET0265
'Fall 2021
'_projectName
'_gitURL
Option Explicit On
Option Strict On
Module ConvertAndValidate
    Sub Main()
        Dim userNumber As Integer
        ' Dim userInput As String
        Dim numberReturn As Integer

        ReturnNumber(numberReturn)
        userNumber = numberReturn
        Console.WriteLine(userNumber)
        Console.WriteLine(numberReturn)

        Console.ReadLine()
    End Sub

    Function ReturnNumber(ByRef numberReturn As Integer) As Integer

        Dim userString As String
        Dim integerReturn As Integer
        userString = Console.ReadLine()
        Try

            integerReturn = CInt(userString)
            Console.WriteLine("works")
            Return integerReturn

        Catch ex As Exception
            Console.WriteLine("Dont work")

        End Try





    End Function

End Module
