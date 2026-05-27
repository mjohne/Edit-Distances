namespace EditDistancesApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        UpdateDistances();
    }

    private void InputTextChanged(object? sender, EventArgs e)
    {
        UpdateDistances();
    }

    private void UpdateDistances()
    {
        string first = textBoxInput1.Text;
        string second = textBoxInput2.Text;

        labelLcs.Text = $"LCS: {LongestCommonSubsequence(first, second)}";
        labelLevenshtein.Text = $"Levenshtein: {LevenshteinDistance(first, second)}";
        labelDamerauLevenshtein.Text = $"Damerau-Levenshtein: {DamerauLevenshteinDistance(first, second)}";
    }

    private static int LongestCommonSubsequence(string first, string second)
    {
        int[,] dp = new int[first.Length + 1, second.Length + 1];

        for (int i = 1; i <= first.Length; i++)
        {
            for (int j = 1; j <= second.Length; j++)
            {
                if (first[i - 1] == second[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp[first.Length, second.Length];
    }

    private static int LevenshteinDistance(string first, string second)
    {
        int[,] dp = new int[first.Length + 1, second.Length + 1];

        for (int i = 0; i <= first.Length; i++)
        {
            dp[i, 0] = i;
        }

        for (int j = 0; j <= second.Length; j++)
        {
            dp[0, j] = j;
        }

        for (int i = 1; i <= first.Length; i++)
        {
            for (int j = 1; j <= second.Length; j++)
            {
                int cost = first[i - 1] == second[j - 1] ? 0 : 1;
                dp[i, j] = Math.Min(
                    Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1),
                    dp[i - 1, j - 1] + cost);
            }
        }

        return dp[first.Length, second.Length];
    }

    private static int DamerauLevenshteinDistance(string first, string second)
    {
        int len1 = first.Length;
        int len2 = second.Length;
        int maxDist = len1 + len2;

        int[,] dp = new int[len1 + 2, len2 + 2];
        var lastRow = new Dictionary<char, int>();

        dp[0, 0] = maxDist;
        for (int i = 0; i <= len1; i++)
        {
            dp[i + 1, 0] = maxDist;
            dp[i + 1, 1] = i;
        }

        for (int j = 0; j <= len2; j++)
        {
            dp[0, j + 1] = maxDist;
            dp[1, j + 1] = j;
        }

        for (int i = 1; i <= len1; i++)
        {
            int matchColumn = 0;

            for (int j = 1; j <= len2; j++)
            {
                int lastMatchingRow = lastRow.GetValueOrDefault(second[j - 1], 0);
                int transpositionColumn = matchColumn;

                int cost;
                if (first[i - 1] == second[j - 1])
                {
                    cost = 0;
                    matchColumn = j;
                }
                else
                {
                    cost = 1;
                }

                dp[i + 1, j + 1] = Math.Min(
                    Math.Min(dp[i, j] + cost, Math.Min(dp[i + 1, j] + 1, dp[i, j + 1] + 1)),
                    dp[lastMatchingRow, transpositionColumn]
                    + (i - lastMatchingRow - 1)
                    + 1
                    + (j - transpositionColumn - 1));
            }

            lastRow[first[i - 1]] = i;
        }

        return dp[len1 + 1, len2 + 1];
    }
}
