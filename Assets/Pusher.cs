using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {
	private float m_zpos;
	private float m_firstpos; //初期Z座標
	private const float s_moving = 10f; //振幅（メートル）
	private const float s_afreq = 0.01f; //角周波数

	// Use this for initialization
	void Start () {
		m_zpos = 0f;
		m_firstpos = transform.position.z; 
	}
	
	// Update is called once per frame
	void Update () {
		m_zpos = m_firstpos - (Mathf.Sin (Time.frameCount * s_afreq) + 1f) * s_moving;
		rigidbody.MovePosition (new Vector3(transform.position.x, transform.position.y, m_zpos));
	}

}
