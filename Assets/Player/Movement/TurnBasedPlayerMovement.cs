﻿using UnityEngine;

namespace TheLurkingDev.Player.Movement2D
{
    public class TurnBasedPlayerMovement : PlayerMovementBase
    {
        private void Start()
        {
            BaseStart();
        }

        private void Update()
        {
            var movementVector = GetMovementDirectionFromKeyboardInput();
            if (movementVector != Vector2.zero)
            {
                Move(movementVector);
                PlayWalkAnimationOnce(movementVector);
                PlayFootstepAudioClipOnce();
            }
            else
            {
                base.PlayIdleAnimation();
            }
        }

        protected override Vector2 Move(Vector2 movementVector)
        {
            _transform.Translate(movementVector);            

            return _transform.position;
        }

        protected override Vector2 GetMovementDirectionFromKeyboardInput()
        {
            float moveX = 0f;
            float moveY = 0f;

            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveY = +1f;
            }
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveY = -1f;
            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveX = -1f;
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveX = +1f;
            }

            return new Vector2(moveX, moveY).normalized;
        }
    }
}
