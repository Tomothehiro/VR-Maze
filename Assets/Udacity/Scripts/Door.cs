using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public AudioClip audioClip;

    // Create a boolean value called "locked" that can be checked in Update() 
	private bool locked = true;

	private bool clicked = false;

    void Update() {
        // If the door is unlocked and it is not fully raised
		if (!locked && clicked) {
			if (transform.position.y < 20.0f) {
				// Animate the door raising up
				transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
			}
			if (transform.localScale.y > 0) {
				transform.localScale -= new Vector3 (0, 0.1f, 0);
			}
		} else if (locked && clicked) {
			clicked = false;
		}
    }

    public void Unlock()
    {
		// You'll need to set "locked" to true here (really?)
		Debug.Log("unlocked");
		locked = false;
		this.gameObject.GetComponentInChildren<AudioSource> ().clip = audioClip;
	}

	public void Clicked(){
		clicked = true;
	}

}
