Imports System.Console

Module Module1

    Sub Main()
        Call ProgramaFactorial()
    End Sub

    Private Sub ProgramaHipotenusa()
        Dim ca, cb, h As Double
        Write("Cateto a: ")
        If Double.TryParse(ReadLine(), ca) Then
            Write("Cateto b: ")
            If Double.TryParse(ReadLine(), cb) Then
                h = Matematica.Hipotenusa(ca, cb)
                WriteLine($"Hipotenusa: {h}")
            Else
                WriteLine("Entrada inválida para el cateto b")
            End If
        Else
            WriteLine("Entrada inválida para el cateto a")
        End If
    End Sub

    Private Sub ProgramaEsPrimo()
        Dim n As Integer
        Write("Número: ")
        If Integer.TryParse(ReadLine(), n) Then
            If Matematica.EsPrimo(n) Then
                WriteLine($"El número {n} es primo")
            Else
                WriteLine($"El número {n} no es primo")
            End If
        Else
            WriteLine("Entrada inválida para el número")
        End If
    End Sub

    Private Sub ProgramaBinarioDecimal()
        Dim bin As String
        Write("Número binario: ")
        bin = ReadLine()
        WriteLine($"Binario: {bin} => Decimal: {Matematica.BinarioDecimal(bin)}")
    End Sub

    Private Sub ProgramaDecimalBinario()
        Dim dec As Integer
        Write("Número decimal: ")
        dec = ReadLine()
        WriteLine($"Decimal: {dec} => Binario: {Matematica.DecimalBinario(dec)}")
    End Sub

    Private Sub ProgramaFactorial()
        Dim n As Integer
        Write("Número: ")
        If Integer.TryParse(ReadLine(), n) Then
            WriteLine($"Factorial de {n}: {Matematica.Factorial(n)}")
        Else
            WriteLine("Entrada inválida para el número")
        End If
    End Sub

End Module
