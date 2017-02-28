using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCell : MonoBehaviour
{
    private HexGrid _grid;

    public int Elevation;

    public int X;
    public int Y;

    public Region Region;

    public Spawn Spawn;

    public River River;

    public Terrain Terrain;

    public PointOfIntrest PointOfIntrest;

    public HexCell(HexGrid grid, int x, int y)
    {
        this._grid = grid;
        this.X = x;
        this.Y = y;

        this.Elevation = 0;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public Vector3 ComputeCellCenter()
    {
        Vector3 position = _grid.Origin;
        position.x += _grid.HexWidth / 2 * X;
        position.y += _grid.StepHeight * Elevation;
        position.z += Y * _grid.HexHeight * 2;
        if (X % 2 == 1)
        {
            //odd row
            position.z += _grid.HexHeight + _grid.HexHeight / 2;
        }

        return position;
    }
}
