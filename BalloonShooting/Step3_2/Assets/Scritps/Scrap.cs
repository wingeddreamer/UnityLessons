using UnityEngine;
using System.Collections;

public class Scrap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<ParticleSystem>().time>0&&GetComponent<ParticleSystem>().particleCount == 0) Destroy(gameObject);
	}
}
