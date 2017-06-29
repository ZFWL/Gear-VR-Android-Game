using UnityEngine;
using System.Collections;

public class spawnRotation : MonoBehaviour {
	public blockLibrary librarian;
	private Transform blockF;

	void Start () {
		if(transform.eulerAngles.y <= 181){

			blockF = librarian.checkOut();

			if(transform.eulerAngles.y == 0){
				Instantiate(blockF, transform.position - new Vector3(0,0,64f), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,(90.0f),0f)));
				Debug.Log ("1");
			}else if(transform.eulerAngles.y >= 90 && transform.eulerAngles.y <= 91){
				Instantiate(blockF, transform.position - new Vector3(64f,0,0), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,(90.0f),0f)));
				Debug.Log ("2");
			}else{
				Instantiate(blockF, transform.position + new Vector3(0,0,64f), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,(90.0f),0f)));
				Debug.Log ("3");
			}
		}
	}
}
