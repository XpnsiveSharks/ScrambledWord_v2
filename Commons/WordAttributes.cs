using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambledWord_v2.Commons
{
    public class WordAttributes : AttributesBase
    {
        
        public static WordAttributes[] GetArrayOfEasyWords()
        {
            WordAttributes[] WordsInfo = new WordAttributes[]
            {
                new WordAttributes{WORD = "apple", HINT = "A round, pomaceous fruit of the rose family, typically having a bright red or yellow skin and a crisp flesh."},
                new WordAttributes{WORD = "bird", HINT = "A warm-blooded vertebrate animal distinguished by feathers, toothless beaked jaws, the laying of hard-shelled eggs, a high metabolic rate, a four-chambered heart, and a well-developed forebrain."},
                new WordAttributes{WORD = "cat", HINT = "A small carnivorous mammal with a soft furry coat, a long tail, and retractable claws."},
                new WordAttributes{WORD = "dog", HINT = "A domesticated carnivorous mammal that typically has a long tail, an acute sense of smell, and a barking, howling, or whining voice."},
                new WordAttributes{WORD = "elephant", HINT = "The largest land animal, characterized by its long trunk, tusks, and large ears."},
                new WordAttributes{WORD = "flower", HINT = "The reproductive structure of a flowering plant, consisting of a stalk, a receptacle, petals, stamens, and a pistil."},
                new WordAttributes{WORD = "fish", HINT = "Any of a large, diverse group of cold-blooded aquatic animals with gills or other respiratory organs and fins or other means of locomotion."},
                new WordAttributes{WORD = "frog", HINT = "A tailless amphibian with a smooth, moist skin, strong legs for jumping, and a short body."},
                new WordAttributes{WORD = "girl", HINT = "A young female human being."},
                new WordAttributes{WORD = "horse", HINT = "A large, strong mammal with four hooves, typically used for riding or pulling carts or carriages."},
                new WordAttributes{WORD = "house", HINT = "A building designed for human habitation."},
                new WordAttributes{WORD = "ice", HINT = "The solid form of water."},
                new WordAttributes{WORD = "key", HINT = "A small metal object with notches or teeth that is used to operate a lock."},
                new WordAttributes{WORD = "milk", HINT = "A liquid produced by the mammary glands of mammals to nourish their young."},
                new WordAttributes{WORD = "moon", HINT = "The natural satellite of the Earth, visible at night by its reflected sunlight."},
                new WordAttributes{WORD = "mouth", HINT = "The opening at the front of the head through which food is taken in and speech is produced."},
                new WordAttributes{WORD = "nest", HINT = "A structure built by birds to lay their eggs and raise their young."},
                new WordAttributes{WORD = "nose", HINT = "The part of an animal's face that contains the nostrils and is used for smelling."},
                new WordAttributes{WORD = "ocean", HINT = "A vast body of salt water covering most of the Earth's surface."},
                new WordAttributes{WORD = "orange", HINT = "A round citrus fruit with a thick, orange-colored skin and a juicy, orange-colored flesh."},
                new WordAttributes{WORD = "pen", HINT = "A writing implement with a point that delivers ink to the writing surface."},
                new WordAttributes{WORD = "pig", HINT = "A domesticated omnivorous mammal with a thick, hairless skin, a short snout, and a curled tail."},
                new WordAttributes{WORD = "rain", HINT = "Water falling from the clouds as drops."},
                new WordAttributes{WORD = "river", HINT = "A large natural stream of water that flows through a land and eventually into a larger body of water, such as an ocean or a lake."},
                new WordAttributes{WORD = "sun", HINT = "The star at the center of the solar system, providing light and heat to the planets."},
                new WordAttributes{WORD = "table", HINT = "A piece of furniture with a flat top and one or more legs, used as a surface for eating, writing, or working at."},
                new WordAttributes{WORD = "tree", HINT = "A woody plant with a single stem or trunk, usually growing to a considerable height and supporting a mass of foliage."},
                new WordAttributes{WORD = "umbrella", HINT = "A collapsible circular device that is held over the head to provide protection from rain or sun."},
                new WordAttributes{WORD = "water", HINT = "A clear, colorless, odorless, and tasteless liquid that is the essential constituent of living organisms."},
                new WordAttributes{WORD = "window", HINT = "An opening in a wall or door that is fitted with glass or some other transparent material to admit light and allow people to see out."},
                new WordAttributes{WORD = "car", HINT = "A motor vehicle with four wheels, used for transporting passengers or goods."},
                new WordAttributes{WORD = "boat", HINT = "A small, open vessel for traveling on water."},
                new WordAttributes{WORD = "bike", HINT = "A two-wheeled vehicle propelled by the rider's feet."},
                new WordAttributes{WORD = "bus", HINT = "A large motor vehicle for carrying passengers by road."},
                new WordAttributes{WORD = "train", HINT = "A railway vehicle or a connected series of railway vehicles that moves on tracks to transport passengers or goods."},
                new WordAttributes{WORD = "airplane", HINT = "A heavier-than-air aircraft that is powered by an engine or engines and is able to maintain flight by the action of air passing over its wings."},
                new WordAttributes{WORD = "ball", HINT = "A spherical object used in games and sports."},
                new WordAttributes{WORD = "doll", HINT = "A small figure of a child, usually a girl, made of materials such as plastic, cloth, or porcelain."},
                new WordAttributes{WORD = "teddy bear", HINT = "A soft toy bear."},
                new WordAttributes{WORD = "video game", HINT = "A game played on a computer or electronic device"}
            };
            return WordsInfo;
        }
        public static WordAttributes[] GetArrayOfAverageWords()
        {
            WordAttributes[] WordsInfo = new WordAttributes[]
            {
                new WordAttributes{WORD = "Apple", HINT = "A round, pomaceous fruit of the rose family, typically having a bright red or yellow skin and a crisp flesh."},
                new WordAttributes{WORD = "Bird", HINT = "A warm-blooded vertebrate animal distinguished by feathers, toothless beaked jaws, the laying of hard-shelled eggs, a high metabolic rate, a four-chambered heart, and a well-developed forebrain."},
            };
            return WordsInfo;
        }
        public override string ToString()
        {
            return $"{WORD}\n{HINT}";
        }
    }
}
