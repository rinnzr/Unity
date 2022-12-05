using System.Collections;
using UnityEngine;

public class Perulangan_ForEach : MonoBehaviour {

	int[] angka = {1,2,3,4,5,6};
    void Start()
    {
     foreach (int ambilAngka in angka)
     {
        Debug.Log(ambilAngka);
     }   
	}
	
	
}
