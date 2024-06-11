namespace Ch1_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] ints = { 1, 2, 3  , 4 , 5 , 6 ,  7 , 8 , 9 , 10  };
            Console.WriteLine(BinarySearch(ints , 1));


        }

        // **************************   

        private static int BinarySearch(int[] Data  , int value )
        {
            int low = 0;    
            int high = Data.Length - 1 ;
            int mid = 0;
            int guess = 0; 
            while (low <= high)
             {
                mid = (low + high) / 2;
         
                guess = Data[mid];  

                if (guess  == value)
                    return mid;     
                else if (guess < value)
                    low = mid  + 1 ;
                else 
                    high = mid - 1 ;    
            
             }

            return -1; 
        }


        private static int BinarySearchPhone (string[] names , string value )
        {

            int low = 0;    
            int high = names.Length - 1; 
            int mid = 0;    
            string  guess = ""; 
            while (low <= high)      
             {
                mid = (high + low) / 2; 
                guess = names[mid];

                if (guess == value)
                    return mid;
                else if (guess.CompareTo(value) == -1)  
                    low = mid + 1;
                else
                    high = mid - 1; 
             }

            return -1; 
            
        }
    }
}
