using UnityEngine;

public class ScriptCapsula : MonoBehaviour
{
    void Awake()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
