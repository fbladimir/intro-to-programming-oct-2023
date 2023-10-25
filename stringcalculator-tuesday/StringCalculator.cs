namespace StringCalculator;


public class StringCalculator
{
    //variables 
    string[] nums; //store split numbers

    int sum = 0; //start at 0, gets incremented in method

    //method signature
    public int Add(string numbers)
    {
        //checking if string is empty
        if (numbers == "")
        {
            return 0; //empty string will return 0 
        }
        else
        {
            if (numbers.Contains("-")) //if contains negative numbers
            {
                string negativeNumbers = ""; //string to store negative numbers 
                Console.WriteLine("negative numbers not allowed"); //display message to show negative numbers not allowed 

                nums = numbers.Split(','); //this splits number based on the comma (,) 

                for (int i = 0; i < nums.Length; i++)
                {
                    if (int.Parse(nums[i]) < 0)
                    {
                        //linking negative numbers 
                        negativeNumbers += nums[i] + "";
                    } //end if 
                } //end for 

                //display negative numbers 
                Console.WriteLine("Negative numbers are: " + negativeNumbers);
                return 0;

            } //end if

            else
            {
                nums = numbers.Split(","); //splitting numbers again based on "," 

                for (int i = 0; i < nums.Length; i++)
                {
                    if (int.Parse(nums[i]) >= 0 && int.Parse(nums[i]) <= 1000) //inclusive to 0 and 1000 (ignoring numbers greater than 1000) 
                    {
                        //add number to sum 
                        sum += int.Parse(nums[i]);

                    } //end if 
                } // end for

                return sum; //sum value is returned 

            } // end second else 

        } //end first else 


    }
}
