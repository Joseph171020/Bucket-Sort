using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucket_Sort
{
    public partial class BucketSort : Form
    {
        private Registro[] registros;  // Arreglo de registros
        private Registro[] registrosOriginal; // Arreglo original para mostrar datos sin ordenar
        private int currentIndex = 0;  // Índice para agregar elementos al arreglo

        public BucketSort()
        {
            InitializeComponent();
        }

        private void BTNArray_Click(object sender, EventArgs e)
        {
            int tamaño = int.Parse(TxBArray.Text); // Capturar el tamaño ingresado
            registros = new Registro[tamaño]; // Crear el arreglo de registros
            registrosOriginal = new Registro[tamaño]; // Crear un arreglo para mantener los valores originales
            currentIndex = 0;
            dataGridViewResults.Rows.Clear();
            dataGridViewResults.Columns.Clear();

            // Configurar las columnas del DataGridView
            dataGridViewResults.Columns.Add("Sin Ordenar", "Sin Ordenar");
            dataGridViewResults.Columns.Add("Ordenados", "Ordenados");

            MessageBox.Show("Tamaño del arreglo establecido. Puede empezar a agregar valores.");
        }

        private void BTNAccept_Click(object sender, EventArgs e)
        {
            if (currentIndex < registros.Length)
            {
                // Convertir el valor ingresado en float y agregar al arreglo
                float valor = float.Parse(TxBucketSort.Text);
                registros[currentIndex] = new Registro(valor);
                registrosOriginal[currentIndex] = new Registro(valor); // Guardar el valor en el arreglo original
                currentIndex++;
                TxBucketSort.Clear();
            }
            else
            {
                MessageBox.Show("El arreglo ya está lleno.");
            }
        }

        private void BTNSort_Click(object sender, EventArgs e)
        {
            // Ordenar el arreglo usando el método de BucketSort
            registros = BucketSorter.Bucket_Sort(registros);
            MostrarResultados(); // Mostrar resultados en el DataGridView
        }

        // Método para mostrar el arreglo ordenado en el DataGridView
        private void MostrarResultados()
        {
            dataGridViewResults.Rows.Clear();
            for (int i = 0; i < registros.Length; i++)
            {
                // Agregar una fila con el valor original y el valor ordenado
                dataGridViewResults.Rows.Add(registrosOriginal[i].Valor, registros[i].Valor);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
