using UnityEngine;

public class ScriptCubo1 : MonoBehaviour
{
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
