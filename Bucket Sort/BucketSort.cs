using System;
using System.Collections.Generic;

// Crear el Arreglo de Registro
public struct Registro
{
    public float Valor;

    public Registro(float valor)
    {
        Valor = valor;
    }
}

public class BucketSorter
{
    // Método de ordenamiento Bucket Sort
    public static Registro[] BucketSort(Registro[] arr)
    {
        int n = arr.Length;
        if (n <= 0)
        {
            return arr;
        }

        // Crear los buckets
        List<Registro>[] buckets = new List<Registro>[n];
        for (int i = 0; i < n; i++)
        {
            buckets[i] = new List<Registro>();
        }
            
        // Distribuir los elementos en los buckets
        foreach (var reg in arr)
        {
            int bucketIndex = (int)(reg.Valor * n);
            buckets[bucketIndex].Add(reg);
        }

        // Ordenar cada bucket individualmente
        for (int i = 0; i < n; i++)
        {
            buckets[i].Sort((a, b) => a.Valor.CompareTo(b.Valor));
        }

        // Concatenar todos los buckets para crear el arreglo ordenado
        int index = 0;
        foreach (var bucket in buckets)
        {
            foreach (var reg in bucket)
            {
                arr[index++] = reg;
            }
        }
        return arr;
    }

    // Método de ordenamiento Bucket Sort
    public static Registro[] Bucket_Sort(Registro[] arr)
    {
        int n = arr.Length;
        if (n <= 0)
        {
            return arr;
        }

        // Encontrar el valor máximo en el arreglo para normalizar los índices de los buckets
        float maxVal = float.MinValue;
        foreach (var reg in arr)
        {
            if (reg.Valor > maxVal)
                maxVal = reg.Valor;
        }

        // Crear los buckets
        List<Registro>[] buckets = new List<Registro>[n];
        for (int i = 0; i < n; i++)
        {
            buckets[i] = new List<Registro>();
        }

        // Distribuir los elementos en los buckets
        foreach (var reg in arr)
        {
            // Normalizar el índice del bucket
            int bucketIndex = (int)(reg.Valor / maxVal * (n - 1));
            buckets[bucketIndex].Add(reg);
        }

        // Ordenar cada bucket individualmente
        for (int i = 0; i < n; i++)
        {
            buckets[i].Sort((a, b) => a.Valor.CompareTo(b.Valor));
        }

        // Concatenar todos los buckets para crear el arreglo ordenado
        int index = 0;
        foreach (var bucket in buckets)
        {
            foreach (var reg in bucket)
            {
                arr[index++] = reg;
            }
        }
        return arr;
    }
}
