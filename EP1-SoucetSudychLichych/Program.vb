Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer = 1

        Console.WriteLine(" Zadej vhodn� ��slo ")
        cislo = Console.ReadLine


        If Not IsNumeric(cislo) Then
            Console.WriteLine("VSTUP MUS� B�T ��SLO!")
            Console.ReadKey()
        End If

        If cislo < 1 Then
            Console.WriteLine(" Minim�ln� zadan� ��slo mus� b�t 1")
            Console.ReadKey()
        End If

    End Sub
End Module
