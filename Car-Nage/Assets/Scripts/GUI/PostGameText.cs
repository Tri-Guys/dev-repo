using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PostGameText : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI postText;
    void Start()
    {
        postText = GetComponent<TextMeshProUGUI>();
        postText.color = new Color32(255, 255, 255, 0);
    }

    // Update is called once per frame
    void PostShow()
    {
        postText.color = new Color32(255, 255, 255, 255);
    }
}
