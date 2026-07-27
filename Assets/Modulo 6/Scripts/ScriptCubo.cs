using UnityEngine;

public class ScriptCubo : MonoBehaviour
{
    void Awake()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
