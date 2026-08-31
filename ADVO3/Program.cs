namespace ADVO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            ## Exercise 1: Student Grade Manager


            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //            // 2. Print collection, Count, first and last grade
            //            Console.WriteLine("Grades: " + string.Join(", ", grades));
            //            Console.WriteLine("Count: " + grades.Count);
            //            Console.WriteLine("First Grade: " + grades.First());
            //            Console.WriteLine("Last Grade: " + grades.Last());

            //            // 3. Sort ascending
            //            grades.Sort();
            //            Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));

            //            // 4. First grade above 90
            //            int firstAbove90 = grades.First(g => g > 90);
            //            Console.WriteLine("First Grade Above 90: " + firstAbove90);

            //            // 5. All grades below 75
            //            List<int> failingGrades = grades.Where(g => g < 75).ToList();
            //            Console.WriteLine("Failing Grades: " + string.Join(", ", failingGrades));

            //            // 6. Remove all failing grades
            //            grades.RemoveAll(g => g < 75);
            //            Console.WriteLine("After Removing Failing Grades: " + string.Join(", ", grades));

            //            // 7. Check if any grade equals 100
            //            bool has100 = grades.Any(g => g == 100);
            //            Console.WriteLine("Contains 100: " + has100);

            //            // 8. Create List<string>
            //            List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //            Console.WriteLine(string.Join(", ", gradeStrings));

//            ## Exercise 2: Leaderboard
//SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

//            // 1. Add players
//            leaderboard.Add(500, "Ahmed");
//            leaderboard.Add(200, "Sara");
//            leaderboard.Add(800, "Ali");
//            leaderboard.Add(350, "Mona");

//            // 2. Print all entries
//            foreach (var player in leaderboard)
//            {
//                Console.WriteLine($"{player.Key} = {player.Value}");
//            }

//            // 3. Access the first key and first value
//            Console.WriteLine("First Key: " + leaderboard.First().Key);
//            Console.WriteLine("First Value: " + leaderboard.First().Value);

//            // 4. Check if score 500 exists
//            Console.WriteLine("Score 500 Exists: " + leaderboard.ContainsKey(500));

//            // 5. Safely get player with score 999
//            if (leaderboard.TryGetValue(999, out string playerName))
//                Console.WriteLine("Player: " + playerName);
//            else
//                Console.WriteLine("Player not found");

//            // 6. Remove score 200 and print updated list
//            leaderboard.Remove(200);

//            foreach (var player in leaderboard)
//            {
//                Console.WriteLine($"{player.Key} = {player.Value}");
//            }


        }
    }
}
