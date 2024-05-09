using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    RectTransform rectTransform;
   

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Debug.Log("rect transform: " +  rectTransform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scaleImage()
    {
        rectTransform.sizeDelta = new Vector2(2, 2);
        Debug.Log("New Vector 2");
    }
}
