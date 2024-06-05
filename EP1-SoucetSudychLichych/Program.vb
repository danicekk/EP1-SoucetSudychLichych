Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer = 1

        Console.WriteLine(" Zadej vhodné èíslo ")
        cislo = Console.ReadLine


        If Not IsNumeric(cislo) Then
            Console.WriteLine("VSTUP MUSÍ BÝT ÈÍSLO!")
            Console.ReadKey()
        End If

        If cislo < 1 Then
            Console.WriteLine(" Minimální zadané èíslo musí být 1")
            Console.ReadKey()
        End If

    End Sub
End Module
