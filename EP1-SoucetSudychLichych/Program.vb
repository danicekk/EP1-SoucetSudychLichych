Imports System
Imports System.Reflection.Metadata.Ecma335

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim suda As Integer = 0
        Dim licha As Integer = 0

        Console.WriteLine(" Zadejte 10 libovoln�ch ��sel a ka�d� ��slo od��dkujte endtrem ")
        cislo = Console.ReadLine

        If Not IsNumeric(cislo) Then
            Console.WriteLine("VSTUP MUS� B�T ��SLO!")
            Console.ReadKey()
        End If

        If cislo < 1 Then
            Console.WriteLine(" Minim�ln� zadan� ��slo mus� b�t 1")
            Console.ReadKey()
        End If

        For i As Integer = 0 To 9
            Console.Write("��slo {0}: ", i + 1)
            Dim number As Integer

        Next






    End Sub

End Module
