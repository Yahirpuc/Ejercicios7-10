public class Practica10
{
    // Método principal para crear una matriz diagonal
    public int[,] CrearMatrizDiagonal(int tamaño)
    {
        int[,] matriz = new int[tamaño, tamaño];
        // Inicia la recursividad desde la primera fila
        CrearMatrizDiagonalRecursiva(matriz, 0, tamaño);
        return matriz;
    }

    // Método recursivo que llena la matriz diagonal
    private void CrearMatrizDiagonalRecursiva(int[,] matriz, int fila, int tamaño)
    {
        // Caso base: si hemos procesado todas las filas, finaliza
        if (fila == tamaño)
        {
            return;
        }

        // Llenamos la fila actual
        LlenarFila(matriz, fila, 0, tamaño);

        // Llamada recursiva para procesar la siguiente fila
        CrearMatrizDiagonalRecursiva(matriz, fila + 1, tamaño);
    }

    // Método recursivo para llenar una fila de la matriz
    private void LlenarFila(int[,] matriz, int fila, int columna, int tamaño)
    {
        // Caso base: si hemos procesado todas las columnas de la fila, finaliza
        if (columna == tamaño)
        {
            return;
        }

        // Si estamos en la diagonal, asignar 1; en caso contrario, 0
        if (fila == columna)
        {
            matriz[fila, columna] = 1;
        }
        else
        {
            matriz[fila, columna] = 0;
        }

        // Llamada recursiva para la siguiente columna
        LlenarFila(matriz, fila, columna + 1, tamaño);
    }
}
