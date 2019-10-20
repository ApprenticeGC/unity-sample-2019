namespace GiantCroissant.DialogueThroughTimeline.EventApproachRepeatDialogue
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;

    public class DialogueSignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public CutSceneManager cutSceneManager;

        public GameObject dialogueGO;
        public UnityEngine.UI.Text conversationText;
        
        private PlayableDirector _playableDirector;

        private void Start()
        {
            cutSceneManager.StartDialogue += CutSceneManagerOnStartDialogue;
            _playableDirector = GetComponent<PlayableDirector>();
        }

        private void OnDestroy()
        {
            cutSceneManager.StartDialogue -= CutSceneManagerOnStartDialogue;
        }

        private void CutSceneManagerOnStartDialogue(object sender, string e)
        {
            conversationText.text = e;
            _playableDirector.time = 0;
            _playableDirector.Stop();
            _playableDirector.Evaluate();
    
            _playableDirector?.Play();
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
            //
            Debug.Log($"Notified that the timeline - Dialogue is completed");
            dialogueGO?.SetActive(false);
            cutSceneManager.DialogueCompleted();
        }
    }
}
