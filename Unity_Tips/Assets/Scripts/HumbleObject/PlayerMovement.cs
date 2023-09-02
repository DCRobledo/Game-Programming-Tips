using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.HumbleObject
{
    public class PlayerMovement
    {
        private IPlayer _player;


        public PlayerMovement(IPlayer player)
        {
            _player = player;
        }


        public void Move(float direction)
        {
            _player.Position += Vector3.right * direction;

            if(_player.Position.x > _player.HorizontalMaxLimit)
            {
                _player.Position = new Vector3(_player.HorizontalMaxLimit, _player.Position.y, _player.Position.z);
            }

            if(_player.Position.x < _player.HorizontalMinLimit)
            {
                _player.Position = new Vector3(_player.HorizontalMinLimit, _player.Position.y, _player.Position.z);
            }
        }
    }
}