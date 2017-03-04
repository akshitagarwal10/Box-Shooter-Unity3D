using UnityEngine;
using System.Collections;

public class GunTriggerAnimation : MonoBehaviour {
	Animator anim;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.Mouse0)) {
			anim.SetTrigger ("fire");
		}
	}
}
