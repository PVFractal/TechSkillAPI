using System.Text.RegularExpressions;

namespace TechSkillAPI
{
    class Skills
    {
        Dictionary<string, string[]> suggestionDict = new Dictionary<string, string[]>
        {
            { "default", new string[3] { "Skill not found", "Skill not found", "Skill not found" } },
            { "python", new string[3] { "Create a machine learning project with PyTorch", "Visualize some data with MatPlotLib", "Populate a Pandas Dataframe from a CSV, and clean the data" } },
            { ".net", new string[3] { "s1", "s2", "s3" } },
            { "sample2", new string[3] { "s1", "s2", "s3" } },
            { "sample3", new string[3] { "s1", "s2", "s3" } },
            { "sample4", new string[3] { "s1", "s2", "s3" } },
            { "sample5", new string[3] { "s1", "s2", "s3" } },
            { "sample6", new string[3] { "s1", "s2", "s3" } },
            { "sample7", new string[3] { "s1", "s2", "s3" } },
            { "sample8", new string[3] { "s1", "s2", "s3" } },
            { "sample9", new string[3] { "s1", "s2", "s3" } }
        };


        public string SuggestSkill(string skillInput)
        {
            var parsedInput = ParseInput(skillInput);

            Random random = new Random();
            var randIndex = random.Next(0, 3);

            return suggestionDict[parsedInput][randIndex];
        }

        private string ParseInput(string skillInput)
        {
            // Getting the different tech skills to matcg
            var keys = suggestionDict.Keys;

            // Looping through the keys
            foreach (var key in keys)
            {

                // Going through the different matches in each key
                // Example: matplotlib and pyplot should map to the same skill, so it will try and match the input to both
                var matches = key.Split(" ");

                // Going over each match
                foreach (var match in matches)
                {
                    // Simple string contains regex
                    Regex regex = new Regex(match);
                    if (regex.IsMatch(skillInput.ToLower()))
                    {
                        return key;
                    }
                }
            }

            // If we don't find any, then we return the default
            return "default";
        }

    }
}