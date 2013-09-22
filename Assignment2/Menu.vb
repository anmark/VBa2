Public Class Menu
    Public Sub Start()
        Dim choice As Integer = -1

        'Display the menu text on the screen and ask the user to make a choice and
        'accept only integer numbers in the given range
        While choice <> 0
            WriteMenuText()
            choice = Console.ReadLine
            'choice = Input.ReadIntegerConsole()

            Select Case choice
                Case 0
                    'Do nothing and exit the program
                Case 1
                    'Addition of integer numbers using a for-loop
                    Dim sumObj As WholeNumbersForAdd = New WholeNumbersForAdd
                    sumObj.Start()
                    Exit Select
                Case 2
                    'Addition of floating point numbers using a while-loop
                    Dim sumObj As FloatingPointNumbersWhileAdd = New FloatingPointNumbersWhileAdd
                    sumObj.Start()
                    Exit Select
            End Select
        End While
    End Sub

End Class
