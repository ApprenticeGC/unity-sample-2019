namespace GiantCroissant.DialogueThroughTimeline.EventApproachRepeatDialogue
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;

    public class MainOverSignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public CutSceneManager cutSceneManager;

        private PlayableDirector _playableDirector;

        private void Start()
        {
            cutSceneManager.FinishCutScene += CutSceneManagerOnFinishCutScene;
            _playableDirector = GetComponent<PlayableDirector>();
        }

        private void OnDestroy()
        {
            cutSceneManager.FinishCutScene -= CutSceneManagerOnFinishCutScene;
        }

        private void CutSceneManagerOnFinishCutScene(object sender, System.EventArgs e)
        {
            _playableDirector?.Play();
        }
        
        public void OnNotify(Playable origin, INotification notification, object context)
        {
            //
            Debug.Log($"Notified that the timeline - Main Over is completed");
            cutSceneManager.CutSceneFinishCompleted();
        }
    }
}
