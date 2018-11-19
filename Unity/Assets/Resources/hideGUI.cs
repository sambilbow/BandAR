using UnityEngine;
using UnityEngine.UI;

public class hideGUI : MonoBehaviour

	{
	// This adds the fields in the Inspector to add GameObjects to interact with the script
	public Button Button;
	public GameObject Selection;
	public GameObject Guitar;
	public GameObject Bass;
	public GameObject Piano;
	public GameObject Drums;
	public GameObject Vocals;
	public GameObject BackingVocals;

	bool state;

	void Start()
	{

		Button btn = Button.GetComponent<Button>();
		GameObject aaa = Selection.GetComponent<GameObject> ();
		GameObject bbb = Guitar.GetComponent<GameObject> ();
		GameObject ccc = Bass.GetComponent<GameObject> ();
		GameObject ddd = Piano.GetComponent<GameObject> ();
		GameObject eee = Drums.GetComponent<GameObject> ();
		GameObject fff = Vocals.GetComponent<GameObject> ();
		GameObject ggg = BackingVocals.GetComponent<GameObject> ();


		//Calls the TaskOnClick method when you click the Button
		btn.onClick.AddListener(TaskOnClick);


	}

	void TaskOnClick()
	{
		//Output this to console when the Button is clicked
		Debug.Log("You have clicked the button!");

		//Run the below method
		SwitchShowHide();

	}

	void SwitchShowHide()
	{
		//Method that hides all GUI GameObjects that have been added to the script above.

		state = !state;


		Selection.SetActive (state);
		Guitar.SetActive (state);
		Bass.SetActive (state);
		Piano.SetActive (state);
		Drums.SetActive (state);
		Vocals.SetActive (state);
		BackingVocals.SetActive (state);
	}


}
