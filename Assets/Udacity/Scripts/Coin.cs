using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	//Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

	private GameObject coinText;

	void Awake(){
		coinText = GameObject.FindWithTag("Coin Text");
	}

    public void OnCoinClicked() {

		// Instantiate the CoinPoof Prefab where this coin is located
		coinPoof.transform.position = gameObject.transform.position;
		Instantiate(coinPoof);

        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(this.gameObject);

		//Transform canvas = transform.Find ("Coin Post");
		string coinCount = coinText.GetComponent<UnityEngine.UI.Text>().text.Substring(0,1);
		print (coinCount);
		int coinAdd = int.Parse (coinCount) + 1;
		coinText.GetComponent<UnityEngine.UI.Text> ().text = coinAdd.ToString () + "/10";
    }
}
