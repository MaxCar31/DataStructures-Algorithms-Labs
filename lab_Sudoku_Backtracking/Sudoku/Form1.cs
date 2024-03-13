using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku_Carrion
{
    public partial class Form1 : Form
    {
        // Declaraciones de variables miembro para almacenar celdas, tablero y propiedades editables
        private TextBox[,] celdasSudoku = new TextBox[9, 9];
        private int[,] tableroSudoku = new int[9, 9];
        private bool[,] celdasEditables = new bool[9, 9];

        public Form1()
        {
            InitializeComponent();
            InicializarTableroSudoku();
        }

        private void InicializarTableroSudoku()
        {
            // Tamaño y ubicación de las celdas en la interfaz
            const int tamanoCelda = 40;
            const int inicioX = 50;
            const int inicioY = 50;

            // Crear y configurar celdas TextBox en la interfaz
            for (int f = 0; f < 9; f++)
            {
                for (int c = 0; c < 9; c++)
                {
                    TextBox celda = new TextBox
                    {
                        Width = tamanoCelda,
                        Height = tamanoCelda,
                        Font = new Font("Arial", 14),
                        TextAlign = HorizontalAlignment.Center,
                        Location = new Point(inicioX + tamanoCelda * c, inicioY + tamanoCelda * f),
                        Multiline = true,
                        MaxLength = 1
                    };

                    celdasSudoku[f, c] = celda;
                    Controls.Add(celda); // Agregar celda a la ventana
                }
            }
        }

        private bool EsNumeroValido(int f, int c, int num)
        {
            for (int i = 0; i < 9; i++)
                if (tableroSudoku[f, i] == num || tableroSudoku[i, c] == num)
                    return false;

            int startFila = f - f % 3;
            int startCol = c - c % 3;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tableroSudoku[i + startFila, j + startCol] == num)
                        return false;

            return true;
        }

        private bool ResolverSudoku()
        {
            for (int f = 0; f < 9; f++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (tableroSudoku[f, c] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (EsNumeroValido(f, c, num))
                            {
                                tableroSudoku[f, c] = num;

                                if (ResolverSudoku())
                                    return true;

                                tableroSudoku[f, c] = 0;
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        private bool GenerarSudoku()
        {
            for (int f = 0; f < 9; f++)
                for (int c = 0; c < 9; c++)
                    tableroSudoku[f, c] = 0;

            if (!GenerarSudokuBacktracking(0, 0))
                return false;

            for (int f = 0; f < 9; f++)
                for (int c = 0; c < 9; c++)
                    celdasEditables[f, c] = true;

            EliminarNumeros(20);
            ActualizarInterfazSudoku();

            return true;
        }

        private bool GenerarSudokuBacktracking(int f, int c)
        {
            if (f == 9)
            {
                f = 0;
                c++;
                if (c == 9)
                {
                    for (int r = 0; r < 9; r++)
                        for (int co = 0; co < 9; co++)
                            celdasEditables[r, co] = tableroSudoku[r, co] != 0;

                    return true;
                }
            }

            Random rand = new Random();
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numeros = Barajar(numeros, rand);

            for (int indiceNum = 0; indiceNum < 9; indiceNum++)
            {
                int num = numeros[indiceNum];
                if (EsNumeroValido(f, c, num))
                {
                    tableroSudoku[f, c] = num;
                    if (GenerarSudokuBacktracking(f + 1, c))
                        return true;
                    tableroSudoku[f, c] = 0;
                }
            }

            return false;
        }

        private void EliminarNumeros(int numAEliminar)
        {
            Random rand = new Random();

            for (int i = 0; i < numAEliminar; i++)
            {
                int f = rand.Next(9);
                int c = rand.Next(9);

                while (!celdasEditables[f, c])
                {
                    f = rand.Next(9);
                    c = rand.Next(9);
                }

                int temp = tableroSudoku[f, c];
                tableroSudoku[f, c] = 0;
                celdasEditables[f, c] = false;

                if (!EsSudokuValido())
                {
                    tableroSudoku[f, c] = temp;
                    celdasEditables[f, c] = true;
                    i--;
                }
            }

            for (int f = 0; f < 9; f++)
                for (int c = 0; c < 9; c++)
                    celdasEditables[f, c] = tableroSudoku[f, c] != 0;
        }

        private int[] Barajar(int[] arreglo, Random rand)
        {
            for (int i = arreglo.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = arreglo[i];
                arreglo[i] = arreglo[j];
                arreglo[j] = temp;
            }
            return arreglo;
        }

        private bool EsSudokuValido()
        {
            bool[] vistos = new bool[10];

            for (int f = 0; f < 9; f++)
            {
                for (int c = 0; c < 9; c++)
                {
                    int num;
                    if (celdasEditables[f, c] && int.TryParse(celdasSudoku[f, c].Text, out num))
                    {
                        if (num < 1 || num > 9 || vistos[num])
                            return false;
                        vistos[num] = true;
                    }
                }
                Array.Clear(vistos, 0, vistos.Length);
            }

            for (int c = 0; c < 9; c++)
            {
                for (int f = 0; f < 9; f++)
                {
                    int num;
                    if (celdasEditables[f, c] && int.TryParse(celdasSudoku[f, c].Text, out num))
                    {
                        if (num < 1 || num > 9 || vistos[num])
                            return false;
                        vistos[num] = true;
                    }
                }
                Array.Clear(vistos, 0, vistos.Length);
            }

            for (int inicioFila = 0; inicioFila < 9; inicioFila += 3)
            {
                for (int inicioCol = 0; inicioCol < 9; inicioCol += 3)
                {
                    for (int f = inicioFila; f < inicioFila + 3; f++)
                    {
                        for (int c = inicioCol; c < inicioCol + 3; c++)
                        {
                            int num;
                            if (celdasEditables[f, c] && int.TryParse(celdasSudoku[f, c].Text, out num))
                            {
                                if (num < 1 || num > 9 || vistos[num])
                                    return false;
                                vistos[num] = true;
                            }
                        }
                    }
                    Array.Clear(vistos, 0, vistos.Length);
                }
            }

            return true;
        }

        private void ActualizarInterfazSudoku()
        {
            for (int f = 0; f < 9; f++)
            {
                for (int c = 0; c < 9; c++)
                {
                    TextBox celdaTextBox = celdasSudoku[f, c];
                    int valor = tableroSudoku[f, c];

                    celdaTextBox.Text = valor == 0 ? "" : valor.ToString();

                    if (celdasEditables[f, c])
                    {
                        celdaTextBox.ReadOnly = false;
                        celdaTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        celdaTextBox.ReadOnly = true;
                        celdaTextBox.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void GenerarSudokuConCeldasEditables()
        {
            GenerarSudoku();
            EliminarNumeros(10);

            for (int f = 0; f < 9; f++)
                for (int c = 0; c < 9; c++)
                    celdasEditables[f, c] = tableroSudoku[f, c] == 0;

            ActualizarInterfazSudoku();
        }

        private void buttonGenerate_Click_1(object sender, EventArgs e)
        {
            GenerarSudokuConCeldasEditables();
        }

        private void buttonCheck_Click_1(object sender, EventArgs e)
        {
            bool todasCeldasEditablesCompletas = true;

            for (int f = 0; f < 9; f++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (celdasEditables[f, c] && string.IsNullOrEmpty(celdasSudoku[f, c].Text))
                    {
                        todasCeldasEditablesCompletas = false;
                        break;
                    }
                }
                if (!todasCeldasEditablesCompletas)
                    break;
            }

            if (todasCeldasEditablesCompletas)
            {
                if (EsSudokuValido())
                {
                    MessageBox.Show("Eh Felicidades ¡Sudoku resuelto exitosamente!");
                }
                else
                {
                    MessageBox.Show("Respuesta Incorrecta, Inténtalo otra vez");
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos para continuar");
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            ResolverSudoku();
            ActualizarInterfazSudoku();
        }
    }
}