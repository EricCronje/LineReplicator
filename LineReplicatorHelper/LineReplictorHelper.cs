using System.Text;
using System.Linq;

namespace LineReplicatorHelper
{
    public class LineReplictorHelper
	{
        public static  string FeedbackMessage { get; set; } = string.Empty;
        public static  string? Output {  get;}

        public IEnumerable<string>? Input { get;}
        public static string ReplacePaceHolder(string input, string template)
        {

            if (string.IsNullOrWhiteSpace(input)) { throw new Exception($"The {nameof(input)} field was empty. Please add a value."); }
            if (string.IsNullOrWhiteSpace(template)) { throw new Exception($"The {nameof(template)} field was empty. Please add a value."); }

            return template.Replace("$1", input);

		}

        public static string ReplacePaceHolderInList(IEnumerable<string> inputStrings, string Template)
        {
			if (!inputStrings.Any()) { throw new Exception($"The {nameof(inputStrings)} field was empty. Please add a vlaue."); }
			if (string.IsNullOrWhiteSpace(Template)) { throw new Exception ($"The {nameof(Template)} field was empty. Please add a vlaue."); }

			StringBuilder resultSB = new();
            foreach (var inputString in inputStrings.Where(inputString => inputString.Length > 0))
            {
                resultSB.AppendLine(ReplacePaceHolder(inputString, Template));
            }

            return resultSB.ToString();
        }

        public static string Feedback()
        {
			FeedbackMessage = FeedbackMessage.Length > 1 ? FeedbackMessage : "Success";
			return FeedbackMessage;
		}

        public static string AddPlaceHolderInTemplateIfInList(string[] inputLines, string template, string errorMessage = "Could not find an item to replace. Please add the placehoder $1 manually.")
        {
			if (inputLines.Length == 0) { throw new Exception($"The field {nameof(inputLines)} was empty. Please add a value."); }
			if (string.IsNullOrWhiteSpace(template)) { throw new Exception($"The field {nameof(template)} was empty. Please add a value."); }

            var input = inputLines.FirstOrDefault(p => template.Contains(p));
            if (string.IsNullOrWhiteSpace(input)) { throw new Exception(errorMessage); }

            return template.Replace(input, "$1");
        }
    }
}
