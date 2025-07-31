using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    [SerializeField] Text startText;
    float time = 0;
    bool startTextJuage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 1.0f)
        { 
            startText.gameObject.SetActive(false);
        }
    }
}
