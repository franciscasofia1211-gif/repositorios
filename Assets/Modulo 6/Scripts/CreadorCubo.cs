using UnityEngine;

public class CreadorCubo : MonoBehaviour
{
    
    public GameObject CuboPref;

    void Awake()
    {
        Instantiate(CuboPref, transform);
    }
}
