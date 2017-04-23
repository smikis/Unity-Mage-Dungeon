using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnce : MonoBehaviour {
    public Transform player;
    public double range;
    public AudioClip sound;
    private bool _played;

	// Use this for initialization
	void Start () {
        _played = false;
	}
	
	// Update is called once per frame
	void Update () {      
        if (Vector3.Distance(player.position, transform.position) < range && !_played)
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            _played = true;
            Destroy(this);
        }
    }
}
