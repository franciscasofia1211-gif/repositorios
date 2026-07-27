using UnityEngine;
using UnityEngine.UIElements;

public class CreadorCubo2 : MonoBehaviour
{
    public GameObject CuboPref;

    void OnDisable()
    {
        Instantiate(CuboPref,transform);
    }
    void OnEnable()
    {
        Instantiate(CuboPref,transform);
    }
}
