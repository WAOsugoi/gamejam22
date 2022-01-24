using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStage_Audio : MonoBehaviour
{
    public AudioManager am;
    public void PlaySound()
    {
        am.Play("Playgame");
    }
}
