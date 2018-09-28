using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AddWords : MonoBehaviour {




	public GameObject word;
	public GameObject word2;
	public GameObject word3;
	public GameObject word4;
	public GameObject word5;
	public GameObject word6;
	public GameObject word7;
	public GameObject word8;
	public GameObject word9;
	public GameObject word10;

	public Text countScore;
	private int count;

	public AudioClip soundToPlay;



	KeywordRecognizer keywordRecognizer;
	Dictionary<string,System.Action> keywords = new Dictionary<string, System.Action> ();


	void Start() {

	

		// initialize

		SetCountText ();

		keywords.Add ("Own", () => {

			ByeWord();

		});
		keywords.Add ("Class", () => {

			ByeWord2();

		});
		keywords.Add ("Apple", () => {

			ByeWord3();

		});
		keywords.Add ("Kind", () => {

			ByeWord4();

		});
		keywords.Add ("Sun", () => {

			ByeWord5();

		});
		keywords.Add ("Mouse", () => {

			ByeWord6();

		});
		keywords.Add ("The", () => {

			ByeWord7();

		});
		keywords.Add ("Love", () => {

			ByeWord8();

		});
		keywords.Add ("Future", () => {

			ByeWord9();

		});
		keywords.Add ("Unionbank", () => {

			ByeWord10();

		});
		keywordRecognizer = new KeywordRecognizer (keywords.Keys.ToArray ());
		keywordRecognizer.OnPhraseRecognized +=	KeywordRecognizerOnPhraseRecognized;
		keywordRecognizer.Start ();
	}


	void KeywordRecognizerOnPhraseRecognized(PhraseRecognizedEventArgs args)
	{
		System.Action keywordAction;

		if (keywords.TryGetValue (args.text, out keywordAction)) {

			keywordAction.Invoke ();

		}

	}

	void ByeWord()
	{
		Destroy (word.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	}

	void ByeWord2()
	{
		Destroy (word2.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
    }
		
	void ByeWord3()
	{
		Destroy (word3.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	}

	void ByeWord4()
	{
		Destroy (word4.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	}

	void ByeWord5()
	{
		Destroy (word5.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	}

	void ByeWord6()
	{
		Destroy (word6.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	}

	void ByeWord7()
	{
		Destroy (word7.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	}

	void ByeWord8()
	{
		Destroy (word8.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	
	}
	void ByeWord9()
	{
		Destroy (word9.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
	}

	void ByeWord10()
	{
		Destroy (word10.gameObject);
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		count = count + 100;
		SetCountText ();
		SceneManager.LoadScene ("WinScreen");
	
	}

void SetCountText()
{
	countScore.text = "Score: " + count.ToString ();


}

}
