using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_1 : MonoBehaviour {

    public Sprite myButtonImage; // Assign /Initilize from Editor or code
    private Button button;
    public Sprite buttonImage;
    public Pack pack;

    void Start()
    {
        button = GetComponent<Button>();

        if(pack.PopularPacks == 1) { button.image.sprite = myButtonImage; }
        else
        {
            button.image.sprite = buttonImage;
        }
        Debug.Log(pack.PopularPacks);

        
    }


}
