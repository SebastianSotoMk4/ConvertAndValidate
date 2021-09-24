'Sebastian Soto
'RCET0265
'Fall 2021
'Convert and Validate
'_gitURL
Option Explicit On
Option Strict On
Module ConvertAndValidate
    Sub Main()
        Dim userInput As String
        Dim numberReturn As Integer
        userInput = Console.ReadLine()
        ReturnNumber(userInput, numberReturn)

        Console.WriteLine(ReturnNumber(userInput, numberReturn))

        Console.ReadLine()

    End Sub

    Private Function ReturnNumber(ByVal userInput As String, ByRef numberReturn As Integer) As String
        Dim message As String
        If userInput = Nothing Then
            message = "Is empty"
        ElseIf userInput <> Nothing Then
            Try
                numberReturn = CInt(userInput)
            Catch ex As Exception
                message = "Must contain a number"
            End Try

        End If
        Return message
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
