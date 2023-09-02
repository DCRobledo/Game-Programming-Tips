using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Builder
{
    public class NPCBossFight : MonoBehaviour
    {
        public void OnFightBegin()
        {
            // Create the tarnished builder
            TarnishedBuilder tarnishedBuilder = new TarnishedBuilder();

            // Build the player's tarnished
            Tarnished playerTarnished = tarnishedBuilder
                .WithArmor(ArmorLocations.HEAD,  new LightArmor())
                .WithArmor(ArmorLocations.ARMS,  new LightArmor())
                .WithArmor(ArmorLocations.CHEST, new HeavyArmor())
                .WithArmor(ArmorLocations.LEGS,  new HeavyArmor())
                .WithWeapon(new Sword())
                .WithHealth(50)
                .Build();

            // Build the NPC to fight (same as player's but a little bit stronger)
            Tarnished NPCTarnished = tarnishedBuilder
                .WithHealth(70)
                .Build();

            StartFight(playerTarnished, NPCTarnished);
        }

        private void StartFight(Tarnished player, Tarnished NPC)
        {
            // Pelien
        }
    }
}