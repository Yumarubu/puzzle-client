using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDragDrop : MonoBehaviour
{
    GameObject BlockList;
    private Vector3 offset;
    private Vector3 screenPoint;
    bool isUse;

    // Start is called before the first frame update
    void Start()
    {
        isUse = false;
    }

    void OnMouseDown()
    {
        BlockList = GameObject.Find("BlockList");
        this.isUse = true;
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        BlockList.SetActive(false);
    }

    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
        transform.position = currentPosition;
        Debug.Log("Move now");
    }

    private void OnMouseUp()
    {
        BlockList.SetActive(true);
    }
}
