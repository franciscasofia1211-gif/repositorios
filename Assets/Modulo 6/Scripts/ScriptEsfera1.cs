using UnityEngine;

public class ScriptEsfera1 : MonoBehaviour
{
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
