using System;

class StaticArray {
    static void Main(String[] args) {
        // create this error due to the static array or string
        static int[] arr = new int[5];  // error CS0106: The modifier 'static' is not valid for this item 
        static string = "vijay";  //  error CS0106: The modifier 'static' is not valid for this item
    }
}
