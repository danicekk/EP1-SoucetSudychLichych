Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer = 1

        Console.WriteLine(" Zadej vhodn� ��slo ")
        cislo = Console.ReadLine


        If cislo < 1 Then
            Console.WriteLine(" Minim�ln� zadan� ��slo mus� b�t 1")
            Console.ReadKey()
        End If

    End Sub
End Module
