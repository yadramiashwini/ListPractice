namespace ListPractice
{

    public class ListPractice
    {

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("ashwini"); list.Add("avinash"); list.Add("abhishek"); list.Add("sakshyyyy");

            foreach (var names in list)
            {
                Console.WriteLine(names);
            }

        }
    }
}
            
