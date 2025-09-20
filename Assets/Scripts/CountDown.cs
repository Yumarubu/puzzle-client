using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] Text CountDownText;
    [SerializeField] Text StartText;

    float CountDownTime = 3;

    //SE
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        StartText.gameObject.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CountDownTime -= Time.deltaTime;
        //audioSource.PlayOneShot(countDownSE);

        if (CountDownTime < 0)
        {
            CountDownText.gameObject.SetActive(false);
            StartText.gameObject.SetActive(true);
        }
        
        CountDownText.text = CountDownTime.ToString("F0");
    }
}