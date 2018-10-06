using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comands : MonoBehaviour {
    public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(Vector3.forward * speed);

        if (Input.GetKey(KeyCode.RightArrow))
           {
            this.transform.Translate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);
            GameObject shootPivot = GameObject.Find("AirplanePivot/shootPivot");
            newMissile.transform.SetParent(shootPivot.transform);
            newMissile.transform.localPosition = Vector3.zero;
            newMissile.transform.SetParent(null);
        }

	}
}
