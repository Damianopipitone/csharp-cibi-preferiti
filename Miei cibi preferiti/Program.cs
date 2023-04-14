// Inserire i cibi preferiti in un array (max 10)
// Stampare la lunghezza della classifica
// sgtampare tutto l'array (cibi classificati)
// Cibo top
// Cibo bottom

string[] favouriteFood = { "Pizza", "Sushi", "Hamburger", "Patate", "Pasta", "Gelato" };

classification(favouriteFood);

lenght(favouriteFood);

firstElement(favouriteFood);

lastElement(favouriteFood);






// ------- FUNZIONI -------

void classification (string[] array)
{ 
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine((i + 1) + "° - " + array[i]);
    } 

}

void lenght (string[] array)
{
    for (int i = 0;i < array.Length; i++)
    {
        Console.WriteLine((i + 1));
    }
}

void firstElement(string[] array)
{
    Console.WriteLine(array[0]);    
}

void lastElement(string[] array)
{
    Console.WriteLine(array[array.Length - 1]);
}