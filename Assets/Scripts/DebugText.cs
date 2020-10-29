using SAE;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugText : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] CursorContoller manager;
    string speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = manager.moveSpeed.ToString();
        text.text = speed;
    }
}
