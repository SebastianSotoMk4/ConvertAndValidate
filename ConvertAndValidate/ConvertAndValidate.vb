'Sebastian Soto
'RCET0265
'Fall 2021
'Convert and Validate
'https://github.com/SebastianSotoMk4/ConvertAndValidate.git
Option Explicit On
Option Strict On
Module ConvertAndValidate
    Sub Main()
        Dim convertThisString As String
        Dim toThisInteger As Integer

        convertThisString = Console.ReadLine()
        ReturnNumber(convertThisString, toThisInteger)
        Console.Write(ReturnNumber(convertThisString, toThisInteger))
        Console.ReadLine()
    End Sub
    'Function converts a string to a 32-bit integer
    Private Function ReturnNumber(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String
        Dim message As String

        If convertThisString = Nothing Then
            'If nothing is entered then "is empty" is returned
            message = "Is empty"
        ElseIf convertThisString <> Nothing Then
            Try
                'Function returns an empty string if success
                toThisInteger = CInt(convertThisString)
            Catch ex As Exception
                'If string to be converted does not contain a number "must contain a number" is returned 
                message = "Must contain a number"
            End Try
        End If
        Return message
    End Function
End Module
