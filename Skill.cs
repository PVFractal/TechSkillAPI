using System.Text.RegularExpressions;

namespace TechSkillAPI
{
    class Skills
    {
        Dictionary<string, string[]> suggestionDict = new Dictionary<string, string[]>
        {
            { "default", new string[3] { "Skill not found", "Skill not found", "Skill not found" } },
            { "python", new string[3] { "Create a machine learning project with PyTorch", "Visualize some data with MatPlotLib", "Populate a Pandas Dataframe from a CSV, and clean the data" } },
            { ".net dotnet", new string[3] { "Create an ASP.NET web API", "Make a basic console app that suggests skills", "Create a basic web app" } },
            { "git", new string[3] { "Make use of GitHub Actions", "Make a branch and merge it with main", "Create and solve a merge conflict" } },
            { "linux", new string[3] { "Practice moving around the filesystem", "Create and edit a text file with the terminal", "Delete root" } },
            { "sql", new string[3] { "Practice making some queries", "Practice updating and deleting entries", "Make a database" } },
            { "aws amazon", new string[3] { "Interact with DynamoDB", "Make a lambda function", "Put something in an S3 bucket" } },
            { "node npm", new string[3] { "Make a basic web API", "Create a project that compiles TypeScript to a dist folder", "Make node go to an older version" } },
            { "c# csharp coctothorpe", new string[3] { "Make hello world", "Make a program that can read and write to a file", "Make a program with a class and an array" } },
            { "unity", new string[3] { "Make a basic platforming game", "Interact with some 3d physics", "Make a frictionless object" } },
            { "typescript", new string[3] { "Make a hello world program", "Use an interface in code", "Use a constant in a program" } },
            { "data_structures", new string[3] { "Make a graph in the programming language of your choice", "Make a linked list in the programming language of your choice", "Make a tree in the programming language of your choice" } },
            { "devops", new string[3] { "Make a project according to the DevOps principles", "Make a project according to the DevOps principles", "Make a project according to the DevOps principles" } },
            { "ai ml machine learning", new string[3] { "Use linear regression", "Use a neural network", "Use a decision tree" } },
            { "template", new string[3] { "s1", "s2", "s3" } },
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