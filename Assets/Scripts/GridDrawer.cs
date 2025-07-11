using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class GridDrawer : MonoBehaviour
{
    public float cellSize = 1f;
    public Material lineMaterial;
    public Camera targetCamera;

    void Start()
    {
        if (targetCamera == null)
            targetCamera = Camera.main;

        DrawGrid();
    }

    void DrawGrid()
    {
        float camHeight = 2f * targetCamera.orthographicSize;
        float camWidth = camHeight * targetCamera.aspect;

        int width = Mathf.CeilToInt(camWidth / cellSize);
        int height = Mathf.CeilToInt(camHeight / cellSize);

        Vector3 bottomLeft = targetCamera.transform.position - new Vector3(camWidth / 2f, camHeight / 2f, 0);

        for (int x = 0; x <= width; x++)
        {
            float xPos = x * cellSize + bottomLeft.x;
            DrawLine(new Vector3(xPos, bottomLeft.y, 0), new Vector3(xPos, bottomLeft.y + height * cellSize, 0));
        }

        for (int y = 0; y <= height; y++)
        {
            float yPos = y * cellSize + bottomLeft.y;
            DrawLine(new Vector3(bottomLeft.x, yPos, 0), new Vector3(bottomLeft.x + width * cellSize, yPos, 0));
        }
    }

    void DrawLine(Vector3 start, Vector3 end)
    {
        GameObject line = new GameObject("GridLine");
        line.transform.parent = transform;

        var lr = line.AddComponent<LineRenderer>();
        lr.positionCount = 2;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
        lr.startWidth = 0.1f;
        lr.endWidth = 0.1f;
        lr.material = lineMaterial;
        lr.useWorldSpace = true;

        // Åö å©Ç¶ÇÈÇÊÇ§Ç…Ç∑ÇÈí«â¡ê›íË
        lr.sortingLayerName = "Default";
        lr.sortingOrder = 100;
    }
}
