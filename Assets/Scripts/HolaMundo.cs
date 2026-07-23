using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Debug.Log("Se esta llamando esta función una sola vez, nula posibilidad de problemas de optimización");
    }
    void Start()
    {
        Debug.Log("Se esta llamando esta función una sola vez, nula posibilidad de problemas de optimización");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Se esta llamando esta Función multiples veces, posible problemas de optimización");
    }

    void FixedUpdate()
    {
        Debug.LogWarning("Se esta llamando esta función con ligera repetición, baja probabilidad de problemas de optimización");
    }
}
