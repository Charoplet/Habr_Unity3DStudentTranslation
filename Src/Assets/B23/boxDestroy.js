#pragma strict

var stars : ParticleSystem;
 
function OnCollisionEnter (col : Collision) {
 Instantiate(stars, transform.position, transform.rotation);
 Destroy(gameObject);
}

