using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Curtis_Simple_Ping_Pong
{
    public static class GameDataUtility
    {
        public static GameRepo LoadRepo(string filePath)
        {
            var reader = new XmlSerializer(typeof(GameRepo));
            using (FileStream input = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (input.Length == 0)
                    return new GameRepo { GameHistory = new List<Game>() };
                return reader.Deserialize(input) as GameRepo;
            }
        }
        public static void SaveRepo(GameRepo repo, string filePath)
        {
            var writer = new XmlSerializer(typeof(GameRepo));
            using (FileStream file = File.OpenWrite(filePath))
            {
                writer.Serialize(file, repo);
            }
        }
    }
}
