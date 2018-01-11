using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	
	public float currentHealth;
	public float maxHealth = 100.0f;
	public float hbLenght;
	
	
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		hbLenght = Screen.width/2;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0.0f){
			Application.LoadLevel("scene2");
			Destroy(gameObject);
		}
	}
	
	void OnGUI(){
		
		GUI.Box(new Rect(10,10,hbLenght,25), "Health");
	}
	
	public void ChangeHealth(float health){
		currentHealth -= health;
		hbLenght = (Screen.width/2)* (currentHealth/(float)maxHealth);
	}
	
	public void Die(){
		Application.LoadLevel("scene2");
	}
	
}
