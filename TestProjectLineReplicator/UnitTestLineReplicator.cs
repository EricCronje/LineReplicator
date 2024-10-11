namespace TestProjectLineReplicator
{
    public class UnitTestLineReplicator
    {
        [Fact]
        public void ValidInput()
        {
            
            string result = LineReplicatorHelper.LineReplictorHelper.ReplacePaceHolder
                ("Bethesta" ,"cd $1/$1");
            string expected = "cd Bethesta/Bethesta";
            Assert.Equal(result, expected);
        }

        [Fact]
        public void ValidInputList()
        {
            IEnumerable<string> InputStrings =
                [
                "a",
                "b"
                ];
            string result = LineReplicatorHelper.LineReplictorHelper.ReplacePaceHolderInList
                (InputStrings, "cd $1/$1");
            string expected = "cd a/a\r\ncd b/b\r\n";
            Assert.Equal(result, expected);
        }

        [Fact]
        public void ValidInputListCheckFeedback()
        {
            IEnumerable<string> InputStrings =
                [
                "a",
                "b"
                ];
            string result = LineReplicatorHelper.LineReplictorHelper.ReplacePaceHolderInList
                (InputStrings, "cd $1/$1");
            result = LineReplicatorHelper.LineReplictorHelper.FeedbackMessage;
            string expected = "";
            Assert.Equal(result, expected);
        }

        [Fact]
        public void ValidAddPlaceHolderInTemplateIfInList()
        {
            string[] InputStrings =
                [
                "a",
                "b"
                ];
            string result = LineReplicatorHelper.LineReplictorHelper.AddPlaceHolderInTemplateIfInList
                (InputStrings, "cd a/a");
            result = LineReplicatorHelper.LineReplictorHelper.FeedbackMessage;
            string expected = "";
            Assert.Equal(result, expected);
        }
    }
}