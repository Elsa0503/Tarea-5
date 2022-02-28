Module Module1
    Sub Main(args As String())

        Dim a, b, c As Integer
        b = 1
        Console.WriteLine("Ingrese el numero:")
        a = Console.ReadLine()

        For y = 1 To a
            b = b * y
        Next
        Console.WriteLine("El factorial es: " + b.ToString)

        For u = 0 To b
            If (u Mod 4) Then
                c = c + 1
            End If
        Next
        Console.WriteLine("Existen " + c.ToString + " numeros multiplos de 4 en " + b.ToString)
        Console.ReadKey()
    End Sub

End Module
