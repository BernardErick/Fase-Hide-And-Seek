using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackgroundImageAction : MonoBehaviour
{
    public Image outsideImage;

    public Sprite[] sprites;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Action();
    }

    void Action() {
        int current = outsideImage.GetComponent<InteractiveLabelAction>().currentText;

        switch (current) {
            case 10:
                this.GetComponent<Image>().sprite = sprites[0];
                break;
        }
    }
}
