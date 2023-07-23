using System;

public class ScoreBoard
{
    private ScoringRules scoringRules;

    public ScoreBoard(ScoringRules scoringRules)
    {
        this.scoringRules = scoringRules;
    }

    public void DisplayScore(int numGuesses, List<string> letters, string word)
    {
        int score = scoringRules.CalculateScore(numGuesses, letters, word);
        scoringRules.ShowScore();

    }


}