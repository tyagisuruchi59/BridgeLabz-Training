using System;

interface IMealPlan
{
    string GetMeal();
}

class VegetarianMeal : IMealPlan
{
    public string GetMeal()
    {
        return "Vegetarian Meal";
    }
}

class VeganMeal : IMealPlan
{
    public string GetMeal()
    {
        return "Vegan Meal";
    }
}

class Meal<T> where T : IMealPlan, new()
{
    public void GenerateMeal()
    {
        T meal = new T();
        Console.WriteLine(meal.GetMeal());
    }
}
