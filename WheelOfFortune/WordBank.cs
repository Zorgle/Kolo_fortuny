using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WheelOfFortune
{
    class WordBank
    {
        public class Puzzle
        {
            public readonly string Category; public readonly string Answer;
            public Puzzle(string category, string answer) { Category = category; Answer = answer; }
        }
        private List<Puzzle> _puzzles = new List<Puzzle>();
        private List<Puzzle> _playedPuzzles = new List<Puzzle>();
        private Random _rand = new Random();
        public void AddPuzzle(string category, string answer)
        {
            _puzzles.Add(new Puzzle(category: category, answer: answer));
        }
        public int PuzzlesRemaining { get { return _puzzles.Count; } }
        public Puzzle GetPuzzle()
        {
            if (_puzzles.Count == 0) { throw new Exception("Out of puzzles"); }
            int wordIndex = _rand.Next(0, _puzzles.Count);
            var puzzle = _puzzles[wordIndex];
            _playedPuzzles.Add(puzzle);
            _puzzles.RemoveAt(wordIndex);
            return puzzle;
        }
    }
}
