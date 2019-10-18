namespace GiantCroissant.InputSystemFirstLook
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerControl : MonoBehaviour
    {
        public float moveSpeed;
        public GameObject laserPrefab;

        public Transform leftPoint;
        public Transform rightPoint;

        public GameObject pauseHud;
        
        private GameControls _gameControls;

        private bool _fromLeftPoint;

        private bool _pausing;

        void Awake()
        {
            _gameControls = new GameControls();
        }

        void Start()
        {
            _gameControls.Battle.Fire.performed += context =>
            {
                if (!_pausing)
                {
                    var createdInstance = GameObject.Instantiate(laserPrefab);
                    if (_fromLeftPoint)
                    {
                        createdInstance.transform.SetParent(leftPoint);
                        createdInstance.transform.localPosition = Vector3.zero;
                        createdInstance.transform.SetParent(null);
                    }
                    else
                    {
                        createdInstance.transform.SetParent(rightPoint);
                        createdInstance.transform.localPosition = Vector3.zero;
                        createdInstance.transform.SetParent(null);
                    }

                    _fromLeftPoint = !_fromLeftPoint;
                }
            };

            _gameControls.Battle.OpenHud.performed += context =>
            {
                if (!_pausing)
                {
                    _pausing = true;
                    pauseHud.SetActive(true);
                }
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

        void Update()
        {
            if (!_pausing)
            {
                var moveValue = _gameControls.Battle.Move.ReadValue<Vector2>();
                Move((moveValue));
            }
        }

        void Move(Vector2 direction)
        {
            if (direction.sqrMagnitude < 0.01)
            {
                return;
            }

            var adjustedDirection = direction * moveSpeed * Time.deltaTime;
            transform.position += new Vector3(adjustedDirection.x, adjustedDirection.y, 0);
        }

        public void ResumeFromPausing()
        {
            _pausing = false;
        }
    }
}
