using UnityEngine;

public class ScriptCapsula1 : MonoBehaviour
{
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
