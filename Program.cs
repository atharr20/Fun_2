// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Arrays

int[] array; // Declared without initializing a size
array = new int[] {0,1,2,3,4,5,6,7,8,9}; // We can now fill the array by using the new operator


string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};


bool[] myArray2;
myArray2 = new bool[10];

    for ( int i=0; i<myArray2.Length; i++){
        if(i%2 == 0){
            myArray2[i]=true;
        }
        else {
            myArray2[i]=false;
        }
    }
Console.WriteLine("[{0}]",string.Join(", ",myArray2));


//Lists

// Initializing an empty list of Ice cream flavors that expects string values
List<string> iceCream = new List<string>();
// Use the Add function in a similar fashion to push
iceCream.Add("Mint");
iceCream.Add("CookiesandCream");
iceCream.Add("Coffee");
iceCream.Add("Vanilla");
iceCream.Add("Chocolate");
iceCream.Add("Ferrero Rocher");
iceCream.Add("Fudge");

//Output the length of the list
Console.WriteLine(iceCream.Count);
// Accessing a generic list value is the same as an array
Console.WriteLine(iceCream[2]); //Prints "Coffee", remember we start at 0!
iceCream.RemoveAt(2);
Console.WriteLine(iceCream.Count); //Prints new Array!

// To get the size of a List, we use Count instead of Length
Console.WriteLine($"We currently know of {iceCream.Count} Ice cream flavors.");


//Dictionary

Dictionary<string,string> profile = new Dictionary<string,string>();
Random rand = new Random();
// We add values to our dictionary the same way we add in Lists
// But remember to specify the key AND value
// When we add, we first specify the key, then the value
profile.Add("Tim",iceCream[rand.Next(iceCream.Count)]);
profile.Add("Martin",iceCream[rand.Next(iceCream.Count)]);
profile.Add("Nikki",iceCream[rand.Next(iceCream.Count)]);
profile.Add("Sarah",iceCream[rand.Next(iceCream.Count)]);

// Now we can render the data like so
Console.WriteLine("Student profile");
// Notice how we use ["KeyName"] to pull the value out


    foreach(KeyValuePair<string,string> entry in profile)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }


