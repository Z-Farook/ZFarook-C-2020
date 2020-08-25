using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericsBasics
{
    #region/*============================================ Generic Interfaces=======================================================*/
    interface IFakeNews<T>
    {
        static void PrintFakeChannels() { }

        string GetName { get; }
        string IschannelFake { get; }
    }

    internal class Channel
    {
        public string Name { get; private set; }
        public bool IsChannelFake { get; private set; }

        public static Channel[] broadCasters = new Channel[3]
        {
             new Channel{Name = "BBC", IsChannelFake = true},
             new Channel{Name = "CNN", IsChannelFake = true},
             new Channel { Name = "FOX", IsChannelFake = false },
        };

    }

    internal class StationCollection : Channel, IFakeNews<Channel>
    {
        public string GetName { get => Name; }

        public string IschannelFake { get => IschannelFake; }

        public static void PrintFakeChannels()
        {
            foreach (var item in Channel.broadCasters)
            {
                Console.WriteLine($"Channel name: {item.Name} \nBroadcast fakeInfo: {item.IsChannelFake}\n");
            }
        }
    }
    #endregion

    #region/*============================================ Covariance with Generic Interfaces=======================================================*/
    //The covariance deals with the returns types that is: the type T will determine the returning types of the interface methods 

    /**A GENERIC INTERFACE IS COVARIANT (from more specific to more generic) IF the generic type is annotated with the OUT KEYWORD. */
    interface IPlants<out T>
    {
        /**note the next one line is nothing much than EXTENSION FUNCTION LIKE  signature!!  like it can be called like MYCLASS[1] and it be executed
         * you MIGHT ASK WHY there are no "()". The ANSWER TO THIS IS THAT it is being defined with auto property which off course implicit */
        T this[int index] { get; }
        int Count { get; }
        string Name { get; }
        //void PrintNames();
    }

    internal class Plant
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return $"Plant name: {Name}, Color: {Color}";
        }
    }
    internal class Flower : Plant
    {

    }

    internal class TreeCollection : IPlants<Flower>
    {
        private Flower[] plantData = new Flower[2]{
          new Flower {Name = "Roos", Color= "Red"}  ,
          new Flower {Name = "Casa Blanca'", Color= "White"}  ,
        };

        private static TreeCollection treeCollection;

        public int Count => plantData.Length;

        string IPlants<Flower>.Name => throw new NotImplementedException();

        public static TreeCollection GetTreeCollection() => treeCollection ?? (treeCollection = new TreeCollection());

        /**The implementation of the EXTENSION METHOD from the interface!!!!!  */
        public Flower this[int index]
        {
            get
            {
                if (index < 0 || index > plantData.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));

                }
                return plantData[index];
            }
        }

        //public void PrintNames()
        //{

        //    foreach (var item in plantData)
        //    {
        //        Console.WriteLine($"Plant name: {item.Name}, Color: {item.Color}");
        //    }
        //}

    }
    #endregion

    #region/*============================================ Contra-Variance  with Generic Interfaces=======================================================*/
    //The Contra-Varianc deals with the parameters types that is: the type T will determine the parameter types of the interface methods 

    /**We WILL USE THE CLASSES DEFINED ABOVE  and only the interface is changed and classes name*/
    public interface IAnimals<in T>
    {
        void PrintPalntInfo(T[] arg);
        int Count { get; }
    }
    internal class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
    internal class Quadruped : Animal
    {

    }
    internal class Zoo : IAnimals<Animal>
    {
        public static Animal[] GetAnimal { get => zooData; }

        private static Quadruped[] zooData = new Quadruped[2]{
          new Quadruped {Name = "Horse 1", Color= "Red"}  ,
          new Quadruped {Name = "Zebra", Color= "White and black"}  ,
        };

        private static Zoo AnimalCollection;

        public int Count => zooData.Length;


        public static Zoo GetAnimalCollection() => AnimalCollection ?? (AnimalCollection = new Zoo());

        public void PrintPalntInfo(Animal[] _object)
        {
            if (zooData.Length < 0)
                throw new ArgumentOutOfRangeException("There is no data!!!");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Plant name: {_object[i].Name}, Color: {_object[i].Color}");
            }
        }
    }

    #endregion  
}
