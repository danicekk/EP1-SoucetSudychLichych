Imports System

Module Program
    Sub Main(args As String())
        Dim cislo(9) As Integer
        Dim sude As Integer = 0
        Dim licha As Integer = 0

        Console.WriteLine("Napište 10 èísel")

        For i As Integer = 0 To 9
            Console.Write("Èíslo {0}", i + 1)
            Dim cislice As Integer

            ' Pokusí se pøeèíst vstup a pøevést ho na Integer
            While Not Integer.TryParse(Console.ReadLine(), cislice)
                Console.WriteLine("Neplatný vstup, zkuste to znovu.")
                Console.Write("Èíslo {0}: ", i + 1)
            End While

            cislo(i) = cislice

            ' Kontrola, zda je èíslo sudé nebo liché
            If cislice Mod 2 = 0 Then
                licha += 1
            Else
                sude += 1
            End If
        Next

        Console.WriteLine("Vstupní èísla jsou:")
        For Each num As Integer In cislo
            Console.WriteLine(num)
        Next

        ' Výpis poètu sudých a lichých èísel
        Console.WriteLine("Poèet sudých èísel: {0}", licha)
        Console.WriteLine("Poèet lichých èísel: {0}", sude)

        ' Zabrání okamžitému uzavøení konzole
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení programu...")
        Console.ReadKey()



    End Sub

End Module
