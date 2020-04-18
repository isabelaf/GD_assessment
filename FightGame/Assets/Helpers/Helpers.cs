﻿namespace Assets.Helpers
{
    public class Characters
    {
        public const string Witch = "character_witch";
        public const string Warrior = "character_warrior";
        public const string Enemy = "character_enemy";
    }

    public class CharacterAttacks
    {
        public const string Magic = "characterAttack_magic";
        public const string Shuriken = "characterAttack_shuriken";
    }

    public class CharacterAnimatorParameters
    {
        public const string Movement = "isMoving";
        public const string Death = "isDead";
    }

    public class Scenes
    {
        public const string FightScene = "FightScene";
        public const string TreasureScene = "TreasureScene";
    }

    public class SceneObjects
    {
        public const string SceneManager = "sceneManager";
        public const string GameOverText = "text_gameOver";
        public const string TreasureSceneTreasure = "prop_treasure";
    }

    public class FightSceneMessages
    {
        private const string gameOverMessage = "Congrats, {0}! Press Space to go to the next level.";

        public static string GameOverMessage(string winnerName)
        {
            return string.Format(gameOverMessage, winnerName);
        }
    }

    public class TreasureSceneMessages
    {
        public const string WinMessage = "Congrats! You got the treasure!";
        public const string LoseMessage = "Oh, no! The dragon captured you!";
        public const string GameOverMessage = "Press Space to play again or Esc to exit the game.";
    }

    public class Tags
    {
        public const string Character = "character";
        public const string Obstacle = "obstacle";
    }

    public class PlayerPrefsKeys
    {
        public const string FightSceneLoser = "fight_scene_loser";
    }

    public class HealthBar
    {
        private const string healthBarName = "healthBar_{0}";

        public const int MaxHP = 100;
        public const int MaxStamina = 100;
        public const string HPHealthBar = "hp";
        public const string StaminaHealthBar = "stamina";

        public static string HealthBarName(string characterName)
        {
            return string.Format(healthBarName, characterName);
        }
    }

    public enum CharacterAction : int
    {
        Dodge = 0,
        Attack = 1
    };
}