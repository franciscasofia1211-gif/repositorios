using UnityEngine;

public class ScriptCubo1 : MonoBehaviour
{
    public ScriptCapsula1 Script1;
    public ScriptCapsula2 Script2;

    public bool IsTrue;

    void FixedUpdate()
    {
        if (Script1 && Script2 == true || Script2 == false)
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
