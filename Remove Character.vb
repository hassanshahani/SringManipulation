Module Module1

    Sub Main()
        Dim str1, str2, nextChar As String
        Dim Char1 As Char
        Dim count As Integer

        str1 = ""
        str2 = ""
        Char1 = ""
        nextChar = ""
        count = 0


        Console.Write("Enter the String: ")
        str1 = Console.ReadLine

        Console.Write("Enter Character to remove: ")
        Char1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextChar = Mid(str1, count, 1)
            If nextChar <> Char1 Then
                str2 = str2 & nextChar
            End If

        Next

        Console.WriteLine("Final String is: " & str2)
        Console.ReadKey()



    End Sub

End Module
