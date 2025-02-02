int [] nums = [];
string input = string.Empty;
int target = 0;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira um sequência de números, separados por vírgula:");
input = Console.ReadLine();
Console.WriteLine("Insira um target:");
target = int.Parse(Console.ReadLine());
nums = input.Split(',').Select(i => int.Parse(i.Trim())).ToArray();

int [] indices = TwoSum(nums, target);

foreach(int i in indices){
    Console.WriteLine(i);
}


int[] TwoSum(int[] nums, int target) {
        bool b;
        int[] resultado=[];

        for (int x = 0; x < nums.Length; x++){
            for (int y = x + 1; y < nums.Length; y++){
                b = nums[x] + nums[y] == target;
                
                if (b == true){
                    resultado = [x,y];
                    return resultado;
                }
            }
        }
        return resultado;
}
