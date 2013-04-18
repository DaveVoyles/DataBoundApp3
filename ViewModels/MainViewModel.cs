using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DataBoundApp3.Resources;

namespace DataBoundApp3.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.Items.Add(new ItemViewModel() {ID = "0", AItem = "A", AItemName = "Apple", ImageURI = "/Assets/Apple.jpg",  
                Description = "This fruit is a delicious addition to your diet. Eating one each day keeps the doctor away!", IsCompleted = false});
            this.Items.Add(new ItemViewModel() {ID = "1", AItem = "B", AItemName = "Banana",  ImageURI = "/Assets/Banana.jpg", 
                Description = "Monkeys are known to eat this fruit, after they peel it, of course", IsCompleted = false});
            this.Items.Add(new ItemViewModel() {ID = "2", AItem = "C", AItemName = "Carrot", ImageURI = "/Assets/Carrot.jpg",
                Description = "This vegatable can help to improve your eye sight!", IsCompleted = false });
            this.Items.Add(new ItemViewModel()
            {
                ID = "3",
                AItem = "D",
                AItemName = "Dog",
                ImageURI = "/Assets/Dog.jpg",
                Description = "These four legged friends are also known as 'man's best friend!'",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "4",
                AItem = "E",
                AItemName = "Elephant",
                ImageURI = "/Assets/Elephant.jpg",
                Description = "Known for their high intelligence, these African creatures love to eat peanuts and can be found at the circus!",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "5",
                AItem = "F",
                AItemName = "Foot",
                ImageURI = "/Assets/Foot.jpg",
                Description = "These are like hands, but at the the bottom of your legs. Don't forget to wear shoes!",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "6",
                AItem = "G",
                AItemName = "Goat",
                ImageURI = "/Assets/Goat.jpg",
                Description = "Often known to chew on a tin can, these mountain dwellers also usually have small horns.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "7",
                AItem = "H",
                AItemName = "Hat",
                ImageURI = "/Assets/Hat.jpg",
                Description = "People wear these on their head to keep the sun out of their eyes.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "8",
                AItem = "I",
                AItemName = "Igloo",
                ImageURI = "/Assets/Igloo.png",
                Description = "Eskimos create these out of ice and use them as a home!",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "9",
                AItem = "J",
                AItemName = "",
                ImageURI = "/Assets/Jeep.jpg",
                Description = "These trucks are American made, and greatly helped the military during World War II.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "10",
                AItem = "K",
                AItemName = "King",
                ImageURI = "/Assets/King.png",
                Description = "These royal rulers sat on a chair made of gold and lead great kingdoms",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "11",
                AItem = "L",
                AItemName = "Lock",
                ImageURI = "/Assets/Lock.jpg",
                Description = "These are used to seal a door and need a key to be opened.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
             {
                ID = "12",
                AItem = "M",
                AItemName = "Man",
                ImageURI = "/Assets/Man.jpg",
                Description = "This person is the opposite of a woman.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "13",
                AItem = "N",
                AItemName = "Number",
                ImageURI = "/Assets/Number.jpg",
                Description = "We use this to count!",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "14",
                AItem = "O",
                AItemName = "Octopus",
                ImageURI = "/Assets/Octopus.jpg",
                Description = "This sea creature has many tentacles used for swimming and eating.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "15",
                AItem = "P",
                AItemName = "Pawn",
                ImageURI = "/Assets/Pawn.jpg",
                Description = "This is the most basic chess piece, and begins in the front row.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "16",
                AItem = "Q",
                AItemName = "Quarter",
                ImageURI = "/Assets/Quarter.jpg",
                Description = "This bit of change is worth $0.25, or 25 cents.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "17",
                AItem = "R",
                AItemName = "Ruler",
                ImageURI = "/Assets/Ruler.jpg",
                Description = "This measuring stick is used to keep track of length.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "18",
                AItem = "S",
                AItemName = "Sun",
                ImageURI = "/Assets/Sun.jpg",
                Description = "This large yellow star keeps us warm during the day and provides light.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "19",
                AItem = "T",
                AItemName = "Turtle",
                ImageURI = "/Assets/Turtle.jpg",
                Description = "These reptiles can hide in their shell when frightened!",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "20",
                AItem = "U",
                AItemName = "UFO",
                ImageURI = "/Assets/UFO.jpg",
                Description = "These saucer-shaped ships are flown by aliens from another planet!",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "21",
                AItem = "V",
                AItemName = "Violin",
                ImageURI = "/Assets/Violin.jpg",
                Description = "This stringed musical insrument is played in the orchestra.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "22",
                AItem = "W",
                AItemName = "Water",
                ImageURI = "/Assets/Water.jpg",
                Description = "We use this liquid to quench our thirst.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "23",
                AItem = "X",
                AItemName = "Xylephone",
                ImageURI = "/Assets/Xylephone.jpg",
                Description = "This musical instrument is played by tapping on colorful keys",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "24",
                AItem = "Y",
                AItemName = "Yogurt",
                ImageURI = "/Assets/Yogurt.jpg",
                Description = "This delicious fruit cup is prepared with milk and often mixed with sugar.",
                IsCompleted = false
            });
            this.Items.Add(new ItemViewModel()
            {
                ID = "25",
                AItem = "Z",
                AItemName = "Zebra",
                ImageURI = "/Assets/Zebra.jpg",
                Description = "These animals have black and white stripes to blend in with one another.",
                IsCompleted = false
            });
                this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}