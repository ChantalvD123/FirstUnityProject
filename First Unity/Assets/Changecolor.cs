
using UnityEngine;

public class Changecolor : MonoBehaviour
{
    public MeshRenderer mr;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "MainCamera")
        {
            Debug.Log("hit");
            

        }
    }
}
