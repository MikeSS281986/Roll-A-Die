Module Module1

    Sub Main()
        Dim displayMenu As Boolean = True
        While (displayMenu)
            displayMenu = Menu()
        End While
    End Sub

    Function Menu() As Boolean
        Console.Clear()
        Console.WriteLine("Want to roll a Die? Y/N")
        Dim result As String = Console.ReadLine()

        If result = "y" Then
            Return RollTheDie()
        ElseIf result = "Y" Then
            Return RollTheDie()
        ElseIf result = "n" Then
            Return False
        Else
            Return True
        End If
    End Function

    Function RollTheDie() As Boolean
        Dim answer As Boolean = True
        Dim rand As New Random
        Do While answer = True
            Dim dieroll As Integer = rand.Next(1, 7)
            Console.WriteLine("You rolled a {0}", dieroll)
            Console.WriteLine("Want to roll again? Y/N")
            Dim result As String = Console.ReadLine()
            If result = "y" Then
                answer = True
            ElseIf result = "Y" Then
                answer = True
            Else
                answer = False
            End If
        Loop
        Return False
    End Function

End Module
