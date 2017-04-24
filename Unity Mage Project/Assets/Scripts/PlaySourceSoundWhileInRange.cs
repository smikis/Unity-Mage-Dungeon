using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySourceSoundWhileInRange : MonoBehaviour {
    public Transform player;
    private AudioSource _sound;

    // Use this for initialization
    void Start()
    {
        _sound = gameObject.GetComponent<AudioSource>();
        _sound.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        // var distanceMin = Vector3.Distance(player.position, _sound.maxDistance);      
        if (Vector3.Distance(player.position, transform.position) < _sound.maxDistance)
        {
            if (!_sound.isPlaying)
            {
                _sound.Play();
            }

        }
        else
        {
            _sound.Stop();
        }
    }
}
