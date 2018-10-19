using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(this.transform.position, new Vector2(this.transform.position.x,-10));
        Debug.Log(this.transform.position.x+"      .......... "+ hit.transform.position.x);
        Debug.Log(hit.transform.name);
        LineController line= transform.Find("LineGenerator").GetComponent<LineController>();    
        line.DrawLine(new List<Vector3> { this.gameObject.transform.position,hit.transform.position });
               
	}


}
