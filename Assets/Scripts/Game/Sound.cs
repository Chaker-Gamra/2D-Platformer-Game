using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound {

	public string name;

	public AudioClip clip;
	public AudioMixerGroup mixer;

	[Range(0f, 1f)]
	public float volume = 1;

	[Range(-3f, 3f)]
	public float pitch = 1;

	public bool loop = false;

	[HideInInspector]
	public AudioSource source;

}
