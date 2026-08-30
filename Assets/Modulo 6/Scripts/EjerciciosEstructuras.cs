using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    public List<int> NumerosAleatorios(int tamaño, int RangoInferior, int RangoSuperior)
    {
        List<int> listaNum = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            listaNum.Add(Random.Range(RangoInferior, RangoSuperior));
        }
        return listaNum;
    }

    public int[] ArregloEnteros(int[] tamaño)
    {
        int[] numeros = tamaño;
        System.Array.Sort(numeros);
        System.Array.Reverse(numeros);
        return numeros;
    }
    public HashSet<int> NumerosRep(int Numeros)
    {
        return new HashSet<int>(Numeros);
    }
    public void Pilas(Stack<string> palabras)
    {
        Stack<string> stack = new Stack<string>(palabras);
        while(stack.Count > 0)
        {
            Debug.Log("Peek: " + stack.Peek());
            Debug.Log("Pop: " + stack.Pop());
        }
        Queue<string> queue = new Queue<string>();
        foreach (string elemento in palabras)
        {
            queue.Enqueue(elemento);
            Debug.Log("enqueue: " + elemento);
        }
        while(queue.Count > 0)
        {
            Debug.Log("Dequeue: " + queue.Dequeue());
        }
    }
    private void Start()
    {
        foreach (var item in NumerosAleatorios(10,4,20))
        {
            Debug.Log("Numero aleatorio: " + item);
        }
        int[] numeros = {2,5,3,6,8,1,4};
        foreach (var item in ArregloEnteros(numeros))
        {
            Debug.Log("Enteros: " + item);
        }
        foreach (var item in NumerosRep(Random.Range(1,3)))
        {
            Debug.Log("Numeros Rep: " + item);
        }
        Stack<string> list = new Stack<string>();
        list.Push("Las");
        list.Push("Papas");
        list.Push("Quedan");
        list.Push("Mejor");
        list.Push("Con");
        list.Push("Queso");
        list.Push("No");
        list.Push("Con");
        list.Push("Sal");
        Pilas(list);
    }
}
