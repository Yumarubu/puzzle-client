using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Collections.AllocatorManager;

public class Stage1Manager : MonoBehaviour
{
    [SerializeField] GameObject BlockList;
    [SerializeField] GameObject BlockOffButton;
    [SerializeField] GameObject BlockButoon;
    [SerializeField] GameObject AllGrid;

    [SerializeField] GameObject PrefabBlockL;
    [SerializeField] GameObject PrefabBlockT;
    [SerializeField] GameObject PrefabBlockI;

    //GameObject PrefabBlockI = GameObject.Find("block_I");
    //GameObject PrefabBlockT;
    //GameObject PrefabBlockL;

    //�Q�[���I�[�o�[��p
    [SerializeField] GameObject GameOverText;
    [SerializeField] GameObject GameOverBackGround;

    //�Q�[���N���A��p
    [SerializeField] GameObject GameClearText;

    //�Q�[���N���A�ƃQ�[���I�[�o�[������p
    [SerializeField] GameObject RetryButton;
    [SerializeField] GameObject BackMenuButton;

    private List<GameObject> blockList;

    //�{���A���̏�������NG�B���ꂩ��̓��X�g�����g������
    GameObject blocks;
    GameObject block1;
    GameObject block2;

    //GameObject testBlock0;
    //GameObject testBlock1;
    //GameObject testBlock2;
    public bool listClose = false;
    //BlockDragDrop blockDragDrop = new BlockDragDrop();

    // Start is called before the first frame update
    void Start()
    {
        BlockOffButton.SetActive(false);
        //blockDragDrop = GetComponent<BlockDragDrop>();

        //blocks = GameObject.Find("block_L");
        blocks = Instantiate(PrefabBlockL, new Vector3(1.54f, 3.48f, 0.0f), Quaternion.identity);
        block1 = Instantiate(PrefabBlockT, new Vector3(5.5f, 3.48f, 0.0f), Quaternion.identity);
        block2 = Instantiate(PrefabBlockI, new Vector3(-2.5f, 3.48f, 0.0f), Quaternion.identity);
        
        //testBlock0 = Instantiate(PrefabBlockL, new Vector3(1.54f, 3.48f, 0.0f), Quaternion.identity);
        //testBlock1 = Instantiate(PrefabBlockT, new Vector3(-2.5f, 3.48f, 0.0f), Quaternion.identity);
        //testBlock0.SetActive(false);
        //testBlock1.SetActive(false);

        //��������C�����Ƃ�����
        //blockList = 

        blocks.SetActive(false);
        block1.SetActive(false);
        block2.SetActive(false);
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

        blocks.SetActive(true);
        block1.SetActive(true);
        block2.SetActive(true);
        //testBlock0.SetActive(true);
        //testBlock1.SetActive(true);
        //PrefabBlockL.SetActive(true);
        //block_I.SetActive(true);
        //block_T.SetActive(true);
        //block_L.SetActive(true);
    }

    public void CloseBlockList() 
    {
        listClose = true;

        BlockOffButton.SetActive(false);
        BlockList.SetActive(false);
        
        //����͂������C��
        //if (blockDragDrop.isUse == false)
        //{
        //    blocks.SetActive(false);
        //}
        
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
    //    block_I.transform.Rotate(0.0f, 0.0f, -90.0f);
    //    block_T.transform.Rotate(0.0f, 0.0f, -90.0f);
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
        SceneController.CurrentSceneName();
        GameClearText.SetActive(true);
        ResuleScene();
    }

    public void ResuleScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
