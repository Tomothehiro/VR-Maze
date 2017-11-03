using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public GameObject door;

	public Animator keyRotationAnimation;

	private Quaternion startRot, endRot;

	public float smooth = 2.0F;
	public float tiltAngle = 3000.0F;

	void Update()
	{
		//Bonus: Key Animation
		Quaternion target = transform.rotation * Quaternion.Euler(0, tiltAngle, 0);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, smooth);
		//startRot = gameObject.transform.rotation;
		//endRot = startRot * Quaternion.Euler (0f, 3600f, 0f);
		//transform.rotation = Quaternion.Lerp (startRot,endRot, Time.deltaTime);
		
	}

	public void OnKeyClicked()
	{
		keyRotationAnimation.enabled = true;
		keyRotationAnimation.SetTrigger ("RotateKey");
        // Instatiate the KeyPoof Prefab where this key is located
		keyPoof.transform.position = gameObject.transform.position;
		Instantiate(keyPoof);

        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
		door.GetComponent<Door>().Unlock();
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(this.gameObject, 3f);
    }

}
