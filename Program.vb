Imports System

Module Program
    Sub Main()
        'Declaration and initialising of required local variables
        Dim Number1 As Integer = 0
        Dim Number2 As Integer = 0
        Dim Multi As Integer = 0

        'Display a request fr the first number
        Console.WriteLine("Please insert first number: ")
        Number1 = Console.ReadLine()

        'Request and store second user input
        Console.WriteLine("Please insert second number: ")
        Number2 = Console.ReadLine()

        'Perform the multiplication and store the value
        Multi = Number1 * Number2

        'Output the multiplication result
        Console.WriteLine("The answer is: ")
        Console.WriteLine(Multi)

        'ReadKey used to pause the console window
        Console.ReadKey()
    End Sub
End Module
