using UnityEngine;

public class CreadorCubo1: MonoBehaviour
{
    public GameObject CuboPref;

    void Update()
    {
        Instantiate(CuboPref,transform);
    }
}
