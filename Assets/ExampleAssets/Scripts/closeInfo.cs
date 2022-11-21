using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeInfo : MonoBehaviour
{
    public GameObject gameObject;
	bool active = true;
	public void OpenAndClose()
	{
		if (active == true) {
			gameObject.transform.gameObject.SetActive(false);
			active = false;
		}
		else {
			gameObject.transform.gameObject.SetActive(true);
			active = true;
		}
	}
}