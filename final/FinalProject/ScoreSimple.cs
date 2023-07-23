using System;

public class ScoreSimple : ScoringRules
{
    private int score;

    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        score = numGuesses;
        return score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your score: {score} ");
    }




}