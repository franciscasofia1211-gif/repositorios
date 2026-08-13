using UnityEngine;

public class EjercicioDeCiclosYArreglos : MonoBehaviour
{
    
        public int[] ArregloUni1 = new int[8];
        public int[] ArregloUni2 = new int[3];
        public int[] ArregloUni3 = new int[6];
        int[,] ArregloBi1 = new int[4,3] {{2,4,6},{8,10,12},{14,16,18},{20,22,24}};
        int[] arregloUni4 = new int[3] {5,7,9};
        public string[] ArregloStri = new string[5];
        string oracion;
    void Start()
    {
        for(int i = 0; i < ArregloBi1.GetLength(0); i++)
        {
            for(int u = 0; u < ArregloBi1.GetLength(1); u++)
            {
                    ArregloBi1[i,u] *= arregloUni4[u];
                    Debug.Log(ArregloBi1[i,u]);
                
            }
        }
        for(int i = 0; i < ArregloUni1.Length; i++)
        {
            ArregloUni1[i] = Random.Range(0, 12);
        }
        for(int i = 0; i < ArregloUni2.Length; i++)
        {
            ArregloUni2[i] = Random.Range(0, 4);
        }
        ArregloUni3[4] = ArregloUni1[2] + ArregloUni2[1];
        Debug.Log(ArregloUni3[4]);
        foreach(string palabras in ArregloStri)
        {
            oracion += palabras + " ";
        }
        Debug.Log(oracion);
    }
}
