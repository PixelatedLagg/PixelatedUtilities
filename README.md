# PixelatedUtilities
### PixelatedUtilities is a library of convenient methods intended to add on to the .Net framework. Below are all of the functionalities that PixelatedUtilities provides.
### _Any ideas for methods or types? Contact me on Discord: Pixelated_Lagg#8321_


## Pack
### A pack is a type inspired by keyvaluepair that stores 2 values of any type.
### Example:

```
Pack<int, int> pack = new Pack<int, int>(); //Initializes a new pack
pack.SetValues(1, 2); //Sets both values
pack.Value1 = 1; //Sets value 1 individually
pack.Value2 = 2; //Sets value 2 individually
var type = pack.GetType(); //Gets the type of pack

Console.WriteLine(pack.Value1);
Console.WriteLine(pack.Value2);
Console.WriteLine(type);
```

### Output:

```
1
2
PixelatedUtilities.Pack`2[System.Int32,System.Int32]
```


## Numbers
### Some extra methods for numbers.
### Example:

```
string result = Number.EvenOrOdd(7); //Returns "even" if even, and "odd" if odd
int random = Number.RandomInt(1, 3); //Generates a random integer than can include the min value and max value

Console.WriteLine(result);
Console.WriteLine(random);
```

### Output:

```
odd
3
```


## Dictionaries
### Some extra methods for dictionaries.
### Example:

```
//still bug fixing a get-key-by-value method
Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("a", 1);
dict.Add("b", 2);
dict.Add("c", 3);
double sum = dict.ValueSum(); //Returns the sum of all values in a dictionary with numeric values
KeyValuePair<string, int> random = dict.RandomPair(); //Returns a random pair from a specified dictionary

Console.WriteLine(sum);
Console.WriteLine(random);
```


### Output:

```
6
[a, 1]
```
## Updates

### Coming in v0.1
```
- Pack

- Number Methods

- Dictionary Methods
```
