using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PackDisplay : MonoBehaviour {

    public Pack pack;

    public Image VirtualCoinsImage;
    public Image MoneyImage;
    public Image BonusImage;
    public Image CoinsImage;
    public GameObject[] Populars;
    public GameObject Popular;

    RectTransform m_RectTransform;
    float m_XAxis, m_YAxis;
   
    

    // Use this for initialization
    void Start () {

        VirtualCoinsImage.sprite = pack.VirtualCoins;
        MoneyImage.sprite = pack.Money;
        CoinsImage.sprite = pack.Coins;

        if (pack.Bonus == null)
        { BonusImage.gameObject.SetActive(false); }
        else
        { BonusImage.sprite = pack.Bonus; }

        if (pack.PopularPacks == 0)
        {
            Debug.Log("0");
            Popular = null;
        }
        else if(pack.PopularPacks == 1)
        {
            GameObject popular = Instantiate(Populars[0], Vector2.zero, Quaternion.identity);
            popular.transform.SetParent(transform, false);

            popular.transform.parent = transform;
            RectTransform rt = popular.GetComponent<RectTransform>();
            rt.anchoredPosition = rt.transform.position;
            rt.localPosition = new Vector2(304, 0);
        }
        else if (pack.PopularPacks == 2)
        {
            GameObject popular = Instantiate(Populars[1], Vector2.zero, Quaternion.identity);
            popular.transform.SetParent(transform, false);

            popular.transform.parent = transform;
            RectTransform rt = popular.GetComponent<RectTransform>();
            rt.anchoredPosition = rt.transform.position;
            rt.localPosition = new Vector2(304, 0);
        }
        return;





    }
	
	
}
