// Criado por Camila Silva
// Desde 31/08/2022
// Este script é responsavel pelo gerenciamento do audio 
// Este script se encontra no objeto ManagerSound

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource dieSource, pointSource, hitSource, swooshSource, wingSource;

    [SerializeField]
    private AudioClip dieClip, pointClip, hitClip, swooshClip, wingClip;

    public static ManagerSound instanceSource;

    void Start(){

        instanceSource = this;
    }

    public void dieSoundPla(AudioClip dieClip){
        dieSource.PlayOneShot(dieClip);
    }

    public void pointSoundPlay(AudioClip pointClip){
        pointSource.PlayOneShot(pointClip);
    }

    public void hitSoundPlay(AudioClip hitClip){
        hitSource.PlayOneShot(hitClip);
    }

    public void swooshSoundPlay(AudioClip swooshClip){
        swooshSource.PlayOneShot(swooshClip);
    }

    public void wingSoundPlay(AudioClip wingClip){
        wingSource.PlayOneShot(wingClip);
    }

}
