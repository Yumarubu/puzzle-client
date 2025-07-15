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

    public void ChangeStage2Scene()
    {
        SceneManager.LoadScene("Stage2Scene");
    }

    public void ChangeStage3Scene()
    {
        SceneManager.LoadScene("Stage3Scene");
    }

    public void ChangeStage4Scene()
    {
        SceneManager.LoadScene("Stage4Scene");
    }

    public void ChangeStage5Scene()
    {
        SceneManager.LoadScene("Stage5Scene");
    }
}
