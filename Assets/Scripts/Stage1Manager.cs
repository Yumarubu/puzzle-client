using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Manager : MonoBehaviour
{
    [SerializeField] GameObject BlockList;
    [SerializeField] GameObject BlockOffButton;
    [SerializeField] GameObject BlockButoon;
    [SerializeField] GameObject AllGrid;

    [SerializeField] GameObject block_I;
    [SerializeField] GameObject block_T;
    [SerializeField] GameObject block_L;

    //ゲームオーバー専用
    [SerializeField] GameObject GameOverText;
    [SerializeField] GameObject GameOverBackGround;

    //ゲームクリア専用

    //ゲームクリアとゲームオーバー両方専用
    [SerializeField] GameObject RetryButton;
    [SerializeField] GameObject BackMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        BlockOffButton.SetActive(false);

        block_I.SetActive(false);
        block_T.SetActive(false);
        block_L.SetActive(false);

        GameOverText.SetActive(false);
        GameOverBackGround.SetActive(false);

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
        block_I.SetActive(true);
        block_T.SetActive(true);
        block_L.SetActive(true);
    }

    public void CloseBlockList() 
    {
        BlockOffButton.SetActive(false);
        BlockList.SetActive(false);
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
        //block_I.transform.rotation(90.0f, 0.0f, 0.0f);
    }

    public void GameOver()
    {
        GameOverText.SetActive(true);
        GameOverBackGround.SetActive(true);

        RetryButton.SetActive(true);
        BackMenuButton.SetActive(true);
    }
}
