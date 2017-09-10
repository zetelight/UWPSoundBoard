using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear(); //clear all before we add
            allSounds.ForEach(p => sounds.Add(p)); //add all sounds into sounds
            
        }

        public static void GetAllSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundcategory)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Category == soundcategory).ToList();
            //both ways same
            //allSounds.Where(p => p.Category == soundcategory).ToList();
            //(from sound in allSounds
            //where sound.Category == soundcategory
            //select sound).ToList();

            sounds.Clear(); //clear all before we add
            filteredSounds.ForEach(p => sounds.Add(p)); //add all sounds into sounds

        }


        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }

        public static void GetAllSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear(); //clear all before we add
            filteredSounds.ForEach(p => sounds.Add(p)); //add all sounds into sounds

        }
    }
}
