Module Module1

    Sub Main()
        Dim Bstr As String
        Dim bcount, count1, count2, sum As Integer
        Dim validBinaryString As Boolean

        Bstr = ""
        bcount = 0
        count1 = 0
        count2 = 0
        sum = 0
        validBinaryString = True

        Console.Write("Enter Binary Number : ")
        Bstr = Console.ReadLine

        bcount = Len(Bstr)

        If bcount < 1 Or bcount > 8 Then
            validBinaryString = False
        Else
            For count1 = 1 To bcount
                If Mid(Bstr, count1, 1) = "0" And Mid(Bstr, count1, 1) = "1" Then
                    validBinaryString = True
                Else
                    validBinaryString = False
                End If
                Exit For
            Next
        End If

        If validBinaryString = False Then
            Console.WriteLine("Not a valid Binary Number")
        ElseIf validBinaryString = True Then
            For count2 = 0 To bcount - 1
                sum = Mid(Bstr, bcount - count2, 1) * 2 ^ (count2) + sum
            Next
            Console.WriteLine("Valid Binary Number")
            Console.WriteLine("Denary Number = " & sum)
        End If
        Console.ReadKey()
    End Sub

End Module
