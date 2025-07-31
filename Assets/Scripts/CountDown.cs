using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] Text CountDownText;
    [SerializeField] Text StartText;

    float CountDownTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        CountDownTime -= Time.deltaTime;

        if (CountDownTime < 1)
        {
            CountDownText.gameObject.SetActive(false);
            StartText.gameObject.SetActive(true);
        }
        
        CountDownText.text = CountDownTime.ToString("F0");
    }
}