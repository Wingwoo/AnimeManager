using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime
{
    public static class AnimeManager {
        static string saveLocation;
        public static List<Anime> animes = new List<Anime> { };

        public static void initialize() {
            saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnimeLoader";
            if (!File.Exists(saveLocation)) {
                Directory.CreateDirectory(saveLocation);
            }
            saveLocation += "\\animes.txt";

            load();
        }

        public static void addAnime(string name, string URL) {
            Anime anime = new Anime(name, URL);
            animes.Add(anime);
            save();
        }

        public static void removeAnime(int index) {
            animes.RemoveAt(index);
            save();
        }

        public static void editAnime(int index, string name, string URL) {
            animes[index].name = name;
            animes[index].URL = URL;
            save();
        }

        static void save() {
            string encodedData = JsonConvert.SerializeObject(animes);
            File.WriteAllText(saveLocation, encodedData);
        }

        static void load() {
            if (File.Exists(saveLocation)) {
                string encodedData = File.ReadAllText(saveLocation);
                animes = JsonConvert.DeserializeObject<List<Anime>>(encodedData);
            }
        }

    }
}
