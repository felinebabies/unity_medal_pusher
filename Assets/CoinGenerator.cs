using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour {
	public GameObject medalprefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousepos = Input.mousePosition;
			Ray mouseray = Camera.main.ScreenPointToRay (mousepos);
			RaycastHit hitinfo = new RaycastHit();;

			//壁に触れているかをチェック
			if(Physics.Raycast (mouseray, out hitinfo)){
				if(hitinfo.transform.gameObject.name == "wall"){
					Vector3 medalpos = hitinfo.point;
					medalpos.z -= (medalprefab.transform.localScale.z / 2f);
					Instantiate (medalprefab, medalpos, Quaternion.Euler (0, 0, 0));
				}
			}
		}
	}
}
