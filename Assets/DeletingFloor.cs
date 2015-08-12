using UnityEngine;
using System.Collections;

public class DeletingFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//メダルを消す判定
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.name == "medal(Clone)"){
			Destroy (collision.gameObject);
		}
	}
}
