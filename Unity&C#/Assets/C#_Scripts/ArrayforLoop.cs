using System.Collections;
using UnityEngine;

public class ArrayforLoop : MonoBehaviour {

	// Use this for initialization
	string[] nama = {"satu", "dua", "tiga"};

	void Start () {
		for (int i = 0; i < nama.Length; i++) {
            Debug.Log(nama [i]);
	}
	
	// Update is called once per frame
	
}
}
