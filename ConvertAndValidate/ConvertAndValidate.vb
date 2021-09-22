'Sebastian Soto
'RCET0265
'Fall 2021
'_projectName
'_gitURL
Option Explicit On
Option Strict On
Module ConvertAndValidate
    Sub Main()
        Dim userInput As String
        Dim numberReturn As Integer

        ReturnNumber(userInput, numberReturn)

        Console.WriteLine(numberReturn)

        Console.ReadLine()

    End Sub

    Function ReturnNumber(ByVal userInput As String, ByRef numberReturn As Integer) As String
        'Dim numberCheck As Boolean
        userInput = Console.ReadLine()


        If userInput = Nothing Then

            Console.WriteLine("is empty")
        ElseIf userInput <> Nothing Then

            Try
                numberReturn = CInt(userInput)


            Catch ex As Exception

                Console.WriteLine("must contain a number")

            End Try


        End If



        Return " "
    End Function

    'Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String
    '    Dim check As Boolean
    '    Dim checkNum As Boolean


    '    Try
    '        toThisInteger = CInt(convertThisString)

    '    Catch ex As Exception

    '        If convertThisString = " "  
    '            Return "Is empty."
    '        End If

    '    End Try




    '    Return "message$"

    'End Function

End Module
