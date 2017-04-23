using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundWhileInRange : MonoBehaviour {
    public Transform player;
    public double range;
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
        var distance = Vector3.Distance(player.position, transform.position);      
        if (Vector3.Distance(player.position, transform.position) < range)
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
