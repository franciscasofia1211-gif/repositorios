using UnityEngine;

public class ScriptCapsula2 : MonoBehaviour
{
    void FixedUpdate()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
