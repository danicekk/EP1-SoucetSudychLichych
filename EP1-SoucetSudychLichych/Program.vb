Imports System
Imports System.Reflection.Metadata.Ecma335

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim suda As Integer = 0
        Dim licha As Integer = 0

        Console.WriteLine(" Zadejte 10 libovolných èísel a každé èíslo odøádkujte endtrem ")
        cislo = Console.ReadLine

        If Not IsNumeric(cislo) Then
            Console.WriteLine("VSTUP MUSÍ BÝT ÈÍSLO!")
            Console.ReadKey()
        End If

        If cislo < 1 Then
            Console.WriteLine(" Minimální zadané èíslo musí být 1")
            Console.ReadKey()
        End If

        For i As Integer = 0 To 9
            Console.Write("Èíslo {0}: ", i + 1)
            Dim number As Integer

        Next






    End Sub

End Module
