using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarPracticas();  // Inicializa los TextBoxes para que el usuario pueda ingresar datos
        }

        // Inicialización de los TextBoxes y paneles para cada práctica
        private void InicializarPracticas()
        {
            InicializarPractica7();
            InicializarPractica8();
            InicializarPractica9();
            InicializarPractica10();
        }

        // Evento para cambiar entre las prácticas
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelPractica7.Visible = false;
            panelPractica8.Visible = false;
            panelPractica9.Visible = false;
            panelPractica10.Visible = false;

            // Mostrar el panel correspondiente a la práctica seleccionada
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Práctica 7":
                    panelPractica7.Visible = true;
                    break;
                case "Práctica 8":
                    panelPractica8.Visible = true;
                    break;
                case "Práctica 9":
                    panelPractica9.Visible = true;
                    break;
                case "Práctica 10":
                    panelPractica10.Visible = true;
                    break;
            }
        }

        // Botón para ejecutar la práctica seleccionada
        private void ButtonEjecutar_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Práctica 7":
                    EjecutarPractica7();
                    break;
                case "Práctica 8":
                    EjecutarPractica8();
                    break;
                case "Práctica 9":
                    EjecutarPractica9();
                    break;
                case "Práctica 10":
                    EjecutarPractica10();
                    break;
            }
        }

        // Implementación de la Práctica 7: Contar ceros en cada fila
        private void InicializarPractica7()
        {
            matriz7TextBoxes = new TextBox[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz7TextBoxes[i, j] = new TextBox();
                    matriz7TextBoxes[i, j].Location = new System.Drawing.Point(20 + j * 40, 30 + i * 30);
                    matriz7TextBoxes[i, j].Size = new System.Drawing.Size(30, 20);
                    panelPractica7.Controls.Add(matriz7TextBoxes[i, j]);
                }
            }

            textBoxResultado7 = new TextBox();
            textBoxResultado7.Location = new System.Drawing.Point(20, 200);  // Posición del resultado
            textBoxResultado7.Size = new System.Drawing.Size(200, 20);
            textBoxResultado7.ReadOnly = true;  // Solo lectura para el resultado
            panelPractica7.Controls.Add(textBoxResultado7);
        }

        private void EjecutarPractica7()
        {
            int[,] matriz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int.TryParse(matriz7TextBoxes[i, j].Text, out matriz[i, j]);
                }
            }

            Practica7 practica7 = new Practica7();
            int[] cerosPorFila = practica7.ContarCerosPorFila(matriz);
            textBoxResultado7.Text = "Ceros por fila: " + string.Join(", ", cerosPorFila);  // Mostrar resultado
        }

        // Implementación de la Práctica 8: Cuadrado mágico
        private void InicializarPractica8()
        {
            matriz8TextBoxes = new TextBox[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz8TextBoxes[i, j] = new TextBox();
                    matriz8TextBoxes[i, j].Location = new System.Drawing.Point(20 + j * 40, 30 + i * 30);
                    matriz8TextBoxes[i, j].Size = new System.Drawing.Size(30, 20);
                    panelPractica8.Controls.Add(matriz8TextBoxes[i, j]);
                }
            }

            textBoxResultado8 = new TextBox();
            textBoxResultado8.Location = new System.Drawing.Point(20, 200);  // Posición del resultado
            textBoxResultado8.Size = new System.Drawing.Size(200, 20);
            textBoxResultado8.ReadOnly = true;  // Solo lectura para el resultado
            panelPractica8.Controls.Add(textBoxResultado8);
        }

        private void EjecutarPractica8()
        {
            int tamaño = 3; // Supongamos que es un cuadrado mágico de 3x3
            int[,] matriz = new int[tamaño, tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    int.TryParse(matriz8TextBoxes[i, j].Text, out matriz[i, j]);
                }
            }

            Practica8 practica8 = new Practica8();
            int constanteMagica;
            if (practica8.EsCuadradoMagico(matriz, out constanteMagica))
            {
                textBoxResultado8.Text = $"Es un cuadrado mágico. Constante mágica: {constanteMagica}";
            }
            else
            {
                textBoxResultado8.Text = "No es un cuadrado mágico.";
            }
        }

        // Implementación de la Práctica 9: Operaciones con matrices 2x2
        private void InicializarPractica9()
        {
            matriz1TextBoxes = new TextBox[2, 2];
            matriz2TextBoxes = new TextBox[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz1TextBoxes[i, j] = new TextBox();
                    matriz1TextBoxes[i, j].Location = new System.Drawing.Point(20 + j * 40, 30 + i * 30);
                    matriz1TextBoxes[i, j].Size = new System.Drawing.Size(30, 20);
                    panelPractica9.Controls.Add(matriz1TextBoxes[i, j]);

                    matriz2TextBoxes[i, j] = new TextBox();
                    matriz2TextBoxes[i, j].Location = new System.Drawing.Point(150 + j * 40, 30 + i * 30);
                    matriz2TextBoxes[i, j].Size = new System.Drawing.Size(30, 20);
                    panelPractica9.Controls.Add(matriz2TextBoxes[i, j]);
                }
            }

            textBoxResultado9 = new TextBox();
            textBoxResultado9.Location = new System.Drawing.Point(20, 200);  // Posición del resultado
            textBoxResultado9.Size = new System.Drawing.Size(300, 20);
            textBoxResultado9.ReadOnly = true;  // Solo lectura para el resultado
            panelPractica9.Controls.Add(textBoxResultado9);
        }

        private void EjecutarPractica9()
        {
            int[,] matriz1 = new int[2, 2];
            int[,] matriz2 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int.TryParse(matriz1TextBoxes[i, j].Text, out matriz1[i, j]);
                    int.TryParse(matriz2TextBoxes[i, j].Text, out matriz2[i, j]);
                }
            }

            Practica9 practica9 = new Practica9();
            int[,] suma = practica9.SumarMatrices(matriz1, matriz2);
            int[,] resta = practica9.RestarMatrices(matriz1, matriz2);
            double[,] producto = practica9.MultiplicarMatrices(matriz1, matriz2);
            double[,] division = practica9.DividirMatrices(matriz1, matriz2);

            textBoxResultado9.Text = $"Suma: [{suma[0, 0]}, {suma[0, 1]}], [{suma[1, 0]}, {suma[1, 1]}]\n" +
                                     $"Resta: [{resta[0, 0]}, {resta[0, 1]}], [{resta[1, 0]}, {resta[1, 1]}]\n" +
                                     $"Producto: [{producto[0, 0]:0.00}, {producto[0, 1]:0.00}], [{producto[1, 0]:0.00}, {producto[1, 1]:0.00}]\n" +
                                     $"División: [{division[0, 0]:0.00}, {division[0, 1]:0.00}], [{division[1, 0]:0.00}, {division[1, 1]:0.00}]";
        }

        // Implementación de la Práctica 10: Matriz diagonal
        private void InicializarPractica10()
        {
            textBoxTamaño10 = new TextBox();
            textBoxTamaño10.Location = new System.Drawing.Point(20, 20);
            panelPractica10.Controls.Add(textBoxTamaño10);

            textBoxResultado10 = new TextBox();
            textBoxResultado10.Location = new System.Drawing.Point(20, 200);  // Posición del resultado
            textBoxResultado10.Size = new System.Drawing.Size(300, 20);
            textBoxResultado10.ReadOnly = true;  // Solo lectura para el resultado
            panelPractica10.Controls.Add(textBoxResultado10);
        }

        private void EjecutarPractica10()
        {
            int tamaño = int.Parse(textBoxTamaño10.Text);
            matriz10TextBoxes = new TextBox[tamaño, tamaño];

            Practica10 practica10 = new Practica10();
            int[,] matriz = practica10.CrearMatrizDiagonal(tamaño);

            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    matriz10TextBoxes[i, j] = new TextBox();
                    matriz10TextBoxes[i, j].Location = new System.Drawing.Point(20 + j * 30, 50 + i * 30);
                    matriz10TextBoxes[i, j].Size = new System.Drawing.Size(30, 20);
                    matriz10TextBoxes[i, j].Text = matriz[i, j].ToString();
                    panelPractica10.Controls.Add(matriz10TextBoxes[i, j]);
                }
            }

            textBoxResultado10.Text = "Matriz diagonal generada correctamente.";
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
