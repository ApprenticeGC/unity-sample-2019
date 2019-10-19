namespace GiantCroissant.InputSystemFirstLook
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PauseHud : MonoBehaviour
    {
        public PlayerControl playerControl;
        public PlayerControlReactive playerControlReactive;

        private GameControls _gameControls;

        void Awake()
        {
            _gameControls = new GameControls();
        }

        void Start()
        {
            _gameControls.Hud.Resume.performed += context =>
            {
                HandleResumeButton();
            };
        }
        
        private void OnEnable()
        {
            _gameControls.Enable();
        }

        private void OnDisable()
        {
            _gameControls.Disable();
        }

        public void HandleResumeButton()
        {
            playerControl?.ResumeFromPausing();
            playerControlReactive?.ResumeFromPausing();
            gameObject.SetActive(false);
        }
    }
}
