using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] Text CountDownText;
    float CountDownTime = 3;
    string StartMessage = "Start!";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountDownTime -= Time.deltaTime;

        if (CountDownTime < 1)
        {
            StartComment();
            //CountDownText.gameObject.SetActive(false);
        }

        CountDownText.text = CountDownTime.ToString("F0");
    }

    public void StartComment()
    {
        CountDownText.text = "Start!";
    }
}
