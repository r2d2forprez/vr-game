using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

	[SerializeField]
	Sprite redReticle;
	[SerializeField]
	Sprite yellowReticle;
	[SerializeField]
	Sprite blueReticle;
	[SerializeField]
	Image reticle;

	public void UpdateReticle() {
	  switch (GunEquipper.activeWeaponType) {
	    case Constants.Pistol:
	      reticle.sprite = redReticle;
	      break;
	    case Constants.Shotgun:
	      reticle.sprite = yellowReticle;
	      break;
	    case Constants.AssaultRifle:
	      reticle.sprite = blueReticle;
	      break;
            
            default:
	      return;
	  }
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
