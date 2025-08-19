using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDragDrop : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 screenPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
    }

    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
        transform.position = currentPosition;
        Debug.Log("Move now");
    }


}
