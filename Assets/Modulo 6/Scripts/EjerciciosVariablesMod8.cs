using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public int enteros = 1;
    public float Float = 1.5f;
    public float NumeroString;
    public float digito1 = 4;
    public float digito2 = 14;

    public string segundaPalabra;
    public string palabra;
    string eliminar = "El completo es la mejor comida";
    string NumeroMil1 = "25456";
    string NumeroMil2 = "7896";
    string NombreCompleto = "Francisca Sofia Chepe";
    string HolaPar = "Hola mundo";
    public GameObject Objeto;
    public GameObject Objeto2;

    void Start()
    {
        for(int i = 0; i < HolaPar.Length; i += 2)
        {
            Debug.Log(HolaPar[i]);
        }
        string ResulElim = eliminar.Substring(5);
        Debug.Log(ResulElim);
        int.TryParse(NumeroMil1, out int resultadoMil1);
        int.TryParse(NumeroMil2, out int resultadoMil2);
        int sumaTotal = resultadoMil1 + resultadoMil2;
        Debug.Log($"La suma total de numeros miles string es {sumaTotal}");
        string Nombre = NombreCompleto.Substring(0,9);
        string SegNombre = NombreCompleto.Substring(10,5);
        string Apellido = NombreCompleto.Substring(16);
        string TodoElNom = Nombre + SegNombre + Apellido;
        Debug.Log(TodoElNom);
        int resultado = (int)(digito1 * digito2);
        Debug.Log("El resultado de digito 1 y 2 es: " + resultado);
        NumeroString = 345.232423f;
        string Numero = NumeroString.ToString("F4");
        Debug.Log($"tu numero con decimales es: {Numero}");
    }

    void Update()
    {
        enteros += enteros;
        Debug.Log($"Las suma de enteros es {enteros}");
    }
    void FixedUpdate()
    {
        switch (palabra)
        {
            case "bad bunny el conejo malo brrr":

                Objeto2.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case "Ozuna negrito ojo' claro'":

                Objeto2.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            default:
                break;
        }
        

        Float *= Float;
        Debug.Log($"La multiplicación: {Float}");
        int RandInt = Random.Range(int.MinValue, int.MaxValue);
        if (RandInt % 2 == 0)
        {
            Objeto.GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log($"El numero: {RandInt} es par");
        }
        else
        {
            Objeto.GetComponent<MeshRenderer>().material.color = Color.pink;
            Debug.Log($"El numero: {RandInt} es impar");
        }
    }
}
