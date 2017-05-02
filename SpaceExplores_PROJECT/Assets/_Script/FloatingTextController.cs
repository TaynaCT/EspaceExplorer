using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextController : MonoBehaviour {

    public FloatingText screenText = null;    
    bool showText = true;
    int indice = 0;

    string[] arrayText = { "Press ... or ...\n to rotate the camera",
                           "Select a object " };

    public void Update()
    {
       
        if (showText && indice < arrayText.Length)
        {
            CreatingText(arrayText[indice]);
            showText = false;
            
            indice++;               
        }

        if (Input.GetKeyDown(KeyCode.Space) && !showText)
        {
            showText = true;
        }
    }

    public void CreatingText(string text)
    {        
        FloatingText instance = Instantiate(screenText);        
        instance.transform.SetParent(this.transform, false);        
        instance.GetComponent<FloatingText>().SetText(text);
     }

}
