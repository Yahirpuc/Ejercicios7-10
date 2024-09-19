public class Practica9
{
    public int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int[,] resultado = new int[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }
        return resultado;
    }

    public int[,] RestarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int[,] resultado = new int[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }
        return resultado;
    }

    public double[,] MultiplicarMatrices(int[,] matriz1, int[,] matriz2)
    {
        double[,] resultado = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matriz1[i, j] * matriz2[i, j];
            }
        }
        return resultado;
    }

    public double[,] DividirMatrices(int[,] matriz1, int[,] matriz2)
    {
        double[,] resultado = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (matriz2[i, j] != 0)
                {
                    resultado[i, j] = (double)matriz1[i, j] / matriz2[i, j];
                }
                else
                {
                    resultado[i, j] = double.NaN;  // Manejar división por cero
                }
            }
        }
        return resultado;
    }
}
