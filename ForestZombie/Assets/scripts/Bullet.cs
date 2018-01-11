using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Bullet : MonoBehaviour {
	private float maxDistance = 1000;
	public GameObject HitParticle;
	public GameObject HitSound;
	private float hitParticleSpeling = 0.001f;
	private RigidbodyFirstPersonController player;
	private RaycastHit hit;
	
	void Awake(){
	player = GameObject.FindGameObjectWithTag("Player").GetComponent<RigidbodyFirstPersonController>();
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(transform.position, transform.forward, out hit, maxDistance)){
			Debug.Log(hit.transform.name);
			Instantiate(HitParticle, hit.point+ (hit.normal* hitParticleSpeling), Quaternion.identity);
		}else{
			Destroy(gameObject);
		}
		Destroy(gameObject);
	}
}
