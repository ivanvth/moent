namespace moent {
    class Program {
        static void Main(string[] args) {
            foreach (var arg in args) {
                try {
                    double input = Double.Parse(arg);
                    System.Console.WriteLine(Moent.Convert(input));
                } catch (Exception e) {
                    System.Console.WriteLine(e.Message + " (" + arg + ")");
                }
            }
        }
    }
}