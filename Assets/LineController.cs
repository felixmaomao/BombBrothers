using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour {

    private LineRenderer LineRenderer;

	// Use this for initialization
	void Start () {
        LineRenderer = this.gameObject.GetComponent<LineRenderer>();       
    }
	
    public void DrawLine(List<Vector3> positions)
    {       
        LineRenderer.SetPositions(positions.ToArray());
    }
}
