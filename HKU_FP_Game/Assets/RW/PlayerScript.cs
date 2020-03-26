using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int points = 0;
    GUIStyle style = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        this.style.fontSize = 100;
        this.style.normal.textColor = Color.white;
        GUI.Label(new Rect(10,10,100,20), "Score : " + points, style);
    }
}
