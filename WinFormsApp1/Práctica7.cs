public class Practica7
{
    // Método principal para contar los ceros en cada fila de la matriz
    public int[] ContarCerosPorFila(int[,] matriz)
    {
        int[] cerosPorFila = new int[matriz.GetLength(0)];
        // Inicia la recursividad desde la primera fila
        return ContarCerosPorFilaRecursivo(matriz, 0, cerosPorFila);
    }

    // Método recursivo que cuenta los ceros en cada fila
    private int[] ContarCerosPorFilaRecursivo(int[,] matriz, int fila, int[] cerosPorFila)
    {
        // Caso base: si hemos procesado todas las filas, devolvemos el resultado
        if (fila == matriz.GetLength(0))
        {
            return cerosPorFila;
        }

        // Contamos los ceros en la fila actual
        cerosPorFila[fila] = ContarCerosEnFila(matriz, fila, 0, 0);

        // Llamada recursiva para la siguiente fila
        return ContarCerosPorFilaRecursivo(matriz, fila + 1, cerosPorFila);
    }

    // Método recursivo que cuenta los ceros en una fila específica
    private int ContarCerosEnFila(int[,] matriz, int fila, int columna, int contador)
    {
        // Caso base: si hemos procesado todas las columnas de la fila
        if (columna == matriz.GetLength(1))
        {
            return contador;
        }

        // Incrementamos el contador si encontramos un 0 en la columna actual
        if (matriz[fila, columna] == 0)
        {
            contador++;
        }

        // Llamada recursiva para la siguiente columna
        return ContarCerosEnFila(matriz, fila, columna + 1, contador);
    }
}
