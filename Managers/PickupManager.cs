using UnityEngine;
using System.Collections;

public class PickupManager : MonoBehaviour {
	
	public int scoreNeededForExtraBullet = 1500;
	public int extraScoreNeededAfterEachPickup = 2000;
    public int scoreNeededForDemon = 5000;
    public int extraScoreNeededAfterEachDemon = 2500;
    public int scoreNeededForSpeedBoost = 300;

	public Pickup healthPickup;
	public Pickup bouncePickup;
	public Pickup piercePickup;
	public Pickup bulletPickup;
    public Pickup speedPickup;
    public Pickup rapidPickup;
    public Pickup demonPickup;
}
