using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;

public class Zombie : MonoBehaviour {

	private UnityEngine.AI.NavMeshAgent agent;
	private Animation anime;
	public float nextAttack;
	public float attackDelay = 1;
	public float health =100;
	public bool isDead = false;
	public GameObject player;
	public PlayerHealth pl;
	
	
	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		anime = transform.GetComponentInChildren<Animation>();
		player = GameObject.FindGameObjectWithTag("Player");
		pl = player.GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isDead == false	){
		
		if(agent.remainingDistance <= agent.stoppingDistance && nextAttack <= Time.time){
			anime.CrossFade("attack");
			Invoke("Attack",0.5f);
			nextAttack = Time.time + attackDelay;
		}else if(agent.remainingDistance > agent.stoppingDistance){
			if(anime.isPlaying == false){
				anime.CrossFade("walk");
			}
			
		}
		agent.SetDestination(GameObject.Find("Atirador").transform.position);
		
		if(health <= 0){
			anime.CrossFade("back_fall");
			isDead = true;
			Die();
		}
		
		
		}
	}
	
	private void Attack(){
		pl.ChangeHealth(0.5f);
	}
	
	public void Die(){
		Destroy(gameObject,3);
	}
	
	public void Hurt(float hp){
		health-=hp;
	}
}
