Imports System

Module Module1

    Sub Main()
        Dim pocetCisel As Integer

        Console.WriteLine("Zadejte pocet cisel:")
        pocetCisel = Console.ReadLine()
        Dim cisla(pocetCisel - 1) As Integer

        For i As Integer = 0 To pocetCisel - 1

            Console.WriteLine("Zadejte cislo " & (i + 1) & ":")
            cisla(i) = Console.ReadLine()
        Next

        Console.WriteLine("Zadana cisla :")
        For i As Integer = 0 To pocetCisel - 1
            Console.WriteLine(cisla(i))
        Next
        Console.WriteLine("Stisknìte libovolnou klavesu pro ukonceni.")
        Console.ReadKey()

    End Sub

End Module