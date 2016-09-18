using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CashUI : MonoBehaviour {
	public Text text;
	public Player player;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter.AddObserver (this, "ClickedEarth");
	}

	public void ClickedEarth() {
		text.text = "$ " + player.cashMoney;
	}
}
