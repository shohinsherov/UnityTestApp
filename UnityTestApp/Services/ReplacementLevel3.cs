namespace UnityTestApp.Services
{
    public class ReplacementLevel3 : ReplacementBase
    {
        public override string Replacement(int number)
        {
            ReplacementLevel2 rpc2 = new ReplacementLevel2();
            return SortResult(rpc2.Replacement(number));
        }


        private string SortResult(string result)
        {
            if (result.Equals("fizz"))
                result = "dog";

            if (result.Equals("buzz"))
                result = "cat";

            if (result.StartsWith("fizz-buzz"))
                result = result.Replace("fizz-buzz", "good-boy");

            return result;
        }
    }
}
