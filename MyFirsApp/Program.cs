// Kommirida
// Rakendus küsib kasutal sisestada tema nime
// Rakendus tervitab kasutajat nimepidi


//Console.WriteLine("Hello, Viljar!");

Console.WriteLine("Enter your name:"); //Output
// Deklareerime muutuja
string userName;

// Kirjutame muutujasse andmed
userName = Console.ReadLine(); // Input
// Muutuja deklareerimine V2, ühtlesi loeme ka kohe andmed
// string userName = Console.ReadLine();

// Leoeme muutujast V1
Console.WriteLine("Hello" + ", " + userName + "!");
// String interpolation
// Loeme muutujast V2
Console.WriteLine($"Hello, {userName} !"); // Output