namespace GiantCroissant.DialogueThroughTimeline.JustOneDirectorWithSignal
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;

    public class DialogueOverSignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public GameObject dialogueUI;
        public void OnNotify(Playable origin, INotification notification, object context)
        {
            //
            Debug.Log($"Notified that the clip - Dialogue over is completed");
            dialogueUI?.SetActive(false);
        }
    }
}
