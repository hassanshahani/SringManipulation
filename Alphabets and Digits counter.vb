Module Module1

    Sub Main()
        Dim str1 As String
        Dim chr As String
        Dim alpha, digit, count As Integer

        str1 = ""
        count = 0
        alpha = 0
        digit = 0
        chr = ""

        Console.Write("Enter word : ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            chr = Mid(str1, count, 1)
            If LCase(chr) > "a" And LCase(chr) < "z" Then
                alpha = alpha + 1
            ElseIf UCase(chr) > "A" And UCase(chr) < "Z" Then
                alpha = alpha + 1
            ElseIf chr >= 0 And chr <= 9 Then
                digit = digit + 1
            End If
        Next

        Console.WriteLine("No. of aplhabets are : " & alpha)
        Console.WriteLine("No. of digits are : " & digit)
        Console.ReadKey()



    End Sub

End Module
