using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] LayerMask blockLayer;
    [SerializeField] Stage1Manager stage1Manager;

    Rigidbody2D rigidbody2;
    float speed;
    float jumpPower = 400;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    public enum DIRECTION_TIPE
    {
        STOP,
        RIGHT,
        LEFT,
    }

    DIRECTION_TIPE direction = DIRECTION_TIPE.STOP;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if(x == 0)
        {
            //�~�܂��Ă���
            direction = DIRECTION_TIPE.STOP;
        }
        else if(x > 0)
        {
            //�E�ɓ���
            direction = DIRECTION_TIPE.RIGHT;
        }
        else if (x < 0)
        {
            //���ɓ���
            direction = DIRECTION_TIPE.LEFT;
        }

        // �X�y�[�X�������ꂽ��Jump������
        if(IsGround() && Input.GetKeyDown("space"))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        switch(direction)
        {
            case DIRECTION_TIPE.STOP:
                speed = 0;
                break;

            case DIRECTION_TIPE.RIGHT:
                speed = 3;
                transform.localScale = new Vector3(1, 1, 1);
                break;

            case DIRECTION_TIPE.LEFT:
                speed = -3;
                transform.localScale = new Vector3(-1, 1, 1);
                break;
        }
        rigidbody2.velocity = new Vector2(speed, rigidbody2.velocity.y);
    }

    void Jump()
    {
        // ��ɗ͂�������
        rigidbody2.AddForce(Vector2.up * jumpPower);
        Debug.Log("Jump");
    }

    bool IsGround()
    {
        //�n�_�ƏI�_�����
        Vector3 leftStartPoint = transform.position - Vector3.right * 0.1f;
        Vector3 rightStartPoint = transform.position + Vector3.right * 0.1f;
        Vector3 endPoint = transform.position - Vector3.up * 0.1f;
        Debug.DrawLine(leftStartPoint, endPoint);
        Debug.DrawLine(rightStartPoint, endPoint);
        return Physics2D.Linecast(leftStartPoint,endPoint, blockLayer)
            || Physics2D.Linecast(rightStartPoint,endPoint,blockLayer);
    }

    void OnTriggerEnter2D(Collider2D collsion)
    {
        if(collsion.gameObject.tag == "trap")
        {
            Debug.Log("�Q�[���I�[�o�[");
            stage1Manager.GameOver();
        }
        if(collsion.gameObject.tag == "Finish")
        {
            Debug.Log("�Q�[���N���A");
            stage1Manager.GameClear();
        }
    }
}