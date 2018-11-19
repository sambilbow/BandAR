using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class onHover : MonoBehaviour {

	RaycastHit hit;
	Ray ray;

	public Transform TextTargetName;

	public GameObject Guitar;
	public GameObject Bass;
	public GameObject Piano;
	public GameObject Drums;
	public GameObject Vocals;
	public GameObject BackingVocals;

	bool state;


	// Methods that hides all but one panel, there is probably a more gracious way to code this but I wasn't sure.

	void showOnlyGuitar()
	{
		// Setting all GUI FX Panels except one inactive (hidden)
		Guitar.SetActive (true);
		Bass.SetActive (false);
		Piano.SetActive (false);
		Drums.SetActive (false);
		Vocals.SetActive (false);
		BackingVocals.SetActive (false);
	}

	void showOnlyBass()
	{
		Guitar.SetActive (false);
		Bass.SetActive (true);
		Piano.SetActive (false);
		Drums.SetActive (false);
		Vocals.SetActive (false);
		BackingVocals.SetActive (false);
	}

	void showOnlyPiano()
	{
		Guitar.SetActive (false);
		Bass.SetActive (false);
		Piano.SetActive (true);
		Drums.SetActive (false);
		Vocals.SetActive (false);
		BackingVocals.SetActive (false);
	}

	void showOnlyDrums()
	{
		Guitar.SetActive (false);
		Bass.SetActive (false);
		Piano.SetActive (false);
		Drums.SetActive (true);
		Vocals.SetActive (false);
		BackingVocals.SetActive (false);
	}

	void showOnlyVocals()
	{
		Guitar.SetActive (false);
		Bass.SetActive (false);
		Piano.SetActive (false);
		Drums.SetActive (false);
		Vocals.SetActive (true);
		BackingVocals.SetActive (false);
	}

	void showOnlyBackingVocals()
	{
		Guitar.SetActive (false);
		Bass.SetActive (false);
		Piano.SetActive (false);
		Drums.SetActive (false);
		Vocals.SetActive (false);
		BackingVocals.SetActive (true);
	}

	void Update()
	{
		TextTargetName.gameObject.SetActive(true);
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		// If you (hover on PC), tap (mobile) on an instrument stage, it brings up the FX panel of that instrument.

		if(Physics.Raycast(ray, out hit))
		{
			Debug.Log("User clicked on " + hit.collider.gameObject.name);

			if(hit.collider.gameObject.name == "guitarbanner")
			{
				// Sets text of "Selected Instrument:" panel once I have added it to the script's GameObject in Unity3D
				TextTargetName.GetComponent<Text>().text = "Selected Instrument: Guitar";

				// Runs method to hide other FX panels
				showOnlyGuitar();
			}

			if(hit.collider.gameObject.name == "bassbanner")
			{
				TextTargetName.GetComponent<Text>().text = "Selected Instrument: Bass Guitar";
				showOnlyBass();
			}

			if(hit.collider.gameObject.name == "pianobanner")
			{
				TextTargetName.GetComponent<Text>().text = "Selected Instrument: Piano";
				showOnlyPiano();
			}

			if(hit.collider.gameObject.name == "drumsbanner")
			{
				TextTargetName.GetComponent<Text>().text = "Selected Instrument: Drum Kit";
				showOnlyDrums();
			}

			if(hit.collider.gameObject.name == "vocalsbanner")
			{
				TextTargetName.GetComponent<Text>().text = "Selected Instrument: Vocals";
				showOnlyVocals();
			}

			if(hit.collider.gameObject.name == "backingvocalsbanner")
			{
				TextTargetName.GetComponent<Text> ().text = "Selected Instrument: Backing Vocals";
				showOnlyBackingVocals();
			}


		}
	}








}
