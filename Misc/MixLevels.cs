using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour {

    public AudioMixer masterMixer;

    void Start() {
        masterMixer.SetFloat("sfxVol", -5);
        masterMixer.SetFloat("musicVol", -10);
    }

    public void SetSfxLvl(float sfxLvl) {
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }

    public void SetMusicLvl(float musicLvl) {
        masterMixer.SetFloat("musicVol", musicLvl);
    }
}
