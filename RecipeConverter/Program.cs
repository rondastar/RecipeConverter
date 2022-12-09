using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter
{
    internal class Program
    {
        public static string[] ingredients =
        {
            // array of ingredients
            "flour", // all-purpose
            "sugar", // granulated
            "brown sugar", // packed
            "baking soda",
            "baking powder",
            "powdered sugar",
            "caster sugar",
            "cornstarch", 
            "bread flour",
            "cake flour",
            "salt",
            "yeast", // active dry
            "butter"
        }; // ingredients[]
        public static string[] unitsUS =
        {
            // unit of measurement (1)
            "cup", // flour
            "cup", // sugar
            "cup", // brown sugar, packed
            "tsp", // baking soda
            "tsp", // baking powder
            "cup", // powdered sugar
            "cup", // caster sugar
            "cup", // cornstarch
            "cup", // bread flour
            "cup", // cake flour - same density as chopped nuts and chestnut flour
            "tsp", // salt
            "tsp", // yeast, dry
            "cup" // butter
        }; // unitsUS[]
        public static float[] UStoMetric =
        {
            // ratio to convert US unit to weight in grams
            128, // g/cup flour, all-purpose, using spoon into cup method
            200, // g/cup sugar, granulated
            220, // g/cup brown sugar, packed
            5, // g/tsp baking soda
            4.9F, // g/tsp baking powder
            125, // g/cup powdered sugar
            225, // g/cup caster sugar
            128, // g/tsp cornstarch, lightly spooned or sifted
            120, // g/cup bread flour
            115, // g/cup cake flour
            6.7F, // g/tsp salt
            3.1F, // g/tsp yeast, active dry
            230 // g/cup butter
        }; // UStoMetric[]
        public static string[] sourcesUStoMetric =
        {
            "https://www.cupcakeproject.com/how-much-does-a-cup-of-flour-weigh/", // flour, all-purpose
            "https://bakeschool.com/baking-conversions/", // cup sugar
            "https://bakeschool.com/baking-conversions/", // cup brown sugar, packed
            "https://web.archive.org/web/20150204074142/http://www.moderndomestic.com/2011/01/baking-math-common-baking-ingredient-weights/", // tsp baking soda
            "https://web.archive.org/web/20150204074142/http://www.moderndomestic.com/2011/01/baking-math-common-baking-ingredient-weights/", // tsp baking powder
            "https://bakeschool.com/baking-conversions/", // cup powdered sugar
            "https://www.traditionaloven.com/culinary-arts/sugars/castor-sugar/convert-us-measuring-cup-to-gram-g-castor-sugar.html", // cup castor sugar
            "https://freefoodtips.com/cornstarch-grams-to-spoons-and-cups/", // tsp cornstarch
            "https://www.kingarthurbaking.com/learn/ingredient-weight-chart", // cup bread flour
            "https://bakeschool.com/baking-conversions/", // cake flour
            "https://web.archive.org/web/20150204074142/http://www.moderndomestic.com/2011/01/baking-math-common-baking-ingredient-weights/", // tsp salt
            "https://web.archive.org/web/20150204074142/http://www.moderndomestic.com/2011/01/baking-math-common-baking-ingredient-weights/", // tsp yeast, dry
            "https://bakeschool.com/baking-conversions/" // butter
        }; //sourcesUStoMetric[]
        static void Main(string[] args)
        {
            BakingPanAreaRecipe();
        }
        public static void Menu()
        {
            bool menuLoop = true;
            while (menuLoop)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Temp: Celsius to Fahrenheit");
                Console.WriteLine("2 - Temp: Fahrenheit to Celsius");
                Console.WriteLine("3 - Ingredients: Convert US units to grams");
                Console.WriteLine("4 - Recipe: Scale by pan size");
                Console.WriteLine("5 - Recipe: Scale by servings");
                Console.WriteLine("e - Exit");
                Console.Write("Enter selection: ");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        // 1 - Temp: Celsius to Fahrenheit ***********
                        break;
                    case "2":
                        // 2 - Temp: Fahrenheit to Celsius ***************
                        break;
                    case "3":
                        // 3 - Ingredients: Convert US units to grams
                        break;
                    case "4":
                        // 4 - Recipe: Scale by pan size
                        break;
                    case "5":
                        // 5 - Recipe: Scale by servings
                        break;
                    case "e":
                        // exit menu - turn off loop
                        Console.WriteLine("Good bye");
                        menuLoop = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        break;
                }
            }
        }
        public static void CToF()
        {

        }
        public static float CelsiusToFahrenheit(float celsius)
        {
            // converts degrees celsius to fahrenheit, returns degrees fahrenheit
            float fahrenheit = celsius * (float)1.8 + 32;
            return fahrenheit; 
        }
        public static float FahrenheitToCelsius(float fahrenheit)
        {
            // converts degrees fahrenheit to celsius, returns degrees celsius
            float celsius = (fahrenheit - 32) / (float)1.8;
            return celsius;
        }
        public static float BakingPanAreaRecipe()
        {
            Console.WriteLine("Enter the dimensions of the baking pan in the recipe");
            Console.Write("Length: ");
            if (float.TryParse(Console.ReadLine(), out float panLengthRecipe));
            else
            {
                Console.WriteLine("Please enter a valid number.");
                BakingPanAreaRecipe();
            }
            Console.Write("Width: ");
            if (float.TryParse(Console.ReadLine(), out float panWidthRecipe));
            else
            {
                Console.WriteLine("Please enter a valid number.");
                BakingPanAreaRecipe();
            }
            float bakingPanAreaRecipe = panLengthRecipe * panWidthRecipe;
            return bakingPanAreaRecipe;
        }
        public static void BakingPanRecipeScaler()
        {
            Console.Write("Enter the dimensions of the pan you would like to use");
            Console.Write("Length: ");
            if (double.TryParse(Console.ReadLine(), out double panLengthDesired)) ;
            else
            {
                Console.WriteLine("Please enter a valid number.");
                BakingPanRecipeScaler();
            }
            Console.Write("Width: ");
            if (double.TryParse(Console.ReadLine(), out double panWidthDesired)) ;
            else
            {
                Console.WriteLine("Please enter a valid number.");
                BakingPanRecipeScaler();
            }
        }
   
    }
}
