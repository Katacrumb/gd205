using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class UiFunctions : MonoBehaviour
{

    public Text textObject;

// Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {



    }


    public void ButtonChange(){
    
        tmp = GetComponent<TextMeshProUGUI>();
        tmp.SetText("buttsquared");

    }
}
