public class Practica8
{
    public bool EsCuadradoMagico(int[,] matriz, out int constanteMagica)
    {
        constanteMagica = 0;
        int n = matriz.GetLength(0);
        int sumaFila = 0, sumaColumna = 0, sumaDiagonal1 = 0, sumaDiagonal2 = 0;

        // Verificar la suma de la primera fila para la constante mágica
        for (int j = 0; j < n; j++)
        {
            constanteMagica += matriz[0, j];
        }

        // Verificar las filas, columnas y diagonales
        for (int i = 0; i < n; i++)
        {
            sumaFila = sumaColumna = 0;
            for (int j = 0; j < n; j++)
            {
                sumaFila += matriz[i, j];
                sumaColumna += matriz[j, i];
            }

            // Sumar las diagonales
            sumaDiagonal1 += matriz[i, i];
            sumaDiagonal2 += matriz[i, n - i - 1];

            // Si alguna fila o columna no coincide con la constante mágica, no es un cuadrado mágico
            if (sumaFila != constanteMagica || sumaColumna != constanteMagica)
            {
                return false;
            }
        }

        return sumaDiagonal1 == constanteMagica && sumaDiagonal2 == constanteMagica;
    }
}
