using UnityEngine;

public class ScriptEsfera2 : MonoBehaviour
{
    void FixedUpdate()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
