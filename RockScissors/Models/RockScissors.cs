using System;
using System.Collections.Generic;

namespace TheGame
{
    public class Game
    {
        private string _playerOneChoice;
        private string _playerTwoChoice;

        private string _gameWinner;
        private string[] _rock;

        private Dictionary<string[], string> _outcomesDictionary = new Dictionary<string[], string>();
        _outcomesDictionary = {{{"rock", "scissors"}, "rock"}, {{"paper", "rock"}, "paper"}, {{"paper", "scissors"}, "scissors"}};

        public void SetPlayerOneChoice(string choice)
        {
            _playerOneChoice = choice;
        }
        public void SetPlayerTwoChoice(string choice)
        {
            _playerTwoChoice = choice;
        }
        public void SetWinner()
        {
            if (_playerOneChoice == _playerTwoChoice)
            {
                _gameWinner = "draw";
            }
            if (_playerOneChoice == "rock")
            {
                if (_playerTwoChoice == "scissors")
                {
                    _gameWinner = "playerOne";
                }
                if (_playerTwoChoice == "paper")
                {
                    _gameWinner = "playerTwo";
                }
            }
            if (_playerOneChoice == "scissors")
            {
                if (_playerTwoChoice == "rock")
                {
                    _gameWinner = "playerTwo";
                }
                if (_playerTwoChoice == "paper")
                {
                    _gameWinner = "playerOne";
                }
            }
            if (_playerOneChoice == "paper")
            {
                if (_playerTwoChoice == "rock")
                {
                    _gameWinner = "playerOne";
                }
                if (_playerTwoChoice == "scissors")
                {
                    _gameWinner = "playerTwo";
                }
            }
        }

        public string GetPlayerOneChoice()
        {
            return _playerOneChoice;
        }

        public string GetPlayerTwoChoice()
        {
            return _playerTwoChoice;
        }
        public string GetGameWinner()
        {
            return _gameWinner;
        }

        public string AltSetWinner()
        {
            if (_playerOneChoice == _playerTwoChoice)
            {
                _gameWinner = "draw";
            }
            else
            {
                string[] matchup = new string[] {_playerOneChoice, _playerTwoChoice};
                Array.Sort(matchup);
                string winningWeapon = _outcomesDictionary[matchup];
                if(_playerOneChoice == winningWeapon)
                {
                    _gameWinner = "playerOne";
                }
                else
                {
                    _gameWinner = "playerTwo";
                }
            }
        }
    }
}