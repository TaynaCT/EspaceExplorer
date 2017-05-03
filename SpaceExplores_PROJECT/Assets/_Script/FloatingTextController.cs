using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    

public class FloatingTextController : MonoBehaviour {

<<<<<<< HEAD
    public FloatingText screenText = null;
    bool showText = true; // Quando true é ativado a criação do texto
    int indice = 0;

    string[] arrayText = { "Aonde é que esta o resto da tripulção?", "Precione Z ou C\npara procurar no mapa", "Va a nave\n Precione E para interagir",  };
    float timer = 0;
=======
    public GameObject screenText;      
>>>>>>> origin

    public void Update()
    {
        timer += Time.deltaTime;

        //ativação e criação funciona
        if (showText && indice < arrayText.Length)
        {
            CreatingText(arrayText[indice]);

            showText = false;

            indice++;
        }

        if (timer > 5 && indice == 1)
        {
            showText = true;
            timer = 0;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) && (indice == 2))
        {         
            showText = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && (indice == 3))
        {
            showText = true;
        }

    }

    public void CreatingText(string text)
<<<<<<< HEAD
    {
        FloatingText instance = Instantiate(screenText);
        instance.transform.SetParent(this.transform, false);
        instance.GetComponent<FloatingText>().SetText(text);
    }
=======
    {      
        GameObject instance = Instantiate(screenText);
            
        instance.transform.SetParent(this.transform, false);
        instance.GetComponent<FloatingText>().SetText(text);
        //por aqui não é possivel introduzir um novo texto
        //instance.SetText(text);
    }

>>>>>>> origin
}
