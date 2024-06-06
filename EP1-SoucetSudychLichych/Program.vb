Imports System

Module Program
    Sub Main(args As String())
        Dim cislo(9) As Integer
        Dim sude As Integer = 0
        Dim licha As Integer = 0

        Console.WriteLine("Napi�te 10 ��sel")

        For i As Integer = 0 To 9
            Console.Write("��slo {0}", i + 1)
            Dim cislice As Integer

            ' Pokus� se p�e��st vstup a p�ev�st ho na Integer
            While Not Integer.TryParse(Console.ReadLine(), cislice)
                Console.WriteLine("Neplatn� vstup, zkuste to znovu.")
                Console.Write("��slo {0}: ", i + 1)
            End While

            cislo(i) = cislice

            ' Kontrola, zda je ��slo sud� nebo lich�
            If cislice Mod 2 = 0 Then
                licha += 1
            Else
                sude += 1
            End If
        Next

        Console.WriteLine("Vstupn� ��sla jsou:")
        For Each num As Integer In cislo
            Console.WriteLine(num)
        Next

        ' V�pis po�tu sud�ch a lich�ch ��sel
        Console.WriteLine("Po�et sud�ch ��sel: {0}", licha)
        Console.WriteLine("Po�et lich�ch ��sel: {0}", sude)

        ' Zabr�n� okam�it�mu uzav�en� konzole
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en� programu...")
        Console.ReadKey()



    End Sub

End Module
