''' <summary>
''' Clase Matematica para realizar operaciones matemáticas.
''' </summary>
Public Class Matematica

    ''' <summary>
    ''' Calcula la hipotenusa de un triángulo rectángulo dado los catetos.
    ''' </summary>
    ''' <param name="ca">Longitud del primer cateto.</param>
    ''' <param name="cb">Longitud del segundo cateto.</param>
    ''' <returns>La longitud de la hipotenusa.</returns>
    Shared Function Hipotenusa(ca As Double, cb As Double) As Double
        Return Math.Sqrt(ca * ca + cb * cb)
    End Function

    ''' <summary>
    ''' Determina si un número es primo.
    ''' </summary>
    ''' <param name="n">El número a verificar.</param>
    ''' <returns>Verdadero si el número es primo, falso en caso contrario.</returns>
    Shared Function EsPrimo(n As Integer) As Boolean
        If n <= 1 Then Return False
        If n = 2 Then Return True
        If n Mod 2 = 0 Then Return False

        Dim i As Integer = 3
        While (i * i <= n)
            If n Mod i = 0 Then Return False
            i = i + 2
        End While

        Return True
    End Function

    ''' <summary>
    ''' Convierte un número binario a decimal.
    ''' </summary>
    ''' <param name="bin">El número binario como una cadena.</param>
    ''' <returns>El número decimal correspondiente como un entero.</returns>
    Shared Function BinarioDecimal(bin As String) As Integer
        Return Convert.ToInt32(bin, 2)
    End Function

    ''' <summary>
    ''' Convierte un número decimal a binario.
    ''' </summary>
    ''' <param name="dec">El número decimal como un entero</param>
    ''' <returns>El número binario correspondiente como una cadena.</returns>
    Shared Function DecimalBinario(dec As Integer) As String
        Return Convert.ToString(dec, 2)
    End Function

    ''' <summary>
    ''' Calcula el factorial de un número.
    ''' </summary>
    ''' <param name="n">El número para calcular el factorial.</param>
    ''' <returns>El factorial del número dado.</returns>
    Shared Function Factorial(n As Integer) As Integer
        Dim f As Integer = 1
        For i = 2 To n
            f *= i
        Next
        Return f
    End Function
End Class