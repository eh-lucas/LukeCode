using LukeCode.ArraysAndHashing;

Dictionary<int,string> categories = new()
{
    { 1, "Arrays & Hashing" },
};

// Printing category choices
Console.WriteLine("Choose category typing the related number:");
foreach (var category in categories)
{
    string message = string.Concat(category.Key, " for ", category.Value);
    Console.WriteLine(message);
}


var valid = false;
int chosenCategory = 0;

// Getting user category response
while (!valid)
{
    // Reads user response
    var categoryResponse = Console.ReadLine();
    
    if (categoryResponse is null)
    {
        RespondError();
        break;
    }

    if (int.TryParse(categoryResponse, out var result))
        chosenCategory = result;

    if (categories.Keys.Contains(chosenCategory))
        valid = true;
    else
    {
        RespondError();
        break;
    }
}

switch (chosenCategory)
{
    case 1: ContainsDuplicate.RunReturningIfCodeIsCorrect();
        break;

    _: ContainsDuplicate.RunReturningIfCodeIsCorrect();
}
void RespondError()
{
    Console.WriteLine("Type a valid number, options being:");
    foreach (var category in categories)
    {
        var message = string.Concat(category.Key, " - ", category.Value);
        Console.WriteLine(message);
    }
}
