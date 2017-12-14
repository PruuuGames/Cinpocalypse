using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetAudioLevels : MonoBehaviour {

	public AudioMixer mainMixer;					//Used to hold a reference to the AudioMixer mainMixer
    public Slider sfxSlider;
    public Slider masterSlider;
    public Slider musicSlider;

	//Call this function and pass in the float parameter musicLvl to set the volume of the AudioMixerGroup Music in mainMixer
	public void SetMusicLevel()
	{
		mainMixer.SetFloat("Music", musicSlider.value);
	}

	//Call this function and pass in the float parameter sfxLevel to set the volume of the AudioMixerGroup SoundFx in mainMixer
	public void SetSfxLevel()
	{
		mainMixer.SetFloat("SFX", sfxSlider.value);
	}

    public void SetMasterLevel()
    {
        mainMixer.SetFloat("Master", masterSlider.value);
    }
}
