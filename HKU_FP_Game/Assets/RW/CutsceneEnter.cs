using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CutsceneEnter : MonoBehaviour
{
    public GameObject timeLine;
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider other)
    {
        PlayableDirector pd = timeLine.GetComponent<PlayableDirector>();
        if (pd != null)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            pd.Play();
            thePlayer.SetActive(false);
            StartCoroutine(FinishCut());
        }

        IEnumerator FinishCut()
        {
            yield return new WaitForSeconds(15);
            SceneManager.LoadScene("UI-EndingScene");
        }
    }
}