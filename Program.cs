using System;
using System.Collections.Generic;

namespace cours_1
{
    public enum Types {Legume, Meat, Sauce, Fish, SeaFood, Fromage};

    public class Ingredient{
        public Ingredient(String name, Types type){
            Name = name;
            Type = type;
        }
        public string Name { get; set; }
        public Types Type { get; set; }

        public string getName(){
            return this.Name;
        }
        public Types getTypes(){
            return this.Type;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Kebab {
        public List<Ingredient> Ingredients { get; set; }

        public Kebab(){
            Ingredients = new List<Ingredient>();
        }

        public bool isVegie(){
            for(int i = 0; i<Ingredients.Count; i++){
                if(Ingredients[i].Type==Types.Meat || Ingredients[i].Type==Types.Fish){
                    return false;
                }
            }
            return true;
        }

        public bool isPescetarian(){
            bool isVeg=true;;
            for(int i = 0; i<Ingredients.Count; i++){
                if(Ingredients[i].Type==Types.Meat){
                    return false;
                }
                if(Ingredients[i].Type==Types.SeaFood ||Ingredients[i].Type==Types.Fish){
                    isVeg=false;
                }
            }
            return !isVeg;
        }

        public Kebab sansOignon()
            {
                for (int i = 0; i < Ingredients.Count; i++)
                {
                    if (Ingredients[i].getName().Equals("oignon"))
                    {
                        Ingredients.Remove(Ingredients[i]);
                    }
                }
                return this;
            }

        public Kebab suppFromage()
            {
                for (int i = 0; i < Ingredients.Count; i++)
                {
                    if (Ingredients[i].Type==Types.Fromage)
                    {
                        Ingredients.Add(Ingredients[i]);
                    }
                }
                return this;
            }

        public override string ToString()
            {
                string chaine = "";
                for (int i = 0; i < Ingredients.Count; i++)
                {
                    chaine+=Ingredients[i].getName() +"\t"+ Ingredients[i].GetType().ToString()+"\n"; 
                }
                return chaine;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kebab myKeb = new Kebab();
            myKeb.Ingredients.Add(new Ingredient("salade", Types.Legume));
            myKeb.Ingredients.Add(new Ingredient("tomate", Types.Legume));
            myKeb.Ingredients.Add(new Ingredient("oignon", Types.Legume));
            myKeb.Ingredients.Add(new Ingredient("algerienne", Types.Sauce));
            myKeb.Ingredients.Add(new Ingredient("oignon", Types.Legume));
            myKeb.Ingredients.Add(new Ingredient("Saumon", Types.Fish));
            myKeb.Ingredients.Add(new Ingredient("Cheddar", Types.Fromage));
        
        
            Console.WriteLine(myKeb.isVegie());    
            Console.WriteLine(myKeb.isPescetarian());     
            
            Console.WriteLine(myKeb.ToString());
            Console.WriteLine(myKeb.suppFromage().ToString());
            Console.WriteLine(myKeb.sansOignon().ToString());
        }
    }
}
