using System;
using System.Collections.Generic;

namespace cours_1
{
    public enum Types {Legume, Meat, Sauce, Fish, SeaFood};
    public class Ingredient{
        public Ingredient(String name, Types type){
            Name = name;
            Type = type;
        }
        public string Name { get; set; }
        public Types Type { get; set; }
    }

    public class Kebab {
        public List<Ingredient> Ingredients { get; set; }

        public Kebab(){
            Ingredients = new List<Ingredient>();
        }

        public bool isVegie(){
            for(int i = 0; i<Ingredients.Count; i++){
                if(Ingredients[i].Type==Type.Viande){
                    return false;
                }
            }
            return true;
        }

        public bool isPescetarian(){
            bool isVeg=true;;
            for(int i = 0; i<Ingredients.Count; i++){
                if(Ingredients[i].Type==Type.Viande){
                    return false;
                }
                if(Ingredients[i].Type==Type.SeaFood ||Ingredients[i].Type==Type.Fish){
                    isVeg=false;
                }
            }
            return !isVeg;
        }

        public Kebab sansOignon()
            {
                for (int i = 0; i < Ingredients.Count; i++)
                {
                    if (String.Equals(String.toLower(Ingredients[i].Name),"oignon"))
                    {
                        Ingredients.Remove(Ingredients[i]);
                    }
                }
                //Return kebab
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kebab myKeb = new Kebab();
            myKeb.Ingredients.Add(new Ingredient("salade", Type.Legume));
            myKeb.Ingredients.Add(new Ingredient("tomate", Type.Legume));
            myKeb.Ingredients.Add(new Ingredient("oignon", Type.Legume));
            myKeb.Ingredients.Add(new Ingredient("algerienne", Type.Sauce));
            myKeb.Ingredients.Add(new Ingredient("Poulet paprika", Type.Viande));
        
            Console.WriteLine(myKeb.isVegie());     
        }
    }
}
