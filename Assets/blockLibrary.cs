using UnityEngine;
using System.Collections;

public class blockLibrary : MonoBehaviour {
	public Transform[] blocks;

	void Awake () {
	}

	public Transform checkOut(){
		return blocks[Random.Range (0, blocks.Length)];
	}
}
