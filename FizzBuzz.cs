const int MAX_COUNT = 100;
int[] nums = {3, 5};
string[] words = {"Fizz", "Buzz"};

for (int i = 0; i <= MAX_COUNT; i++) {
    string output = "";
    for (int j = 0; j < nums.Length; j++)
    {
        if (i % nums[j] == 0) {
            output += words[j];
        }
    }
    //if output is empty, write the current number, else write output
    Console.WriteLine(output == "" ? i : output);
}