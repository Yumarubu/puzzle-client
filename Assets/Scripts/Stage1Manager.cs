using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1Manager : MonoBehaviour
{
    [SerializeField] GameObject BlockList;
    [SerializeField] GameObject BlockOffButton;
    [SerializeField] GameObject BlockButoon;
    [SerializeField] GameObject AllGrid;

    [SerializeField] GameObject block_I;
    [SerializeField] GameObject block_T;
    [SerializeField] GameObject block_L;

    [SerializeField] GameObject PrefabBlockL;

    //ゲームオーバー専用
    [SerializeField] GameObject GameOverText;
    [SerializeField] GameObject GameOverBackGround;

    //ゲームクリア専用
    [SerializeField] GameObject GameClearText;

    //ゲームクリアとゲームオーバー両方専用
    [SerializeField] GameObject RetryButton;
    [SerializeField] GameObject BackMenuButton;

    GameObject testBlock;
    public bool listClose = false;

    // Start is called before the first frame update
    void Start()
    {
        BlockOffButton.SetActive(false);

        block_I.SetActive(false);
        //block_T.SetActive(false);
        block_L.SetActive(false);
        testBlock = Instantiate(PrefabBlockL, new Vector3(1.54f, 3.48f, 0.0f), Quaternion.identity);
        testBlock.SetActive(false);

        GameOverText.SetActive(false);
        GameOverBackGround.SetActive(false);

        GameClearText.SetActive(false);

        RetryButton.SetActive(false);
        BackMenuButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenBlockList()
    {
        BlockList.SetActive(true);
        BlockOffButton.SetActive(true);

        testBlock.SetActive(true);
        PrefabBlockL.SetActive(true);
        //block_I.SetActive(true);
        //block_T.SetActive(true);
        //block_L.SetActive(true);
    }

    public void CloseBlockList() 
    {
        listClose = true;

        BlockOffButton.SetActive(false);
        BlockList.SetActive(false);

        //testBlock.SetActive(false);
        
        //block_I.SetActive(false);
        //block_T.SetActive(false);
        //block_L.SetActive(false);
    }
    
    public void ActionMode()
    {
        BlockButoon.SetActive(false);
        AllGrid.SetActive(false);
    }

    public void RotetionButton()
    {
        block_I.transform.Rotate(0.0f, 0.0f, -90.0f);
        block_T.transform.Rotate(0.0f, 0.0f, -90.0f);
    }

    public void GameOver()
    {
        GameOverText.SetActive(true);
        GameOverBackGround.SetActive(true);

        RetryButton.SetActive(true);
        BackMenuButton.SetActive(true);
    }

    public void GameClear()
    {
        GameClearText.SetActive(true);
        ResuleScene();
    }

    public void ResuleScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
