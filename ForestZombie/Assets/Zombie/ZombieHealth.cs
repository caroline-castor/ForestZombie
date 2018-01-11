using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour {
	
	public float currentHealth;
	public float maxHealth = 100.0f;
	public float hbLenght;
	public bool acertou = false;
	private Animation anime;
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		hbLenght = Screen.width/2;
		anime = transform.GetComponentInChildren<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if(acertou){
			ChangeHealth(50.0f);
			acertou=false;
		}
		if(currentHealth ==0){
			anime.CrossFade("back_fall");
			Die();
		}
	}
	
void OnCollisionEnter (Collision col)
{
    print("nome do collider" + col.gameObject.name);
    if (col.gameObject.name.StartsWith("projetil") )
    {
         acertou = true;    
    }
	
       
}

public void Die(){
		Destroy(gameObject,1.5f);
	}
	
	

	
	public void ChangeHealth(float health){
		currentHealth -= health;
		hbLenght = (Screen.width/2)* (currentHealth/(float)maxHealth);
	}
	
}
