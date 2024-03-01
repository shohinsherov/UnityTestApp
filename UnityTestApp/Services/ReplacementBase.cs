using System.Text;

namespace UnityTestApp.Services
{
    public abstract class ReplacementBase
    {
        protected StringBuilder replacementBuilder;

        protected ReplacementBase()
        {
            replacementBuilder = new StringBuilder();
        }

        public virtual List<string> GetReplacements(List<int> numbers)
        {
            if (numbers.Count == 0)
                throw new ArgumentNullException();

            return numbers.Select(Replacement).ToList();
        }

        public abstract string Replacement(int number);

        protected virtual void AppendReplacement(string replacement)
        {
            if (replacementBuilder.Length > 0)
            {
                replacementBuilder.Insert(0, "-");
            }
            replacementBuilder.Insert(0, replacement);
        }

        protected void AppendBasicReplacement(int number)
        {
            string basicReplacement = ReplacementLevel1(number);
            if (replacementBuilder.Length == 0 || basicReplacement != number.ToString())
            {
                AppendReplacement(basicReplacement);
            }
        }

        public virtual string ReplacementLevel1(int number)
        {
            StringBuilder replacementBuilder = new StringBuilder();

            if (number % 3 == 0)
                replacementBuilder.Append("fizz");
            if (number % 5 == 0)
                replacementBuilder.Append(replacementBuilder.Length == 0 ? "buzz" : "-buzz");

            if (replacementBuilder.Length == 0)
                replacementBuilder.Append(number);

            return replacementBuilder.ToString();
        }
    }
}
