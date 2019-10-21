Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim count, s As Integer

        str1 = ""
        str2 = ""
        count = 0

        Console.Write("Enter the string : ")
        str1 = Console.ReadLine


        str2 = str2 & Mid(str1, Len(str1), 1)

        For count = 1 To Len(str1) - 1
            s = Len(str1) - count
            str2 = str2 & Mid(str1, s, 1)
        Next

        Console.WriteLine("The inverse of your string is : " & str2)
        Console.ReadKey()

    End Sub

End Module
