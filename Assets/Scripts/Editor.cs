using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class Editor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DrawGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int width = 10;
    public int height = 10;
    public float cellSize = 1f;
    public Material lineMaterial;

    void DrawGrid()
    {
        for (int x = 0; x <= width; x++)
        {
            DrawLine(new Vector3(x * cellSize, 0, 0), new Vector3(x * cellSize, height * cellSize, 0));
        }

        for (int y = 0; y <= height; y++)
        {
            DrawLine(new Vector3(0, y * cellSize, 0), new Vector3(width * cellSize, y * cellSize, 0));
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
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;
        lr.material = lineMaterial;
        lr.useWorldSpace = true;
    }
}