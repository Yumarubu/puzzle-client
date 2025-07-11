using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySelectManager : MonoBehaviour
{
    public void ChangeStage1Scene()
    {
        SceneManager.LoadScene("Stage1Scene");
    }

}
