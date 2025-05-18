

using System.Security.Cryptography;

namespace TechSkillAPI
{
    class Skills
    {
        Dictionary<string, string[]> suggestionDict = new Dictionary<string, string[]>
        {
            { "python", new string[3] { "Create a machine learning project with PyTorch", "Visualize some data with MatPlotLib", "Populate a Pandas Dataframe from a CSV, and clean the data" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } },
            { "sample", new string[3] { "s1", "s2", "s3" } }
        };


        public string SuggestSkill(string skillInput)
        {
            var parsedInput = ParseInput(skillInput);

            Random random = new Random();
            var randIndex = random.Next(1, 4);

            return suggestionDict[parsedInput][randIndex];
        }

        private string ParseInput(string skillInput)
        {
            var keys = suggestionDict.Keys;

            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            return skillInput;
        }

    }
}