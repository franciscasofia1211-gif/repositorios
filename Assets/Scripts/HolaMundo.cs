using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola Mundo");
        Debug.LogWarning("Algo no tan grave a fallado");
        Debug.LogError("Algo grave a fallado");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
