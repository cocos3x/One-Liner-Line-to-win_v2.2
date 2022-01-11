using System.Collections.Generic;
using UnityEngine;

public class AudioManager65 : MonoBehaviour
{
	public static AudioManager65 Instance;

	private AudioClip[] Audios;

	private AudioClip[] music;

	private AudioSource audioSource;

	private Dictionary<string, AudioClip> Dic_Audio;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PlaySFX(string AudioName, float voluem = 1f)
	{
	}

	public void PlayBGM()
	{
	}

	public void StopBGM()
	{
	}
}
