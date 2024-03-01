namespace UnityTestApp.Services
{
    public class ReplacementLevel1 : ReplacementBase
    {
        public override string Replacement(int number)
        {
            replacementBuilder = new System.Text.StringBuilder();
            AppendBasicReplacement(number);
            return replacementBuilder.ToString();
        }
    }
}
