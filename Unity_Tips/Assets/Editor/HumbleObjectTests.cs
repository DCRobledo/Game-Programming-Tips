using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Patterns.HumbleObject
{
    public class HumbleObjectTests
    {
        [Test]
        public void PlayerMovesRight()
        {
            IPlayer player = new MockPlayer() { HorizontalMaxLimit = 5f, HorizontalMinLimit = -5f };
            PlayerMovement playerMovement = new PlayerMovement(player);

            playerMovement.Move(2f);
            Assert.AreEqual(2f, player.Position.x);
        }

        [Test]
        public void PlayerMovesLeft()
        {
            IPlayer player = new MockPlayer() { HorizontalMaxLimit = 5f, HorizontalMinLimit = -5f };
            PlayerMovement playerMovement = new PlayerMovement(player);

            playerMovement.Move(-2f);
            Assert.AreEqual(-2f, player.Position.x);
        }

        [Test]
        public void PlayerStopsAtHorizontalMaxLimit()
        {
            IPlayer player = new MockPlayer() { HorizontalMaxLimit = 5f, HorizontalMinLimit = -5f };
            PlayerMovement playerMovement = new PlayerMovement(player);

            playerMovement.Move(15f);
            Assert.AreEqual(5f, player.Position.x);
        }

        [Test]
        public void PlayerStopsAtHorizontalMinLimit()
        {
            IPlayer player = new MockPlayer() { HorizontalMaxLimit = 5f, HorizontalMinLimit = -5f };
            PlayerMovement playerMovement = new PlayerMovement(player);

            playerMovement.Move(-15f);
            Assert.AreEqual(-5f, player.Position.x);
        }
    }
}