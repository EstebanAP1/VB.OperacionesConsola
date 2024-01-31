Imports System.Console
Imports OperacionVB.Matematica

Module Module1

    Sub Main()
        Dim key As ConsoleKeyInfo

        Do
            WriteLine("1. Hipotenusa.")
            WriteLine("2. Es primo.")
            WriteLine("3. Binario a decimal.")
            WriteLine("4. Decimal a binario.")
            WriteLine("5. Factorial.")
            WriteLine("6. Salir")
            Write("Seleccione una opción: ")

            key = ReadKey()
            Clear()

            Select Case key.Key
                Case ConsoleKey.D1, ConsoleKey.NumPad1
                    ProgramaHipotenusa()
                Case ConsoleKey.D2, ConsoleKey.NumPad2
                    ProgramaEsPrimo()
                Case ConsoleKey.D3, ConsoleKey.NumPad3
                    ProgramaBinarioDecimal()
                Case ConsoleKey.D4, ConsoleKey.NumPad4
                    ProgramaDecimalBinario()
                Case ConsoleKey.D5, ConsoleKey.NumPad5
                    ProgramaFactorial()
                Case ConsoleKey.D6, ConsoleKey.NumPad6
                    Exit Do
                Case Else
                    WriteLine("Opción inválida.")
            End Select

            WriteLine()

        Loop While key.Key <> ConsoleKey.D6 And key.Key <> ConsoleKey.NumPad6

    End Sub

    Private Sub ProgramaHipotenusa()
        Dim ca, cb, h As Double
        Write("Cateto a: ")
        If Double.TryParse(ReadLine(), ca) Then
            Write("Cateto b: ")
            If Double.TryParse(ReadLine(), cb) Then
                h = Hipotenusa(ca, cb)
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
            If EsPrimo(n) Then
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
        WriteLine($"Binario: {bin} => Decimal: {BinarioDecimal(bin)}")
    End Sub

    Private Sub ProgramaDecimalBinario()
        Dim dec As Integer
        Write("Número decimal: ")
        dec = ReadLine()
        WriteLine($"Decimal: {dec} => Binario: {DecimalBinario(dec)}")
    End Sub

    Private Sub ProgramaFactorial()
        Dim n As Integer
        Write("Número: ")
        If Integer.TryParse(ReadLine(), n) Then
            WriteLine($"Factorial de {n}: {Factorial(n)}")
        Else
            WriteLine("Entrada inválida para el número")
        End If
    End Sub

End Module
