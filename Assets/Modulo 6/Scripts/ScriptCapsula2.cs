using UnityEngine;

public class ScriptCapsula2 : MonoBehaviour
{
    public ScriptEsfera1 Script1;
    public ScriptCubo Script2;

    public bool IsTrue;

    //void FixedUpdate()
    //{
    //    GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    //}
    void FixedUpdate()
    {
        if(Script1.IsTrue == true && Script2.IsTrue == true)
        {
            IsTrue = true;
        }
        else
        {
            IsTrue = false;
        }
        if (IsTrue)
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

}
