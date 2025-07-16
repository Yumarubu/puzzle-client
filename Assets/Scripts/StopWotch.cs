using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWotch : MonoBehaviour
{
    [SerializeField] Text TimerText; 
    float AddCountDown = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerText.text += AddCountDown; 
    }
}
