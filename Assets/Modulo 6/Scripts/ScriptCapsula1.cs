using UnityEngine;

public class ScriptCapsula1 : MonoBehaviour
{ 
    public ScriptEsfera1 Script1;
    public ScriptCubo Script2;

    public bool IsTrue;
    void FixedUpdate()
    {
        if(Script1.IsTrue == true || Script2.IsTrue == true)
        {
            IsTrue = false;
        }
        else
        {
            IsTrue = true;
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
