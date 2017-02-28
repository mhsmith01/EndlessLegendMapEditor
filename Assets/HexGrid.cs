using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGrid : MonoBehaviour
{
    private bool dirtySize;
    private int width;
    private int height;

    public int GridWidth
    {
        get { return width; }
        set
        {
            if (width != value)
            {
                dirtySize = true;
                width = value;
            }
        }
    }


    public int GridHeight
    {
        get { return height; }
        set
        {
            if (height != value)
            {
                dirtySize = true;
                height = value;
            }
        }
    }

    private float hexHeight;
    private float hexWidth;

    public float HexHeight
    {
        get { return hexHeight; }
        set
        {
            this.hexHeight = value;
            this.hexWidth = (value * Mathf.Sqrt(3)) / 2;
        }
    }

    public float HexWidth
    {
        get { return this.hexWidth; }
    }

    public float StepHeight;

    public Vector3 Origin;

    public HexCell[,] Cells;

    public bool Wrap;

	// Use this for initialization
	void Start ()
	{
	    Origin = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateGridArea()
    {
        if (this.dirtySize)
        {
            this.dirtySize = false;

            HexCell[,] next = new HexCell[GridWidth, GridHeight];
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    next[x, y] = Cells[x, y];
                }
            }

            for (int x = 0; x < GridWidth; x++)
            {
                for (int y = 0; y < GridHeight; y++)
                {
                    if (next[x, y] == null)
                    {
                        next[x,y] = new HexCell(this, x, y);
                    }
                }
            }
        }
    }

}
