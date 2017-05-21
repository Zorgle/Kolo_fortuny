using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuzzleList = System.Collections.Generic.List<WheelOfFortune.WordBank.Puzzle>;

namespace WheelOfFortune
{
    class WordBank
    {
        public class Puzzle
        {
            public readonly string Filename;
            public readonly string Category;
            public readonly string Answer;
            public Puzzle(string filename, string category, string answer) { Filename = filename; Category = category; Answer = answer; }
        }
        private Dictionary<string, PuzzleList> _puzzleSets = new Dictionary<string, PuzzleList>();
        private PuzzleList _playedPuzzles = new PuzzleList();
        private Random _rand = new Random();
        public void AddPuzzle(string filename, string category, string answer)
        {
            if (!_puzzleSets.ContainsKey(filename))
            {
                _puzzleSets.Add(filename, new PuzzleList());
            }
            PuzzleList puzzles = _puzzleSets[filename];
            answer = RemoveUnhandledPunctuation(answer);
            puzzles.Add(new Puzzle(filename: filename, category: category, answer: answer));
        }
        private string RemoveUnhandledPunctuation(string phrase)
        {
            List<char> illegalChars = new List<char>();
            foreach (char ch in phrase)
            {
                // Check for stuff we allow
                if (char.IsLetter(ch)) { continue; }
                if (ch == ' ') { continue; }
                if (ch == '\'') { continue; }
                if (ch == '&') { continue; }
                if (ch == '-') { continue; }
                illegalChars.Add(ch);
            }
            foreach (char ch in illegalChars)
            {
                phrase = phrase.Replace(ch.ToString(), "");
            }
            return phrase;
        }
        public int PuzzlesRemaining { get { return _puzzleSets.Sum(x => x.Value.Count); } }
        public Puzzle GetPuzzle()
        {
            // Choose a random set
            int set = _rand.Next(0, _puzzleSets.Count);
            var puzzles = RandomValues(_puzzleSets).Take(1).First();
            if (puzzles.Count == 0) { throw new Exception("Error: got empty puzzle list"); }
            // Choose a random word from set
            int wordIndex = _rand.Next(0, puzzles.Count);
            var puzzle = puzzles[wordIndex];
            _playedPuzzles.Add(puzzle);
            puzzles.RemoveAt(wordIndex);
            if (puzzles.Count == 0)
            {
                _puzzleSets.Remove(puzzle.Filename);
            }
            return puzzle;
        }
        public static IEnumerable<TValue> RandomValues<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            Random rand = new Random();
            List<TValue> values = Enumerable.ToList(dict.Values);
            int size = dict.Count;
            while (true)
            {
                yield return values[rand.Next(size)];
            }
        }
    }
}
