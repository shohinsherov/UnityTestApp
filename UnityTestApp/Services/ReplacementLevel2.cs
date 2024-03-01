using System.Text;

namespace UnityTestApp.Services
{
    public class ReplacementLevel2 : ReplacementBase
    {
        public override string Replacement(int number)
        {
            replacementBuilder = new StringBuilder();

            if (number % 4 == 0)
                replacementBuilder.Append("muzz");
            if (number % 7 == 0)
                replacementBuilder.Append(replacementBuilder.Length == 0 ? "guzz" : "-guzz");

            AppendBasicReplacement(number);

            return replacementBuilder.ToString();
        }
    }
}
