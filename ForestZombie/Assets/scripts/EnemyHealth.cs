using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
	
	public int currentHealth;
	public int maxHealth = 100;
	public float hbLenght;
	
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		hbLenght = Screen.width/2;
		
	}
	
	// Update is called once per frame
	void Update () {
		ChangeHealth(0);
	}
	
	void OnGUI(){
		GUI.Box(new Rect(10,50,hbLenght,25), currentHealth + " /"+ maxHealth);
	}
	
	public void ChangeHealth(int health){
		currentHealth += health;
		hbLenght = (Screen.width/2)* (currentHealth/(float)maxHealth);
	}
}
