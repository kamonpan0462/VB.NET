Imports System
Module Interrst
    Public deposit, rate As Double
    Sub Main()
        Dim Year1, Year2 As Double
        rate = 0.02
        deposit = 10000

        Year1 = deposit * (1 + rate)
        REM Console.WriteLine("First yaer = {0}", Year1)
        Year2 = Year1 * (1 + rate)
        Console.WriteLine("Second yaer = {0:C}", Year2)
        Console.ReadLine()

    End Sub

End Module
